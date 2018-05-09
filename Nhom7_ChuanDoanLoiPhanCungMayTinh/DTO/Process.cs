using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;

namespace Nhom7_ChuanDoanLoiPhanCungMayTinh.DTO
{
    class Process
    {
        #region Field
        /// <summary>
        /// khai báo RULE dạng bảng,Bảng RULE có 2 cột là id (R0,R1,R2.......) và các luật suy diễn (vd: K2 ^ D1 ^ L1 ^ H5 -> KL1,....)
        /// </summary>
        protected DataTable RULE;
        public string view;
        protected List<string> GT;

        /// <summary>
        /// khai báo KL_table dạng bảng, bảng KL_table gồm 1 cột chứa kết luận (K1,K2,K3......)
        /// </summary>
        private DataTable KL_table;

        protected DataTable RULE1
        {
            get { return RULE; }
            set { RULE = value; }
        }


        public List<string> GT1
        {
            get { return GT; }
            set { GT = value; }
        }


        public DataTable KL_table1
        {
            get { return KL_table; }
            set { KL_table = value; }
        }

        public Process()
        {
            GT = new List<string>();
            RULE = new DataTable();
            KL_table = new DataTable();
        }

        public Process(DataTable rule_table)
        {
            RULE = rule_table;
        }

        public Process(List<string> gt, DataTable kl, DataTable rule_table)
        {
            RULE = rule_table;
            GT = gt;
            KL_table = kl;
        }

        #endregion Field

        #region Method

        public List<Rules> get_rule()
        {

            List<Rules> rules = new List<Rules>();
            for (int i = 0; i < RULE.Rows.Count; i++)
            {
                Rules rule = new Rules();
                string str = RULE.Rows[i][1].ToString();
                Regex RE = new Regex(@" -> ");
                string[] r;
                r = RE.Split(trim(str));
                rule.Index = i;
                Regex RE1 = new Regex(@" \^ ");
                rule.Left.AddRange(RE1.Split(r[0]));
                Regex RE2 = new Regex(@" ");
                rule.Right.AddRange(RE2.Split(r[1]));
                rule.Used = false;
                rules.Add(rule);
            }
            return rules;

        }

        /// <summary>
        /// hàm lấy danh sách tập các kết luận trong bảng KL_table
        /// </summary>
        /// <returns></returns>
        public List<string> get_KL()
        {
            List<string> KL = new List<string>();
            int i = 0;
            while (i < KL_table.Rows.Count)
            {
                KL.Add(KL_table.Rows[i][0].ToString());
                i++;
            }
            return KL;
        }

        /// <summary>
        /// hàm lọc các luật khả dụng
        /// </summary>
        /// <param name="rules">danh sách luật</param>
        /// <param name="TG">danh sách các sự kiện trong tập trung gian</param>
        /// <returns></returns>
        public List<Rules> LOC(List<Rules> rules, List<string> TG)
        {
            bool chk;
            List<Rules> LOC_rules = new List<Rules>();
            for (int i = 0; i < rules.Count; i++)
            {
                if (rules[i].Used == false)
                {
                    chk = true;
                    for (int j = 0; j < rules[i].Left.Count; j++)
                        if (TG.Contains(rules[i].Left[j].ToString())) chk = chk && true;
                        else chk = chk && false;
                    if (chk)
                    {
                        LOC_rules.Add(rules[i]);
                    }
                }
            }
            return LOC_rules;
        }

        /// <summary>
        /// hàm lấy ra 1 luật trong tập SAT để thực hiện việc suy diễn, lấy luật từ trái qua phải
        /// </summary>
        /// <param name="SAT">danh sách kết luận trong tập SAT</param>
        /// <returns></returns>
        public Rules get_one_rule(List<Rules> SAT)
        {
            int i = 0;
            while (i < SAT.Count)
            {
                if (SAT[i].Used == false)
                {
                    SAT[i].Used = true;
                    break;
                }
                i++;
            }
            return SAT[i];
        }

        /// <summary>
        /// hàm bổ sung vế phải của luật đang được xét vào tập cuối tập TG
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="TG"></param>
        public void TG_union_right(Rules rule, List<string> TG)
        {
            for (int i = 0; i < rule.Right.Count; i++)
                if (!TG.Contains(rule.Right[i])) TG.Add(rule.Right[i]);
        }

        /// <summary>
        /// hàm kiểm tra tập SAT
        /// </summary>
        /// <param name="SAT">danh sách tập SAT</param>
        /// <returns></returns>
        public bool check_SAT(List<Rules> SAT)
        {
            if (SAT.Count == 0) return false;
            for (int i = 0; i < SAT.Count; i++)
                if (!SAT[i].Used) return true;
            return false;
        }


        /// <summary>
        /// hàm xử lý thuật toán suy diễn tiến
        /// </summary>
        /// <returns></returns>
        public List<int> forward_reasoning()
        {
            List<int> kq = new List<int>();

            List<string> KL = new List<string>();
            List<Rules> SAT = new List<Rules>();
            List<Rules> rules = new List<Rules>();
            List<string> TG = new List<string>();
            rules = get_rule();
            KL = get_KL();
            TG = GT;
            SAT = LOC(rules, TG);
            int index = 1;
            view = bieudien(0, TG, SAT);
            while (check_SAT(SAT))
            {
                TG_union_right(get_one_rule(SAT), TG);
                SAT.AddRange(LOC(rules, TG));
                view += bieudien(index, TG, SAT);
                index++;
            }
            view += bieudien_KL(index, TG, SAT);
            for (int i = 0; i < KL.Count; i++)
                if (TG.Contains(KL[i])) kq.Add(i);
            return kq;
        }

        public string trim(string str)
        {
            Regex RE = new Regex(@"\s+");
            string str_trim = RE.Replace(str, " ");
            return str_trim;
        }

        /// <summary>
        /// hàm giải thích quá trình thực hiện suy diễn, giải thích từng lần thực hiện để cho ra kết quả
        /// </summary>
        /// <param name="index">lần thực hiện suy diễn</param>
        /// <param name="TG">danh sách tập trung gian</param>
        /// <param name="SAT">danh sách các luật khả dụng (các luật sẽ được sử dụng đẻ suy diễn)</param>
        /// <returns></returns>
        public string bieudien(int index, List<string> TG, List<Rules> SAT)
        {
            string str, strTG;
            if (index == 0)
            {
                str = null;
                str = "Bắt đầu:\n";
                strTG = "\tTG = GT = { ";
            }
            else
            {
                str = "----------------------------------------------------------------------\n";
                str += "Lần " + index.ToString() + ":\n";

                strTG = "\tTG = { ";
            }

            for (int i = 0; i < TG.Count; i++)
            {
                if (i != 0) strTG += ", ";
                strTG += TG[i].ToString() + " ";
            }
            strTG += "}\n";
            str += strTG;

            List<int> d = new List<int>();
            for (int i = 0; i < SAT.Count; i++)
                if (SAT[i].Used == false && !d.Contains(SAT[i].Index))
                    d.Add(SAT[i].Index);
            if (d.Count > 0)
            {

                string strSAT = "\tSAT = LOC(R,TG) = { ";
                for (int i = 0; i < d.Count; i++)
                {
                    if (i != 0) strSAT += ", ";
                    strSAT += "R" + d[i].ToString() + " ";
                }
                strSAT += "}\n";
                str += strSAT;

                str += "\tLấy luật R" + d[0].ToString() + " trong SAT\n";
                str += "\t=> TG = TG U { ";

                string strKL = null;
                int vt = 0;
                for (int i = 0; i < SAT.Count; i++)
                    if (SAT[i].Used == false)
                    {
                        vt = i;
                        break;
                    }
                for (int i = 0; i < SAT[vt].Right.Count; i++)
                {
                    if (i != 0) strKL += ", ";
                    strKL += SAT[vt].Right[i] + " ";
                }
                str += strKL + "} = {";
                strTG = null;
                for (int i = 0; i < TG.Count; i++)
                {
                    if (i != 0) strTG += ", ";
                    strTG += TG[i].ToString() + " ";
                }
                strTG += ", " + strKL;
                str += strTG;
                str += "}\n";

            }
            else
            {
                str += "\tSAT={ø} => Dừng\n";
            }

            return str;
        }


        /// <summary>
        /// hàm biểu diễn danh sách các kết luận được suy diễn ra
        /// </summary>
        /// <param name="index"></param>
        /// <param name="TG"></param>
        /// <param name="SAT"></param>
        /// <returns></returns>
        public string bieudien_KL(int index, List<string> TG, List<Rules> SAT)
        {
            List<string> KL = new List<string>();
            KL = get_KL();
            string str = "----------------------------------------------------------------------\n";
            str += "Kết thúc:\n";
            string strKL = "\tKL = { ";
            int d = 0;
            for (int i = 0; i < KL.Count; i++)
                if (TG.Contains(KL[i]))
                {
                    if (d != 0) strKL += ", ";
                    strKL = string.Concat(strKL, KL[i] + " ");
                    d++;
                }
            str += strKL + "}\n";
            return str;

        }
    }
        #endregion Method
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Nhom7_ChuanDoanLoiPhanCungMayTinh.DTO
{
    class ConnectFile
    {
         private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public ConnectFile()
        {
            filePath = null;
        }

        public ConnectFile(string _filePath)
        {
            filePath = _filePath;
        }

        /// <summary>
        /// phương thức đọc dữ liệu trong file .txt
        /// </summary>
        /// <param name="filePath">tên file</param>
        /// <returns></returns>
        public DataTable DocFile(string filePath)
        {
            DataTable bang = new DataTable();
            DataColumn column1 = new DataColumn("Luật", typeof(String));
            DataColumn column2 = new DataColumn("Nội dung", typeof(String));
            bang.Columns.Add(column1);
            bang.Columns.Add(column2);


            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string str = lines[i];
                Regex regex = new Regex(@": ");
                string[] r;
                r = regex.Split(str);
                bang.Rows.Add(r[0], r[1]);
            }
            return bang;
        }

        /// <summary>
        /// Phương thức Load dữ liệu từ Text lên DataGridView
        /// </summary>
        /// <param name="dg">Tên DataGridView</param>
        /// <param name="filePath">Tên File</param>
        public void LoadToDataGridView(DataGridView dg, string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(':');
                dg.Rows.Add(mang);
                Line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}

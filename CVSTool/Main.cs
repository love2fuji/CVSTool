using CVSTool.Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CVSTool
{
    public partial class Main : Form
    {
        static string SqlConnectionString = Config.GetValue("MSSQLConnect");

        public Main()
        {
            InitializeComponent();
        }

        private void btnExport2Excel_Click(object sender, EventArgs e)
        {
            /*打开文件选择窗口*/
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c://";
            openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            /**/
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = openFileDialog.FileName;//记录选择的文件全路径  
                string file_dir = file_path.Substring(0, file_path.LastIndexOf(Path.DirectorySeparatorChar) + 1);//获取文件目录                    
                string file_name = openFileDialog.SafeFileName;//获取文件名  
                string file_exc = file_name.Substring(file_name.LastIndexOf("."), file_name.Length - file_name.LastIndexOf(".")); //获取文件扩展名 

                //创建一个空表  
                DataTable dt = new DataTable();
                //将数据放到空表中  
                dt = CSVHelper.OpenCSV(file_path);
                //显示导入的数据
                dgrSendMsgLog.DataSource = dt;
                SQLHelper.DataTableToSQLServer(dt, SqlConnectionString);

                //DataRow[] result = dt.Select("区域编码  AND 建筑编码 AND 上级区域代码 AND 区域名称");
                //foreach (DataRow row in result)
                //{
                //    Console.WriteLine("{0}, {1} , {2}, {3}", row[0], row[1], row[2], row[3]);
                //}

                //CSVToSQLServer(dt);


            }
        }

        void CSVToSQLServer( DataTable dt )
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(SqlConnectionString))
                {
                    sqlConn.Open();
                    SqlCommand commd = new SqlCommand();
                    commd.Connection = sqlConn;

                    commd.CommandText = String.Empty;

                    //DataRow[] result = dt.Select("区域编码  AND 建筑编码 AND 上级区域代码 AND 区域名称");
                    //foreach (DataRow row in result)
                    //{
                    //    Console.WriteLine("{0}, {1} , {2}, {3}", row[0], row[1] , row[2] , row[3]);
                    //}

                    //foreach (DataGridViewRow row in dgrSendMsgLog.Rows)
                    //{
                    //    commd.CommandText = string.Format(@"insert into web_content (data1,data2,data3) values('{0}','{1}','{2}')",
                    //        row.Cells[0].Value.ToString(),
                    //        row.Cells[1].Value.ToString(),
                    //        row.Cells[2].Value.ToString());

                    //     int reslut=commd.ExecuteNonQuery();
                    //}

                   // int reslut = commd.ExecuteNonQuery();
                    sqlConn.Close();
                    Console.WriteLine("-----sql 插入：" );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 错误：数据库连接失败，请设置数据库连接..."+ex);
               // ShowLog("错误：数据库连接失败，请设置数据库连接..." + ex.Message);

            }
        }

        private void btnDataExport2Excel_Click(object sender, EventArgs e)
        {

        }
    }
}

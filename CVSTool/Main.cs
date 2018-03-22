using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CVSTool
{
    public partial class Main : Form
    {
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


            }
        }

        private void btnDataExport2Excel_Click(object sender, EventArgs e)
        {

        }
    }
}

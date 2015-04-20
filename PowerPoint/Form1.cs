using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PowerPoint
{
    public partial class Form1 : Form
    {
        //定义全局变量
        public string filename, fileroot, filenames, newpatch;
        private byte[] data;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void 解密ToolStripMenuItem_Click(object sender, EventArgs e)//单文件解密
        {
            //打开对话框
            openFileDialog1.ShowDialog();
            //获取文件名
            filename = openFileDialog1.FileName;
            var filer = new FileInfo(filename);
            fileroot = filer.Directory.ToString();
           
            //filename = "D:\\1.docx";
            FileStream fs = File.OpenRead(filename);
            filename = fileroot + "\\解密\\" + openFileDialog1.SafeFileName;
            //取得文件长度
            data = new byte[fs.Length];
            //3、哇！开始读了，调用一个文件流的一个方法读取数据到data数组中
            fs.Read(data, 0, data.Length);
            Save();//调用另存为过程
            MessageBox.Show("全部完成");
        }

       

       
        //private void 还原ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //    //由于DLP的加密原理，这里需要调用一个不被监控的程序来重命名文件
        //    //这里还没有写完成，这里以调用notepad为例
        //    System.Diagnostics.Process exep = new System.Diagnostics.Process();
        //    //***下面是定义获取CrackD的程序目录

        //    string rootpatch = Directory.GetCurrentDirectory();//获取运行程序所在目录
        //    richTextBox1.Text = rootpatch;
        //    int rootname = richTextBox1.Find("PowerPoint", 0, RichTextBoxFinds.MatchCase);//取得程序安装目录
        //    string newroot = rootpatch.Substring(0, rootname);
            
        //    exep.StartInfo.FileName = newroot + "\\PowerPoint\\CrackD\\obj\\Release\\CrackD.exe";
        //    exep.EnableRaisingEvents = true;
        //    exep.Exited += new EventHandler(exep_Exited);
        //    exep.Start();  
        //}
        public  void Save()//文件写入，另存为过程
        {
            creat();
            FileStream fs = new FileStream(filename + ".ak47", FileMode.Create);
            //获得字节数组
            //byte[] data = System.Text.Encoding.Default.GetBytes("Hello World!"); 
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();                
        }
        public void creat()//创建另存为文件的文件夹
        {
            
            if (!Directory.Exists(@fileroot +"\\解密"))//如果路径不存在
            {
                Directory.CreateDirectory(@fileroot + "\\解密");//创建一个路径的文件夹
            }            
        }
        private void 批量解密ToolStripMenuItem_Click(object sender, EventArgs e)//批量操作，枚举取得文件夹下文件名
        {
            //打开文件夹并获取路径
            folderBrowserDialog1.ShowDialog();
            fileroot = folderBrowserDialog1.SelectedPath;
            int i = 0;
            //枚举路径下文件名
            DirectoryInfo dir = new DirectoryInfo(@fileroot);
            foreach (var item in dir.GetFiles("*"))
            {
                i = i + 1;//记录解密的文件总数
                
                FileStream fs = File.OpenRead(item.FullName);
                //取得文件长度
                data = new byte[fs.Length];
                //3、哇！开始读了，调用一个文件流的一个方法读取数据到data数组中
                fs.Read(data, 0, data.Length);
                //保存过程已经增加判断当前目录下是否存在解密文件夹，不存在则创建，这里不再调用creat()这个过程
                //creat();//判断是否存在解密文件夹，不存在则创建
                filename = @fileroot + "\\解密\\" + item.Name;//路径加上“解密”文件名
                filenames = filename+".ak47" + Environment.NewLine + filenames;
                Save();//调用另存为过程
                //MessageBox.Show(item.FullName);//打印路径和文件名)
            }
            MessageBox.Show("共计"+i+"个文件，全部完成");
            filenames = Environment.NewLine + filenames;
            writelog();//写入配置文件
            crack();//读取配置文件解密
        }
        void exep_Exited(object sender, EventArgs e)//运行完毕重命名后提示并关闭
        {
            MessageBox.Show("全部完毕");
        }
        private void writelog()//写log后面可以调用另外的程序，读取log的内容，再解密
        {
            getpatch();
            //string str3 = Directory.GetCurrentDirectory();//获取程序所在目录

            richTextBox1.Text = newpatch;
            FileStream wl = new FileStream(newpatch + "\\log.ini", FileMode.Create);//在程序所在目录写log
            StreamWriter sw = new StreamWriter(wl);
            //开始写入
            sw.WriteLine(filenames, true, Encoding.UTF8);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            wl.Close();
        }

        private void getpatch()
        {
            string rootpatch = Directory.GetCurrentDirectory();//获取运行程序所在目录
            richTextBox1.Text = rootpatch;
            int rootname = richTextBox1.Find("PowerPoint", 0, RichTextBoxFinds.MatchCase);//取得程序安装目录
            string newroot = rootpatch.Substring(0, rootname);
            //richTextBox1.Text = newroot;
            newpatch = newroot;
        }
        private void crack()
        {

            //由于DLP的加密原理，这里需要调用一个不被监控的程序来重命名文件
            //这里还没有写完成，这里以调用notepad为例
            System.Diagnostics.Process exep = new System.Diagnostics.Process();
            //***下面是定义获取CrackD的程序目录

            string rootpatch = Directory.GetCurrentDirectory();//获取运行程序所在目录
            richTextBox1.Text = rootpatch;
            int rootname = richTextBox1.Find("PowerPoint", 0, RichTextBoxFinds.MatchCase);//取得程序安装目录
            string newroot = rootpatch.Substring(0, rootname);

            exep.StartInfo.FileName = newroot + "\\PowerPoint\\CrackD\\obj\\Release\\CrackD.exe";
            exep.EnableRaisingEvents = true;
            exep.Exited += new EventHandler(exep_Exited);
            exep.Start();
        }

        
    }
}

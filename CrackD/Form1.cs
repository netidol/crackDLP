using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackD
{
    public partial class Form1 : Form
    {
        private string newpatch;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            getpatch();
            richTextBox1.Text = newpatch;
            Read(newpatch + "log.ini");
           // string rootpatch = Directory.GetCurrentDirectory();//获取程序所在目录
           //richTextBox1.Text = rootpatch;
           //int rootname = richTextBox1.Find("CrackD", 0, RichTextBoxFinds.MatchCase);
           //string newroot = rootpatch.Substring(0, rootname);
           //richTextBox1.Text = newroot;
            System.Environment.Exit(0);//关闭自己，退出进程
        }
        private void getpatch()//获取安装目录
        {
            string rootpatch = Directory.GetCurrentDirectory();//获取运行程序所在目录
            richTextBox1.Text = rootpatch;
            int rootname = richTextBox1.Find("PowerPoint", 0, RichTextBoxFinds.MatchCase);//取得程序安装目录
            string newroot = rootpatch.Substring(0, rootname);
            //richTextBox1.Text = newroot;
            newpatch = newroot;
        }
        public void Read(string path)//读取配置文件
        {
            StreamReader sr = new StreamReader(path ,Encoding.UTF8);
            String line = sr.ReadLine();
            
            while ((line = sr.ReadLine()) != null)//这里循环有点问题，有一个无法解密，待会改为foreach看看
                //已经通过在写log前面增加一个空行解决少解密的问题
            {
                //MessageBox.Show(line.ToString());
                richTextBox2.Text = line.ToString();
                if (richTextBox2.Text!="")
                {
                    string line2 = line.Substring(0, richTextBox2.Find(".ak47", 0, RichTextBoxFinds.MatchCase));
                    File.Move(line, line2);
                }
               

            }
            sr.Close();//关闭流
            
            //MessageBox.Show("全部完成");
        }

    }
}

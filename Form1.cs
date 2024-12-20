using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace 开机启动橘子桌面宠物_启动器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "请稍候...";
            if (!File.Exists(Application.StartupPath+"橘子桌面宠物.exe"))
            {
                MessageBox.Show("未找到橘子桌面宠物，请将其放在与本程序相同的目录，并确认其名称，本程序所在目录为：" + Application.StartupPath);
                this.Close();
                return;
            }
            if (!File.Exists(Application.StartupPath + "auto_startup_launcher_config.txt"))
            {
                File.WriteAllText(Application.StartupPath + "auto_startup_launcher_config.txt");
            }
            Process.Start(Application.StartupPath + "橘子桌面宠物.exe");
        }
    }
}

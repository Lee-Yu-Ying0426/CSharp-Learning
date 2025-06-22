using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6_MultiUserLogin
{
    public partial class FormMain : Form
    {
        private string username;
        private string displayName;
        public FormMain(string username, string displayName)
        {
            InitializeComponent();
            this.username = username;
            this.displayName = displayName;
            lblWelcome.Text = $"歡迎使用者：{displayName}\n（帳號：{username}）";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉主畫面
        }
    }
}

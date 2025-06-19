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
    public partial class log : Form
    {
        Dictionary<string, string> accounts = new Dictionary<string, string>(); // 帳號 ➜ 密碼
        Dictionary<string, string> profiles = new Dictionary<string, string>(); // 帳號 ➜ 使用者名稱
        Dictionary<string, int> loginAttempts = new Dictionary<string, int>(); // 帳號➜ 錯誤次數
        public log()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accounts.Add("admin", "1234");
            accounts.Add("guest", "0000");

            profiles.Add("admin", "Yu-Ying");
            profiles.Add("guest", "Visitor");

            loginAttempts.Add("admin", 0);
            loginAttempts.Add("guest", 0);

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string inputAccount = userName.Text;

            if (accounts.ContainsKey(userName.Text))  //是否存在帳號
            {
                if (loginAttempts.ContainsKey(inputAccount) && loginAttempts[inputAccount] <= 1)
                {
                    if (userPassword.Text == accounts[inputAccount]) //密碼是否正確
                    {
                        loginAttempts[inputAccount] = 0;
                        string displayName = profiles[inputAccount];
                        lblResult.Text = $"歡迎使用者：{displayName}。";
                    }
                    else
                    {
                       int log = loginAttempts[inputAccount] + 1;
                        loginAttempts[inputAccount] += 1;
                        int sum = 3 - log;
                        lblResult.Text = $"密碼錯誤，請再試一次。\n剩餘次數{sum}";
                    }
                }
                else
                {
                    lblResult.Text = "密碼錯誤已達 3 次。\n帳號已鎖定。";
                }
            }         
        }
    }
}

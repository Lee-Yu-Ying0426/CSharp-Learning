using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            bool isLogin = CheckLogin(userName.Text, userPassword.Text);

            if (isLogin)// 登入成功，顯示功能選單
            {
                this.Hide(); // 隱藏登入視窗
                string username = userName.Text;
                string name = profiles[username]; // 取得使用者名稱

                FormMain mainForm = new FormMain(username, name); // ➜ 建立主畫面表單
                mainForm.ShowDialog(); // 顯示主畫面，並暫停登入畫面

                this.Show(); // 當主畫面關閉後，回到登入畫面
                //ShowMenu(userName.Text);
                userName.Clear(); // 清除帳號欄位
                 userPassword.Clear(); // 清除密碼欄位
            }
        }

        bool CheckLogin(string username, string password)
        {
            if (!accounts.ContainsKey(username)) // 檢查帳號是否存在
            {
                MessageBox.Show("帳號不存在！");
                return false;
            }
            if (loginAttempts[username] >= 3) // 檢查錯誤次數是否超過3次
            {
                MessageBox.Show("帳號已鎖定，請稍後再試！");
                return false;
            }
            if (accounts[username] != password) // 檢查密碼是否正確
            {
                loginAttempts[username]++; // 錯誤次數加1 
                MessageBox.Show($"密碼錯誤！\n已錯誤{loginAttempts[username]}次。\n錯誤3次將鎖定帳號。");
                return false;
            }
            loginAttempts[username] = 0; // 登入成功，重置錯誤次數
            MessageBox.Show($"歡迎 {profiles[username]}！"); // 顯示使用者名稱
            return true; // 登入成功
        }

        //void ShowMenu(string username)
        //{
        //    string choice = Interaction.InputBox("請輸入功能編號：1=查詢、2=改密碼、3=登出", "功能選單", "");
        //    while(choice != "3")
        //    {
        //        if (choice == "1")
        //        {
        //            MessageBox.Show($"帳號：{username}\n名稱：{profiles[username]}");
        //        }
        //        else if (choice == "2")
        //        {
        //            string newPwd = Interaction.InputBox("請輸入新密碼：", "修改密碼", "");
        //            accounts[username] = newPwd;
        //            MessageBox.Show("密碼已更新！");
        //        }
        //        else
        //        {
        //            MessageBox.Show("請輸入有效選項！");
        //        }
        //        choice = Interaction.InputBox("請輸入功能編號：1=查詢、2=改密碼、3=登出", "功能選單", "");
        //    }
        //    MessageBox.Show("登出成功！");
        //    this.Show(); //顯示回登入視窗
        //}
    }
}

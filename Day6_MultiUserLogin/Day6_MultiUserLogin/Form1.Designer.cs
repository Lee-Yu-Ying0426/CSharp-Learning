namespace Day6_MultiUserLogin
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 32F);
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("新細明體", 32F);
            this.userName.Location = new System.Drawing.Point(146, 34);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(250, 59);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("新細明體", 32F);
            this.userPassword.Location = new System.Drawing.Point(146, 143);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(250, 59);
            this.userPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 32F);
            this.label2.Location = new System.Drawing.Point(24, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "密碼:";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("新細明體", 32F);
            this.login.Location = new System.Drawing.Point(146, 243);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 67);
            this.login.TabIndex = 4;
            this.login.Text = "登入";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("新細明體", 32F);
            this.lblResult.Location = new System.Drawing.Point(471, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 43);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 489);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label lblResult;
    }
}


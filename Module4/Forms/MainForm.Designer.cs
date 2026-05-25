namespace Module4.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMain = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panelCaptch = new System.Windows.Forms.Panel();
            this.buttonReady = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.pictureBoxCaptch1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch4 = new System.Windows.Forms.PictureBox();
            this.panelCaptch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(210, 41);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(141, 25);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Авторизация";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(158, 104);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(256, 31);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(158, 166);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(256, 31);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(45, 104);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(71, 25);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(45, 169);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 25);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Пароль";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(189, 219);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(174, 62);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // panelCaptch
            // 
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch4);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch3);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch2);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch1);
            this.panelCaptch.Controls.Add(this.buttonRight);
            this.panelCaptch.Controls.Add(this.buttonReady);
            this.panelCaptch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaptch.Location = new System.Drawing.Point(0, 0);
            this.panelCaptch.Name = "panelCaptch";
            this.panelCaptch.Size = new System.Drawing.Size(523, 311);
            this.panelCaptch.TabIndex = 3;
            this.panelCaptch.Visible = false;
            // 
            // buttonReady
            // 
            this.buttonReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReady.Location = new System.Drawing.Point(158, 242);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(138, 39);
            this.buttonReady.TabIndex = 0;
            this.buttonReady.Text = "Готово";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(302, 242);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(73, 39);
            this.buttonRight.TabIndex = 0;
            this.buttonRight.Text = "->";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // pictureBoxCaptch1
            // 
            this.pictureBoxCaptch1.Location = new System.Drawing.Point(177, 32);
            this.pictureBoxCaptch1.Name = "pictureBoxCaptch1";
            this.pictureBoxCaptch1.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxCaptch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch1.TabIndex = 1;
            this.pictureBoxCaptch1.TabStop = false;
            // 
            // pictureBoxCaptch2
            // 
            this.pictureBoxCaptch2.Location = new System.Drawing.Point(267, 32);
            this.pictureBoxCaptch2.Name = "pictureBoxCaptch2";
            this.pictureBoxCaptch2.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxCaptch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch2.TabIndex = 1;
            this.pictureBoxCaptch2.TabStop = false;
            // 
            // pictureBoxCaptch3
            // 
            this.pictureBoxCaptch3.Location = new System.Drawing.Point(267, 122);
            this.pictureBoxCaptch3.Name = "pictureBoxCaptch3";
            this.pictureBoxCaptch3.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxCaptch3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch3.TabIndex = 1;
            this.pictureBoxCaptch3.TabStop = false;
            // 
            // pictureBoxCaptch4
            // 
            this.pictureBoxCaptch4.Location = new System.Drawing.Point(177, 122);
            this.pictureBoxCaptch4.Name = "pictureBoxCaptch4";
            this.pictureBoxCaptch4.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxCaptch4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch4.TabIndex = 1;
            this.pictureBoxCaptch4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 311);
            this.Controls.Add(this.panelCaptch);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelMain);
            this.MaximumSize = new System.Drawing.Size(539, 350);
            this.MinimumSize = new System.Drawing.Size(539, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelCaptch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Panel panelCaptch;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.PictureBox pictureBoxCaptch4;
        private System.Windows.Forms.PictureBox pictureBoxCaptch3;
        private System.Windows.Forms.PictureBox pictureBoxCaptch2;
        private System.Windows.Forms.PictureBox pictureBoxCaptch1;
    }
}


﻿namespace StoreAssitant
{
    partial class LogInView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInView));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Lb_ForgotPass = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Lb_SignUp = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Pn_Login = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tb__User = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tb_Password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pn_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.Lb_SignUp);
            this.kryptonPanel1.Controls.Add(this.Pn_Login);
            this.kryptonPanel1.Controls.Add(this.Lb_ForgotPass);
            this.kryptonPanel1.Controls.Add(this.tb__User);
            this.kryptonPanel1.Controls.Add(this.Btn_Login);
            this.kryptonPanel1.Controls.Add(this.tb_Password);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 1);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(425, 502);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPanel1.StateCommon.Image")));
            this.kryptonPanel1.TabIndex = 9;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(43, 394);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.Control;
            this.Btn_Login.OverrideDefault.Border.Color1 = System.Drawing.SystemColors.Control;
            this.Btn_Login.OverrideDefault.Border.Color2 = System.Drawing.SystemColors.Control;
            this.Btn_Login.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.Btn_Login.Size = new System.Drawing.Size(312, 25);
            this.Btn_Login.StateCommon.Content.LongText.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Login.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Login.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Login.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Login.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Login.StateNormal.Content.LongText.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.StateNormal.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Values.Text = "Login";
            // 
            // Lb_ForgotPass
            // 
            this.Lb_ForgotPass.Location = new System.Drawing.Point(43, 426);
            this.Lb_ForgotPass.Name = "Lb_ForgotPass";
            this.Lb_ForgotPass.Size = new System.Drawing.Size(107, 20);
            this.Lb_ForgotPass.TabIndex = 4;
            this.Lb_ForgotPass.Values.Text = "Forgot password?";
            // 
            // Lb_SignUp
            // 
            this.Lb_SignUp.Location = new System.Drawing.Point(186, 426);
            this.Lb_SignUp.Name = "Lb_SignUp";
            this.Lb_SignUp.Size = new System.Drawing.Size(170, 20);
            this.Lb_SignUp.TabIndex = 5;
            this.Lb_SignUp.Values.Text = "Don\'t have account? Sign up!";
            // 
            // Pn_Login
            // 
            this.Pn_Login.Location = new System.Drawing.Point(429, 119);
            this.Pn_Login.Name = "Pn_Login";
            this.Pn_Login.Size = new System.Drawing.Size(360, 168);
            this.Pn_Login.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pn_Login.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.Pn_Login.StateDisabled.Color1 = System.Drawing.SystemColors.Control;
            this.Pn_Login.StateDisabled.Color2 = System.Drawing.SystemColors.Control;
            this.Pn_Login.TabIndex = 6;
            // 
            // tb__User
            // 
            this.tb__User.Location = new System.Drawing.Point(44, 319);
            this.tb__User.Name = "tb__User";
            this.tb__User.Size = new System.Drawing.Size(312, 23);
            this.tb__User.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.tb__User.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control;
            this.tb__User.TabIndex = 1;
            this.tb__User.Text = "Username";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(45, 357);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(312, 23);
            this.tb_Password.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.tb_Password.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control;
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Text = "Password";
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "LogInView";
            this.Size = new System.Drawing.Size(423, 503);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pn_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lb_SignUp;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel Pn_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Lb_ForgotPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb__User;
        public ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_Password;
    }
}

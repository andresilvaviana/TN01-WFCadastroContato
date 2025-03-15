namespace WFAcesso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_logar = new Button();
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            SuspendLayout();
            // 
            // btn_logar
            // 
            btn_logar.Image = (Image)resources.GetObject("btn_logar.Image");
            btn_logar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logar.Location = new Point(138, 162);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(78, 38);
            btn_logar.TabIndex = 0;
            btn_logar.Text = "Logar";
            btn_logar.TextAlign = ContentAlignment.MiddleRight;
            btn_logar.UseVisualStyleBackColor = true;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(46, 44);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(50, 15);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(46, 62);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Informe o usuario";
            txt_usuario.Size = new Size(170, 23);
            txt_usuario.TabIndex = 2;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(46, 118);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Informe a senha";
            txt_senha.Size = new Size(170, 23);
            txt_senha.TabIndex = 4;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(46, 100);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 275);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_logar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logar;
        private Label lbl_usuario;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label lbl_senha;
    }
}

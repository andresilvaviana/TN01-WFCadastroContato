namespace TN01___WFCadastroContato
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
            snu_menu = new MenuStrip();
            mnu_cadastro = new ToolStripMenuItem();
            mnu_sobre = new ToolStripMenuItem();
            mnu_sair = new ToolStripMenuItem();
            snu_menu.SuspendLayout();
            SuspendLayout();
            // 
            // snu_menu
            // 
            snu_menu.Items.AddRange(new ToolStripItem[] { mnu_cadastro, mnu_sobre, mnu_sair });
            snu_menu.Location = new Point(0, 0);
            snu_menu.Name = "snu_menu";
            snu_menu.Size = new Size(351, 24);
            snu_menu.TabIndex = 0;
            snu_menu.Text = "Menu";
            // 
            // mnu_cadastro
            // 
            mnu_cadastro.Name = "mnu_cadastro";
            mnu_cadastro.Size = new Size(69, 20);
            mnu_cadastro.Text = "Cadastrar";
            mnu_cadastro.Click += toolStripMenuItem1_Click;
            // 
            // mnu_sobre
            // 
            mnu_sobre.Name = "mnu_sobre";
            mnu_sobre.Size = new Size(49, 20);
            mnu_sobre.Text = "Sobre";
            mnu_sobre.Click += mnu_sobre_Click;
            // 
            // mnu_sair
            // 
            mnu_sair.Name = "mnu_sair";
            mnu_sair.Size = new Size(38, 20);
            mnu_sair.Text = "Sair";
            mnu_sair.Click += mnu_sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(351, 273);
            Controls.Add(snu_menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = snu_menu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASV Cadastro";
            snu_menu.ResumeLayout(false);
            snu_menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip snu_menu;
        private ToolStripMenuItem mnu_cadastro;
        private ToolStripMenuItem mnu_sobre;
        private ToolStripMenuItem mnu_sair;
    }
}

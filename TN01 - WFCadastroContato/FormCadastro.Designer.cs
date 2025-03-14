namespace TN01___WFCadastroContato
{
    partial class FormCadastro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lbl_nome = new Label();
            txt_nome = new TextBox();
            txt_sobrenome = new TextBox();
            lbl_sobrenome = new Label();
            lbl_dddtelefone = new Label();
            msk_dddtelefone = new MaskedTextBox();
            grp_tipotelefone = new GroupBox();
            rdb_recado = new RadioButton();
            rdb_comercial = new RadioButton();
            rdb_pessoal = new RadioButton();
            txt_email = new TextBox();
            lbl_email = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_voltar = new Button();
            btn_salva = new Button();
            grp_tipotelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(45, 21);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(45, 39);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(190, 23);
            txt_nome.TabIndex = 1;
            // 
            // txt_sobrenome
            // 
            txt_sobrenome.Location = new Point(255, 39);
            txt_sobrenome.Name = "txt_sobrenome";
            txt_sobrenome.Size = new Size(190, 23);
            txt_sobrenome.TabIndex = 3;
            // 
            // lbl_sobrenome
            // 
            lbl_sobrenome.AutoSize = true;
            lbl_sobrenome.Location = new Point(255, 21);
            lbl_sobrenome.Name = "lbl_sobrenome";
            lbl_sobrenome.Size = new Size(68, 15);
            lbl_sobrenome.TabIndex = 2;
            lbl_sobrenome.Text = "Sobrenome";
            // 
            // lbl_dddtelefone
            // 
            lbl_dddtelefone.AutoSize = true;
            lbl_dddtelefone.Location = new Point(45, 110);
            lbl_dddtelefone.Name = "lbl_dddtelefone";
            lbl_dddtelefone.Size = new Size(86, 15);
            lbl_dddtelefone.TabIndex = 4;
            lbl_dddtelefone.Text = "DDD / Telefone";
            // 
            // msk_dddtelefone
            // 
            msk_dddtelefone.Location = new Point(45, 128);
            msk_dddtelefone.Mask = "(00)00000-9999";
            msk_dddtelefone.Name = "msk_dddtelefone";
            msk_dddtelefone.Size = new Size(154, 23);
            msk_dddtelefone.TabIndex = 5;
            msk_dddtelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // grp_tipotelefone
            // 
            grp_tipotelefone.Controls.Add(rdb_recado);
            grp_tipotelefone.Controls.Add(rdb_comercial);
            grp_tipotelefone.Controls.Add(rdb_pessoal);
            grp_tipotelefone.Location = new Point(208, 110);
            grp_tipotelefone.Name = "grp_tipotelefone";
            grp_tipotelefone.Size = new Size(237, 61);
            grp_tipotelefone.TabIndex = 6;
            grp_tipotelefone.TabStop = false;
            grp_tipotelefone.Text = "Tipo Telefone";
            // 
            // rdb_recado
            // 
            rdb_recado.AutoSize = true;
            rdb_recado.Location = new Point(165, 23);
            rdb_recado.Name = "rdb_recado";
            rdb_recado.Size = new Size(64, 19);
            rdb_recado.TabIndex = 2;
            rdb_recado.TabStop = true;
            rdb_recado.Text = "Recado";
            rdb_recado.UseVisualStyleBackColor = true;
            // 
            // rdb_comercial
            // 
            rdb_comercial.AutoSize = true;
            rdb_comercial.Location = new Point(80, 23);
            rdb_comercial.Name = "rdb_comercial";
            rdb_comercial.Size = new Size(79, 19);
            rdb_comercial.TabIndex = 1;
            rdb_comercial.TabStop = true;
            rdb_comercial.Text = "Comercial";
            rdb_comercial.UseVisualStyleBackColor = true;
            // 
            // rdb_pessoal
            // 
            rdb_pessoal.AutoSize = true;
            rdb_pessoal.Location = new Point(10, 23);
            rdb_pessoal.Name = "rdb_pessoal";
            rdb_pessoal.Size = new Size(64, 19);
            rdb_pessoal.TabIndex = 0;
            rdb_pessoal.TabStop = true;
            rdb_pessoal.Text = "Pessoal";
            rdb_pessoal.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(45, 222);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(400, 23);
            txt_email.TabIndex = 7;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(45, 204);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(44, 15);
            lbl_email.TabIndex = 8;
            lbl_email.Text = "E-mail:";
            lbl_email.Click += label2_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(45, 191);
            label3.Name = "label3";
            label3.Size = new Size(400, 1);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(45, 82);
            label4.Name = "label4";
            label4.Size = new Size(400, 1);
            label4.TabIndex = 10;
            // 
            // btn_voltar
            // 
            btn_voltar.Image = (Image)resources.GetObject("btn_voltar.Image");
            btn_voltar.Location = new Point(189, 364);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(113, 44);
            btn_voltar.TabIndex = 11;
            btn_voltar.Text = "Voltar";
            btn_voltar.TextAlign = ContentAlignment.MiddleRight;
            btn_voltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_salva
            // 
            btn_salva.Image = (Image)resources.GetObject("btn_salva.Image");
            btn_salva.Location = new Point(308, 364);
            btn_salva.Name = "btn_salva";
            btn_salva.Size = new Size(113, 44);
            btn_salva.TabIndex = 12;
            btn_salva.Text = "Salva";
            btn_salva.TextAlign = ContentAlignment.MiddleRight;
            btn_salva.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salva.UseVisualStyleBackColor = true;
            btn_salva.Click += btn_salva_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btn_salva);
            Controls.Add(btn_voltar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_email);
            Controls.Add(txt_email);
            Controls.Add(grp_tipotelefone);
            Controls.Add(msk_dddtelefone);
            Controls.Add(lbl_dddtelefone);
            Controls.Add(txt_sobrenome);
            Controls.Add(lbl_sobrenome);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            grp_tipotelefone.ResumeLayout(false);
            grp_tipotelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private TextBox txt_nome;
        private TextBox txt_sobrenome;
        private Label lbl_sobrenome;
        private Label lbl_dddtelefone;
        private MaskedTextBox msk_dddtelefone;
        private GroupBox grp_tipotelefone;
        private RadioButton rdb_recado;
        private RadioButton rdb_comercial;
        private RadioButton rdb_pessoal;
        private TextBox txt_email;
        private Label lbl_email;
        private Label label3;
        private Label label4;
        private Button btn_voltar;
        private Button btn_salva;
    }
}
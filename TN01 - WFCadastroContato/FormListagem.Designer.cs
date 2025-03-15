namespace TN01___WFCadastroContato
{
    partial class FormListagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListagem));
            dgv_listacontatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_listacontatos).BeginInit();
            SuspendLayout();
            // 
            // dgv_listacontatos
            // 
            dgv_listacontatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listacontatos.Location = new Point(12, 8);
            dgv_listacontatos.Name = "dgv_listacontatos";
            dgv_listacontatos.Size = new Size(599, 212);
            dgv_listacontatos.TabIndex = 0;
            dgv_listacontatos.CellContentClick += dgv_listacontatos_CellContentClick;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 228);
            Controls.Add(dgv_listacontatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Contatos";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listacontatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listacontatos;
    }
}
namespace AppModelo.View.Windows.Cadastros
{
    partial class frmListadeFuncionarios
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
            this.dgvListaDeFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeFuncionarios
            // 
            this.dgvListaDeFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeFuncionarios.Location = new System.Drawing.Point(2, 2);
            this.dgvListaDeFuncionarios.Name = "dgvListaDeFuncionarios";
            this.dgvListaDeFuncionarios.Size = new System.Drawing.Size(776, 352);
            this.dgvListaDeFuncionarios.TabIndex = 0;
            // 
            // frmListadeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 454);
            this.Controls.Add(this.dgvListaDeFuncionarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadeFuncionarios";
            this.Text = "frmListadeFuncionarios";
            this.Load += new System.EventHandler(this.frmListadeFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeFuncionarios;
    }
}
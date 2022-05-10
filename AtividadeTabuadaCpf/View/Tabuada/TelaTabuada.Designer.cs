
namespace AtividadeTabuadaCpf.View.Tabuada
{
    partial class TelaTabuada
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(89, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcular a Tabuada";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbxNumero.Location = new System.Drawing.Point(89, 73);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(87, 29);
            this.tbxNumero.TabIndex = 1;
            // 
            // lbxResultado
            // 
            this.lbxResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 21;
            this.lbxResultado.Location = new System.Drawing.Point(224, 73);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(131, 172);
            this.lbxResultado.TabIndex = 2;
            // 
            // TelaTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 303);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.lblTitulo);
            this.KeyPreview = true;
            this.Name = "TelaTabuada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Tabuada";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaTabuada_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.ListBox lbxResultado;
    }
}
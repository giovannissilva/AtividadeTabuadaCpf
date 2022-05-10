
namespace AtividadeTabuadaCpf.View.CPF
{
    partial class TelaCPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCPF));
            this.lblTxt = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTxt.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTxt.ForeColor = System.Drawing.Color.White;
            this.lblTxt.Location = new System.Drawing.Point(216, 33);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(342, 40);
            this.lblTxt.TabIndex = 0;
            this.lblTxt.Text = "Validar o Número do CPF";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(61, 120);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(53, 25);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF :";
            // 
            // tbxCPF
            // 
            this.tbxCPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbxCPF.Location = new System.Drawing.Point(120, 120);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(190, 23);
            this.tbxCPF.TabIndex = 2;
            this.tbxCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCPF.TextChanged += new System.EventHandler(this.tbxCPF_TextChanged);
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnValidar.Location = new System.Drawing.Point(339, 119);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(63, 180);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(351, 137);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TelaCPF
            // 
            this.AcceptButton = this.btnValidar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.tbxCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTxt);
            this.Name = "TelaCPF";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblResultado;
    }
}

namespace AtividadeTabuadaCpf.View
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atividade de Tabuada E CPF";
            // 
            // btnTabuada
            // 
            this.btnTabuada.BackColor = System.Drawing.Color.White;
            this.btnTabuada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnTabuada.Location = new System.Drawing.Point(189, 144);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(373, 64);
            this.btnTabuada.TabIndex = 1;
            this.btnTabuada.Text = "Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = false;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnCPF
            // 
            this.btnCPF.BackColor = System.Drawing.Color.White;
            this.btnCPF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCPF.Location = new System.Drawing.Point(189, 232);
            this.btnCPF.Name = "btnCPF";
            this.btnCPF.Size = new System.Drawing.Size(373, 64);
            this.btnCPF.TabIndex = 2;
            this.btnCPF.Text = "Validar CPF";
            this.btnCPF.UseVisualStyleBackColor = false;
            this.btnCPF.Click += new System.EventHandler(this.btnCPF_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCPF);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnCPF;
    }
}
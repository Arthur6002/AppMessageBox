namespace AppMessageBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntExemplo1 = new System.Windows.Forms.Button();
            this.bntExemplo2 = new System.Windows.Forms.Button();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.Seleção = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntExemplo1
            // 
            this.bntExemplo1.Location = new System.Drawing.Point(169, 244);
            this.bntExemplo1.Name = "bntExemplo1";
            this.bntExemplo1.Size = new System.Drawing.Size(127, 78);
            this.bntExemplo1.TabIndex = 1;
            this.bntExemplo1.Text = "Exemplo 1";
            this.bntExemplo1.UseVisualStyleBackColor = true;
            this.bntExemplo1.Click += new System.EventHandler(this.bntExemplo1_Click);
            // 
            // bntExemplo2
            // 
            this.bntExemplo2.Location = new System.Drawing.Point(436, 244);
            this.bntExemplo2.Name = "bntExemplo2";
            this.bntExemplo2.Size = new System.Drawing.Size(127, 78);
            this.bntExemplo2.TabIndex = 2;
            this.bntExemplo2.Text = "Exemplo 2";
            this.bntExemplo2.UseVisualStyleBackColor = true;
            this.bntExemplo2.Click += new System.EventHandler(this.bntExemplo2_Click);
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(169, 170);
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(394, 20);
            this.txtSelecao.TabIndex = 3;
            // 
            // Seleção
            // 
            this.Seleção.AutoSize = true;
            this.Seleção.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleção.Location = new System.Drawing.Point(284, 98);
            this.Seleção.Name = "Seleção";
            this.Seleção.Size = new System.Drawing.Size(161, 42);
            this.Seleção.TabIndex = 4;
            this.Seleção.Text = "Seleção";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Seleção);
            this.Controls.Add(this.txtSelecao);
            this.Controls.Add(this.bntExemplo2);
            this.Controls.Add(this.bntExemplo1);
            this.Name = "Form1";
            this.Text = "Aula 09/08/23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntExemplo1;
        private System.Windows.Forms.Button bntExemplo2;
        private System.Windows.Forms.TextBox txtSelecao;
        private System.Windows.Forms.Label Seleção;
    }
}


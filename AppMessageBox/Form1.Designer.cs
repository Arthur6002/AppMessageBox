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
            this.bntMessageBox1 = new System.Windows.Forms.Button();
            this.bntMessageBox2 = new System.Windows.Forms.Button();
            this.bntMessageBox3 = new System.Windows.Forms.Button();
            this.bntMessageBox4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntMessageBox1
            // 
            this.bntMessageBox1.Location = new System.Drawing.Point(54, 12);
            this.bntMessageBox1.Name = "bntMessageBox1";
            this.bntMessageBox1.Size = new System.Drawing.Size(127, 78);
            this.bntMessageBox1.TabIndex = 0;
            this.bntMessageBox1.Text = "Message Box 1";
            this.bntMessageBox1.UseVisualStyleBackColor = true;
            this.bntMessageBox1.Click += new System.EventHandler(this.bntMessageBox1_Click);
            // 
            // bntMessageBox2
            // 
            this.bntMessageBox2.Location = new System.Drawing.Point(54, 124);
            this.bntMessageBox2.Name = "bntMessageBox2";
            this.bntMessageBox2.Size = new System.Drawing.Size(127, 78);
            this.bntMessageBox2.TabIndex = 1;
            this.bntMessageBox2.Text = "Message Box 2";
            this.bntMessageBox2.UseVisualStyleBackColor = true;
            // 
            // bntMessageBox3
            // 
            this.bntMessageBox3.Location = new System.Drawing.Point(54, 229);
            this.bntMessageBox3.Name = "bntMessageBox3";
            this.bntMessageBox3.Size = new System.Drawing.Size(127, 78);
            this.bntMessageBox3.TabIndex = 2;
            this.bntMessageBox3.Text = "Message Box 3";
            this.bntMessageBox3.UseVisualStyleBackColor = true;
            // 
            // bntMessageBox4
            // 
            this.bntMessageBox4.Location = new System.Drawing.Point(54, 338);
            this.bntMessageBox4.Name = "bntMessageBox4";
            this.bntMessageBox4.Size = new System.Drawing.Size(127, 78);
            this.bntMessageBox4.TabIndex = 3;
            this.bntMessageBox4.Text = "Message Box 4";
            this.bntMessageBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntMessageBox4);
            this.Controls.Add(this.bntMessageBox3);
            this.Controls.Add(this.bntMessageBox2);
            this.Controls.Add(this.bntMessageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntMessageBox1;
        private System.Windows.Forms.Button bntMessageBox2;
        private System.Windows.Forms.Button bntMessageBox3;
        private System.Windows.Forms.Button bntMessageBox4;
    }
}


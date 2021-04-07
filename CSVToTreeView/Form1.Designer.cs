namespace Macoratti.CSVTreeView
{
    partial class Form1
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
            this.Pesquisa = new System.Windows.Forms.TreeView();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(23, 26);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(339, 225);
            this.Pesquisa.TabIndex = 0;
            this.Pesquisa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.contatos_AfterSelect);
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(23, 257);
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(339, 20);
            this.txtSelecao.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 293);
            this.Controls.Add(this.txtSelecao);
            this.Controls.Add(this.Pesquisa);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "CSV Para TreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Pesquisa;
        private System.Windows.Forms.TextBox txtSelecao;
    }
}


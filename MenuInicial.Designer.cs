
namespace SmartBooks
{
    partial class SmartBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_livro = new System.Windows.Forms.Button();
            this.btn_livraria = new System.Windows.Forms.Button();
            this.btn_cp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(77, 91);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(129, 50);
            this.btn_cliente.TabIndex = 4;
            this.btn_cliente.Text = "Utilizador";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_livro
            // 
            this.btn_livro.Location = new System.Drawing.Point(77, 161);
            this.btn_livro.Name = "btn_livro";
            this.btn_livro.Size = new System.Drawing.Size(129, 50);
            this.btn_livro.TabIndex = 5;
            this.btn_livro.Text = "Livro";
            this.btn_livro.UseVisualStyleBackColor = true;
            this.btn_livro.Click += new System.EventHandler(this.btn_livro_Click);
            // 
            // btn_livraria
            // 
            this.btn_livraria.Location = new System.Drawing.Point(77, 231);
            this.btn_livraria.Name = "btn_livraria";
            this.btn_livraria.Size = new System.Drawing.Size(129, 50);
            this.btn_livraria.TabIndex = 6;
            this.btn_livraria.Text = "Livraria";
            this.btn_livraria.UseVisualStyleBackColor = true;
            this.btn_livraria.Click += new System.EventHandler(this.btn_livraria_Click);
            // 
            // btn_cp
            // 
            this.btn_cp.Location = new System.Drawing.Point(328, 91);
            this.btn_cp.Name = "btn_cp";
            this.btn_cp.Size = new System.Drawing.Size(172, 50);
            this.btn_cp.TabIndex = 7;
            this.btn_cp.Text = "Codigos Postais";
            this.btn_cp.UseVisualStyleBackColor = true;
            this.btn_cp.Click += new System.EventHandler(this.btn_cp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Criar";
            // 
            // Adicionar
            // 
            this.Adicionar.AutoSize = true;
            this.Adicionar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Adicionar.Location = new System.Drawing.Point(84, 43);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(122, 25);
            this.Adicionar.TabIndex = 9;
            this.Adicionar.Text = "Adicionar";
            // 
            // SmartBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 307);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cp);
            this.Controls.Add(this.btn_livraria);
            this.Controls.Add(this.btn_livro);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SmartBooks";
            this.Text = "SmartBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_livro;
        private System.Windows.Forms.Button btn_livraria;
        private System.Windows.Forms.Button btn_cp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Adicionar;
    }
}


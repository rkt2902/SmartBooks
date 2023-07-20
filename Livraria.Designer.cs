
namespace SmartBooks
{
    partial class Livraria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livraria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomeL = new System.Windows.Forms.TextBox();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.Localidade = new System.Windows.Forms.Label();
            this.txt_loc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contacto_txt = new System.Windows.Forms.Label();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Livraria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Postal";
            // 
            // txt_nomeL
            // 
            this.txt_nomeL.Location = new System.Drawing.Point(139, 116);
            this.txt_nomeL.Name = "txt_nomeL";
            this.txt_nomeL.Size = new System.Drawing.Size(110, 23);
            this.txt_nomeL.TabIndex = 3;
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(139, 145);
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(110, 23);
            this.txt_Rua.TabIndex = 4;
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(139, 174);
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(110, 23);
            this.txt_CP.TabIndex = 5;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(84, 294);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 6;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(352, 169);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Atualizar";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(352, 206);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(666, 382);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar.TabIndex = 12;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(329, 256);
            this.dataGridView1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(341, 127);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 16;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.Window;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(32, 31);
            this.btn_home.TabIndex = 17;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Localidade
            // 
            this.Localidade.AutoSize = true;
            this.Localidade.Location = new System.Drawing.Point(31, 206);
            this.Localidade.Name = "Localidade";
            this.Localidade.Size = new System.Drawing.Size(64, 15);
            this.Localidade.TabIndex = 38;
            this.Localidade.Text = "Localidade";
            // 
            // txt_loc
            // 
            this.txt_loc.Location = new System.Drawing.Point(139, 203);
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(110, 23);
            this.txt_loc.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(68, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Criar Livraria";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // contacto_txt
            // 
            this.contacto_txt.AutoSize = true;
            this.contacto_txt.Location = new System.Drawing.Point(31, 237);
            this.contacto_txt.Name = "contacto_txt";
            this.contacto_txt.Size = new System.Drawing.Size(56, 15);
            this.contacto_txt.TabIndex = 41;
            this.contacto_txt.Text = "Contacto";
            // 
            // txt_contacto
            // 
            this.txt_contacto.Location = new System.Drawing.Point(139, 234);
            this.txt_contacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(110, 23);
            this.txt_contacto.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(602, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Dados Das Livrarias";
            // 
            // Livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.contacto_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_loc);
            this.Controls.Add(this.Localidade);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.txt_Rua);
            this.Controls.Add(this.txt_nomeL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Livraria";
            this.Text = "Livraria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nomeL;
        private System.Windows.Forms.TextBox txt_Rua;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label Localidade;
        private System.Windows.Forms.TextBox txt_loc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label contacto_txt;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.Label label6;
    }
}
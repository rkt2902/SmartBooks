
namespace SmartBooks
{
    partial class Utilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilizador));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_type = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.Label();
            this.cp_txt = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.Label();
            this.contacto_txt = new System.Windows.Forms.Label();
            this.txt_nome1 = new System.Windows.Forms.TextBox();
            this.txt_email1 = new System.Windows.Forms.TextBox();
            this.txt_pass1 = new System.Windows.Forms.TextBox();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.txt_rua1 = new System.Windows.Forms.TextBox();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.txt_loc = new System.Windows.Forms.TextBox();
            this.Localidade = new System.Windows.Forms.Label();
            this.usertype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(350, 92);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(110, 23);
            this.txt_id.TabIndex = 13;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(97, 318);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_Inserir.TabIndex = 14;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(364, 139);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Atualizar";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(364, 176);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 16;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(628, 345);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar.TabIndex = 17;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(281, 251);
            this.dataGridView1.TabIndex = 18;
            // 
            // txt_type
            // 
            this.txt_type.AutoSize = true;
            this.txt_type.Location = new System.Drawing.Point(45, 62);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(99, 15);
            this.txt_type.TabIndex = 19;
            this.txt_type.Text = "Tipo de Utilizador";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Location = new System.Drawing.Point(47, 90);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(40, 15);
            this.txt_nome.TabIndex = 20;
            this.txt_nome.Text = "Nome";
            // 
            // txt_rua
            // 
            this.txt_rua.AutoSize = true;
            this.txt_rua.Location = new System.Drawing.Point(47, 118);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(27, 15);
            this.txt_rua.TabIndex = 21;
            this.txt_rua.Text = "Rua";
            // 
            // cp_txt
            // 
            this.cp_txt.AutoSize = true;
            this.cp_txt.Location = new System.Drawing.Point(47, 147);
            this.cp_txt.Name = "cp_txt";
            this.cp_txt.Size = new System.Drawing.Size(81, 15);
            this.cp_txt.TabIndex = 22;
            this.cp_txt.Text = "Codigo Postal";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(47, 204);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(36, 15);
            this.txt_email.TabIndex = 23;
            this.txt_email.Text = "Email";
            // 
            // txt_pass
            // 
            this.txt_pass.AutoSize = true;
            this.txt_pass.Location = new System.Drawing.Point(47, 231);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(77, 15);
            this.txt_pass.TabIndex = 24;
            this.txt_pass.Text = "Palavra Passe";
            // 
            // contacto_txt
            // 
            this.contacto_txt.AutoSize = true;
            this.contacto_txt.Location = new System.Drawing.Point(47, 258);
            this.contacto_txt.Name = "contacto_txt";
            this.contacto_txt.Size = new System.Drawing.Size(56, 15);
            this.contacto_txt.TabIndex = 25;
            this.contacto_txt.Text = "Contacto";
            // 
            // txt_nome1
            // 
            this.txt_nome1.Location = new System.Drawing.Point(150, 87);
            this.txt_nome1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome1.Name = "txt_nome1";
            this.txt_nome1.Size = new System.Drawing.Size(110, 23);
            this.txt_nome1.TabIndex = 27;
            // 
            // txt_email1
            // 
            this.txt_email1.Location = new System.Drawing.Point(150, 201);
            this.txt_email1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email1.Name = "txt_email1";
            this.txt_email1.Size = new System.Drawing.Size(110, 23);
            this.txt_email1.TabIndex = 30;
            // 
            // txt_pass1
            // 
            this.txt_pass1.Location = new System.Drawing.Point(150, 228);
            this.txt_pass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.Size = new System.Drawing.Size(110, 23);
            this.txt_pass1.TabIndex = 31;
            // 
            // txt_contacto
            // 
            this.txt_contacto.Location = new System.Drawing.Point(150, 255);
            this.txt_contacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(110, 23);
            this.txt_contacto.TabIndex = 32;
            // 
            // txt_rua1
            // 
            this.txt_rua1.Location = new System.Drawing.Point(150, 115);
            this.txt_rua1.Name = "txt_rua1";
            this.txt_rua1.Size = new System.Drawing.Size(110, 23);
            this.txt_rua1.TabIndex = 33;
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(150, 144);
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(110, 23);
            this.txt_CP.TabIndex = 34;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.Window;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Location = new System.Drawing.Point(22, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(32, 31);
            this.btn_home.TabIndex = 35;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // txt_loc
            // 
            this.txt_loc.Location = new System.Drawing.Point(150, 173);
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(110, 23);
            this.txt_loc.TabIndex = 36;
            // 
            // Localidade
            // 
            this.Localidade.AutoSize = true;
            this.Localidade.Location = new System.Drawing.Point(47, 176);
            this.Localidade.Name = "Localidade";
            this.Localidade.Size = new System.Drawing.Size(64, 15);
            this.Localidade.TabIndex = 37;
            this.Localidade.Text = "Localidade";
            // 
            // usertype
            // 
            this.usertype.FormattingEnabled = true;
            this.usertype.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Cliente"});
            this.usertype.Location = new System.Drawing.Point(150, 59);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(110, 23);
            this.usertype.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Criar Novo Utilizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(575, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Dados Dos Utilizadores";
            // 
            // Utilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.Localidade);
            this.Controls.Add(this.txt_loc);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.txt_rua1);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.txt_pass1);
            this.Controls.Add(this.txt_email1);
            this.Controls.Add(this.txt_nome1);
            this.Controls.Add(this.contacto_txt);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.cp_txt);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Utilizador";
            this.Text = "Utilizador";
            this.Load += new System.EventHandler(this.Utilizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_type;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label txt_rua;
        private System.Windows.Forms.Label cp_txt;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Label txt_pass;
        private System.Windows.Forms.Label contacto_txt;
        private System.Windows.Forms.TextBox txt_nome1;
        private System.Windows.Forms.TextBox txt_email1;
        private System.Windows.Forms.TextBox txt_pass1;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.TextBox txt_rua1;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox txt_loc;
        private System.Windows.Forms.Label Localidade;
        private System.Windows.Forms.ComboBox usertype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
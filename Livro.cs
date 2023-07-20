using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace SmartBooks
{
    public partial class Livro : Form
    {
        Thread th;
        public Livro()
        {
            InitializeComponent();
        }

        public void openMenu(object obj)
        {
            Application.Run(new SmartBooks());
        }
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("insert into LIVRO values (@NomeLivro, @PreçoLivro)", con);

            con.Open();
            cmd.Parameters.AddWithValue("@NomeLivro", txt_nome.Text);
            cmd.Parameters.AddWithValue("@PreçoLivro", float.Parse(txt_preco.Text));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("Update LIVRO set NomeLivro=@NomeLivro, PreçoLivro = @PreçoLivro where ID = @ID", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text));
            cmd.Parameters.AddWithValue("@NomeLivro", txt_nome.Text);
            cmd.Parameters.AddWithValue("@PreçoLivro", float.Parse(txt_preco.Text));
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete LIVRO where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text));
            cmd.ExecuteNonQuery();

            con.Close();

        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Livro", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

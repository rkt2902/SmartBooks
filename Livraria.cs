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
    public partial class Livraria : Form
    {
        Thread th;
        public Livraria()
        {
            InitializeComponent();
        }

        public void openMenu(object obj)
        {
            Application.Run(new SmartBooks());
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("insert into LIVRARIA(NomeLiv, Rua, CodigoPostal,ContactoID) values (@NomeLiv, @Rua, @CodigoPostal,@ContactoID)", conn);
            SqlCommand storeProcedureCommand = new SqlCommand("addCodigoPostal", conn);

            conn.Open();
          
            cmd.Parameters.AddWithValue("@NomeLiv", txt_nomeL.Text);
            cmd.Parameters.AddWithValue("@Rua", txt_Rua.Text);
            cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txt_CP.Text));
            cmd.Parameters.AddWithValue("@ContactoID", txt_contacto.Text);
            storeProcedureCommand.CommandType = System.Data.CommandType.StoredProcedure;
           
            storeProcedureCommand.Parameters.Add(new SqlParameter("@cp", int.Parse(txt_CP.Text)));
            storeProcedureCommand.Parameters.Add(new SqlParameter("@loc", txt_loc.Text));
            storeProcedureCommand.ExecuteNonQuery();


            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");
            SqlCommand storeProcedureCommand = new SqlCommand("addCodigoPostal", con);
            con.Open();

            SqlCommand cmd = new SqlCommand("Update LIVRARIA set NomeLiv=@NomeLiv, Rua = @Rua, CodigoPostal=@CodigoPostal, ContactoID=@ContactoID where ID = @ID", con);
            
            cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text));
            cmd.Parameters.AddWithValue("@NomeLiv", txt_nomeL.Text);
            cmd.Parameters.AddWithValue("@Rua", txt_Rua.Text);
            cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txt_CP.Text));
            cmd.Parameters.AddWithValue("@ContactoID", txt_contacto.Text);
            cmd.ExecuteNonQuery();

            storeProcedureCommand.CommandType = System.Data.CommandType.StoredProcedure;
            storeProcedureCommand.Parameters.Add(new SqlParameter("@cp", int.Parse(txt_CP.Text)));
            storeProcedureCommand.Parameters.Add(new SqlParameter("@loc", txt_loc.Text));
            storeProcedureCommand.ExecuteNonQuery();
            con.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete LIVRARIA where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text));
            cmd.ExecuteNonQuery();



            con.Close();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Livraria", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

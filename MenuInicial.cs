using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;


namespace SmartBooks
{
     
    public partial class SmartBooks : Form
    {
        Thread th;
        public SmartBooks()
        {
            InitializeComponent();
        }

        public void openCliente(object obj)
        {
            Application.Run(new Utilizador());
        }
        public void openLivro(object obj)
        {
            Application.Run(new Livro());
        }
        public void openLivraria(object obj)
        {
            Application.Run(new Livraria());
        }
        public void openCP(object obj)
        {
            Application.Run(new CodigoPostal());
        }


        private void btn_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCliente);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_livro_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLivro);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_livraria_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLivraria);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_cp_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

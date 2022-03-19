using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CASOPRACTICO3.cliente.model;
using CASOPRACTICO3.cliente.clienteservicereference;

namespace CASOPRACTICO3.cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            clienteservicereference.webservSoapClient ws = new clienteservicereference.webservSoapClient();
            dgvpeliculas.DataSource = ws.Peliculas();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
           clienteservicereference.webservSoapClient ws = new clienteservicereference.webservSoapClient();
            var fecha = DateTime.Parse(txtfecha.Text);
            var id = Convert.ToInt32(txtid.Text);

            var resultado = ws.InsertarPelicula(id, txtnombre.Text, fecha, txtdescrip.Text, txtcomen.Text, txturl.Text);
            if (resultado == true)
              MessageBox.Show("DATOS GUARDADOS :)");
            else
               MessageBox.Show("OCURRIO UN ERROR :(");

            dgvpeliculas.DataSource = ws.Peliculas();

            txtid.Clear();
            txtnombre.Clear();
            txtfecha.Clear();
            txtdescrip.Clear();
            txtcomen.Clear();
            txturl.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            clienteservicereference.webservSoapClient ws = new clienteservicereference.webservSoapClient();
            var fecha = DateTime.Parse(txtfecha.Text);
            var id = Convert.ToInt32(txtid.Text);

            var resultado = ws.ModificarPelicula(id, txtnombre.Text, fecha, txtdescrip.Text, txtcomen.Text, txturl.Text);
            if (resultado == true)
                MessageBox.Show("DATOS ACTUALIZADOS :)");
            else
                MessageBox.Show("OCURRIO UN ERROR :(");

            dgvpeliculas.DataSource = ws.Peliculas();

            txtid.Clear();
            txtnombre.Clear();
            txtfecha.Clear();
            txtdescrip.Clear();
            txtcomen.Clear();
            txturl.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            clienteservicereference.webservSoapClient ws = new clienteservicereference.webservSoapClient();
            var id = Convert.ToInt32(txtid.Text);
            var resultado = ws.EliminarPelicula(id);
            if (resultado == true)
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
            else
                MessageBox.Show("OCURRIO UN ERROR :(");

            dgvpeliculas.DataSource = ws.Peliculas();

            txtid.Clear();
        }
    }
}

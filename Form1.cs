using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Librerias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var bd = new LibreriaEntities())
                {
                    var cliente = new Clientes();
                    cliente.Nombre = textBox3.Text;
                    cliente.Genero = textBox2.Text;
                    bd.Clientes.Add(cliente);
                    bd.SaveChanges();
                    MessageBox.Show("Cliente registrado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var bd = new LibreriaEntities())
                {
                    var Libro = new Libros();
                    Libro.Titulo = textBox5.Text;
                    Libro.TipoLibro = Convert.ToInt32(textBox6.Text);
                    Libro.Precio = Convert.ToInt32(textBox7.Text);
                    bd.Libros.Add(Libro);
                    bd.SaveChanges();
                    MessageBox.Show("libro registrado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var bd = new LibreriaEntities())
            {
                // Obtener el cliente por ID y mostrar el nombre en textBox9
                var cliente1 = bd.Clientes.FirstOrDefault(s => s.ClienteID == ClienteID);
                if (cliente1 != null)
                {
                    textBox9.Text = cliente1.Nombre;
                }
                else
                {
                    textBox9.Text = "Cliente no encontrado";
                }

                // Obtener el libro por ID y mostrar el nombre en textBox10
                var libro1 = bd.Libros.FirstOrDefault(s => s.LibroID == LibroID);
                if (libro1 != null)
                {
                    textBox10.Text = libro1.Titulo;
                }
                else
                {
                    textBox10.Text = "Libro no encontrado";
                }
            }

        }

    }
}


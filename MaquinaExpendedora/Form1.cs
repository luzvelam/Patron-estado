using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaExpendedora
{
    public partial class FrmMaquina : Form
    {
        public FrmMaquina()
        {
            InitializeComponent();
        }
        
        private void FrmMaquina_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual; 
            this.Location = new Point(300, 100); 
        }


        string productoSeleccionado = "";

        
        Contexto contexto = new Contexto();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Se selecciona el producto
            productoSeleccionado = "Coca";
            // Mensaje en pantalla
            lblMensaje.Text = "Seleccionaste Coca-Cola";

            // Se guarda en el contexto
            contexto.Producto = productoSeleccionado;
            // Se llama al estado actual para manejar la selección
            contexto.Estado.SeleccionarProducto(contexto);

            SoundPlayer player = new SoundPlayer("click.wav");
            player.Play();

        }

        private void picSabritas_Click(object sender, EventArgs e)
        {
            productoSeleccionado = "Sabritas";
            lblMensaje.Text = "Seleccionaste Sabritas";

            contexto.Producto = productoSeleccionado;
            contexto.Estado.SeleccionarProducto(contexto);

            SoundPlayer player = new SoundPlayer("click.wav");
            player.Play();

        }

        private void picSuavicrema_Click(object sender, EventArgs e)
        {
            productoSeleccionado = "Suavicrema";
            lblMensaje.Text = "Seleccionaste Suavicrema";

            contexto.Producto = productoSeleccionado;
            contexto.Estado.SeleccionarProducto(contexto);

            SoundPlayer player = new SoundPlayer("click.wav");
            player.Play();

        }


        private void picPocky_Click(object sender, EventArgs e)
        {
            productoSeleccionado = "Pocky";
            lblMensaje.Text = "Seleccionaste Pocky";

            contexto.Producto = productoSeleccionado;
            contexto.Estado.SeleccionarProducto(contexto);


            SoundPlayer player = new SoundPlayer("click.wav");
            player.Play();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnDinero_Click(object sender, EventArgs e)
        {
            // Se llama al estado actual para insertar dinero
            contexto.Estado.InsertarDinero(contexto);

          
            lblDinero.Text = "Dinero: $" + contexto.Dinero;
            lblEstado.Text = "Estado: Activo";
            lblMensaje.Text = contexto.Mensaje;

            SoundPlayer player = new SoundPlayer("dinero.wav");
            player.Play();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            contexto.Estado.ConfirmarCompra(contexto);

            lblMensaje.Text = contexto.Mensaje;
            lblDinero.Text = "Dinero: $" + contexto.Dinero;

            SoundPlayer player = new SoundPlayer("sonido.wav");
            player.Play();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            contexto.Estado.Cancelar(contexto);

            lblMensaje.Text = contexto.Mensaje;
            lblDinero.Text = "Dinero: $" + contexto.Dinero;
        }
    }
}

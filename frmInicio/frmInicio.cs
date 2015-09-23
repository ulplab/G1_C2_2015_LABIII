using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Interfaces;
using Logica;
using Entidades;
using Datos;
using System.Data.SqlClient;

namespace frmInicio
{
    public partial class frmInicio : Form
    {
        IMetodosFactory manejador;
        IMetodos metodosUsuarios;

        string usuarioRegistrado;
        int idUsuario;

        
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            tbClave.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar(tbUsuario, tbClave))
            {
                manejador = new MetodosFactory();

                metodosUsuarios = manejador.getMetodos(MetodoType.usuarios);
                bool existe = false;
                bool conecto = true;

                try
                {
                    foreach (IEntidad usu in metodosUsuarios.Todo())
                    {
                        clsUsuarios usuario = (clsUsuarios)usu;

                        if(usuario.Username==tbUsuario.Text && usuario.Contraseña==tbClave.Text)
                        {
                            existe = true;
                            idUsuario = usuario.Id;
                        }
                    }                   
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Se ha producido el sgte. error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    conecto = false;
                }

                if (existe)
                {
                    usuarioRegistrado = tbUsuario.Text;
                    frmMenu oFrmMenu = new frmMenu(this);
                    oFrmMenu.Show();
                    usuarioRegistrado = tbUsuario.Text;
                    this.Hide();
                }
                else
                {
                    if (conecto)
                    {
                        MessageBox.Show("Los datos ingresados no son válidos", "Ingreso fallido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }   
                    tbClave.Clear();
                    tbUsuario.Clear();
                    tbUsuario.Focus();
                }
            }
        }

        /// <summary>
        /// Verifica que los campos contengan un string alfanumérico de al menos 3 caracteres.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        private bool validar(TextBox usuario, TextBox clave)
        {
            TextBox[] parametros = { usuario, clave };
            foreach(TextBox par in parametros)
            {                
                if(string.IsNullOrWhiteSpace((par as TextBox).Text))
                {
                    MessageBox.Show("Campo "+(par as TextBox).Tag+" vacío.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    (par as TextBox).Focus();
                    return false;
                }
                if(!EsAlfanumerico((par as TextBox).Text))
                {
                    MessageBox.Show("Solo se permiten caracteres alfanumericos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    (par as TextBox).Clear();
                    (par as TextBox).Focus();
                    return false;
                }
                if((par as TextBox).Text.Length < 3)
                {
                    MessageBox.Show("Campo " + (par as TextBox).Tag + " incompleto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    (par as TextBox).Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// true = la cadena ingresada es alfanumérica, false = contiene otros símbolos
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        private bool EsAlfanumerico(String cadena)
        {
            Regex patronAlfanumerico = new Regex("[^a-zA-Z0-9]");
            return !patronAlfanumerico.IsMatch(cadena);
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string UsuarioRegistrado
        {
            get { return usuarioRegistrado; }
        }

    }
}

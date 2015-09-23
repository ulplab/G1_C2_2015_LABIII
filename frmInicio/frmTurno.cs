using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
using Interfaces;
using System.Data.SqlClient;

namespace frmInicio
{
    public partial class frmTurno : Form
    {
        frmMenu padre;
        IMetodosFactory manejador;
        IMetodos metodosTurnos;
        IEntidad paciente;

        public frmTurno(IEntidad paciente, frmMenu padre)
        {
            InitializeComponent();
            this.padre = padre;
            this.paciente = paciente;
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            this.Text = "Turno para: " + ((clsPaciente)paciente).Nombre + " " + ((clsPaciente)paciente).Apellido + " documento: " + ((clsPaciente)paciente).Dni;
            

        }

        /// <summary>
        /// en casi de existir medicos correspondientes habilita controles, caso contrario cierra form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hay = false;
            List<string> strMed = new List<string>();
            if (padre.Medicos.Count >= 1)
            {
                hay = true;
                foreach (clsMedico med in padre.Medicos)
                {
                    if (med.Especialidad == cbEspecialidadT.SelectedItem.ToString())
                    {
                        strMed.Add(med.Apellido + " " + med.Nombre);
                        hay = true;
                    }
                }
                if (hay)
                {
                    cbMedicos.DataSource = null;
                    cbMedicos.DataSource = strMed;
                    cbMedicos.Enabled = true;
                }
                else
                    MessageBox.Show("No hay medicos registrados con esa especialidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se registran medicos cargados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        /// <summary>
        /// habilita el boton de carga de medico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMedicos.SelectedIndex != (-1))
            {
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Enabled = true;
                }
            }
        }

        /// <summary>
        /// TURNO ALTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarT_Click(object sender, EventArgs e)
        {
            DialogResult tur = MessageBox.Show("Confirme :"+dtpFecha.Value.ToLongDateString()+" Horario: "+nudHoras.Value.ToString()+":"+nudMinutos.Value.ToString(),"Confirmación.", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(tur==DialogResult.OK)
            {
                DateTime fechaTurno = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, (int)nudHoras.Value, (int)nudMinutos.Value, 0);
                int idMedico=0;
                int idUsuario = padre.Padre.IdUsuario;
                foreach(clsMedico med in padre.Medicos)
                {
                    if((med.Apellido + " " + med.Nombre)==cbMedicos.SelectedItem.ToString())
                    {
                        idMedico=med.Id;
                    }
                }
                
                clsTurno oClsTurno = new clsTurno(idMedico, paciente.Id, fechaTurno, padre.Padre.IdUsuario);
                if(!existeTurno(oClsTurno))
                {
                    manejador = new MetodosFactory();
                    metodosTurnos = manejador.getMetodos(MetodoType.turnos);
                    try
                    {
                        metodosTurnos.Alta(oClsTurno);
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Error de conexion con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Se produjo el sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("El turno se cargo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// comprueba si el turno esta disponible
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        public bool existeTurno(clsTurno turno)
        {
            foreach(clsTurno existente in padre.Turnos)
            {
                if(existente.IdMedico==turno.IdMedico && existente.Fecha==turno.Fecha)
                {
                    MessageBox.Show("Turno ya asignado, verifique horarios disponibles en la pestaña \"Turnos\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return true;
                }
            }
            return false;
        }

    }
}

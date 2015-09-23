using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Logica;
using Interfaces;
using Entidades;
using System.Data.SqlClient;

namespace frmInicio
{
    public partial class frmMenu : Form
    {
        IMetodosFactory manejador;
        IMetodos metodosMedicos;
        IMetodos metodosPacientes;
        IMetodos metodosUsuarios;
        IMetodos metodosTurnos;
        List<clsMedico> medicos;
        List<clsPaciente> pacientes;
        List<clsUsuarios> usuarios;
        List<clsTurno> turnos;

        bool edicion = false;
        frmInicio padre;


        public frmMenu(frmInicio inicio)
        {
            InitializeComponent();
            padre = inicio;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = null;
            dgvTurnos.DataSource = null;
            dgvUsuarios.DataSource = null;
            dgvPacientes.DataSource = null;

            manejador = new MetodosFactory();

            metodosMedicos = manejador.getMetodos(MetodoType.medicos);
            metodosPacientes = manejador.getMetodos(MetodoType.pacientes);
            metodosUsuarios = manejador.getMetodos(MetodoType.usuarios);
            metodosTurnos = manejador.getMetodos(MetodoType.turnos);

            medicos = new List<clsMedico>();
            pacientes = new List<clsPaciente>();
            usuarios = new List<clsUsuarios>();
            turnos = new List<clsTurno>();
            actualizar();
        }

        /// <summary>
        /// MEDICO ALTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (verificarMedico())
            {
                if (!edicion)
                {
                    clsMedico oClsMedico = new clsMedico(Convert.ToInt32(tbMatricula.Text), Convert.ToInt64(tbDocumento.Text), tbNombre.Text, tbApellido.Text, cbEspecialidad.SelectedItem.ToString());
                    bool fallo = false;
                    try
                    {
                        metodosMedicos.Alta((IEntidad)oClsMedico);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Se ha producido el sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fallo = true;
                    }

                    limpiarMedico();
                    tbMatricula.Focus();
                    dgvMedicos.Columns[0].Visible = false;
                    if (!fallo)
                    {
                        MessageBox.Show("El medico fue insertado con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizar();
                    }
                }
                else
                {
                    clsMedico oClsMedico = new clsMedico(Convert.ToInt32(tbMatricula.Text), Convert.ToInt64(tbDocumento.Text), tbNombre.Text, tbApellido.Text, cbEspecialidad.SelectedItem.ToString());
                    oClsMedico.Id = Convert.ToInt32( dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[0].Value);
                    try
                    {
                        metodosMedicos.Modificacion((IEntidad)oClsMedico);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Se ha producido el sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    actualizar();
                    limpiarMedico();
                }
            }
        }

        /// <summary>
        /// MEDICO confirma la existencia de datos coherentes
        /// </summary>
        /// <returns></returns>
        private bool verificarMedico()
        {
            foreach(Control ctrl in tpMedicos.Controls)
            {
                if(ctrl is TextBox)
                {
                    if(string.IsNullOrWhiteSpace((ctrl as TextBox).Text))
                    {
                        MessageBox.Show("El campo "+(ctrl as TextBox).Tag+" está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBox).Focus();
                        return false;
                    }
                }
            }

            if (tbDocumento.Text.Length == 8)
            {
                if (!edicion)
                {
                    foreach (clsMedico doc in metodosMedicos.Todo())
                    {
                        if (((clsMedico)doc).Dni == Convert.ToInt64(tbDocumento.Text))
                        {
                            MessageBox.Show("El doctor " + ((clsMedico)doc).Nombre + " " + ((clsMedico)doc).Apellido + ", Documento: " + ((clsMedico)doc).Dni + " ya está cargado en el sistema.", "Doctor registrado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                    }
                }
                else
                {
                    btnCargar.Text = "Cargar";
                }
            }
            else
            {
                MessageBox.Show("Campo \"Documento\" incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDocumento.Focus();
                return false;
            }
            if(cbEspecialidad.SelectedItem==null)
            {
                MessageBox.Show("El campo Especialidad está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEspecialidad.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// MEDICO BAJA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult elim = MessageBox.Show("¿Desea eliminar a " + dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[3].Value + " " + dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[4].Value + " Doc. Nro: " + dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[2].Value, "Verificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(elim==DialogResult.OK)
            {
                IEntidad exMedico = new clsMedico();
                exMedico.Id=Convert.ToInt32( dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[0].Value);

                try
                {
                    metodosMedicos.Baja(exMedico);
                    MessageBox.Show("Se eliminó con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    medicos.Clear();
                    foreach (IEntidad ent in metodosMedicos.Todo())
                    {
                        medicos.Add((clsMedico)ent);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Se produjo el sgte. error "+ex.Message);
                }
                dgvMedicos.DataSource = null;
                dgvMedicos.DataSource = medicos;
            }           
        }

        /// <summary>
        /// MEDICO UPDATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult elim = MessageBox.Show("¿Desea editar a " + dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[3].Value + " " + dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[4].Value + " Doc. Nro: " + dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[2].Value, "Verificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(elim==DialogResult.OK)
            {
                edicion = true;
                tbMatricula.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[1].Value.ToString();
                tbDocumento.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[2].Value.ToString();
                tbNombre.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[3].Value.ToString();
                tbApellido.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[4].Value.ToString();
                cbEspecialidad.SelectedItem = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[5].Value.ToString();
                btnCargar.Text = "Editar";
            }
        }

        /// <summary>
        /// MEDICO limpia los campos de cargar medico
        /// </summary>
        private void limpiarMedico()
        {
            foreach (Control ctrl in tpMedicos.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
                cbEspecialidad.SelectedIndex = -1;
            }
        }


        /// <summary>
        /// TURNO habilita el filtrado por fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFecha.Checked)
            {
                dtpFecha.Enabled = true;
                List<clsTurno> lista = new List<clsTurno>();
                foreach (clsMedico med in medicos)
                {
                    if (cbMedicos.SelectedItem.ToString() == med.Apellido + " " + med.Nombre)
                    {
                        foreach (clsTurno tur in turnos)
                        {
                            if (tur.IdMedico == med.Id && tur.Fecha.Date==dtpFecha.Value.Date)
                            {
                                lista.Add(tur);
                            }
                        }
                    }
                }
                actualizarTurno(lista);
            }
            else
            {
                dtpFecha.Enabled = false;
            }
        }

        /// <summary>
        /// PACIENTE limpia los campos de cargar paciente
        /// </summary>
        private void limpiarPaciente()
        {
            foreach (Control ctrl in tpPaciente.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
            tbNombreP.Focus();
        }

        /// <summary>
        /// PACIENTE BAJA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult elim = MessageBox.Show("¿Desea eliminar a " + dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[1].Value.ToString() + " " + dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[2].Value.ToString(), "Verificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (elim == DialogResult.OK)
            {
                IEntidad ent = new clsPaciente();
                ent.Id = Convert.ToInt32(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value);
                try
                {
                    metodosPacientes.Baja(ent);
                    pacientes.Clear();
                    foreach (IEntidad enti in metodosPacientes.Todo())
                    {
                        pacientes.Add((clsPaciente)enti);
                    }
                    dgvPacientes.DataSource = null;
                    dgvPacientes.DataSource = pacientes;
                    dgvPacientes.Columns[0].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el sgte. error " + ex.Message);
                }
            }
        }

        /// <summary>
        /// PACIENTE busca un paciente por Documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (tbBuscarP.Text.Length == 8)
            {
                foreach (IEntidad pac in pacientes)
                {
                    if (((clsPaciente)pac).Dni == Convert.ToInt64(tbBuscarP.Text))
                    {
                        List<clsPaciente> lista = new List<clsPaciente>();

                        clsPaciente oClsPaciente = new clsPaciente(((clsPaciente)pac).Dni, ((clsPaciente)pac).Nombre, ((clsPaciente)pac).Apellido, ((clsPaciente)pac).Telefono);

                        lista.Clear();
                        lista.Add(oClsPaciente);
                        
                        dgvPacientes.DataSource = lista;
                        existe = true;
                    }
                }
            }
            else
                MessageBox.Show("Formato de Documento incorrecto", "Alerta.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (!existe)
                MessageBox.Show("No se registra paciente con dicho documento.", "Alerta.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// PACIENTE lista todos los pacientes cargados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarP_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = null;
            actualizar();
            dgvPacientes.DataSource = pacientes;
        }

        /// <summary>
        /// PACIENTE ALTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarP_Click(object sender, EventArgs e)
        {
            if(verificarPaciente())
            {
                clsPaciente pac=new clsPaciente(Convert.ToInt64(tbDniP.Text), tbNombreP.Text, tbApellidoP.Text, Convert.ToInt64(tbTelefonoP.Text));
                try 
                {
                    metodosPacientes.Alta((IEntidad)pac);
                    pacientes.Clear();
                    foreach(IEntidad ent in metodosPacientes.Todo())
                    {
                        pacientes.Add((clsPaciente)ent);
                    }
                    dgvPacientes.DataSource = null;
                    dgvPacientes.DataSource = pacientes;
                    limpiarPaciente();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error de conexion con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// PACIENTE verifica coherencia de datos para cargar Paciente
        /// </summary>
        /// <returns></returns>
        private bool verificarPaciente()
        {
            foreach(Control ctrl in tpPaciente.Controls)
            {
                if(ctrl is TextBox )
                {
                    if (string.IsNullOrWhiteSpace((ctrl as TextBox).Text) && (ctrl as TextBox).Tag.ToString()!="no")
                    {
                        MessageBox.Show("El campo " + (ctrl as TextBox).Tag + " está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBox).Focus();
                        return false;
                    }
                }
            }
            if (tbDniP.Text.Length < 8)
            {
                MessageBox.Show("Formato de Documento incorrecto", "Alerta.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDniP.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// USUARIO verifica coherencia de datos para cargar Usuario
        /// </summary>
        /// <returns></returns>
        private bool verificaUsuario()
        {
            foreach(Control ctrl in tpUsuarios.Controls)
            {
                if(ctrl is TextBox)
                {
                    if(string.IsNullOrWhiteSpace((ctrl as TextBox).Text))
                    {
                        MessageBox.Show("El campo "+(ctrl as TextBox).Tag+" está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        (ctrl as TextBox).Focus();
                        return false;
                    }
                }
            }
            if(tbClave.Text!=tbClaveConfirm.Text)
            {
                MessageBox.Show("La clave no coincide","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbClave.Clear();
                tbClaveConfirm.Clear();
                tbClave.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// USUARIO BAJA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult elim = MessageBox.Show("¿Desea eliminar a " + dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[1].Value.ToString(), "Verificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (elim == DialogResult.OK)
            {
                if (dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[1].Value.ToString() == "admin")
                {
                    MessageBox.Show("No es posible eliminar el usuario admin.", "Accion denegada.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                IEntidad ent = new clsUsuarios();
                ent.Id = Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value);
                try
                {
                    metodosUsuarios.Baja(ent);
                    usuarios.Clear();
                    foreach (IEntidad enti in metodosUsuarios.Todo())
                    {
                        usuarios.Add((clsUsuarios)enti);
                    }
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = usuarios;
                    dgvUsuarios.Columns[2].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el sgte. error " + ex.Message);
                }
            }
        }

        /// <summary>
        /// USUARIO ALTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if(verificaUsuario())
            {
                bool fallo = false;
                IEntidad usu = new clsUsuarios(tbUsuario.Text, tbClave.Text);
                try
                {
                    metodosUsuarios.Alta((IEntidad)usu);
                    usuarios.Clear();
                    foreach (IEntidad ent in metodosUsuarios.Todo())
                    {
                        usuarios.Add((clsUsuarios)ent);
                    }
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = usuarios;
                    dgvUsuarios.Columns[2].Visible = false;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se ha producido el sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fallo = true;
                }
                if (!fallo)
                {
                    MessageBox.Show("El usuario fue insertado con exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEspecialidadTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecialidadMenuT.SelectedIndex != (-1))
            {
                bool hay = false;
                List<clsTurno> lista = new List<clsTurno>();
                List<string> strlist = new List<string>();
                if (medicos.Count >= 1)
                {
                    hay = true;
                    foreach (clsMedico med in medicos)
                    {
                        if (med.Especialidad == cbEspecialidadMenuT.SelectedItem.ToString())
                        {
                            strlist.Add(med.Apellido + " " + med.Nombre);
                            if(turnos.Count>0)
                            {
                                foreach(clsTurno tur in turnos)
                                {
                                    if(tur.IdMedico==med.Id)
                                    {
                                        lista.Add(tur);
                                    }
                                }
                            }
                        }
                    }
                    if (hay)
                    {
                        cbMedicos.DataSource = null;
                        cbMedicos.DataSource = strlist;
                        cbMedicos.Enabled = true;
                    }
                    else
                        MessageBox.Show("No hay medicos registrados con esa especialidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se registran medicos cargados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                actualizarTurno(lista);
                cbMedicos.SelectedIndex = (-1);
            }
            else
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag.ToString() != "especialidad")
                    {
                        ctrl.Enabled = false;
                    }
                }
            }
            cbMedicos.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMedicos.SelectedIndex!=(-1))
            {
                List<clsTurno> lista = new List<clsTurno>();
                List<string> strlist = new List<string>();

                foreach (clsMedico med in medicos)
                {
                    if ((med.Apellido + " " + med.Nombre) == cbMedicos.SelectedValue.ToString())
                    {
                        foreach (clsTurno turno in turnos)
                        {
                            if (turno.IdMedico == med.Id)
                            {
                                lista.Add(turno);
                            }
                        }
                        break;
                    }
                }
                actualizarTurno(lista);
                dtpFecha.Enabled = true;
                cbFecha.Enabled = true;
            }
        }

        /// <summary>
        /// TURNOS abre formulario de carga de turnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarTurno_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.Focus() && dgvPacientes.SelectedRows.Count>0)
            {
                try
                {
                    int idPaciente = Convert.ToInt32(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value);
                    long dni = Convert.ToInt64(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[3].Value);
                    string nombre = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[1].Value.ToString();
                    string apellido = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[2].Value.ToString();
                    long telefono = Convert.ToInt64(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[3].Value);

                    clsPaciente oClsPacienteTurno = new clsPaciente(idPaciente, dni, nombre, apellido, telefono);
                    actualizar();

                    frmTurno oFrmTurno = new frmTurno(oClsPacienteTurno, this);

                    oFrmTurno.ShowDialog();
                }
                catch(NullReferenceException ex)
                {
                    dgvTurnos.Focus();
                }
            }
            else
            { 
                MessageBox.Show("Seleccione un paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public List<clsMedico> Medicos
        {
            get { return medicos; }
            set { medicos = value; }
        }

        public List<clsPaciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }

        public List<clsUsuarios> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        public List<clsTurno> Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }

        public frmInicio Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        /// <summary>
        /// actualiza todas las listas y sus respectivas grillas.
        /// </summary>
        public void actualizar()
        {
            medicos.Clear();
            pacientes.Clear();
            turnos.Clear();
            usuarios.Clear();
            try
            {
                foreach (IEntidad ent in metodosMedicos.Todo())
                {
                    medicos.Add((clsMedico)ent);
                }
                foreach (IEntidad ent in metodosPacientes.Todo())
                {
                    pacientes.Add((clsPaciente)ent);
                }
                foreach (IEntidad ent in metodosTurnos.Todo())
                {
                    turnos.Add((clsTurno)ent);
                }
                foreach (IEntidad ent in metodosUsuarios.Todo())
                {
                    usuarios.Add((clsUsuarios)ent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = medicos;
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = pacientes;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios;
            dgvUsuarios.Columns[2].Visible = false;
            dgvMedicos.Columns[0].Visible = false;
            dgvPacientes.Columns[0].Visible = false;
            actualizarTurno(turnos);            
        }

        public void actualizarTurno(List<clsTurno> turnos)
        {
            dgvTurnos.Columns.Clear();

            dgvTurnos.Columns.Add("idTurno", "idTurno");
            dgvTurnos.Columns["idTurno"].Visible = false;
            dgvTurnos.Columns.Add("Medico", "Medico");
            dgvTurnos.Columns.Add("Paciente", "Paciente");
            dgvTurnos.Columns.Add("Fecha", "Fecha");
            
            foreach(clsTurno turno in turnos)
            {
                try
                {
                    int id = ((clsMedico)metodosMedicos.buscarPorId(turno.IdMedico)).Id;
                    string medico = ((clsMedico)metodosMedicos.buscarPorId(turno.IdMedico)).Nombre + " " + ((clsMedico)metodosMedicos.buscarPorId(turno.IdMedico)).Apellido;
                    string paciente = ((clsPaciente)metodosPacientes.buscarPorId(turno.IdPaciente)).Nombre + " " + ((clsPaciente)metodosPacientes.buscarPorId(turno.IdPaciente)).Apellido;
                    DateTime fecha = turno.Fecha;
                    dgvTurnos.Rows.Add(id, medico, paciente, fecha);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Se ha producido el sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public void esString(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.Close();
        }

        private void tbMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            esString(sender, e);
        }

        private void tbClaveConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten números y/o letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// TURNO BAJA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.SelectedRows.Count > 0)
            {
                IEntidad tur;
                MessageBox.Show(dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells["idTurno"].Value.ToString());
                try
                {
                    tur = metodosTurnos.buscarPorId(Convert.ToInt32(dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells["idTurno"].Value));
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Se ha producido el sgte. error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult elim = MessageBox.Show("Desea eliminar el turno seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (elim == DialogResult.OK)
                {
                    IEntidad ent = new clsTurno();
                    ent.Id = Convert.ToInt32(dgvTurnos.Rows[dgvTurnos.CurrentRow.Index].Cells[0].Value);
                    try
                    {
                        metodosTurnos.Baja(ent);
                        actualizar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el sgte. error " + ex.Message);
                    }
                }
            }
        }
    }
}

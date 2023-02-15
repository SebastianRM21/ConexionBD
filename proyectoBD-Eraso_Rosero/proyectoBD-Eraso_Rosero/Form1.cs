using System;
using System.Data;
using System.Windows.Forms;
using proyectoBD_Eraso_Rosero.AccesoDatos;
using proyectoBD_Eraso_Rosero.Logica;

namespace proyectoBD_Eraso_Rosero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tenista ten = new Tenista();
        TorneoTenis torneo = new TorneoTenis();
        Registro reg = new Registro();
        Datos dt = new Datos();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cod, r;
            string nom, apel,cat ;

            if (txtCodigo.Text.Trim().Equals("") || txtNombre.Text.Trim().Equals("") || txtApellido.Text.Trim().Equals("") || cbxCategoria.SelectedItem==null)
            {
                MessageBox.Show("Hay Campos Vacios", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (txtCodigo.Text.Length > 10)
                    {
                        MessageBox.Show("El codigo no puede tener mas de 10 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cod = int.Parse(txtCodigo.Text);

                        if (ten.validarCodigoTen(cod).Tables[0].Rows.Count==0)
                        {
                            cod = int.Parse(txtCodigo.Text);
                            nom = txtNombre.Text.Trim();
                            apel = txtApellido.Text.Trim();
                            cat = cbxCategoria.SelectedItem.ToString();

                            r = ten.ingresarTenista(cod, nom, apel, cat);

                            if (r > 0)
                            {
                                MessageBox.Show("Tenista ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCodigo.Text = "";
                                txtNombre.Text = "";
                                txtApellido.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Tenista NO ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El codigo ya está en uso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } 
                }
                catch (Exception error)
                {
                    MessageBox.Show("El codigo debe ser numerico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            int cod, r;
            string nom;
            if (txtCodigoTor.Text.Trim().Equals("")||txtNombreTor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hay campos vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (txtCodigoTor.Text.Length>10)
                    {
                        MessageBox.Show("El no puede tener mas de 10 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        cod = int.Parse(txtCodigoTor.Text);
                        if (torneo.validarCodigoTor(cod).Tables[0].Rows.Count==0)
                        {
                            nom = txtNombreTor.Text;
                            r = torneo.ingresarTorneo(cod, nom);

                            if (r > 0)
                            {
                                MessageBox.Show("Torneo Ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Torneo NO Ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El codigo ya está en uso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("El codigo debe ser numerico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int  r;
            String Fecha,hora;
            DataRowView  codten, codtor;
            codten =(DataRowView) cbxCodTen.SelectedItem;
            codtor = (DataRowView)cbxCodTor.SelectedItem;
            Fecha = dtpFecha.Text.ToString();
            hora = quitarPuntos(dtpHora.Text.ToString()) ;
            r = reg.registrar(int.Parse(codten.Row.ItemArray[0].ToString())  ,int.Parse(codtor.Row.ItemArray[0].ToString()) ,Fecha,hora);

            if (r > 0)
            {
                MessageBox.Show("Torneo Ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Torneo NO Ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String quitarPuntos(String dato)
        {
            dato = dato.Replace(".", " ");
            String[] datos= dato.Split(' ');
            dato = datos[0] +" "+ datos[1] +"m";
            return dato;
        }

        private void btnConsultar1_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            DataRowView codtor;
            String fecha;
            if (cbxCodTorConsulta.SelectedItem==null)
            {
                MessageBox.Show("Seleccione un torneo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                codtor = (DataRowView)cbxCodTorConsulta.SelectedItem;
                fecha = dtpFechaCon.Text.ToString();
                dsResultado = reg.consulta1(int.Parse(codtor.Row.ItemArray[0].ToString()), fecha);

                if (dsResultado.Tables[0].Rows.Count==0)
                {
                    MessageBox.Show("No se encontraron registros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvConsulta1.DataSource = dsResultado;
                    dgvConsulta1.DataMember = "ResultadoDatos";
                }
            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = ten.consulta2();
            if (dsResultado.Tables[0].Rows.Count > 0)
            {
                lbConsulta2.Text = dsResultado.Tables[0].Rows[0]["cuenta"].ToString();
            }
            else
            {
                lbConsulta2.Text = "0";
            }
        }

        private void ActualizarCodTenista(object sender, EventArgs e)
        {
            DataSet miDS = new DataSet();
            String consulta = "select tencod, tenCod||'-'||tenNombre regten from tblTenista";
            miDS = dt.ejecutarSELECT(consulta);
            cbxCodTen.DataSource = miDS.Tables[0];
            cbxCodTen.DisplayMember = "regten";
            //cbxCodTen.ValueMember = "TENCOD";
        }

        private void ActualizarCodTorneo(object sender, EventArgs e)
        {
            DataSet miDS = new DataSet();
            String consulta1 = "select torcod, torCod||'-'||torNombre regtor from tblTorneo";
            miDS = dt.ejecutarSELECT(consulta1);
            cbxCodTor.DataSource = miDS.Tables[0];
            cbxCodTor.DisplayMember = "regtor";
            //cbxCodTor.ValueMember = "torCod";
        }
        private void ActualizarCodTorneoConsulta(object sender, EventArgs e)
        {
            DataSet miDS = new DataSet();
            String consulta1 = "select torcod, torCod||'-'||torNombre regtor from tblTorneo";
            miDS = dt.ejecutarSELECT(consulta1);
            cbxCodTorConsulta.DataSource = miDS.Tables[0];
            cbxCodTorConsulta.DisplayMember = "regtor";
            //cbxCodTor.ValueMember = "torCod";
        }

    }
}
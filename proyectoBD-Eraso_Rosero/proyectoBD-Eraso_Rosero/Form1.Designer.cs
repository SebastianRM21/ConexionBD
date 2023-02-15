
namespace proyectoBD_Eraso_Rosero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tpTenista = new System.Windows.Forms.TabPage();
            this.pnlTenista = new System.Windows.Forms.Panel();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbCat = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tpTorneo = new System.Windows.Forms.TabPage();
            this.pnlTorneo = new System.Windows.Forms.Panel();
            this.txtNombreTor = new System.Windows.Forms.TextBox();
            this.txtCodigoTor = new System.Windows.Forms.TextBox();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.lbNombreTor = new System.Windows.Forms.Label();
            this.lbCodigo2 = new System.Windows.Forms.Label();
            this.lbMensaje1 = new System.Windows.Forms.Label();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.cbxCodTor = new System.Windows.Forms.ComboBox();
            this.cbxCodTen = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConsulta1 = new System.Windows.Forms.TabPage();
            this.pnlConsulta1 = new System.Windows.Forms.Panel();
            this.cbxCodTorConsulta = new System.Windows.Forms.ComboBox();
            this.dtpFechaCon = new System.Windows.Forms.DateTimePicker();
            this.lbFechaCon = new System.Windows.Forms.Label();
            this.lbCodTorCon = new System.Windows.Forms.Label();
            this.btnConsultar1 = new System.Windows.Forms.Button();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.tpConsulta2 = new System.Windows.Forms.TabPage();
            this.pnlConsulta2 = new System.Windows.Forms.Panel();
            this.lbConsulta2 = new System.Windows.Forms.Label();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.lbMensaje4 = new System.Windows.Forms.Label();
            this.lbMensaje3 = new System.Windows.Forms.Label();
            this.tbcGestion.SuspendLayout();
            this.tpTenista.SuspendLayout();
            this.pnlTenista.SuspendLayout();
            this.tpTorneo.SuspendLayout();
            this.pnlTorneo.SuspendLayout();
            this.tpRegistro.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.tpConsulta1.SuspendLayout();
            this.pnlConsulta1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.tpConsulta2.SuspendLayout();
            this.pnlConsulta2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tpTenista);
            this.tbcGestion.Controls.Add(this.tpTorneo);
            this.tbcGestion.Controls.Add(this.tpRegistro);
            this.tbcGestion.Controls.Add(this.tpConsulta1);
            this.tbcGestion.Controls.Add(this.tpConsulta2);
            this.tbcGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcGestion.Location = new System.Drawing.Point(0, 0);
            this.tbcGestion.Multiline = true;
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(806, 475);
            this.tbcGestion.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcGestion.TabIndex = 0;
            // 
            // tpTenista
            // 
            this.tpTenista.Controls.Add(this.pnlTenista);
            this.tpTenista.Location = new System.Drawing.Point(4, 25);
            this.tpTenista.Name = "tpTenista";
            this.tpTenista.Padding = new System.Windows.Forms.Padding(3);
            this.tpTenista.Size = new System.Drawing.Size(798, 446);
            this.tpTenista.TabIndex = 0;
            this.tpTenista.Text = "Tenista";
            this.tpTenista.UseVisualStyleBackColor = true;
            // 
            // pnlTenista
            // 
            this.pnlTenista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTenista.BackgroundImage")));
            this.pnlTenista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTenista.Controls.Add(this.cbxCategoria);
            this.pnlTenista.Controls.Add(this.txtApellido);
            this.pnlTenista.Controls.Add(this.txtNombre);
            this.pnlTenista.Controls.Add(this.txtCodigo);
            this.pnlTenista.Controls.Add(this.btnGuardar);
            this.pnlTenista.Controls.Add(this.lbCat);
            this.pnlTenista.Controls.Add(this.lbApellido);
            this.pnlTenista.Controls.Add(this.lbNombre);
            this.pnlTenista.Controls.Add(this.lbCodigo);
            this.pnlTenista.Controls.Add(this.lbMensaje);
            this.pnlTenista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTenista.Location = new System.Drawing.Point(0, 0);
            this.pnlTenista.Name = "pnlTenista";
            this.pnlTenista.Size = new System.Drawing.Size(803, 450);
            this.pnlTenista.TabIndex = 1;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "NOVATO",
            "JUNIOR",
            "SENIOR"});
            this.cbxCategoria.Location = new System.Drawing.Point(188, 283);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(262, 37);
            this.cbxCategoria.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(188, 224);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 35);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(188, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 35);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(188, 109);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(262, 35);
            this.txtCodigo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(562, 166);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 63);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbCat
            // 
            this.lbCat.AutoSize = true;
            this.lbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCat.Location = new System.Drawing.Point(38, 291);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(134, 29);
            this.lbCat.TabIndex = 5;
            this.lbCat.Text = "Categoria:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lbApellido.Location = new System.Drawing.Point(38, 227);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(117, 29);
            this.lbApellido.TabIndex = 4;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNombre.Location = new System.Drawing.Point(38, 166);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(114, 29);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCodigo.Location = new System.Drawing.Point(38, 109);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(105, 29);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "Codigo:";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMensaje.Location = new System.Drawing.Point(37, 28);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(418, 37);
            this.lbMensaje.TabIndex = 1;
            this.lbMensaje.Text = "Digite los datos del tenista";
            // 
            // tpTorneo
            // 
            this.tpTorneo.Controls.Add(this.pnlTorneo);
            this.tpTorneo.Location = new System.Drawing.Point(4, 25);
            this.tpTorneo.Name = "tpTorneo";
            this.tpTorneo.Padding = new System.Windows.Forms.Padding(3);
            this.tpTorneo.Size = new System.Drawing.Size(798, 446);
            this.tpTorneo.TabIndex = 1;
            this.tpTorneo.Text = "Torneo";
            this.tpTorneo.UseVisualStyleBackColor = true;
            // 
            // pnlTorneo
            // 
            this.pnlTorneo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTorneo.BackgroundImage")));
            this.pnlTorneo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTorneo.Controls.Add(this.txtNombreTor);
            this.pnlTorneo.Controls.Add(this.txtCodigoTor);
            this.pnlTorneo.Controls.Add(this.btnGuardar1);
            this.pnlTorneo.Controls.Add(this.lbNombreTor);
            this.pnlTorneo.Controls.Add(this.lbCodigo2);
            this.pnlTorneo.Controls.Add(this.lbMensaje1);
            this.pnlTorneo.Location = new System.Drawing.Point(0, 0);
            this.pnlTorneo.Name = "pnlTorneo";
            this.pnlTorneo.Size = new System.Drawing.Size(795, 450);
            this.pnlTorneo.TabIndex = 1;
            // 
            // txtNombreTor
            // 
            this.txtNombreTor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNombreTor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTor.Location = new System.Drawing.Point(277, 151);
            this.txtNombreTor.Name = "txtNombreTor";
            this.txtNombreTor.Size = new System.Drawing.Size(203, 31);
            this.txtNombreTor.TabIndex = 5;
            // 
            // txtCodigoTor
            // 
            this.txtCodigoTor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(137)))));
            this.txtCodigoTor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoTor.Location = new System.Drawing.Point(277, 106);
            this.txtCodigoTor.Name = "txtCodigoTor";
            this.txtCodigoTor.Size = new System.Drawing.Size(203, 31);
            this.txtCodigoTor.TabIndex = 4;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar1.FlatAppearance.BorderSize = 2;
            this.btnGuardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar1.Location = new System.Drawing.Point(585, 109);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(153, 66);
            this.btnGuardar1.TabIndex = 3;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = false;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // lbNombreTor
            // 
            this.lbNombreTor.AutoSize = true;
            this.lbNombreTor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreTor.Location = new System.Drawing.Point(65, 154);
            this.lbNombreTor.Name = "lbNombreTor";
            this.lbNombreTor.Size = new System.Drawing.Size(181, 25);
            this.lbNombreTor.TabIndex = 2;
            this.lbNombreTor.Text = "Nombre Torneo:";
            // 
            // lbCodigo2
            // 
            this.lbCodigo2.AutoSize = true;
            this.lbCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo2.Location = new System.Drawing.Point(65, 109);
            this.lbCodigo2.Name = "lbCodigo2";
            this.lbCodigo2.Size = new System.Drawing.Size(174, 25);
            this.lbCodigo2.TabIndex = 1;
            this.lbCodigo2.Text = "Codigo Torneo:";
            // 
            // lbMensaje1
            // 
            this.lbMensaje1.AutoSize = true;
            this.lbMensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje1.Location = new System.Drawing.Point(207, 26);
            this.lbMensaje1.Name = "lbMensaje1";
            this.lbMensaje1.Size = new System.Drawing.Size(370, 33);
            this.lbMensaje1.TabIndex = 0;
            this.lbMensaje1.Text = "Dijite los datos del torneo";
            // 
            // tpRegistro
            // 
            this.tpRegistro.Controls.Add(this.pnlRegistro);
            this.tpRegistro.Location = new System.Drawing.Point(4, 25);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(798, 446);
            this.tpRegistro.TabIndex = 2;
            this.tpRegistro.Text = "Registro";
            this.tpRegistro.UseVisualStyleBackColor = true;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRegistro.BackgroundImage")));
            this.pnlRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegistro.Controls.Add(this.cbxCodTor);
            this.pnlRegistro.Controls.Add(this.cbxCodTen);
            this.pnlRegistro.Controls.Add(this.btnRegistrar);
            this.pnlRegistro.Controls.Add(this.dtpHora);
            this.pnlRegistro.Controls.Add(this.dtpFecha);
            this.pnlRegistro.Controls.Add(this.label5);
            this.pnlRegistro.Controls.Add(this.label4);
            this.pnlRegistro.Controls.Add(this.label3);
            this.pnlRegistro.Controls.Add(this.label2);
            this.pnlRegistro.Controls.Add(this.label1);
            this.pnlRegistro.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(795, 450);
            this.pnlRegistro.TabIndex = 1;
            // 
            // cbxCodTor
            // 
            this.cbxCodTor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCodTor.FormattingEnabled = true;
            this.cbxCodTor.Location = new System.Drawing.Point(188, 138);
            this.cbxCodTor.Name = "cbxCodTor";
            this.cbxCodTor.Size = new System.Drawing.Size(269, 32);
            this.cbxCodTor.TabIndex = 11;
            this.cbxCodTor.DropDown += new System.EventHandler(this.ActualizarCodTorneo);
            // 
            // cbxCodTen
            // 
            this.cbxCodTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCodTen.FormattingEnabled = true;
            this.cbxCodTen.Location = new System.Drawing.Point(188, 99);
            this.cbxCodTen.Name = "cbxCodTen";
            this.cbxCodTen.Size = new System.Drawing.Size(269, 32);
            this.cbxCodTen.TabIndex = 10;
            this.cbxCodTen.DropDown += new System.EventHandler(this.ActualizarCodTenista);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatAppearance.BorderSize = 2;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(560, 141);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(175, 66);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(188, 222);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(269, 29);
            this.dtpHora.TabIndex = 8;
            this.dtpHora.Value = new System.DateTime(2023, 1, 27, 14, 51, 20, 0);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(188, 181);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(269, 29);
            this.dtpFecha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Torneo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Tenista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione los datos a registrar";
            // 
            // tpConsulta1
            // 
            this.tpConsulta1.Controls.Add(this.pnlConsulta1);
            this.tpConsulta1.Location = new System.Drawing.Point(4, 25);
            this.tpConsulta1.Name = "tpConsulta1";
            this.tpConsulta1.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta1.Size = new System.Drawing.Size(798, 446);
            this.tpConsulta1.TabIndex = 3;
            this.tpConsulta1.Text = "Consulta1";
            this.tpConsulta1.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta1
            // 
            this.pnlConsulta1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConsulta1.BackgroundImage")));
            this.pnlConsulta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConsulta1.Controls.Add(this.cbxCodTorConsulta);
            this.pnlConsulta1.Controls.Add(this.dtpFechaCon);
            this.pnlConsulta1.Controls.Add(this.lbFechaCon);
            this.pnlConsulta1.Controls.Add(this.lbCodTorCon);
            this.pnlConsulta1.Controls.Add(this.btnConsultar1);
            this.pnlConsulta1.Controls.Add(this.dgvConsulta1);
            this.pnlConsulta1.Location = new System.Drawing.Point(0, 0);
            this.pnlConsulta1.Name = "pnlConsulta1";
            this.pnlConsulta1.Size = new System.Drawing.Size(795, 450);
            this.pnlConsulta1.TabIndex = 1;
            // 
            // cbxCodTorConsulta
            // 
            this.cbxCodTorConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCodTorConsulta.FormattingEnabled = true;
            this.cbxCodTorConsulta.Location = new System.Drawing.Point(214, 31);
            this.cbxCodTorConsulta.Name = "cbxCodTorConsulta";
            this.cbxCodTorConsulta.Size = new System.Drawing.Size(293, 28);
            this.cbxCodTorConsulta.TabIndex = 5;
            this.cbxCodTorConsulta.DropDown += new System.EventHandler(this.ActualizarCodTorneoConsulta);
            // 
            // dtpFechaCon
            // 
            this.dtpFechaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCon.Location = new System.Drawing.Point(214, 65);
            this.dtpFechaCon.Name = "dtpFechaCon";
            this.dtpFechaCon.Size = new System.Drawing.Size(293, 26);
            this.dtpFechaCon.TabIndex = 4;
            // 
            // lbFechaCon
            // 
            this.lbFechaCon.AutoSize = true;
            this.lbFechaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaCon.Location = new System.Drawing.Point(54, 70);
            this.lbFechaCon.Name = "lbFechaCon";
            this.lbFechaCon.Size = new System.Drawing.Size(155, 20);
            this.lbFechaCon.TabIndex = 3;
            this.lbFechaCon.Text = "Fecha de registro:";
            // 
            // lbCodTorCon
            // 
            this.lbCodTorCon.AutoSize = true;
            this.lbCodTorCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodTorCon.Location = new System.Drawing.Point(54, 34);
            this.lbCodTorCon.Name = "lbCodTorCon";
            this.lbCodTorCon.Size = new System.Drawing.Size(131, 20);
            this.lbCodTorCon.TabIndex = 2;
            this.lbCodTorCon.Text = "Codigo Torneo:";
            // 
            // btnConsultar1
            // 
            this.btnConsultar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar1.Location = new System.Drawing.Point(593, 31);
            this.btnConsultar1.Name = "btnConsultar1";
            this.btnConsultar1.Size = new System.Drawing.Size(144, 57);
            this.btnConsultar1.TabIndex = 1;
            this.btnConsultar1.Text = "Consultar";
            this.btnConsultar1.UseVisualStyleBackColor = true;
            this.btnConsultar1.Click += new System.EventHandler(this.btnConsultar1_Click);
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.AllowUserToResizeColumns = false;
            this.dgvConsulta1.AllowUserToResizeRows = false;
            this.dgvConsulta1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvConsulta1.Location = new System.Drawing.Point(46, 120);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.Size = new System.Drawing.Size(691, 289);
            this.dgvConsulta1.TabIndex = 0;
            // 
            // tpConsulta2
            // 
            this.tpConsulta2.Controls.Add(this.pnlConsulta2);
            this.tpConsulta2.Location = new System.Drawing.Point(4, 25);
            this.tpConsulta2.Name = "tpConsulta2";
            this.tpConsulta2.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta2.Size = new System.Drawing.Size(798, 446);
            this.tpConsulta2.TabIndex = 4;
            this.tpConsulta2.Text = "Consulta2";
            this.tpConsulta2.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta2
            // 
            this.pnlConsulta2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConsulta2.BackgroundImage")));
            this.pnlConsulta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConsulta2.Controls.Add(this.lbConsulta2);
            this.pnlConsulta2.Controls.Add(this.btnConsulta2);
            this.pnlConsulta2.Controls.Add(this.lbMensaje4);
            this.pnlConsulta2.Controls.Add(this.lbMensaje3);
            this.pnlConsulta2.Location = new System.Drawing.Point(0, 0);
            this.pnlConsulta2.Name = "pnlConsulta2";
            this.pnlConsulta2.Size = new System.Drawing.Size(795, 450);
            this.pnlConsulta2.TabIndex = 0;
            // 
            // lbConsulta2
            // 
            this.lbConsulta2.AutoSize = true;
            this.lbConsulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsulta2.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbConsulta2.Location = new System.Drawing.Point(229, 111);
            this.lbConsulta2.Name = "lbConsulta2";
            this.lbConsulta2.Size = new System.Drawing.Size(26, 33);
            this.lbConsulta2.TabIndex = 3;
            this.lbConsulta2.Text = "-";
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.BackColor = System.Drawing.Color.GreenYellow;
            this.btnConsulta2.FlatAppearance.BorderSize = 2;
            this.btnConsulta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta2.Location = new System.Drawing.Point(532, 136);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(156, 69);
            this.btnConsulta2.TabIndex = 2;
            this.btnConsulta2.Text = "Consultar";
            this.btnConsulta2.UseVisualStyleBackColor = false;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // lbMensaje4
            // 
            this.lbMensaje4.AutoSize = true;
            this.lbMensaje4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMensaje4.Location = new System.Drawing.Point(94, 115);
            this.lbMensaje4.Name = "lbMensaje4";
            this.lbMensaje4.Size = new System.Drawing.Size(113, 29);
            this.lbMensaje4.TabIndex = 1;
            this.lbMensaje4.Text = "Numero:";
            // 
            // lbMensaje3
            // 
            this.lbMensaje3.AutoSize = true;
            this.lbMensaje3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMensaje3.Location = new System.Drawing.Point(94, 47);
            this.lbMensaje3.Name = "lbMensaje3";
            this.lbMensaje3.Size = new System.Drawing.Size(464, 29);
            this.lbMensaje3.TabIndex = 0;
            this.lbMensaje3.Text = "Numero de tenista de categoria Senior";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(802, 474);
            this.Controls.Add(this.tbcGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tbcGestion.ResumeLayout(false);
            this.tpTenista.ResumeLayout(false);
            this.pnlTenista.ResumeLayout(false);
            this.pnlTenista.PerformLayout();
            this.tpTorneo.ResumeLayout(false);
            this.pnlTorneo.ResumeLayout(false);
            this.pnlTorneo.PerformLayout();
            this.tpRegistro.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.tpConsulta1.ResumeLayout(false);
            this.pnlConsulta1.ResumeLayout(false);
            this.pnlConsulta1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.tpConsulta2.ResumeLayout(false);
            this.pnlConsulta2.ResumeLayout(false);
            this.pnlConsulta2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.TabPage tpTenista;
        private System.Windows.Forms.Panel pnlTenista;
        private System.Windows.Forms.TabPage tpTorneo;
        private System.Windows.Forms.Panel pnlTorneo;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.TabPage tpConsulta1;
        private System.Windows.Forms.Panel pnlConsulta1;
        private System.Windows.Forms.TabPage tpConsulta2;
        private System.Windows.Forms.Panel pnlConsulta2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbMensaje1;
        private System.Windows.Forms.TextBox txtNombreTor;
        private System.Windows.Forms.TextBox txtCodigoTor;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Label lbNombreTor;
        private System.Windows.Forms.Label lbCodigo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar1;
        private System.Windows.Forms.DataGridView dgvConsulta1;
        private System.Windows.Forms.DateTimePicker dtpFechaCon;
        private System.Windows.Forms.Label lbFechaCon;
        private System.Windows.Forms.Label lbCodTorCon;
        private System.Windows.Forms.ComboBox cbxCodTor;
        private System.Windows.Forms.ComboBox cbxCodTen;
        private System.Windows.Forms.Label lbConsulta2;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Label lbMensaje4;
        private System.Windows.Forms.Label lbMensaje3;
        private System.Windows.Forms.ComboBox cbxCodTorConsulta;
    }
}


namespace libro
{
    partial class NuevoLibrocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orden = new System.Windows.Forms.TextBox();
            this.cb_principal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_nivel1 = new System.Windows.Forms.ComboBox();
            this.cb_nivel2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_is = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_idioma = new System.Windows.Forms.ComboBox();
            this.txt_edicion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_anno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ejemplar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orden:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_orden
            // 
            this.txt_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orden.Location = new System.Drawing.Point(102, 26);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(157, 26);
            this.txt_orden.TabIndex = 4;
            // 
            // cb_principal
            // 
            this.cb_principal.FormattingEnabled = true;
            this.cb_principal.Items.AddRange(new object[] {
            "Generalidades",
            "Ciencias Sociales",
            "Ciencias Naturales y Matematicas",
            "Tecnologia (Ciencias Aplicadas)",
            "Las artes.  Bellas artes y artes decorativas",
            "Literatura y retórica",
            "Geografía e historia",
            "Lenguas",
            "Ciencias naturales y matemáticas",
            "Filosofía y Psicología"});
            this.cb_principal.Location = new System.Drawing.Point(371, 28);
            this.cb_principal.Name = "cb_principal";
            this.cb_principal.Size = new System.Drawing.Size(188, 21);
            this.cb_principal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Principal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sub Nivel 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sub Nivel 2:";
            // 
            // cb_nivel1
            // 
            this.cb_nivel1.FormattingEnabled = true;
            this.cb_nivel1.Items.AddRange(new object[] {
            "Generalidades",
            "Bibliografía",
            "Bibliotecología y ciencias de la información",
            "Psicología",
            "Ética (Filosofía moral)",
            "Filosofía antigua , medieval, oriental",
            "Religión",
            "Cristianismo Teología Cristiana",
            "Moral cristiana y teología piadosa",
            "Teología social y eclesiástica",
            "Religión comparada y otras religiones",
            "Ciencias sociales",
            "Ciencia política",
            "Economía",
            "Administración pública y ciencia militar"});
            this.cb_nivel1.Location = new System.Drawing.Point(143, 74);
            this.cb_nivel1.Name = "cb_nivel1";
            this.cb_nivel1.Size = new System.Drawing.Size(188, 21);
            this.cb_nivel1.TabIndex = 9;
            // 
            // cb_nivel2
            // 
            this.cb_nivel2.FormattingEnabled = true;
            this.cb_nivel2.Items.AddRange(new object[] {
            "Conocimiento",
            "Sistemas",
            "Procesamiento de datos Ciencia de los computadores",
            "Programación, programas, datos de computador",
            "Métodos especiales de computador",
            "Bibliografías",
            "Bibliotecología y ciencias de la información",
            "Administración de personal",
            "Operaciones bibliotecarias",
            "Bibliotecas generales",
            "Lectura y uso de otros medios de información",
            "Medios noticiosos, periodísmo, publicación"});
            this.cb_nivel2.Location = new System.Drawing.Point(477, 74);
            this.cb_nivel2.Name = "cb_nivel2";
            this.cb_nivel2.Size = new System.Drawing.Size(188, 21);
            this.cb_nivel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Titulo:";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(97, 116);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(387, 26);
            this.txt_titulo.TabIndex = 12;
            // 
            // txt_autor
            // 
            this.txt_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(554, 113);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(268, 26);
            this.txt_autor.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Autor:";
            // 
            // txt_is
            // 
            this.txt_is.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_is.Location = new System.Drawing.Point(128, 166);
            this.txt_is.Name = "txt_is";
            this.txt_is.Size = new System.Drawing.Size(131, 26);
            this.txt_is.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "isbn/issn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Idioma:";
            // 
            // cb_idioma
            // 
            this.cb_idioma.FormattingEnabled = true;
            this.cb_idioma.Items.AddRange(new object[] {
            "esp",
            "eng"});
            this.cb_idioma.Location = new System.Drawing.Point(355, 172);
            this.cb_idioma.Name = "cb_idioma";
            this.cb_idioma.Size = new System.Drawing.Size(91, 21);
            this.cb_idioma.TabIndex = 18;
            // 
            // txt_edicion
            // 
            this.txt_edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edicion.Location = new System.Drawing.Point(532, 169);
            this.txt_edicion.Name = "txt_edicion";
            this.txt_edicion.Size = new System.Drawing.Size(62, 26);
            this.txt_edicion.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Edicion:";
            // 
            // txt_editorial
            // 
            this.txt_editorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editorial.Location = new System.Drawing.Point(128, 213);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(294, 26);
            this.txt_editorial.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Editorial:";
            // 
            // txt_anno
            // 
            this.txt_anno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_anno.Location = new System.Drawing.Point(97, 263);
            this.txt_anno.Name = "txt_anno";
            this.txt_anno.Size = new System.Drawing.Size(86, 26);
            this.txt_anno.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Año:";
            // 
            // txt_ejemplar
            // 
            this.txt_ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ejemplar.Location = new System.Drawing.Point(287, 269);
            this.txt_ejemplar.Name = "txt_ejemplar";
            this.txt_ejemplar.Size = new System.Drawing.Size(44, 26);
            this.txt_ejemplar.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ejemplar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(352, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Tipo:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Físico"});
            this.cb_tipo.Location = new System.Drawing.Point(406, 271);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(188, 21);
            this.cb_tipo.TabIndex = 27;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(181, 345);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(168, 53);
            this.btn_agregar.TabIndex = 29;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(406, 345);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(168, 53);
            this.btn_cancelar.TabIndex = 30;
            this.btn_cancelar.Text = "Calcelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // NuevoLibrocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 466);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.txt_ejemplar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_anno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_editorial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_edicion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_idioma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_is);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_nivel2);
            this.Controls.Add(this.cb_nivel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_principal);
            this.Controls.Add(this.txt_orden);
            this.Controls.Add(this.label1);
            this.Name = "NuevoLibrocs";
            this.Text = "NuevoLibrocs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orden;
        private System.Windows.Forms.ComboBox cb_principal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_nivel1;
        private System.Windows.Forms.ComboBox cb_nivel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_is;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_idioma;
        private System.Windows.Forms.TextBox txt_edicion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_anno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ejemplar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
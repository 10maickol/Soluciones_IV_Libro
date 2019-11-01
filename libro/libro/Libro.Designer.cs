namespace libro
{
    partial class Libro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_openCorreo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_filtro = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_archivoname = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grv_data = new System.Windows.Forms.DataGridView();
            this.btn_text = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_text);
            this.groupBox3.Controls.Add(this.btn_openCorreo);
            this.groupBox3.Controls.Add(this.btn_eliminar);
            this.groupBox3.Controls.Add(this.btn_filter);
            this.groupBox3.Controls.Add(this.txt_filter);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbo_filtro);
            this.groupBox3.Location = new System.Drawing.Point(271, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 112);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // btn_openCorreo
            // 
            this.btn_openCorreo.Location = new System.Drawing.Point(128, 83);
            this.btn_openCorreo.Name = "btn_openCorreo";
            this.btn_openCorreo.Size = new System.Drawing.Size(75, 23);
            this.btn_openCorreo.TabIndex = 5;
            this.btn_openCorreo.Text = "Correos";
            this.btn_openCorreo.UseVisualStyleBackColor = true;
            this.btn_openCorreo.Click += new System.EventHandler(this.Btn_openCorreo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(26, 83);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Elimnar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(324, 41);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 3;
            this.btn_filter.Text = "Filtrar";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.Btn_filter_Click);
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(171, 43);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(136, 20);
            this.txt_filter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Columna de filtro";
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.FormattingEnabled = true;
            this.cbo_filtro.Location = new System.Drawing.Point(26, 43);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(121, 21);
            this.cbo_filtro.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_archivoname);
            this.panel1.Controls.Add(this.btn_openfile);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 112);
            this.panel1.TabIndex = 0;
            // 
            // txt_archivoname
            // 
            this.txt_archivoname.AutoSize = true;
            this.txt_archivoname.Location = new System.Drawing.Point(24, 64);
            this.txt_archivoname.Name = "txt_archivoname";
            this.txt_archivoname.Size = new System.Drawing.Size(145, 13);
            this.txt_archivoname.TabIndex = 1;
            this.txt_archivoname.Text = "Ningun archivo seleccionado";
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(27, 12);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(132, 23);
            this.btn_openfile.TabIndex = 0;
            this.btn_openfile.Text = "Abrir Excel";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.Btn_openfile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grv_data);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lisbros";
            // 
            // grv_data
            // 
            this.grv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_data.Location = new System.Drawing.Point(3, 16);
            this.grv_data.Name = "grv_data";
            this.grv_data.Size = new System.Drawing.Size(855, 306);
            this.grv_data.TabIndex = 0;
            // 
            // btn_text
            // 
            this.btn_text.Location = new System.Drawing.Point(254, 83);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(100, 23);
            this.btn_text.TabIndex = 6;
            this.btn_text.Text = "Generar Texto";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.Btn_text_Click);
            // 
            // Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Libro";
            this.Text = "Libro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_archivoname;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_filtro;
        private System.Windows.Forms.DataGridView grv_data;
        private System.Windows.Forms.Button btn_openCorreo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_text;
    }
}
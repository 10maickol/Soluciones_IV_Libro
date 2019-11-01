namespace libro
{
    partial class EnviarCorreo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemisor = new System.Windows.Forms.TextBox();
            this.txtreceptor = new System.Windows.Forms.TextBox();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtarchivoruta = new System.Windows.Forms.TextBox();
            this.btnarchivo = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asunto:";
            // 
            // txtemisor
            // 
            this.txtemisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemisor.Location = new System.Drawing.Point(129, 33);
            this.txtemisor.Name = "txtemisor";
            this.txtemisor.Size = new System.Drawing.Size(300, 26);
            this.txtemisor.TabIndex = 3;
            // 
            // txtreceptor
            // 
            this.txtreceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreceptor.Location = new System.Drawing.Point(129, 111);
            this.txtreceptor.Name = "txtreceptor";
            this.txtreceptor.Size = new System.Drawing.Size(300, 26);
            this.txtreceptor.TabIndex = 4;
            // 
            // txtasunto
            // 
            this.txtasunto.Location = new System.Drawing.Point(129, 197);
            this.txtasunto.Multiline = true;
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(300, 99);
            this.txtasunto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(129, 74);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(226, 26);
            this.txtcontraseña.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Archivo:";
            // 
            // txtarchivoruta
            // 
            this.txtarchivoruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarchivoruta.Location = new System.Drawing.Point(104, 331);
            this.txtarchivoruta.Name = "txtarchivoruta";
            this.txtarchivoruta.Size = new System.Drawing.Size(295, 26);
            this.txtarchivoruta.TabIndex = 9;
            // 
            // btnarchivo
            // 
            this.btnarchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarchivo.Location = new System.Drawing.Point(406, 331);
            this.btnarchivo.Name = "btnarchivo";
            this.btnarchivo.Size = new System.Drawing.Size(36, 26);
            this.btnarchivo.TabIndex = 10;
            this.btnarchivo.Text = "...";
            this.btnarchivo.UseVisualStyleBackColor = true;
            this.btnarchivo.Click += new System.EventHandler(this.Btnarchivo_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Location = new System.Drawing.Point(86, 385);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(292, 52);
            this.btnenviar.TabIndex = 11;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.Btnenviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mensaje:";
            // 
            // txtmensaje
            // 
            this.txtmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmensaje.Location = new System.Drawing.Point(129, 154);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(300, 26);
            this.txtmensaje.TabIndex = 13;
            // 
            // EnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 449);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnarchivo);
            this.Controls.Add(this.txtarchivoruta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtreceptor);
            this.Controls.Add(this.txtemisor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnviarCorreo";
            this.Text = "EnviarCorreo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemisor;
        private System.Windows.Forms.TextBox txtreceptor;
        private System.Windows.Forms.TextBox txtasunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtarchivoruta;
        private System.Windows.Forms.Button btnarchivo;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmensaje;
    }
}
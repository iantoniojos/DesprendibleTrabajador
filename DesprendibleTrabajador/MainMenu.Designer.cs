
namespace DesprendibleTrabajador
{
    partial class MainMenu
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiasTrabajados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalarioDia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " Programa cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(401, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = " Identificacion";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(401, 177);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(273, 22);
            this.txtID.TabIndex = 4;
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Electricista",
            "Programador",
            "Abogado",
            "Arquitecta",
            "Aseador"});
            this.cmbCargo.Location = new System.Drawing.Point(400, 238);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(274, 24);
            this.cmbCargo.TabIndex = 5;
            this.cmbCargo.Text = "Cargo";
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = " Numero de dias trabajado";
            // 
            // txtDiasTrabajados
            // 
            this.txtDiasTrabajados.Location = new System.Drawing.Point(400, 296);
            this.txtDiasTrabajados.Name = "txtDiasTrabajados";
            this.txtDiasTrabajados.Size = new System.Drawing.Size(274, 22);
            this.txtDiasTrabajados.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genero";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(402, 359);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(96, 21);
            this.rbMasculino.TabIndex = 9;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = " Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(402, 393);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(95, 21);
            this.rbFemenino.TabIndex = 10;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = " Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(400, 432);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(98, 21);
            this.rbNoBinario.TabIndex = 11;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = " No binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = " Salario dia";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSalarioDia
            // 
            this.txtSalarioDia.Location = new System.Drawing.Point(786, 112);
            this.txtSalarioDia.Name = "txtSalarioDia";
            this.txtSalarioDia.Size = new System.Drawing.Size(221, 22);
            this.txtSalarioDia.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = " Guardar Registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 55);
            this.button2.TabIndex = 15;
            this.button2.Text = " Calcular nomina y mostrar reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 38);
            this.button3.TabIndex = 16;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 641);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalarioDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbNoBinario);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiasTrabajados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiasTrabajados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalarioDia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
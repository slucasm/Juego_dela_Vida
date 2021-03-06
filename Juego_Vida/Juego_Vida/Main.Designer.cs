﻿namespace Juego_Vida
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.button_abrir = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.dataGrid_infectados = new System.Windows.Forms.DataGridView();
            this.textBox_columnas = new System.Windows.Forms.TextBox();
            this.textBox_filas = new System.Windows.Forms.TextBox();
            this.label_columnas = new System.Windows.Forms.Label();
            this.label_filas = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_ciclo = new System.Windows.Forms.Button();
            this.button_crearenfermedad = new System.Windows.Forms.Button();
            this.button_creargrid = new System.Windows.Forms.Button();
            this.comboBox_enfermedades = new System.Windows.Forms.ComboBox();
            this.timer_simulacion = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_yainfectada = new System.Windows.Forms.Label();
            this.label_noinfectada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_infectados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_abrir
            // 
            this.button_abrir.Location = new System.Drawing.Point(632, 318);
            this.button_abrir.Name = "button_abrir";
            this.button_abrir.Size = new System.Drawing.Size(75, 23);
            this.button_abrir.TabIndex = 40;
            this.button_abrir.Text = "Abrir archivo";
            this.button_abrir.UseVisualStyleBackColor = true;
            this.button_abrir.Click += new System.EventHandler(this.button_abrir_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(632, 273);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 39;
            this.button_guardar.Text = "Guardar situación";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // dataGrid_infectados
            // 
            this.dataGrid_infectados.AllowUserToAddRows = false;
            this.dataGrid_infectados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_infectados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGrid_infectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_infectados.ColumnHeadersVisible = false;
            this.dataGrid_infectados.Location = new System.Drawing.Point(53, 129);
            this.dataGrid_infectados.Name = "dataGrid_infectados";
            this.dataGrid_infectados.RowHeadersVisible = false;
            this.dataGrid_infectados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid_infectados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid_infectados.Size = new System.Drawing.Size(467, 261);
            this.dataGrid_infectados.TabIndex = 38;
            this.dataGrid_infectados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_infectados_CellClick);
            // 
            // textBox_columnas
            // 
            this.textBox_columnas.Location = new System.Drawing.Point(111, 64);
            this.textBox_columnas.Name = "textBox_columnas";
            this.textBox_columnas.Size = new System.Drawing.Size(100, 20);
            this.textBox_columnas.TabIndex = 37;
            // 
            // textBox_filas
            // 
            this.textBox_filas.Location = new System.Drawing.Point(111, 27);
            this.textBox_filas.Name = "textBox_filas";
            this.textBox_filas.Size = new System.Drawing.Size(100, 20);
            this.textBox_filas.TabIndex = 36;
            // 
            // label_columnas
            // 
            this.label_columnas.AutoSize = true;
            this.label_columnas.Location = new System.Drawing.Point(50, 64);
            this.label_columnas.Name = "label_columnas";
            this.label_columnas.Size = new System.Drawing.Size(53, 13);
            this.label_columnas.TabIndex = 35;
            this.label_columnas.Text = "Columnas";
            // 
            // label_filas
            // 
            this.label_filas.AutoSize = true;
            this.label_filas.Location = new System.Drawing.Point(47, 27);
            this.label_filas.Name = "label_filas";
            this.label_filas.Size = new System.Drawing.Size(28, 13);
            this.label_filas.TabIndex = 34;
            this.label_filas.Text = "Filas";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(620, 235);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(102, 23);
            this.button_stop.TabIndex = 33;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(620, 190);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(102, 23);
            this.button_play.TabIndex = 32;
            this.button_play.Text = "Play simulación";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_ciclo
            // 
            this.button_ciclo.Location = new System.Drawing.Point(620, 149);
            this.button_ciclo.Name = "button_ciclo";
            this.button_ciclo.Size = new System.Drawing.Size(102, 23);
            this.button_ciclo.TabIndex = 31;
            this.button_ciclo.Text = "Avanzar un ciclo";
            this.button_ciclo.UseVisualStyleBackColor = true;
            this.button_ciclo.Click += new System.EventHandler(this.button_ciclo_Click);
            // 
            // button_crearenfermedad
            // 
            this.button_crearenfermedad.Location = new System.Drawing.Point(6, 61);
            this.button_crearenfermedad.Name = "button_crearenfermedad";
            this.button_crearenfermedad.Size = new System.Drawing.Size(136, 23);
            this.button_crearenfermedad.TabIndex = 30;
            this.button_crearenfermedad.Text = "Crear nueva enfermedad";
            this.button_crearenfermedad.UseVisualStyleBackColor = true;
            this.button_crearenfermedad.Click += new System.EventHandler(this.button_crearenfermedad_Click);
            // 
            // button_creargrid
            // 
            this.button_creargrid.Location = new System.Drawing.Point(217, 43);
            this.button_creargrid.Name = "button_creargrid";
            this.button_creargrid.Size = new System.Drawing.Size(75, 23);
            this.button_creargrid.TabIndex = 29;
            this.button_creargrid.Text = "Crear grid";
            this.button_creargrid.UseVisualStyleBackColor = true;
            this.button_creargrid.Click += new System.EventHandler(this.button_creargrid_Click);
            // 
            // comboBox_enfermedades
            // 
            this.comboBox_enfermedades.FormattingEnabled = true;
            this.comboBox_enfermedades.Location = new System.Drawing.Point(6, 30);
            this.comboBox_enfermedades.Name = "comboBox_enfermedades";
            this.comboBox_enfermedades.Size = new System.Drawing.Size(121, 21);
            this.comboBox_enfermedades.TabIndex = 28;
            this.comboBox_enfermedades.DropDown += new System.EventHandler(this.comboBox_enfermedades_DropDown);
            this.comboBox_enfermedades.SelectedIndexChanged += new System.EventHandler(this.comboBox_enfermedades_SelectedIndexChanged);
            // 
            // timer_simulacion
            // 
            this.timer_simulacion.Tick += new System.EventHandler(this.timer_simulacion_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_noinfectada);
            this.groupBox1.Controls.Add(this.label_yainfectada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_crearenfermedad);
            this.groupBox1.Controls.Add(this.comboBox_enfermedades);
            this.groupBox1.Location = new System.Drawing.Point(338, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 110);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enfermedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Si la celda no está infectada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Si la celda ya está infectada:";
            // 
            // label_yainfectada
            // 
            this.label_yainfectada.AutoSize = true;
            this.label_yainfectada.Location = new System.Drawing.Point(158, 38);
            this.label_yainfectada.Name = "label_yainfectada";
            this.label_yainfectada.Size = new System.Drawing.Size(0, 13);
            this.label_yainfectada.TabIndex = 33;
            // 
            // label_noinfectada
            // 
            this.label_noinfectada.AutoSize = true;
            this.label_noinfectada.Location = new System.Drawing.Point(158, 81);
            this.label_noinfectada.Name = "label_noinfectada";
            this.label_noinfectada.Size = new System.Drawing.Size(0, 13);
            this.label_noinfectada.TabIndex = 34;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 410);
            this.Controls.Add(this.button_abrir);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.dataGrid_infectados);
            this.Controls.Add(this.textBox_columnas);
            this.Controls.Add(this.textBox_filas);
            this.Controls.Add(this.label_columnas);
            this.Controls.Add(this.label_filas);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_ciclo);
            this.Controls.Add(this.button_creargrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Juego de la vida";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_infectados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_abrir;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.DataGridView dataGrid_infectados;
        private System.Windows.Forms.TextBox textBox_columnas;
        private System.Windows.Forms.TextBox textBox_filas;
        private System.Windows.Forms.Label label_columnas;
        private System.Windows.Forms.Label label_filas;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_ciclo;
        private System.Windows.Forms.Button button_crearenfermedad;
        private System.Windows.Forms.Button button_creargrid;
        private System.Windows.Forms.ComboBox comboBox_enfermedades;
        private System.Windows.Forms.Timer timer_simulacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_noinfectada;
        private System.Windows.Forms.Label label_yainfectada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


namespace Juego_dela_Vida
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_creargrid = new System.Windows.Forms.Button();
            this.button_crearenfermedad = new System.Windows.Forms.Button();
            this.button_ciclo = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label_filas = new System.Windows.Forms.Label();
            this.label_columnas = new System.Windows.Forms.Label();
            this.textBox_filas = new System.Windows.Forms.TextBox();
            this.textBox_columnas = new System.Windows.Forms.TextBox();
            this.dataGrid_infectados = new System.Windows.Forms.DataGridView();
            this.timer_simulacion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_infectados)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(374, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button_creargrid
            // 
            this.button_creargrid.Location = new System.Drawing.Point(202, 52);
            this.button_creargrid.Name = "button_creargrid";
            this.button_creargrid.Size = new System.Drawing.Size(75, 23);
            this.button_creargrid.TabIndex = 1;
            this.button_creargrid.Text = "Crear grid";
            this.button_creargrid.UseVisualStyleBackColor = true;
            this.button_creargrid.Click += new System.EventHandler(this.button_creargrid_Click);
            // 
            // button_crearenfermedad
            // 
            this.button_crearenfermedad.Location = new System.Drawing.Point(359, 68);
            this.button_crearenfermedad.Name = "button_crearenfermedad";
            this.button_crearenfermedad.Size = new System.Drawing.Size(136, 23);
            this.button_crearenfermedad.TabIndex = 2;
            this.button_crearenfermedad.Text = "Crear nueva enfermedad";
            this.button_crearenfermedad.UseVisualStyleBackColor = true;
            this.button_crearenfermedad.Click += new System.EventHandler(this.button_crearenfermedad_Click);
            // 
            // button_ciclo
            // 
            this.button_ciclo.Location = new System.Drawing.Point(408, 168);
            this.button_ciclo.Name = "button_ciclo";
            this.button_ciclo.Size = new System.Drawing.Size(102, 23);
            this.button_ciclo.TabIndex = 3;
            this.button_ciclo.Text = "Avanzar un ciclo";
            this.button_ciclo.UseVisualStyleBackColor = true;
            this.button_ciclo.Click += new System.EventHandler(this.button_ciclo_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(408, 209);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(102, 23);
            this.button_play.TabIndex = 4;
            this.button_play.Text = "Play simulación";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(408, 254);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(102, 23);
            this.button_stop.TabIndex = 5;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label_filas
            // 
            this.label_filas.AutoSize = true;
            this.label_filas.Location = new System.Drawing.Point(32, 36);
            this.label_filas.Name = "label_filas";
            this.label_filas.Size = new System.Drawing.Size(28, 13);
            this.label_filas.TabIndex = 6;
            this.label_filas.Text = "Filas";
            // 
            // label_columnas
            // 
            this.label_columnas.AutoSize = true;
            this.label_columnas.Location = new System.Drawing.Point(35, 73);
            this.label_columnas.Name = "label_columnas";
            this.label_columnas.Size = new System.Drawing.Size(53, 13);
            this.label_columnas.TabIndex = 7;
            this.label_columnas.Text = "Columnas";
            // 
            // textBox_filas
            // 
            this.textBox_filas.Location = new System.Drawing.Point(96, 36);
            this.textBox_filas.Name = "textBox_filas";
            this.textBox_filas.Size = new System.Drawing.Size(100, 20);
            this.textBox_filas.TabIndex = 8;
            // 
            // textBox_columnas
            // 
            this.textBox_columnas.Location = new System.Drawing.Point(96, 73);
            this.textBox_columnas.Name = "textBox_columnas";
            this.textBox_columnas.Size = new System.Drawing.Size(100, 20);
            this.textBox_columnas.TabIndex = 9;
            // 
            // dataGrid_infectados
            // 
            this.dataGrid_infectados.AllowUserToAddRows = false;
            this.dataGrid_infectados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_infectados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGrid_infectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_infectados.ColumnHeadersVisible = false;
            this.dataGrid_infectados.Location = new System.Drawing.Point(38, 138);
            this.dataGrid_infectados.Name = "dataGrid_infectados";
            this.dataGrid_infectados.RowHeadersVisible = false;
            this.dataGrid_infectados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid_infectados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid_infectados.Size = new System.Drawing.Size(353, 222);
            this.dataGrid_infectados.TabIndex = 10;
            this.dataGrid_infectados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_infectados_CellClick);
            // 
            // timer_simulacion
            // 
            this.timer_simulacion.Tick += new System.EventHandler(this.timer_simulacion_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 389);
            this.Controls.Add(this.dataGrid_infectados);
            this.Controls.Add(this.textBox_columnas);
            this.Controls.Add(this.textBox_filas);
            this.Controls.Add(this.label_columnas);
            this.Controls.Add(this.label_filas);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_ciclo);
            this.Controls.Add(this.button_crearenfermedad);
            this.Controls.Add(this.button_creargrid);
            this.Controls.Add(this.comboBox1);
            this.Name = "Main";
            this.Text = "Juego de la Vida";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_infectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_creargrid;
        private System.Windows.Forms.Button button_crearenfermedad;
        private System.Windows.Forms.Button button_ciclo;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label_filas;
        private System.Windows.Forms.Label label_columnas;
        private System.Windows.Forms.TextBox textBox_filas;
        private System.Windows.Forms.TextBox textBox_columnas;
        private System.Windows.Forms.DataGridView dataGrid_infectados;
        private System.Windows.Forms.Timer timer_simulacion;
    }
}


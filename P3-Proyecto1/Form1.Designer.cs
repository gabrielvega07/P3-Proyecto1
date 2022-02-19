namespace ProyectoN1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.txtcombo2 = new System.Windows.Forms.TextBox();
            this.txtcombo1 = new System.Windows.Forms.TextBox();
            this.BtnCargarEquipos = new System.Windows.Forms.Button();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // combo1
            // 
            this.combo1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.combo1.Enabled = false;
            this.combo1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(255, 123);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(204, 29);
            this.combo1.TabIndex = 2;
            // 
            // combo2
            // 
            this.combo2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.combo2.Enabled = false;
            this.combo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(841, 123);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(202, 29);
            this.combo2.TabIndex = 3;
            // 
            // txtcombo2
            // 
            this.txtcombo2.Enabled = false;
            this.txtcombo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcombo2.Location = new System.Drawing.Point(724, 114);
            this.txtcombo2.Multiline = true;
            this.txtcombo2.Name = "txtcombo2";
            this.txtcombo2.Size = new System.Drawing.Size(96, 43);
            this.txtcombo2.TabIndex = 4;
            this.txtcombo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcombo1
            // 
            this.txtcombo1.Enabled = false;
            this.txtcombo1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcombo1.Location = new System.Drawing.Point(481, 114);
            this.txtcombo1.Multiline = true;
            this.txtcombo1.Name = "txtcombo1";
            this.txtcombo1.Size = new System.Drawing.Size(96, 43);
            this.txtcombo1.TabIndex = 5;
            this.txtcombo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCargarEquipos
            // 
            this.BtnCargarEquipos.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCargarEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCargarEquipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCargarEquipos.Location = new System.Drawing.Point(12, 12);
            this.BtnCargarEquipos.Name = "BtnCargarEquipos";
            this.BtnCargarEquipos.Size = new System.Drawing.Size(187, 57);
            this.BtnCargarEquipos.TabIndex = 6;
            this.BtnCargarEquipos.Text = "Cargar Equipos";
            this.BtnCargarEquipos.UseVisualStyleBackColor = false;
            this.BtnCargarEquipos.Click += new System.EventHandler(this.BtnCargarEquipos_Click);
            // 
            // BtnResultado
            // 
            this.BtnResultado.BackColor = System.Drawing.Color.Crimson;
            this.BtnResultado.Enabled = false;
            this.BtnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResultado.Location = new System.Drawing.Point(562, 34);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(172, 35);
            this.BtnResultado.TabIndex = 27;
            this.BtnResultado.Text = "Resultado";
            this.BtnResultado.UseVisualStyleBackColor = false;
            this.BtnResultado.Click += new System.EventHandler(this.BtnResultado_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(606, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 43);
            this.label11.TabIndex = 28;
            this.label11.Text = "VS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tabla
            // 
            this.Tabla.BackgroundColor = System.Drawing.Color.Linen;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.Tabla.Location = new System.Drawing.Point(12, 199);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 29;
            this.Tabla.Size = new System.Drawing.Size(1275, 262);
            this.Tabla.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Posicion";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Club";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "J";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PTS";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "G";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "E";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "P";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "GF";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "GC";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "DG";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Navy;
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(1133, 158);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(149, 37);
            this.BtnActualizar.TabIndex = 30;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 473);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnResultado);
            this.Controls.Add(this.BtnCargarEquipos);
            this.Controls.Add(this.txtcombo1);
            this.Controls.Add(this.txtcombo2);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.combo1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox combo1;
        private ComboBox combo2;
        private TextBox txtcombo2;
        private TextBox txtcombo1;
        private Button BtnCargarEquipos;
        private Button BtnResultado;
        private Label label11;
        private DataGridView Tabla;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button BtnActualizar;
    }
}
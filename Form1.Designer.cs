namespace Sesion16
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
            this.Bt_Crear = new System.Windows.Forms.Button();
            this.Lb_Id = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.Lb_Promedio = new System.Windows.Forms.Label();
            this.Tx_Id = new System.Windows.Forms.TextBox();
            this.Tx_Nombre = new System.Windows.Forms.TextBox();
            this.Tx_Apellido = new System.Windows.Forms.TextBox();
            this.Tx_Promedio = new System.Windows.Forms.TextBox();
            this.Lvw_Estudiante = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Bt_Crear
            // 
            this.Bt_Crear.Location = new System.Drawing.Point(128, 229);
            this.Bt_Crear.Name = "Bt_Crear";
            this.Bt_Crear.Size = new System.Drawing.Size(114, 54);
            this.Bt_Crear.TabIndex = 0;
            this.Bt_Crear.Text = "Crear Estudiante";
            this.Bt_Crear.UseVisualStyleBackColor = true;
            this.Bt_Crear.Click += new System.EventHandler(this.Bt_Crear_Click);
            // 
            // Lb_Id
            // 
            this.Lb_Id.AutoSize = true;
            this.Lb_Id.Location = new System.Drawing.Point(68, 65);
            this.Lb_Id.Name = "Lb_Id";
            this.Lb_Id.Size = new System.Drawing.Size(18, 16);
            this.Lb_Id.TabIndex = 1;
            this.Lb_Id.Text = "Id";
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Location = new System.Drawing.Point(68, 101);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(56, 16);
            this.Lb_Nombre.TabIndex = 2;
            this.Lb_Nombre.Text = "Nombre";
            // 
            // Lb_Apellido
            // 
            this.Lb_Apellido.AutoSize = true;
            this.Lb_Apellido.Location = new System.Drawing.Point(68, 147);
            this.Lb_Apellido.Name = "Lb_Apellido";
            this.Lb_Apellido.Size = new System.Drawing.Size(57, 16);
            this.Lb_Apellido.TabIndex = 3;
            this.Lb_Apellido.Text = "Apellido";
            // 
            // Lb_Promedio
            // 
            this.Lb_Promedio.AutoSize = true;
            this.Lb_Promedio.Location = new System.Drawing.Point(56, 188);
            this.Lb_Promedio.Name = "Lb_Promedio";
            this.Lb_Promedio.Size = new System.Drawing.Size(66, 16);
            this.Lb_Promedio.TabIndex = 4;
            this.Lb_Promedio.Text = "Promedio";
            // 
            // Tx_Id
            // 
            this.Tx_Id.Location = new System.Drawing.Point(128, 62);
            this.Tx_Id.Name = "Tx_Id";
            this.Tx_Id.Size = new System.Drawing.Size(153, 22);
            this.Tx_Id.TabIndex = 6;
            // 
            // Tx_Nombre
            // 
            this.Tx_Nombre.Location = new System.Drawing.Point(128, 101);
            this.Tx_Nombre.Name = "Tx_Nombre";
            this.Tx_Nombre.Size = new System.Drawing.Size(153, 22);
            this.Tx_Nombre.TabIndex = 7;
            // 
            // Tx_Apellido
            // 
            this.Tx_Apellido.Location = new System.Drawing.Point(128, 147);
            this.Tx_Apellido.Name = "Tx_Apellido";
            this.Tx_Apellido.Size = new System.Drawing.Size(153, 22);
            this.Tx_Apellido.TabIndex = 8;
            // 
            // Tx_Promedio
            // 
            this.Tx_Promedio.Location = new System.Drawing.Point(128, 185);
            this.Tx_Promedio.Name = "Tx_Promedio";
            this.Tx_Promedio.Size = new System.Drawing.Size(153, 22);
            this.Tx_Promedio.TabIndex = 10;
            // 
            // Lvw_Estudiante
            // 
            this.Lvw_Estudiante.FullRowSelect = true;
            this.Lvw_Estudiante.GridLines = true;
            this.Lvw_Estudiante.HideSelection = false;
            this.Lvw_Estudiante.Location = new System.Drawing.Point(329, 50);
            this.Lvw_Estudiante.Name = "Lvw_Estudiante";
            this.Lvw_Estudiante.Size = new System.Drawing.Size(687, 355);
            this.Lvw_Estudiante.TabIndex = 11;
            this.Lvw_Estudiante.UseCompatibleStateImageBehavior = false;
            this.Lvw_Estudiante.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.Lvw_Estudiante);
            this.Controls.Add(this.Tx_Promedio);
            this.Controls.Add(this.Tx_Apellido);
            this.Controls.Add(this.Tx_Nombre);
            this.Controls.Add(this.Tx_Id);
            this.Controls.Add(this.Lb_Promedio);
            this.Controls.Add(this.Lb_Apellido);
            this.Controls.Add(this.Lb_Nombre);
            this.Controls.Add(this.Lb_Id);
            this.Controls.Add(this.Bt_Crear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Crear;
        private System.Windows.Forms.Label Lb_Id;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Promedio;
        private System.Windows.Forms.TextBox Tx_Id;
        private System.Windows.Forms.TextBox Tx_Nombre;
        private System.Windows.Forms.TextBox Tx_Apellido;
        private System.Windows.Forms.TextBox Tx_Promedio;
        private System.Windows.Forms.ListView Lvw_Estudiante;
    }
}


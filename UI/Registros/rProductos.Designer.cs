namespace PrimerProyecto.UI.Registros
{
    partial class rProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.VInventarioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductoID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Inventario";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(92, 21);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.IdNumericUpDown.TabIndex = 5;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(92, 56);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(124, 20);
            this.DescripcionTextBox.TabIndex = 6;
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Location = new System.Drawing.Point(27, 104);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(58, 20);
            this.ExistenciaTextBox.TabIndex = 7;
            this.ExistenciaTextBox.TextChanged += new System.EventHandler(this.ExistenciaTextBox_TextChanged);
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.Location = new System.Drawing.Point(133, 103);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.Size = new System.Drawing.Size(58, 20);
            this.CostoTextBox.TabIndex = 8;
            this.CostoTextBox.TextChanged += new System.EventHandler(this.CostoTextBox_TextChanged);
            // 
            // VInventarioTextBox
            // 
            this.VInventarioTextBox.Location = new System.Drawing.Point(225, 104);
            this.VInventarioTextBox.Name = "VInventarioTextBox";
            this.VInventarioTextBox.ReadOnly = true;
            this.VInventarioTextBox.Size = new System.Drawing.Size(78, 20);
            this.VInventarioTextBox.TabIndex = 9;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(150, 18);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(66, 23);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(27, 145);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(66, 23);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(125, 145);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(66, 23);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(225, 145);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(66, 23);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 187);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.VInventarioTextBox);
            this.Controls.Add(this.CostoTextBox);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rProductos";
            this.Text = "rProductos";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.TextBox VInventarioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}
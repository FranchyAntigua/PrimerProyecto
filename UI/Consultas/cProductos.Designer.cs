namespace PrimerProyecto.UI.Consultas
{
    partial class cProductos
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
            this.InventarioTextBox = new System.Windows.Forms.TextBox();
            this.RefrescarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor Total del Inventario";
            // 
            // InventarioTextBox
            // 
            this.InventarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventarioTextBox.Location = new System.Drawing.Point(12, 57);
            this.InventarioTextBox.Multiline = true;
            this.InventarioTextBox.Name = "InventarioTextBox";
            this.InventarioTextBox.ReadOnly = true;
            this.InventarioTextBox.Size = new System.Drawing.Size(184, 63);
            this.InventarioTextBox.TabIndex = 7;
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.Image = global::PrimerProyecto.Properties.Resources.icons8_sincronizar_48;
            this.RefrescarButton.Location = new System.Drawing.Point(202, 58);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(52, 47);
            this.RefrescarButton.TabIndex = 8;
            this.RefrescarButton.UseVisualStyleBackColor = true;
            this.RefrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // cProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 140);
            this.Controls.Add(this.RefrescarButton);
            this.Controls.Add(this.InventarioTextBox);
            this.Controls.Add(this.label1);
            this.Name = "cProductos";
            this.Text = "Ver Valor Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InventarioTextBox;
        private System.Windows.Forms.Button RefrescarButton;
    }
}
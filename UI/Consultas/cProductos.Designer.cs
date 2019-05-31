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
            this.ProductoDdataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoDdataGridView
            // 
            this.ProductoDdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoDdataGridView.Location = new System.Drawing.Point(23, 39);
            this.ProductoDdataGridView.Name = "ProductoDdataGridView";
            this.ProductoDdataGridView.Size = new System.Drawing.Size(409, 339);
            this.ProductoDdataGridView.TabIndex = 2;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(23, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 5;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // cProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 390);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ProductoDdataGridView);
            this.Name = "cProductos";
            this.Text = "cProductos";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductoDdataGridView;
        private System.Windows.Forms.Button BuscarButton;
    }
}
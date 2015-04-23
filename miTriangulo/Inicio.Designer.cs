namespace misFiguras
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblInicio = new System.Windows.Forms.Label();
            this.rbTriángulo = new System.Windows.Forms.RadioButton();
            this.rbRectángulo = new System.Windows.Forms.RadioButton();
            this.btnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblInicio.Location = new System.Drawing.Point(30, 20);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(92, 22);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Calcular:";
            // 
            // rbTriángulo
            // 
            this.rbTriángulo.AutoSize = true;
            this.rbTriángulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTriángulo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbTriángulo.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.rbTriángulo.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbTriángulo.Location = new System.Drawing.Point(34, 59);
            this.rbTriángulo.Name = "rbTriángulo";
            this.rbTriángulo.Size = new System.Drawing.Size(101, 25);
            this.rbTriángulo.TabIndex = 1;
            this.rbTriángulo.TabStop = true;
            this.rbTriángulo.Text = "Triángulo";
            this.rbTriángulo.UseVisualStyleBackColor = false;
            // 
            // rbRectángulo
            // 
            this.rbRectángulo.AutoSize = true;
            this.rbRectángulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbRectángulo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbRectángulo.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.rbRectángulo.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbRectángulo.Location = new System.Drawing.Point(34, 90);
            this.rbRectángulo.Name = "rbRectángulo";
            this.rbRectángulo.Size = new System.Drawing.Size(124, 25);
            this.rbRectángulo.TabIndex = 2;
            this.rbRectángulo.TabStop = true;
            this.rbRectángulo.Text = "Rectángulo";
            this.rbRectángulo.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(192, 122);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(279, 157);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.rbRectángulo);
            this.Controls.Add(this.rbTriángulo);
            this.Controls.Add(this.lblInicio);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(289, 189);
            this.Name = "frmInicio";
            this.Text = "Cálculos Geométricos v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.RadioButton rbTriángulo;
        private System.Windows.Forms.RadioButton rbRectángulo;
        private System.Windows.Forms.Button btnInicio;
    }
}
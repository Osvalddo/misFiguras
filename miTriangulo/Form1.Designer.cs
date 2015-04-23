namespace misFiguras
{
    partial class frmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriangulo));
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.lblcalcularSuperf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcalcularPerim = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.Location = new System.Drawing.Point(279, 16);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(139, 20);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Medida del Lado 1";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.Location = new System.Drawing.Point(279, 63);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(139, 20);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Medida del Lado 2";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado3.Location = new System.Drawing.Point(279, 110);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(139, 20);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.Text = "Medida del Lado 3";
            // 
            // txtLado1
            // 
            this.txtLado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado1.Location = new System.Drawing.Point(212, 14);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(61, 22);
            this.txtLado1.TabIndex = 0;
            this.txtLado1.TextChanged += new System.EventHandler(this.txtLado1_TextChanged);
            this.txtLado1.Leave += new System.EventHandler(this.txtLado1_Leave);
            // 
            // txtLado2
            // 
            this.txtLado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado2.Location = new System.Drawing.Point(212, 61);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(61, 22);
            this.txtLado2.TabIndex = 1;
            // 
            // txtLado3
            // 
            this.txtLado3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado3.Location = new System.Drawing.Point(212, 108);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(61, 22);
            this.txtLado3.TabIndex = 2;
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.BackColor = System.Drawing.Color.Snow;
            this.lblSuperficie.Location = new System.Drawing.Point(51, 146);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(121, 13);
            this.lblSuperficie.TabIndex = 6;
            this.lblSuperficie.Text = "Superficie del Triángulo:";
            // 
            // lblcalcularSuperf
            // 
            this.lblcalcularSuperf.AutoSize = true;
            this.lblcalcularSuperf.BackColor = System.Drawing.Color.Snow;
            this.lblcalcularSuperf.Location = new System.Drawing.Point(110, 161);
            this.lblcalcularSuperf.Name = "lblcalcularSuperf";
            this.lblcalcularSuperf.Size = new System.Drawing.Size(0, 13);
            this.lblcalcularSuperf.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perímetro del Triángulo:";
            // 
            // lblcalcularPerim
            // 
            this.lblcalcularPerim.AutoSize = true;
            this.lblcalcularPerim.BackColor = System.Drawing.Color.OliveDrab;
            this.lblcalcularPerim.Location = new System.Drawing.Point(138, 217);
            this.lblcalcularPerim.Name = "lblcalcularPerim";
            this.lblcalcularPerim.Size = new System.Drawing.Size(0, 13);
            this.lblcalcularPerim.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(283, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 41);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(437, 259);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblcalcularPerim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcalcularSuperf);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmTriangulo";
            this.Text = "Cálculos para un Triángulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Label lblcalcularSuperf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcalcularPerim;
        private System.Windows.Forms.Button btnCalcular;
    }
}


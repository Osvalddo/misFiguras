namespace misFiguras
{
    partial class frmRectang2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRectang2));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblcalcularPerim = new System.Windows.Forms.Label();
            this.lblPerimR = new System.Windows.Forms.Label();
            this.lblcalcularSuperfR = new System.Windows.Forms.Label();
            this.lblSuperficieR = new System.Windows.Forms.Label();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.lblLado2R = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.lblLado1R = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(329, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 31);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblcalcularPerim
            // 
            this.lblcalcularPerim.AutoSize = true;
            this.lblcalcularPerim.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblcalcularPerim.Location = new System.Drawing.Point(237, 72);
            this.lblcalcularPerim.Name = "lblcalcularPerim";
            this.lblcalcularPerim.Size = new System.Drawing.Size(0, 13);
            this.lblcalcularPerim.TabIndex = 20;
            // 
            // lblPerimR
            // 
            this.lblPerimR.AutoSize = true;
            this.lblPerimR.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblPerimR.Location = new System.Drawing.Point(111, 72);
            this.lblPerimR.Name = "lblPerimR";
            this.lblPerimR.Size = new System.Drawing.Size(120, 13);
            this.lblPerimR.TabIndex = 19;
            this.lblPerimR.Text = "Perímetro del Triángulo:";
            // 
            // lblcalcularSuperfR
            // 
            this.lblcalcularSuperfR.AutoSize = true;
            this.lblcalcularSuperfR.BackColor = System.Drawing.Color.SpringGreen;
            this.lblcalcularSuperfR.Location = new System.Drawing.Point(238, 132);
            this.lblcalcularSuperfR.Name = "lblcalcularSuperfR";
            this.lblcalcularSuperfR.Size = new System.Drawing.Size(0, 13);
            this.lblcalcularSuperfR.TabIndex = 18;
            // 
            // lblSuperficieR
            // 
            this.lblSuperficieR.AutoSize = true;
            this.lblSuperficieR.BackColor = System.Drawing.Color.SpringGreen;
            this.lblSuperficieR.Location = new System.Drawing.Point(99, 132);
            this.lblSuperficieR.Name = "lblSuperficieR";
            this.lblSuperficieR.Size = new System.Drawing.Size(132, 13);
            this.lblSuperficieR.TabIndex = 17;
            this.lblSuperficieR.Text = "Superficie del Rectángulo:";
            // 
            // txtLadoB
            // 
            this.txtLadoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoB.Location = new System.Drawing.Point(244, 31);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(61, 22);
            this.txtLadoB.TabIndex = 16;
            this.txtLadoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLadoB_KeyPress);
            // 
            // lblLado2R
            // 
            this.lblLado2R.AutoSize = true;
            this.lblLado2R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2R.Location = new System.Drawing.Point(87, 31);
            this.lblLado2R.Name = "lblLado2R";
            this.lblLado2R.Size = new System.Drawing.Size(151, 20);
            this.lblLado2R.TabIndex = 15;
            this.lblLado2R.Text = "Medida del Lado \"b\"";
            // 
            // txtLadoA
            // 
            this.txtLadoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoA.Location = new System.Drawing.Point(244, 208);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(61, 22);
            this.txtLadoA.TabIndex = 14;
            // 
            // lblLado1R
            // 
            this.lblLado1R.AutoSize = true;
            this.lblLado1R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1R.Location = new System.Drawing.Point(87, 210);
            this.lblLado1R.Name = "lblLado1R";
            this.lblLado1R.Size = new System.Drawing.Size(151, 20);
            this.lblLado1R.TabIndex = 13;
            this.lblLado1R.Text = "Medida del Lado \"a\"";
            // 
            // frmRectang2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(431, 253);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblcalcularPerim);
            this.Controls.Add(this.lblPerimR);
            this.Controls.Add(this.lblcalcularSuperfR);
            this.Controls.Add(this.lblSuperficieR);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.lblLado2R);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLado1R);
            this.DoubleBuffered = true;
            this.Name = "frmRectang2";
            this.Text = "Cálculos para un Rectángulo";
            this.Load += new System.EventHandler(this.Rectangulo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblcalcularPerim;
        private System.Windows.Forms.Label lblPerimR;
        private System.Windows.Forms.Label lblcalcularSuperfR;
        private System.Windows.Forms.Label lblSuperficieR;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label lblLado2R;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.Label lblLado1R;
    }
}
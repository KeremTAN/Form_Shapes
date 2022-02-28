namespace FormShapes
{
    partial class RectangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleForm));
            this.lblObjectInfo = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picRectangle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObjectInfo
            // 
            this.lblObjectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblObjectInfo.AutoSize = true;
            this.lblObjectInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblObjectInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblObjectInfo.Location = new System.Drawing.Point(15, 715);
            this.lblObjectInfo.Name = "lblObjectInfo";
            this.lblObjectInfo.Size = new System.Drawing.Size(0, 24);
            this.lblObjectInfo.TabIndex = 8;
            this.lblObjectInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnCalculate.Location = new System.Drawing.Point(540, 750);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 34);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // picRectangle
            // 
            this.picRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.picRectangle.Location = new System.Drawing.Point(5, 5);
            this.picRectangle.Name = "picRectangle";
            this.picRectangle.Size = new System.Drawing.Size(1227, 700);
            this.picRectangle.TabIndex = 10;
            this.picRectangle.TabStop = false;
            this.picRectangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picRectangle_MouseDown);
            this.picRectangle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picRectangle_MouseUp);
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1234, 811);
            this.Controls.Add(this.picRectangle);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblObjectInfo);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1250, 850);
            this.Name = "RectangleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangle Form";
            this.Load += new System.EventHandler(this.RectangleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRectangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjectInfo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picRectangle;
    }
}
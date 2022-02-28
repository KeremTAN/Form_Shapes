namespace FormShapes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmbOptions = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtEdge1 = new System.Windows.Forms.TextBox();
            this.lblEgde1 = new System.Windows.Forms.Label();
            this.lblEdge2 = new System.Windows.Forms.Label();
            this.txtEdge2 = new System.Windows.Forms.TextBox();
            this.btnRedirect = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOptions
            // 
            this.cmbOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Items.AddRange(new object[] {
            "- Select -",
            "Circle",
            "Rectangle"});
            this.cmbOptions.Location = new System.Drawing.Point(300, 128);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(360, 32);
            this.cmbOptions.TabIndex = 0;
            this.cmbOptions.SelectedIndexChanged += new System.EventHandler(this.cmbOptions_SelectedIndexChanged);
            // 
            // txtEdge1
            // 
            this.txtEdge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdge1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEdge1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtEdge1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtEdge1.HideSelection = false;
            this.txtEdge1.Location = new System.Drawing.Point(401, 205);
            this.txtEdge1.MaxLength = 3;
            this.txtEdge1.Name = "txtEdge1";
            this.txtEdge1.Size = new System.Drawing.Size(226, 29);
            this.txtEdge1.TabIndex = 1;
            this.txtEdge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEgde1
            // 
            this.lblEgde1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEgde1.AutoSize = true;
            this.lblEgde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgde1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEgde1.Location = new System.Drawing.Point(305, 210);
            this.lblEgde1.Name = "lblEgde1";
            this.lblEgde1.Size = new System.Drawing.Size(77, 24);
            this.lblEgde1.TabIndex = 2;
            this.lblEgde1.Text = "Edge 1";
            // 
            // lblEdge2
            // 
            this.lblEdge2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdge2.AutoSize = true;
            this.lblEdge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEdge2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdge2.Location = new System.Drawing.Point(305, 261);
            this.lblEdge2.Name = "lblEdge2";
            this.lblEdge2.Size = new System.Drawing.Size(77, 24);
            this.lblEdge2.TabIndex = 4;
            this.lblEdge2.Text = "Edge 2";
            // 
            // txtEdge2
            // 
            this.txtEdge2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdge2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEdge2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtEdge2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtEdge2.HideSelection = false;
            this.txtEdge2.Location = new System.Drawing.Point(401, 256);
            this.txtEdge2.MaxLength = 3;
            this.txtEdge2.Name = "txtEdge2";
            this.txtEdge2.Size = new System.Drawing.Size(226, 29);
            this.txtEdge2.TabIndex = 3;
            this.txtEdge2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRedirect
            // 
            this.btnRedirect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRedirect.BackColor = System.Drawing.Color.White;
            this.btnRedirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRedirect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnRedirect.Location = new System.Drawing.Point(432, 312);
            this.btnRedirect.Name = "btnRedirect";
            this.btnRedirect.Size = new System.Drawing.Size(171, 34);
            this.btnRedirect.TabIndex = 5;
            this.btnRedirect.Text = "Redirect";
            this.btnRedirect.UseVisualStyleBackColor = false;
            this.btnRedirect.Click += new System.EventHandler(this.btnRedirect_Click);
            this.btnRedirect.MouseLeave += new System.EventHandler(this.btnRedirect_MouseLeave);
            this.btnRedirect.MouseHover += new System.EventHandler(this.btnRedirect_MouseHover);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErrorMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErrorMessage.Location = new System.Drawing.Point(397, 513);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 24);
            this.lblErrorMessage.TabIndex = 6;
            // 
            // txtRadius
            // 
            this.txtRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRadius.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtRadius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtRadius.HideSelection = false;
            this.txtRadius.Location = new System.Drawing.Point(401, 370);
            this.txtRadius.MaxLength = 3;
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(226, 29);
            this.txtRadius.TabIndex = 7;
            this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRadius
            // 
            this.lblRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRadius.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRadius.Location = new System.Drawing.Point(308, 375);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(74, 24);
            this.lblRadius.TabIndex = 8;
            this.lblRadius.Text = "Radius";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnRedirect);
            this.Controls.Add(this.lblEdge2);
            this.Controls.Add(this.txtEdge2);
            this.Controls.Add(this.lblEgde1);
            this.Controls.Add(this.txtEdge1);
            this.Controls.Add(this.cmbOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOptions;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtEdge1;
        private System.Windows.Forms.Label lblEgde1;
        private System.Windows.Forms.Label lblEdge2;
        private System.Windows.Forms.TextBox txtEdge2;
        private System.Windows.Forms.Button btnRedirect;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
    }
}


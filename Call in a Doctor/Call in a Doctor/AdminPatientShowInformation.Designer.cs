﻿namespace Call_in_a_Doctor
{
    partial class frmAdminPatientShowInformation
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
            this.btnBackPatient = new System.Windows.Forms.Button();
            this.dgvDoctorInformation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(311, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 83);
            this.label1.TabIndex = 37;
            this.label1.Text = "All Patient Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackPatient
            // 
            this.btnBackPatient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPatient.Location = new System.Drawing.Point(12, 12);
            this.btnBackPatient.Name = "btnBackPatient";
            this.btnBackPatient.Size = new System.Drawing.Size(67, 36);
            this.btnBackPatient.TabIndex = 150;
            this.btnBackPatient.Text = "Back";
            this.btnBackPatient.UseVisualStyleBackColor = true;
            this.btnBackPatient.Click += new System.EventHandler(this.btnBackDoctor_Click);
            // 
            // dgvDoctorInformation
            // 
            this.dgvDoctorInformation.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDoctorInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorInformation.Location = new System.Drawing.Point(311, 152);
            this.dgvDoctorInformation.Name = "dgvDoctorInformation";
            this.dgvDoctorInformation.RowTemplate.Height = 24;
            this.dgvDoctorInformation.Size = new System.Drawing.Size(675, 433);
            this.dgvDoctorInformation.TabIndex = 38;
            // 
            // frmAdminPatientShowInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Call_in_a_Doctor.Properties.Resources.AdminPatientUpdate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btnBackPatient);
            this.Controls.Add(this.dgvDoctorInformation);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminPatientShowInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Patient Information";
            this.Load += new System.EventHandler(this.frmAdminPatientShowInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackPatient;
        private System.Windows.Forms.DataGridView dgvDoctorInformation;
    }
}
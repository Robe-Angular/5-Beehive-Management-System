
namespace _5_Beehive_Management_System
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignJob = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.workTheNextShiftButton = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.jobComboBox);
            this.groupBox1.Location = new System.Drawing.Point(51, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Job Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Worker bee job";
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(52, 69);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(185, 23);
            this.assignJob.TabIndex = 2;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(210, 33);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(57, 20);
            this.shifts.TabIndex = 1;
            // 
            // jobComboBox
            // 
            this.jobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "String patrol"});
            this.jobComboBox.Location = new System.Drawing.Point(33, 33);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(121, 21);
            this.jobComboBox.TabIndex = 0;
            // 
            // workTheNextShiftButton
            // 
            this.workTheNextShiftButton.Location = new System.Drawing.Point(406, 36);
            this.workTheNextShiftButton.Name = "workTheNextShiftButton";
            this.workTheNextShiftButton.Size = new System.Drawing.Size(86, 83);
            this.workTheNextShiftButton.TabIndex = 1;
            this.workTheNextShiftButton.Text = "Work the next shift";
            this.workTheNextShiftButton.UseVisualStyleBackColor = true;
            this.workTheNextShiftButton.Click += new System.EventHandler(this.workTheNextShiftButton_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(51, 160);
            this.report.MinimumSize = new System.Drawing.Size(200, 200);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(441, 200);
            this.report.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 372);
            this.Controls.Add(this.report);
            this.Controls.Add(this.workTheNextShiftButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox jobComboBox;
        private System.Windows.Forms.Button workTheNextShiftButton;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.NumericUpDown shifts;
    }
}


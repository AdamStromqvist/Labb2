namespace ProjektOOSU2_Test.PresentationLayer
{
    partial class PatientForm
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
            listBoxPatient = new ListBox();
            SuspendLayout();
            // 
            // listBoxPatient
            // 
            listBoxPatient.FormattingEnabled = true;
            listBoxPatient.ItemHeight = 15;
            listBoxPatient.Location = new Point(45, 19);
            listBoxPatient.Name = "listBoxPatient";
            listBoxPatient.Size = new Size(200, 409);
            listBoxPatient.TabIndex = 0;
            
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPatient);
            Name = "PatientForm";
            Text = "PatientForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPatient;
    }
}
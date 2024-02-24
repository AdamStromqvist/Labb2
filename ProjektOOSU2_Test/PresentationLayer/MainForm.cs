using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOOSU2_Test.PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void labelHeading_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            var viewAllForm = new ViewAllForm();
            viewAllForm.Show(); 
        }

        private void buttonPatientService_Click(object sender, EventArgs e)
        {
            var patientForm = new PatientForm();
            patientForm.Show();
        }

        private void buttonDoctorAppointmentService_Click(object sender, EventArgs e)
        {
            var doctorAppointmentForm = new DoctorAppointmentForm();
            doctorAppointmentForm.Show();
        }

        private void buttonDiagnosisService_Click(object sender, EventArgs e)
        {
            var diagnosisForm = new DiagnosisForm();
            diagnosisForm.Show();
        }

        private void buttonMedicinePrescriptionService_Click(object sender, EventArgs e)
        {
            var medicinePrescriptionForm = new MedicinePrescriptionForm();
            medicinePrescriptionForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the application
        }
    }
}

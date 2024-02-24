using ProjektOOSU2_Test.BusinessLayer;
using ProjektOOSU2_Test.DataLayer;
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
    public partial class PatientForm : Form
    {
        private readonly PatientService _patientService;

        public PatientForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _patientService = new PatientService(unitOfWork);
        }

        private async void PatientForm_Load(object sender, EventArgs e)
        {
            var patients = await _patientService.GetAllPatientsAsync();
            listBoxPatient.DataSource = patients.ToList();
            listBoxPatient.DisplayMember = "Name"; // Antag att "Name" är en property hos Patient-entiteten
        }
    }
}

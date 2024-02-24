using ProjektOOSU2_Test.DataLayer;
using ProjektOOSU2_Test.EntetiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOSU2_Test.BusinessLayer
{
    public class PatientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _unitOfWork.Patients.GetAllAsync();
        }
    }
}

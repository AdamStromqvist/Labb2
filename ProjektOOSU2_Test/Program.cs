using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjektOOSU2_Test.BusinessLayer;
using ProjektOOSU2_Test.DataLayer;
using ProjektOOSU2_Test.EntetiesLayer;
using ProjektOOSU2_Test.PresentationLayer;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ProjektOOSU2_Test
{
    static class Program
    {


        // Global tillgång till UnitOfWork om så önskas
        public static IUnitOfWork UnitOfWork { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Konfigurera DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<PatientManagementContext>();
            optionsBuilder.UseSqlServer(@"Server=sqlutb2-db.hb.se,56077;Database=oosu2408;User ID=oosu2408;Password=UKB987;TrustServerCertificate=True;");

            // Skapa en instans av DbContext
            var context = new PatientManagementContext(optionsBuilder.Options);

            var unitOfWork = new UnitOfWork(context);
            var employeeService = new EmployeeService(unitOfWork);
            var loginForm = new LoginForm(employeeService);

            // Skapa en global instans av UnitOfWork (valfritt, beroende på design)
            UnitOfWork = new UnitOfWork(context);

            // Starta applikationen med huvudformuläret
            // Antag att MainForm är din startform, byt ut mot din faktiska startform
            Application.Run(loginForm);
        }
    }



}
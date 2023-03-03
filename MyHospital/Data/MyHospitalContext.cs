using Microsoft.EntityFrameworkCore;
using MyHospital.Models;

namespace MyHospital.Data
{
    public partial class MyHospitalContext : DbContext
    {
        public MyHospitalContext()
        {

        }
        public MyHospitalContext(DbContextOptions<MyHospitalContext> options) : base(options)
        {

        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

    }
}

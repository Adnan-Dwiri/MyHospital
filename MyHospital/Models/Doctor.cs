﻿using System.ComponentModel.DataAnnotations;

namespace MyHospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Speciality { get; set; }
        public string? Address { get; set; }
        public ICollection<Patient>? Patients { get; set; }
    }
}

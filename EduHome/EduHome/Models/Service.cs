﻿
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "don't null")]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeactive { get; set; }

    }
}

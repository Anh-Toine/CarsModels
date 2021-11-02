using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarModelsDemo.Models
{
    [Table("CarModels")]
    public class CarModelsLogic
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Company { get; set; }
        public string Release { get; set; }
        public string Country { get; set; }
    }
}

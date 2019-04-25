using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APITarea.Models
{
    public enum StatusTypeP
    {
        Activo,
        Inactivo
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        [Required]
        public StatusTypeP Status { get; set; }

    }
}
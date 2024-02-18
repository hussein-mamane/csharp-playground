using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace MvcCrud.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Book's Title")]
        public string? Title { get; set; }

    }
}
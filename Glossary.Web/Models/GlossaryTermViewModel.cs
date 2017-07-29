using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Glossary.Web.Models
{
    public class GlossaryTermViewModel
    {
        [Required]
        public  int Id { get; set; }

        [StringLength(50)]
        [Required]
        public  string Term { get; set; }

        [StringLength(255)]
        [Required]
        public  string Definition { get; set; }
    }
}
using Pepper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pepper.Dto
{
    public class CustomerDto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribeToNewsltter { get; set; }

        public byte MemberShipTypeId { get; set; }

        //[Min18YearsIfaMember]
        public DateTime? Birthday { get; set; }
        
    }
}
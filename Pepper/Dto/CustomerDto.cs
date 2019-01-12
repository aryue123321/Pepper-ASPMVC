
using System;
using System.ComponentModel.DataAnnotations;


namespace Pepper.Dto
{
    
    public class CustomerDto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribeToNewsltter { get; set; }

        //public byte MemberShipTypeId { get; set; }

        public MemberShipTypeDto MemberShipType { get; set; }

        //[Min18YearsIfaMember]
        public DateTime? Birthday { get; set; }
        
    }
}
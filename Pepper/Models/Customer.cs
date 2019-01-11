﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pepper.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DisplayName("Subscribe to NewsLetter")]
        public bool IsSubscribeToNewsltter { get; set; }

        [DisplayName("Membership Type")]
        public MemberShipType MemberShipType { get; set; }

        [DisplayName("Membership Type")]
        public byte MemberShipTypeId { get; set; }

        [DisplayFormat(DataFormatString = "{MM/dd")]
        [DisplayName("Date of Birth")]
        public DateTime? Birthday { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlib_v2.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MemberShipTypeId { get; set; }

        public MemberShipType MemberShipType { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidlib_v2.Models
{
    public class MemberShipType
    {

        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        [Required]
        public string Name { get; set; }
        public byte DiscountRate { get; set; }


    }
}
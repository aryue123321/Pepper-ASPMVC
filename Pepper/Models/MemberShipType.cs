using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pepper.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public string Name { get; set; }

        public static readonly byte UNKNOWN = 0;

        public static readonly byte PAY_AS_YOU_GO = 1;


    }
}
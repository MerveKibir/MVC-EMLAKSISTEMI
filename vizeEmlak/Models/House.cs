using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vizeEmlak.Models
{
    public class House
    {
        public byte[] Resim { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public int No { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
    }
}
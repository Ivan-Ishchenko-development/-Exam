using System;
using System.Collections.Generic;
using System.Text;

namespace ExLayer.DAL
{
    public class Parents
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NumberPhone { get; set; }
        public int Priority { get; set; }
        public Chaild Chaild { get; set; }
    }
}

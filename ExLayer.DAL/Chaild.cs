using System;
using System.Collections.Generic;
using System.Text;
namespace ExLayer.DAL
{
    public class Chaild
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
        public Parents Parents { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExLayer.DAL
{
    public class Group
    {
        public int Id { get; set; }
        public ICollection<Chaild> Chaild { get; set; }
    }
}

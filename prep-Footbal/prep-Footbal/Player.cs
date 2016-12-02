using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prep_Footbal
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Rating { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Rating} / 10";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Player
    {
        public int Id { get; set; }
        public int ShirtNo { get; set; }
        public string Name { get; set; }
        public int Appearance { get; set; }
        public int Goal { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
        
        public int ClubId { get; set; }
        public Club Club { get; set; }

    }
}

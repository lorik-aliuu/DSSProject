using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Villa
    {

        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public int SquareFoot { get; set; }

        public int Occupancy { get; set; }

        public string? imageUrl { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

    }
}

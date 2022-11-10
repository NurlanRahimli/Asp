using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna_backend.Models
{
    public class Box
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}

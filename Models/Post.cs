
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna_backend.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public int BoxId { get; set; }
        public Box Box { get; set; }
    }
}

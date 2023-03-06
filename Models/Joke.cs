using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Joke
    {
        public int JokeId { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set;}
        public string JokeType { get; set; }
    }
}

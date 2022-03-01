using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJokesApp.Models
{
    public class Joke
    {
        //prop shortcut
        public int Id { get; set; }
        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        //constructor

        public Joke()
        {

        }
    }
}

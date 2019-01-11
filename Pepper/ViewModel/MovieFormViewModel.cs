using Pepper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pepper.ViewModel
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
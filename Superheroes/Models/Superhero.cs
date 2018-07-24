using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superheroes.Models
{
    public class Superhero : IEnumerable
    {

        [Key]

        public int ID { get; set; }

        public string Name { get; set; }

        public string AlterEgo {get;set;}

        public string PrimarySuperheroAbility { get; set; }

        public string SecondarySuperheroAbility { get; set; }

        public string Catchphrase { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
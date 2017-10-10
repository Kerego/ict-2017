using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ict2017.Common.Models
{
    public class Presenter : Entity
    {
        [StringLength(100)]
        public string Forename { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }
        public ICollection<Presentation> Presentations { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace Ict2017.Common.Models
{
    public class Presentation : Entity
    {
        [StringLength(100)]
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int PresenterId { get; set; }
        public Presenter Presenter { get; set; }
        public int? AssetId { get; set; }
        public Asset Asset { get; set; }
        public int ClapCount { get; set; }

    }
}
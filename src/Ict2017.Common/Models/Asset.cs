using System.ComponentModel.DataAnnotations;

namespace Ict2017.Common.Models
{
    public class Asset : Entity
    {
        [StringLength(255)]
        public string Location { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public AssetType Type { get; set; }
    }
}
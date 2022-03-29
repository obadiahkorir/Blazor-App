using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Shared.Models
{
    [Table("RegionMaster")]
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
    }
}

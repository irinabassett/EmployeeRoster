using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeRoster.Models
{
    public class Position
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PositionID { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }

        public virtual ICollection<Employment> Employments { get; set; }

        // Position <-> Employment <-> Employee relationship
    }
}





        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRoster.Models
{
    public enum EvalScore
    {
        A, B, C, D, E
    }
    public class Employment
    {
        public int EmploymentID { get; set; }
        public int PositionID { get; set; }
        public int EmployeetID { get; set; }
        public EvalScore? EvalScore { get; set; }

        public virtual Position Course { get; set; }
        public virtual Employee Student { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRoster.Models

    // This enum is not currently utilized.
{
    public enum EvalScore  
    {
        A, B, C, D, E
    }
    public class Employment
    {
        public int EmploymentID { get; set; }
        public int PositionID { get; set; }
        public int EmployeeID { get; set; }
        public EvalScore? EvalScore { get; set; }

        public virtual Position Position { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
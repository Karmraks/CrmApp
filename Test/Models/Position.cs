using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        
        public string PositionName { get; set; }
    }
}
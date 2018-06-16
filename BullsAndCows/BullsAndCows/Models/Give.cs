using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Models
{
    public class Give
    {
        public int[] GenNumber { get; set; }
        public int InNumber { get; set; }

        public int CoincidenceBulls { get; set; }

        public int CoincidenceCows { get; set; }

        public Boolean Flag { get; set; }

        public int[,] BullAndCow { get; set; }

        public int FreeMass { get; set; }

        



    }
}
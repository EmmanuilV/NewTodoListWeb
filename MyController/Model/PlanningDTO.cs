using System;
using System.Collections.Generic;

namespace TodoItems
{
    public class PlanningDTO
    {
       public int CountOfPlanedForToday { get; set; }
        public List<NotDoneDTO> NotDoneDTO { get; set; }
    }
}
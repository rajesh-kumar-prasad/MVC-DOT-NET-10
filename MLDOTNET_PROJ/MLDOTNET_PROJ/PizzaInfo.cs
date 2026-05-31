using System;
using System.Collections.Generic;
using System.Text;

namespace MLDOTNET_PROJ
{
    public class PizzaInfo
    {
        public float OvenTemp { get; set; }
        public float CookingTime { get; set; }
    }

    public class PredictedCookingTime
    {
        public float Score { get; set; }
    }
}

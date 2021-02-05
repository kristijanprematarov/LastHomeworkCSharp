using System.Collections.Generic;

namespace VezbanjeNaCas
{
    public interface ISmoothie
    {
        Dictionary<string[], double> Ingredients { get; set; }

        double GetCost();
        void GetName();
        void GetPrice();
    }
}
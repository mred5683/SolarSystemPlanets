using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemPlanets {
  public class Earth {
    public double AverageSurfaceTemp { get; set; }
    public double AverageCoreTemp { get; set; }

    public Earth(double averageSurfaceTemp, double averageCoreTemp) {
      AverageSurfaceTemp = averageSurfaceTemp;
      AverageCoreTemp = averageCoreTemp;
    }
  }
}

using System;
using System.Linq;
using System.Reflection;

namespace SolarSystemPlanets {
  public class Program {
    public static void Main() {
      var earth = new Earth(67, 10000);
      Console.WriteLine(Convert.ToString(earth).Single());
      Console.ReadLine();
    }
  }
}

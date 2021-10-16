using System;
using System.Collections.Generic;

namespace ChimeCalculator.BusinessLogic
{
	//This is bad practice for anything other than a simple console app. Dont use public static normally.
	public static class Constants
  {
    public const double AirSpeedOfSound = 343.5999732; // m/s; SI unit
    public const double gravityInSxS = 384.4; //inches/s^2 SI: 9.8m/s^2
    public const double gravityMMSxS = 9806.65;
    public const double Euler1 = 22.37;
    public const double Euler2 = 61.67;
    public const double Euler3 = 120.9;
    public const double Euler4 = 199.859;
    public const double PSIToPascal = 6894.76;
    public const double LengthInMetres = 0.001;
    public const double Euler = Math.E;
    public const double HangPointFactor = 0.2242;

    //readonly is similar to const, but const cannot be used alongside 'new'
    public static readonly Dictionary<MetalType, double> ElasticityModulus = new Dictionary<MetalType, double> {
      { MetalType.Steel, 180000000000000 },
      { MetalType.Aluminium, 69000000000 },
      { MetalType.Brass, 102000000000 },
      { MetalType.Copper, 117000000000 },
    };

    public static readonly Dictionary<MetalType, double> Density = new Dictionary<MetalType, double> {
      { MetalType.Steel, 7850.0 },
      { MetalType.Aluminium, 2712.6 },
      { MetalType.Brass, 8525.4 },
      { MetalType.Copper, 8929.5 },
    };
  }
}
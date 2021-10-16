using System;

namespace ChimeCalculator.BusinessLogic.Models
{
	public class CylinderModel
	{
    public double RootFrequency { get; set; }    
    public double TubeArea { get; set; }
    public double TubeMass { get; set; }
    public double SolidVolume { get; set; }
    public double SolidMass { get; set; }
    public double Density { get; set; }
    public double ElasticityModulus { get; set; }
    
    public MetalType MetalType { get; set; }
    
    public double WallVolume { get; set; }
    
    public double OuterRadius { get; set; }
    public double InnerRadius { get; set; }
    public double Height { get; set; }
    public double WallThickness { get; set; }
    public double OuterDiameter { get; set; }
    public double InnerDiameter { get; set; }
    public double ZAxisMassMOI { get; set; }
    public double XYAxisMassMOI { get; set; }
    public double AreaMOI { get; set; }
    public double BaseUnitPerlength { get; set; }
    public double SpeedOfSound { get; set; }
    public double Frequency { get; set; }
    public double Octave { get; set; }
    public string NoteName { get; set; }
    public double RootNote { get; set; }
    public double NotePos { get; set; }
    public double CurrentNote { get; set; }
    public double ChimeLength { get; set; }
    public double InnerSolidVolume { get; set; }
    public double MassPerUnitLength { get; set; }
		public double HangPoint { get; set; }

		public CylinderModel()
    {
    }
    public CylinderModel(string noteName, double massPerUnitLength, double innerSolidVolume, double chimeLength, double currentNote, double notePos, double rootNote, double rootFrequency, double octave, double frequency, double speedOfSound, double tubeArea, double baseArea, double areaMOI, double xyAxisMassMOI, double zAxisMassMOI, double tubeMass, double outerDiameter, double innerDiameter, double solidMass, double solidVolume, double density, double elasticityModulus, double innerRadius, double outerRadius, double height, double wallThickness, double wallVolume)
    {
      MassPerUnitLength = massPerUnitLength;
      InnerSolidVolume = innerSolidVolume;
      ChimeLength = chimeLength;
      CurrentNote = currentNote;
      NotePos = notePos;
      RootNote = rootNote;
      RootFrequency = rootFrequency;
      NoteName = noteName;
      Octave = octave;
      Frequency = frequency;
      SpeedOfSound = speedOfSound;
      TubeArea = tubeArea;
      BaseUnitPerlength = baseArea;
      AreaMOI = areaMOI;
      XYAxisMassMOI = xyAxisMassMOI;
      ZAxisMassMOI = zAxisMassMOI;
      TubeMass = tubeMass;
      InnerDiameter = innerDiameter;
      OuterDiameter = outerDiameter;
      SolidVolume = solidVolume;
      SolidMass = solidMass;
      WallVolume = wallVolume;
      OuterRadius = outerRadius;
      InnerRadius = innerRadius;
      Height = height;
      WallThickness = wallThickness;
      Density = density;
      ElasticityModulus = elasticityModulus;

    }
  }
}

using System;

namespace ConsoleApp2
{
    public class Cylinder
    {
        public const double Euler = Math.E;
        public double RootFrequency { get; set; }
        public const double PSIToPascal = 6894.76;
        public double TubeArea { get; set; }
        public double TubeMass { get; set; }
        public double SolidVolume { get; set; }
        public double SolidMass { get; set; }
        public double Density { get; set; }
        public double ElasticityModulus { get; set; }
        public const double AirSpeedOfSound = 343.5999732; // m/s; SI unit
        public const double gravityInSxS = 384.4; //inches/s^2 SI: 9.8m/s^2
        public const double gravityMMSxS = 9806.65;
        public const double Euler1 = 22.37;
        public const double Euler2 = 61.67;
        public const double Euler3 = 120.9;
        public const double Euler4 = 199.859;
        public MetalType MetalType { get; set; }
        public const double LengthInMetres = 0.001;
        public double WallVolume { get; set; }
        private const double pi = Math.PI;
        public double OuterRadius { get; set; }
        public double InnerRadius { get; set; }
        public double Height { get; set; }
        public double WallThickness { get; set; }
        public double OuterDiameter { get; set; }
        public double InnerDiameter { get; set; }
        public double ZAxisMassMOI { get; set; }
        public double XYAxisMassMOI { get; set; }
        public double AreaMOI { get; set; }
        public double BaseArea { get; set; }
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

        public Cylinder()
        {
            Console.WriteLine("Instantiated new Cylinder()");
        }
        public Cylinder(string noteName, double massPerUnitLength, double innerSolidVolume, double chimeLength, double currentNote, double notePos, double rootNote ,double rootFrequency, double octave, double frequency, double speedOfSound, double tubeArea, double baseArea, double areaMOI, double xyAxisMassMOI, double zAxisMassMOI, double tubeMass, double outerDiameter, double innerDiameter, double solidMass, double solidVolume, double density, double elasticityModulus, double innerRadius, double outerRadius, double height, double wallThickness, double wallVolume)
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
            BaseArea = baseArea;
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
        public double GetHeight()
        {
            return Height;
        }
        public double GetLengthInMetres()
        {
            return LengthInMetres;
        }
        public double GetWallThickness()
        {
            WallThickness = (OuterDiameter - InnerDiameter) / 2;
            return WallThickness;
        }
        public double GetOuterDiameter()
        {
            return OuterDiameter;
        }
        public double GetMassPerUnitLength()
        {
            Density = GetDensity();
            BaseArea = GetBaseArea();
            MassPerUnitLength = BaseArea * Density;
            return MassPerUnitLength;
        }
        public double GetInnerDiameter()
        {
            return InnerDiameter;
        }
        public double GetInnerRadius()
        {
            InnerDiameter = GetInnerDiameter();
            InnerRadius = InnerDiameter / 2;
            return InnerRadius;
        }
        public double GetOuterRadius()
        {
            OuterDiameter = GetOuterDiameter();
            OuterRadius = OuterDiameter / 2;
            return OuterRadius;
        }
        public double GetInnerSolidVolume()
        {
            InnerRadius = GetInnerRadius();
            InnerSolidVolume = pi* (Math.Pow(InnerRadius, 2)) * Height;
            return InnerSolidVolume;
        }
        public double GetWallVolume()
        {
            SolidVolume = GetSolidVolume();
            InnerSolidVolume = GetInnerSolidVolume();
            WallVolume = SolidVolume - InnerSolidVolume;
            return WallVolume;     
        }
        public double GetBaseArea()
        {
            return pi * (Math.Pow(OuterRadius, 2));
        }
        public double GetTubeArea()
        {
            BaseArea = GetBaseArea();
            TubeArea = BaseArea - (pi * (Math.Pow(InnerRadius, 2)));
            return TubeArea;
        }
        public double GetBasePerimeter()
        {
            return 2 * pi * OuterRadius;
        }
        public double GetSpeedOfSound()
        {
            Density = GetDensity();
            ElasticityModulus = GetElasticityModulus();
            SpeedOfSound = (Math.Sqrt(ElasticityModulus / Density));
            return SpeedOfSound;
        }
        public double GetFrequency() //for an open pipe
        {
            SpeedOfSound = GetSpeedOfSound();
            Height = GetHeight();

            Frequency = AirSpeedOfSound / (4 * (Height + 0.3));
            return Frequency;
        }
        public double GetSolidVolume()
        { 
            SolidVolume = pi * (Math.Pow(OuterRadius,2)) * Height;
            return SolidVolume;
        }
        public double GetOctave()
        {
            return Octave;
        }
        public double GetRootFrequency()
        {
            return RootFrequency;
        }
        public string GetNoteName()
        {
            return NoteName;
        }
        public double GetNotePos()
        {
            Octave = GetOctave();
            NoteName = GetNoteName();
            switch (NoteName)
            
            {
                case "A#":
                    NotePos = 1  / 12;
                    break;
                case "B":
                    NotePos = 2  / 12;
                    break;
                case "C":
                    NotePos = 3  / 12;
                    break;
                case "C#":
                    NotePos = 4  / 12;
                    break;
                case "D":
                    NotePos = 5  / 12;
                    break;
                case "D#":
                    NotePos = 6  / 12;
                    break;
                case "E":
                    NotePos = 7  / 12;
                    break;
                case "F":
                    NotePos = 8  / 12;
                    break;
                case "F#":
                    NotePos = 9  / 12;
                    break;
                case "G":
                    NotePos = 10  / 12;
                    break;
                case "G#":
                    NotePos = 11  / 12;
                    break;
                case "A":
                    NotePos = 12 / 12;
                    break;
                default:
                    break;
            }
            return NotePos;
        }
        public double GetRootNote()
        {
            RootFrequency = GetRootFrequency();
            switch (Octave)
            {

                case 0:
                    RootNote = RootFrequency * 1/16;
                    break;
                case 1:
                    RootNote = RootFrequency * 1/8;
                    break;
                case 2:
                    RootNote = RootFrequency * 1/4;
                    break;
                case 3:
                    RootNote = RootFrequency * 1/2;
                    break;
                case 4:
                    RootNote = RootFrequency;
                    break;
                case 5:
                    RootNote = RootFrequency * 2;
                    break;
                case 6:
                    RootNote = RootFrequency * 4;
                    break;
                case 7:
                    RootNote = RootFrequency * 8;
                    break;
                case 8:
                    RootNote = RootFrequency * 16;
                    break;
                default:
                    break;
            }
            return RootNote;
        }
        public double GetLengthFromFreq()
        {
            SpeedOfSound = GetSpeedOfSound();
            Frequency = GetCurrentNote();
            ChimeLength = (AirSpeedOfSound / Frequency);
            return ChimeLength;
        }
        public double GetCurrentNote()
        {
            Octave = GetOctave();
            NoteName = GetNoteName();
            RootNote = GetRootNote();
            NotePos = GetNotePos();
            
            CurrentNote = Math.Pow(RootNote, NotePos);
            return CurrentNote;
        }
        public double GetElasticityModulus()
        {
          //  MetalType = "";
          //  ElasticityModulus = 0;
            switch (MetalType)
            {
                case MetalType.Steel:
                    ElasticityModulus = 180000000000000;
                    break;
                case  MetalType.Aluminium:
                    ElasticityModulus = 69000000000;
                    break;
                case MetalType.Brass:
                    ElasticityModulus = 102000000000;
                    break;
                case MetalType.Copper:
                    ElasticityModulus = 117000000000;
                    break;
                default:
                    break;
            }
            return ElasticityModulus;
        }
        public double GetDensity() //in SI unit : kg.m^3
        {
       //     MetalType = "";
       //     Density = 0;
            switch (MetalType)
            {
                case MetalType.Steel: // Kg/cb.m
                    Density = 7850.0;
                    break;
                case MetalType.Aluminium:
                    Density = 2712.6;
                    break;
                case MetalType.Brass:
                    Density = 8525.4;
                    break;
                case MetalType.Copper:
                    Density = 8929.5;
                    break;
                default:
                    break;
            }
            return Density;
        }
        public double GetXYAxisMassMOI() 
        {
            Density = GetDensity();
            TubeMass = GetTubeMass();
            XYAxisMassMOI = (TubeMass / 12) *  ( 3 * (Math.Pow(OuterRadius,2) + Math.Pow(InnerRadius,2)) + Math.Pow(Height,2));
            return XYAxisMassMOI;
        }
        public double GetZAxisMassMOI()
        {
            Density = GetDensity();
            TubeMass = GetTubeMass();
            ZAxisMassMOI = (TubeMass / 2) * (Math.Pow(InnerRadius, 2) + Math.Pow(OuterRadius, 2));
            return ZAxisMassMOI;
        }
        /*
        public double GetZAxisSolidMassMOI()
        {
            ZAxisMassMOI = (TubeMass / 2) * (Math.Pow(InnerRadius, 2) + Math.Pow(OuterRadius, 2));
            return ZAxisMassMOI;
        }
        */
        public double GetAreaMOI()
        {
            BaseArea = GetBaseArea();
            Density = GetDensity();

            AreaMOI = Math.PI * ((Math.Pow(OuterDiameter,4)-Math.Pow(InnerDiameter,4))) / 64;
            return AreaMOI;
        }
        public double GetSolidMass()
        {
            Density = GetDensity();
            SolidVolume = GetSolidVolume();
            SolidMass =  Density * SolidVolume;
            return SolidMass;
        }
        public double GetTubeMass()
        {
            Density = GetDensity();
            WallVolume = GetWallVolume();
            TubeMass = Density * WallVolume;
            return TubeMass;
        }
        public class Windchime : Cylinder
        {
            public const double HangPointFactor = 0.2242;
            public double HangPoint { get; set; }
            public string ChimeNote { get; set; }
            public Windchime()
            {

            }
            public Windchime(double rootFrequency, double hangPoint)
            {
                RootFrequency = rootFrequency;
                HangPoint = hangPoint;

            }
            public Windchime(string chimeNote)
            {
                ChimeNote = chimeNote;
            }
            public double GetHangPoint()
            {
                Height = GetHeight();
                HangPoint = Height * HangPointFactor;
                return HangPoint;
            }
            public double GetHangPointFactor()
            {
                return HangPointFactor;
            }
        


        }
    }
}

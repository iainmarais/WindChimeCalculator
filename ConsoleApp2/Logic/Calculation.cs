using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Logic
{
    class Calculation
    {
        public WindchimeModel GetDetailedOutput(decimal innerDiameter, decimal outerDiameter, MetalType metalType)
        {
            return new WindchimeModel
            {
                
            };
        }
    }

    public class WindchimeModel
    {
        //Console.WriteLine($"Chime props:");
        //Console.WriteLine($"Easticity modulus of {chime1.MetalType}:             {chime1.GetElasticityModulus()} Pascals");
        //Console.WriteLine($"Outer Radius:                               {chime1.GetOuterRadius()} m");
        //Console.WriteLine($"Wall thickness:                             {chime1.GetWallThickness()} m");
        //Console.WriteLine($"Length:                                     {chime1.GetHeight()} m");
        //Console.WriteLine($"Inner radius:                               {chime1.GetInnerRadius()} m");
        //Console.WriteLine($"Mass of equivalent solid bar:               {chime1.GetSolidMass()}  kg");
        //Console.WriteLine($"Mass of chime tube:                         {chime1.GetTubeMass()}  kg");
        //Console.WriteLine($"Mass Moment of inertia along Z axis:        {chime1.GetZAxisMassMOI()} kg m^2");
        //Console.WriteLine($"Mass Moment of inertia along X and Y axis:  {chime1.GetXYAxisMassMOI()} kg m^2");
        //Console.WriteLine($"Area Moment of inertia:                     {chime1.GetAreaMOI()} m^4");
        //Console.WriteLine($"Wind chime hang point:                      {chime1.GetHangPoint()} m");
        //Console.WriteLine($"Speed of sound in chime tube:               {chime1.GetSpeedOfSound()} metres/s");
        ////Console.WriteLine($"Frequency of wind chime:                    {chime1.GetFrequency()} - raw value from calculation");
        //Console.WriteLine($"Frequency of wind chime:                    {chime1.GetFrequency() / 10000} Hertz\n");

        //Console.WriteLine("chime length from known frequency: ");

        //Console.WriteLine($"Frequency of A4:                            {chime1.RootFrequency} Hertz");
        //Console.WriteLine($"Note: {chime1.NoteName} on octave {chime1.Octave}:                        {chime1.GetCurrentNote()} Hz\n");
        //Console.WriteLine($"Chime length relative to current note frequency:  {chime1.GetLengthFromFreq()}  metres");

        public MetalType MetalType { get; set; }
        public decimal ElasticityModulus { get; set; }
        public decimal OuterRadius { get; set; }
        public decimal WallThickness { get; set; }
        public decimal Length { get; set; }

    }
}

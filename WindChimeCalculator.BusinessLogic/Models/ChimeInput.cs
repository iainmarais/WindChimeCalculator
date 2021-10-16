namespace ChimeCalculator.BusinessLogic.Models
{
	public class ChimeInput
	{
    public double OuterDiameter { get; set; }
    public double InnerDiameter { get; set; }
    public double Height { get; set; }
    public MetalType MetalType { get; set; }
    public double RootFrequency { get; set; }
    public double Octave { get; set; }
    public Note NoteName { get; set; }   

	}
}

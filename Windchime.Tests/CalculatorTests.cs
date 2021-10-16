using NUnit.Framework;
using ChimeCalculator.BusinessLogic;
using ChimeCalculator.BusinessLogic.Models;

namespace ChimeCalculator.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Assert_That_Calculations_Are_Correct()
		{
			var model = new ChimeInput()
			{
				OuterDiameter = 25 * Constants.LengthInMetres,
				InnerDiameter = 23 * Constants.LengthInMetres,
				Height = 1023.9 * Constants.LengthInMetres,
				MetalType = MetalType.Aluminium,
				RootFrequency = 432,
				Octave = 3,
				NoteName = Note.A
			};

			var output = new BusinessLogic.ChimeCalculator().Caculate(model);

			Assert.IsTrue(output.Octave == 1.234, "Octave is invalid");
			Assert.IsTrue(output.OuterRadius == 1.234, "OuterRadius is invalid");
			Assert.IsTrue(output.SolidVolume == 44, "Solid Volume is invalid");
		}
	}
}
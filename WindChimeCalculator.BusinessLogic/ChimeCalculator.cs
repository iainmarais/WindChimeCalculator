using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChimeCalculator.BusinessLogic.Models;

namespace ChimeCalculator.BusinessLogic
{
	public class ChimeCalculator
	{
		private ChimeInput input;

		public CylinderModel Caculate(ChimeInput inputModel)
		{
			this.input = inputModel;

			var elasticityModulus = Constants.ElasticityModulus.FirstOrDefault(s => s.Key == input.MetalType).Value;
			double innerRadius = input.InnerDiameter / 2;
			double outerRadius = input.OuterDiameter / 2;
			double solidVolume = Math.PI * (Math.Pow(outerRadius, 2)) * input.Height;
			double innerSolidVolume = Math.PI * (Math.Pow(innerRadius, 2)) * input.Height;
			double wallThickness = (input.OuterDiameter - input.InnerDiameter) / 2;

			double baseArea = Math.PI * (Math.Pow(outerRadius, 2));
			double tubeArea = baseArea - (Math.PI * (Math.Pow(innerRadius, 2)));

			double density = Constants.Density.FirstOrDefault(s => s.Key == input.MetalType).Value;		
			double solidMass = density * solidVolume;			
			double wallVolume = solidVolume - innerSolidVolume;
			double tubeMass = density * wallVolume;

			double zAxisMassMOI = (tubeMass / 2) * (Math.Pow(innerRadius, 2) + Math.Pow(outerRadius, 2));
			double xYAxisMassMOI = (tubeMass / 12) * (3 * (Math.Pow(outerRadius, 2) + Math.Pow(innerRadius, 2)) + Math.Pow(input.Height, 2));
			double areaMOI = Math.PI * ((Math.Pow(input.OuterDiameter, 4) - Math.Pow(input.InnerDiameter, 4))) / 64;
			double hangPoint = input.Height * Constants.HangPointFactor;
			double speedOfSound = (Math.Sqrt(elasticityModulus / density));
			double bassPerUnitLength = baseArea * density;
			double frequency = Constants.AirSpeedOfSound / (4 * (input.Height + 0.3));
			double chimeLength = (Constants.AirSpeedOfSound / frequency);

			double rootNode = GetRootNote(input.RootFrequency, int.Parse(input.Octave.ToString()));
			int notePos = (int)input.NoteName / 12;
			double currentNote = Math.Pow(rootNode, notePos);

			return new CylinderModel
			{
				ElasticityModulus = elasticityModulus,
				OuterRadius = outerRadius,
				WallThickness = wallThickness,
				WallVolume = solidVolume - innerSolidVolume,				
				TubeArea = tubeArea,
				InnerRadius = innerRadius,
				SolidMass = solidMass,
				SolidVolume = solidVolume,
				TubeMass = tubeMass,
				ZAxisMassMOI = zAxisMassMOI,
				XYAxisMassMOI = xYAxisMassMOI,
				AreaMOI = areaMOI,
				HangPoint = hangPoint,
				SpeedOfSound = speedOfSound,
				BaseUnitPerlength = bassPerUnitLength,
				Frequency = frequency,
				ChimeLength = input.Height,
				Octave = input.Octave,
				NoteName = input.NoteName.ToString(),
				RootNote = rootNode,
				NotePos = notePos,
				CurrentNote = currentNote
			};
		}
		private double GetRootNote(double rootFrequency, int octave)
		{
			int[] octavePosition = new int[] { 1 / 16, 1 / 8, 1 / 4, 1 / 2, 1, 2, 4, 8, 16 };
			return rootFrequency * octavePosition[octave];
		}
		
		//something for you to review :)
		private double GetFrequency(string note)
		{
			string[] notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

			int octave = note.Length == 3 ? 
				  int.Parse(note.ToCharArray()[2].ToString())
				: int.Parse(note.ToCharArray()[1].ToString());

			int keyNumber = notes.ToList().IndexOf(note.Substring(0, note.Length - 1));

			if (keyNumber < 3)
			{
				keyNumber = keyNumber + 12 + ((octave - 1) * 12) + 1;
			}
			else
			{
				keyNumber = keyNumber + ((octave - 1) * 12) + 1;
			}

			return 440 * Math.Pow(2, (float)(keyNumber - 49) / 12);
		}
	}
}

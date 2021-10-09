using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
       static void Main(string[] args)  //This is the main function of the program
        {
            //operators:
            /*
             assignment : = : assign value
            arithmetic: + : add values/concatenate strings
                        - : subtract values
                        * : multiply values
                        / : divide values
                        % : modulus: remaining part after division
                        (): normal brackets - demarcate that to be processed first
            order: (brackets) mult/div, add/sub
            relational: == : equal to (for bool func: is)
            //all return a bool value
                        >  : greater than/larger than
                        <  : smaller than
                        >= : greater than/equal to
                        <= : smaller than/equal to
                        != : not equal to (for bool func: is not)
            logical operators: 
                        && : logical and 
                        || : logical or
            unary operators: 
                        +  : unary plus - leaves the sign of the value as is
                        -  : unary minus - inverts the sign of the value
                        ++ : increment - increases value by 1; equivalent to += followed by 1
                        -- : decrement - decreases value by 1; equivalent to -= followed by 1
                        !  : logical negate (not) - inverts a bool value: !true == false will return true 
            ternary operator:
                        ?  : Query condition, return second exp if false, first exp if true
            compound assign operator: 
                        += : addition assignment
                        -= : subtraction assignment
                        *= : multiplication assignment
                        /= : division assignment
                        %= : modulus assignment
                        &= : bitwise and assignment
                        |= : bitwise or assignment
                        ^= : bitwise xor assignment
                       <<= : left shift assignment
                       >>= : right shift assignment
                        => : lambda operator
            conditional:
            --start--
                if (condition is true, if not, skip over)
                    doSomething
            --end if--

            --start if/else--
                if (condition is true, if not, go to else)
                    doSomething
                else
                    doSomethingElse
            --end if/else--
            
            --start else/if--
                if (condition 1 is true, if not, go to else if)
                    doSomething
                else if (condition 2 is true, if not, go to else)
                    doSomethingElse
                else
                    doSomethingElse2
            --end else/if--

            access modifier:
                           public : publicly accessible by all funcs and classes within program
                          private : only accessible within class
                         internal : accessible from all members within same namespace/assembly
                        protected
               protected internal : accessible from subclasses within same assembly

            String builder: can modify existing strings, instantiated with StringBuilder <varName> = new() StringBuilder; assigned a value as with strings.
            It is mutable. ReferenceEquals(string1, string2) comparison func will return true, unlike for string. 
            They are faster than strings for appending multiple strings

                      append: adds values to end of an existing instance
                appendformat: appends formatted string values to end
                      insert: insert string at specified index
                      remove: remove specified range
                     replace: replace existing characters with new ones
                    tostring: convert to string.
            */
            //constant values are variables that have been marked as such
            //such vars are needed for mathematically correct scientific calculations
            //example of such instantiation: const varname = value
            //{string varname:0000} or "string":00000: zero pad, for leading zeros
            //


            Cylinder.Windchime chime1 = new();
            chime1.OuterDiameter = 25 * chime1.GetLengthInMetres();          // in millimetres, will be converted to metres
            chime1.InnerDiameter = 23 * chime1.GetLengthInMetres();          // in millimetres, will be converted to metres
            chime1.Height = 1023.9 * chime1.GetLengthInMetres();             // in millimetres, will be converted to metres
            chime1.MetalType = MetalType.Aluminium;
            chime1.RootFrequency = 432;
            chime1.Octave = 3;
            chime1.NoteName = "A";


            
            Console.WriteLine($"Chime props:");
            Console.WriteLine($"Easticity modulus of {chime1.MetalType}:             {chime1.GetElasticityModulus()} Pascals");
            Console.WriteLine($"Outer Radius:                               {chime1.GetOuterRadius()} m");
            Console.WriteLine($"Wall thickness:                             {chime1.GetWallThickness()} m");
            Console.WriteLine($"Wall volume:                                {chime1.GetWallVolume()} m^3");
            Console.WriteLine($"Length:                                     {chime1.GetHeight()} m");
            Console.WriteLine($"Base area of tube:                          {chime1.GetTubeArea()} m^2");
            Console.WriteLine($"Inner radius:                               {chime1.GetInnerRadius()} m");
            Console.WriteLine($"Mass of equivalent solid bar:               {chime1.GetSolidMass()}  kg");
            Console.WriteLine($"Volume of equivalent solid bar:             {chime1.GetSolidVolume()} m^3");
            Console.WriteLine($"Mass of chime tube:                         {chime1.GetTubeMass()}  kg");
            Console.WriteLine($"Mass Moment of inertia along Z axis:        {chime1.GetZAxisMassMOI()} kg m^2");
            Console.WriteLine($"Mass Moment of inertia along X and Y axis:  {chime1.GetXYAxisMassMOI()} kg m^2");
            Console.WriteLine($"Area Moment of inertia:                     {chime1.GetAreaMOI()} m^4");
            Console.WriteLine($"Wind chime hang point:                      {chime1.GetHangPoint()} m");
            Console.WriteLine($"Speed of sound in chime tube:               {chime1.GetSpeedOfSound()} metres/s");
            Console.WriteLine($"Mass per unit length:                       {chime1.GetMassPerUnitLength()} kg/m");
            //Console.WriteLine($"Frequency of wind chime:                    {chime1.GetFrequency()} - raw value from calculation");
            Console.WriteLine($"Frequency of wind chime:                    {chime1.GetFrequency()} Hertz\n");

            Console.WriteLine("chime length from known frequency: ");

            Console.WriteLine($"Frequency of A4:                            {chime1.RootFrequency} Hertz");
            Console.WriteLine($"Note: {chime1.NoteName} on octave {chime1.Octave}:                        {chime1.GetCurrentNote()} Hz\n");
            Console.WriteLine($"Chime length relative to current note frequency:  {chime1.GetLengthFromFreq()}  metres");
           
        }
    }
    
}

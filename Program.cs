using System;
using System.Collections.Generic;

namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {


            Hacker christine = new Hacker
            {
                Name = "Christine",
                SkillLevel = 50,
                PercentageCut = 20
            };

            Hacker ryan = new Hacker
            {
                Name = "Ryan",
                SkillLevel = 50,
                PercentageCut = 20
            };

            Hacker josh = new Hacker
            {
                Name = "Josh",
                SkillLevel = 50,
                PercentageCut = 20
            };

            Muscle barry = new Muscle
            {
                Name = "Barry",
                SkillLevel = 50,
                PercentageCut = 20
            };

            Muscle christina = new Muscle
            {
                Name = "Christina",
                SkillLevel = 50,
                PercentageCut = 20
            };

            LockSpecialist pazia = new LockSpecialist
            {
                Name = "Pazia",
                SkillLevel = 50,
                PercentageCut = 20
            };

            LockSpecialist chris = new LockSpecialist
            {
                Name = "Chris",
                SkillLevel = 50,
                PercentageCut = 20
            };


            List<IRobber> rolodex = new List<IRobber>()
            {
                christine, ryan, josh, barry, christina, pazia, chris
            };

            BuildYourCrew();

            void BuildYourCrew()
            {

                Console.WriteLine($"Current operatives: {rolodex.Count}");

                Console.WriteLine("Who are you tryna add?");
                string OpName = Console.ReadLine();

                // If the user doesn't enter anything, stop the program.
                if (string.IsNullOrWhiteSpace(OpName))
                {
                    return;
                }

                Console.WriteLine("How are they going to benefit us?");
                Console.WriteLine(@"[1] Hacker (Disables alarms)
[2] Muscle (Disarms guards)
[3] Lock Specialist (Cracks vault)");

                int specialist = Convert.ToInt32(Console.ReadLine());

                if (specialist == 1)
                {
                    Hacker newHacker = new Hacker();
                    newHacker.Name = OpName;

                    Console.WriteLine("Enter the skill level.");
                    newHacker.SkillLevel = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the percentage cut.");
                    newHacker.PercentageCut = Convert.ToInt32(Console.ReadLine());

                    rolodex.Add(newHacker);
                    BuildYourCrew();
                }
                else if (specialist == 2)
                {
                    Muscle newMuscle = new Muscle();
                    newMuscle.Name = OpName;
                    Console.WriteLine("Enter the skill level from 1 to 100.");
                    newMuscle.SkillLevel = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the percentage cut.");
                    newMuscle.PercentageCut = Convert.ToInt32(Console.ReadLine());

                    rolodex.Add(newMuscle);
                    BuildYourCrew();
                }
                else if (specialist == 3)
                {
                    LockSpecialist newLocksmith = new LockSpecialist();
                    newLocksmith.Name = OpName;
                    Console.WriteLine("Enter the skill level.");
                    newLocksmith.SkillLevel = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the percentage cut.");
                    newLocksmith.PercentageCut = Convert.ToInt32(Console.ReadLine());

                    rolodex.Add(newLocksmith);
                    BuildYourCrew();
                }
            }

        }
    }
}

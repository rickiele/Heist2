using System;

namespace Heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int Muscles = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is breaking the security guard's arm! Decreased security by {SkillLevel} points.");
            if (bank.AlarmScore == 0)
            {
                Console.WriteLine($"{Name} has disposed of the security guard.");
            }
            else
            {
                return;
            }

        }


    }
}
using System;

namespace Heist2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int Hacking = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points.");
            if (bank.AlarmScore == 0)
            {
                Console.WriteLine($"{Name} has disable the alarm system!");
            }
            else
            {
                return;
            }

        }


    }
}
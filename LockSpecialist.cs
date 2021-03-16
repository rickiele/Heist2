using System;

namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int LockSkills = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is picking the lock! Decreased security by {SkillLevel} points.");
            if (bank.AlarmScore == 0)
            {
                Console.WriteLine($"{Name} has picked the lock.");
            }
            else
            {
                return;
            }

        }


    }
}
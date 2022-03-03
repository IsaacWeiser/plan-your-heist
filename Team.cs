using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Team
    {
        public List<TeamMember> Roster { get; }

        public Team() {
            Roster = new List<TeamMember>();
        }
        //methods to add members
        public void AddTeamMember(TeamMember person) {
            Roster.Add(person);
        }
       // method to return the list size 
        public int GetTeamSize() {
            return Roster.Count;
        }

        public void DisplayMembersInfo() {
            foreach (TeamMember person in Roster) {
            Console.WriteLine($"Comrade {person.Name} has a skill level of {person.SkillLevel} and a courage factor of {person.CourageFactor}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Team
    {
        private readonly List<IWorker> workers;
        private readonly TeamLeader teamLeader;

        public Team(List<IWorker> workers, TeamLeader teamLeader)
        {
            this.workers = workers;
            this.teamLeader = teamLeader;
        }

        public void BuildHouse(House house)
        {
            foreach (var worker in workers)
            {
                if (!house.IsCompleted())
                {
                    worker.Work(house);
                }
            }
        }
    }
}

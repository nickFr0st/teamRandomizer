using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace teamRandomizer
{
    class TeamMember
    {
        private string name;
        private int position;
        private List<string> neighborList;

        public TeamMember(int position, string name)
        {
            this.position = position;
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getPosition()
        {
            return position;
        }

        public void setPosition(int position)
        {
            this.position = position;
        }

        public List<string> getNeighborList()
        {
            return neighborList;
        }

        public void setNeighborList(List<string> neighborList)
        {
            this.neighborList = neighborList;
        }

    }
}

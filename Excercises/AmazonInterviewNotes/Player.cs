using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonInterviewNotes
{
    class Player
    {
        public Guid playerID;
        public string playerName;
        public double kda;
        public int position;

        public Player(Guid playerID, string playerName, double kda, int position)
        {
            this.playerID = playerID;
            this.playerName = playerName;
            this.kda = kda;
            this.position = position;
        }
    }

    struct ROLE
    {
        public const int TOP = 0;
        public const int JUNGLE = 1;
        public const int MIDDLE = 2;
        public const int ADC = 3;
        public const int SUPPORT = 4;
    }
}

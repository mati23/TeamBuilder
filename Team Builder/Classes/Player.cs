using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Builder.Classes
{
    class Player
    {
        //---------------------------- Player Info
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int NationalityId { get; set; }
        public string DominantFoot { get; set; }
        public int PictureId { get; set; }
        public int StatsId { get; set; }
        //-----------------------------Player Stats
        public int Attack { get; set; }
        public int BallControl { get; set; }
        public int Dribblind { get; set; }
        public int LowPass { get; set; }
        public int LoftedPass { get; set; }
        public int Finishing { get; set; }
        public int Curve { get; set; }
        public int Header { get; set; }
        public int DefensiveSkill { get; set; }
        public int BallWinning { get; set; }
        public int KickPower { get; set; }
        public int Speed { get; set; }
        public int Explosion { get; set; }
        public int BodyStrenght { get; set; }
        public int PhysicalContact { get; set; }
        public int Jump { get; set; }
        public int Goalkeeping { get; set; }
        public int Catching { get; set; }
        public int Clearing { get; set; }
        public int Coverage { get; set; }
        public int Reflexes { get; set; }
        public int Stamina { get; set; }
        public int NDFUsage { get; set; }
        public int NDFPrecision { get; set; }
        public int Condition { get; set; }
        public int InjuryResistence { get; set; }
        public int StatsClubId { get; set; }
        public string StatsPlayerName { get; set; }
        
    }
}

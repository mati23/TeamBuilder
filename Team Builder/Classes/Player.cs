using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Builder.Forms;

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
        public int Attack { get; set; }         //position increaser    
        public int BallControl { get; set; }    //agility
        public int Dribbling { get; set; }      //agility
        public int LowPass { get; set; }        //pass
        public int LoftedPass { get; set; }     //pass
        public int Finishing { get; set; }      //shooting
        public int Curve { get; set; }          //shooting
        public int Header { get; set; }         //shooting
        public int DefensiveSkill { get; set; } //defense
        public int BallWinning { get; set; }    //agility
        public int KickPower { get; set; }      //shooting
        public int Speed { get; set; }          //speed
        public int Explosion { get; set; }      //speed
        public int BodyStrenght { get; set; }   //physical
        public int PhysicalContact { get; set; }//physical
        public int Jump { get; set; }           //physical
        public int Goalkeeping { get; set; }    //defense
        public int Catching { get; set; }       //defense
        public int Clearing { get; set; }       //defense
        public int Coverage { get; set; }       //defense
        public int Reflexes { get; set; }       //defense
        public int Stamina { get; set; }        //physical
        public int NDFUsage { get; set; }       //agility
        public int NDFPrecision { get; set; }   //agility
        public int Condition { get; set; }      //physical
        public int InjuryResistence { get; set; }//physical
        public int StatsClubId { get; set; }
        public string StatsPlayerName { get; set; }

        public void SetPlayerStats(
         int new_Attack,         //position increaser    
         int new_BallControl,    //agility
         int new_Dribbling,      //agility
         int new_LowPass,        //pass
         int new_LoftedPass,     //pass
         int new_Finishing,      //shooting
         int new_Curve,          //shooting
         int new_Header,         //shooting
         int new_DefensiveSkill, //defense
         int new_BallWinning,    //agility
         int new_KickPower,      //shooting
         int new_Speed,          //speed
         int new_Explosion,      //speed
         int new_BodyStrenght,   //physical
         int new_PhysicalContact,//physical
         int new_Jump,           //physical
         int new_Goalkeeping,    //defense
         int new_Catching,       //defense
         int new_Clearing,       //defense
         int new_Coverage,       //defense
         int new_Reflexes,       //defense
         int new_Stamina,        //physical
         int new_NDFUsage,       //agility
         int new_NDFPrecision,   //agility
         int new_Condition,      //physical
         int new_InjuryResistence,//physical
         int new_StatsClubId,
         string new_StatsPlayerName)
        {
            this.Attack = new_Attack;
            this.BallControl = new_BallControl;
            this.Dribbling = new_Dribbling;
            this.LowPass = new_LowPass;
            this.LoftedPass = new_LoftedPass;
            this.Finishing = new_Finishing;
            this.Curve = new_Curve;
            this.Header = new_Header;
            this.DefensiveSkill = new_DefensiveSkill;
            this.BallWinning = new_BallWinning;
            this.KickPower = new_KickPower;
            this.Speed = new_Speed;
            this.Explosion = new_Explosion;
            this.BodyStrenght = new_BodyStrenght;
            this.PhysicalContact = new_PhysicalContact;
            this.Jump = new_Jump;
            this.Goalkeeping = new_Goalkeeping;
            this.Catching = new_Catching;
            this.Clearing = new_Clearing;
            this.Coverage = new_Coverage;
            this.Reflexes = new_Reflexes;
            this.Stamina = new_Stamina;
            this.NDFUsage = new_NDFUsage;
            this.NDFPrecision = new_NDFPrecision;
            this.Condition = new_Condition;
            this.InjuryResistence = new_InjuryResistence; //physical
            this.StatsClubId = new_StatsClubId;
            this.StatsPlayerName = new_StatsPlayerName;
    }
        
        //----------------------------------------------

        //this function will return the mean stats calculated by the arithimetical mean of the 5 main stats
        //of the player.
        public Dictionary<string,float> MeanStats()
        {
            
            float agility = (this.Dribbling +
                            this.BallControl +
                            this.BallWinning +
                            this.NDFUsage +
                            this.NDFPrecision) / 5;
            float physical = (this.BodyStrenght +
                              this.PhysicalContact +
                              this.Jump +
                              this.Stamina+
                              this.InjuryResistence+
                              this.Condition)/6;
            float speed = (this.Speed +
                           this.Explosion
                           ) / 2;
            float defense = (this.DefensiveSkill +
                             this.Goalkeeping +
                             this.Catching +
                             this.Clearing +
                             this.Coverage +
                             this.Reflexes) / 6;
			float shooting = (this.Finishing +
							  this.Curve +
							  this.Header +
							  this.KickPower) / 4;
			float pass = (this.LoftedPass +
						  this.LowPass) / 2;
			
            
            Dictionary<string, float> meanStats = new Dictionary<string, float>
            {
                {"Agility", agility },
                {"Physical", physical },
                {"Speed", speed },
                {"Defense", defense },
				{"Shooting", shooting },
				{"Pass",pass }
            };
            return meanStats;
        }
        
    }
}

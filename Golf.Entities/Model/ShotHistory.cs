// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using Golf.Entities.Model.Map;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Golf.Entities.Enumerations;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Golf.Entities.Model
{
    // ShotHistory
    public partial class ShotHistory : Entity
    {
        public int ShotId { get; set; } // ShotId (Primary key)
        public int Club { get; set; } // Club. Club as enum eg. 1iron=1, 2iron=2, etc. PW=10, SW=11, LW=12, 1W=13,etc.
        public int Distance { get; set; } // Distance. Distance in feet
        public int Lie { get; set; } // Lie. Enum containing placement of the ball eg. (Fairway=1 [default=1], Sand=2, Rough=3, Fringe=4, FirstCut=5, DeepRough=7, TallGrass=8, Water=9, CartPath=10, etc.)
        public int Elevation { get; set; } // Elevation. Elevation of shot to destination (in feet)
        public int WindDirection { get; set; } // WindDirection. Wind direction as integer (0-15) with 0 meaning in your face & 8 meaning at your back
        public int WindCondition { get; set; } // WindCondition. WindConditionEnum (1=No Wind, 2=Breezy, 3=Gusty, 4=Windy)
        public int GreenSpeed { get; set; } // GreenSpeed. Green speed (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public int GreenHardness { get; set; } // GreenHardness. Green hardness (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public int? SwingRatio { get; set; } // SwingRatio. Percent of club to use (0-100)
        public string Notes { get; set; } // Notes

        public ShotHistory()
        {
            Lie = 1;
            Elevation = 0;
            WindDirection = 0;
            WindCondition = 2;
            GreenSpeed = 5;
            GreenHardness = 5;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

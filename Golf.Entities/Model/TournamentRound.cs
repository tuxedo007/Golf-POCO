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
    // TournamentRound
    public partial class TournamentRound : Entity
    {
        public int RoundId { get; set; } // RoundId (Primary key)
        public int TournamentId { get; set; } // TournamentId. Tournament (by TournamentId)
        public int RoundNo { get; set; } // RoundNo. Tournament round for the selected course
        public int CourseId { get; set; } // CourseId. Tournament Course used (by CourseId)
        public bool CutRound { get; set; } // CutRound. Is there a Tournament cut on this round
        public int? RemainingAfterCut { get; set; } // RemainingAfterCut
        public int WindConditions { get; set; } // WindConditions. Wind conditions for round
        public int GreenSpeed { get; set; } // GreenSpeed. Green speed for round
        public int GreenHardness { get; set; } // GreenHardness. Green hardness for round
        public int PinLocation { get; set; } // PinLocation. Pin location for round

        // Foreign keys
        public virtual Course Course { get; set; } // FK_TournamentRound_Course
        public virtual Tournament Tournament { get; set; } // FK_TournamentRound_Tournaments

        public TournamentRound()
        {
            CutRound = false;
            WindConditions = 2;
            GreenSpeed = 5;
            GreenHardness = 5;
            PinLocation = 2;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

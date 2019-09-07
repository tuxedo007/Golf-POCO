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
    // Tournaments
    public partial class Tournament : Entity
    {
        public int TournamentId { get; set; } // TournamentId (Primary key)
        public string TournamentName { get; set; } // TournamentName
        public int? Season { get; set; } // Season
        public DateTime? StartDate { get; set; } // StartDate
        public DateTime? EndDate { get; set; } // EndDate
        public decimal TotalPurse { get; set; } // TotalPurse
        public decimal TopPrize { get; set; } // TopPrize
        public decimal FecPoints { get; set; } // FecPoints
        public int Rounds { get; set; } // Rounds. The number of rounds scheduled for the Tournament
        public int MaximumEntries { get; set; } // MaximumEntries. Maximum entries allowed for the tournament
        public bool Completed { get; set; } // Completed. has Tournament been completed
        public bool Active { get; set; } // Active. The tournament that is currently being simulated (THERE CAN ONLY BE ONE AT A TIME)
        public int Category { get; set; } // Category. Category for the level of the event (1=Playoff,2=Major,3=WGC,4=FEC Standard,5=FEC Minor, 6=Non FEC (Other)
        public string Winner { get; set; } // Winner
        public string Location { get; set; } // Location

        // Reverse navigation
        public virtual ICollection<TournamentEntry> TournamentEntries { get; set; } // TournamentEntries.FK_TournamentEntries_Tournaments
        public virtual ICollection<TournamentRound> TournamentRounds { get; set; } // TournamentRound.FK_TournamentRound_Tournaments

        public Tournament()
        {
            TotalPurse = 0.00m;
            TopPrize = 0.00m;
            FecPoints = 0m;
            Rounds = 4;
            MaximumEntries = 156;
            Completed = false;
            Active = false;
            Category = 0;
            TournamentEntries = new List<TournamentEntry>();
            TournamentRounds = new List<TournamentRound>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

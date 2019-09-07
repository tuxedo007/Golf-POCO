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
    // TournamentEntries
    public partial class TournamentEntry : Entity
    {
        public int EntryId { get; set; } // EntryId (Primary key)
        public int TournamentId { get; set; } // TournamentId. Id of tournament
        public int MemberId { get; set; } // MemberId. Id of Member
        public int Position { get; set; } // Position. Finishing position of member in the tournament
        public int? R1 { get; set; } // R1. Round 1 score
        public int? R2 { get; set; } // R2. Round 2 score
        public int? R3 { get; set; } // R3. Round 3 score
        public int? R4 { get; set; } // R4. Round 4 score
        public int? TotalStrokes { get; set; } // TotalStrokes. Total strokes recorded for the tournament
        public decimal Earnings { get; set; } // Earnings. Prize money awarded
        public decimal FecPoints { get; set; } // FecPoints. FedEx Cup points awarded
        public bool Cut { get; set; } // Cut. Is cut from this Tournament
        public string Player { get; set; } // Player

        // Foreign keys
        public virtual Member Member { get; set; } // FK_TournamentEntries_Members
        public virtual Tournament Tournament { get; set; } // FK_TournamentEntries_Tournaments

        public TournamentEntry()
        {
            Position = 0;
            Earnings = 0.00m;
            FecPoints = 0m;
            Cut = false;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

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
    // MemberStat
    public partial class MemberStat : Entity
    {
        public int StatId { get; set; } // StatId (Primary key)
        public int MemberId { get; set; } // MemberId
        public int Season { get; set; } // Season. The season used for the compiling of the stats
        public int? Ranking { get; set; } // Ranking. Ranking for the season
        public decimal Earnings { get; set; } // Earnings. Earnings for the season
        public decimal FecPoints { get; set; } // FecPoints. FedEx Cup Point count the season
        public int FecRank { get; set; } // FecRank. FedEx Cup ranking
        public int CutCount { get; set; } // CutCount. Numer of events that the member was cut for the season
        public int CutStreak { get; set; } // CutStreak. Longest cut sreak for the member in a season
        public int Wins { get; set; } // Wins. Events won for the season
        public int TopThree { get; set; } // TopThree. Events top three finished (2nd & 3rd placing only)  for the season
        public int TopTen { get; set; } // TopTen. Events top ten finished (4rd thru to 10th placing only)  for the season
        public int Majors { get; set; } // Majors. Major tournamemt wins  for the season
        public int? Strokes { get; set; } // Strokes. Total number of strokes recorded for the season
        public decimal? Average { get; set; } // Average. Members season average
        public int RoundCount { get; set; } // RoundCount. Professional  rounds completed by member for the season
        public int EntryCount { get; set; } // EntryCount. Count of events that the member participated in for the season
        public int? LastEvent { get; set; } // LastEvent. Last event that the member participated in for the season

        // Foreign keys
        public virtual Member Member { get; set; } // FK_MemberStats_Members

        public MemberStat()
        {
            Earnings = 0m;
            FecRank = 0;
            CutCount = 0;
            CutStreak = 0;
            Wins = 0;
            TopThree = 0;
            TopTen = 0;
            Majors = 0;
            RoundCount = 0;
            EntryCount = 0;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

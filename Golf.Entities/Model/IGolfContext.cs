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
    public interface IGolfContext : IDisposable
    {
        IDbSet<Country> Countries { get; set; } // Country
        IDbSet<Course> Courses { get; set; } // Course
        IDbSet<Member> Members { get; set; } // Members
        IDbSet<MemberStat> MemberStats { get; set; } // MemberStat
        IDbSet<PrizeDistribution> PrizeDistributions { get; set; } // PrizeDistribution
        IDbSet<PuttHistory> PuttHistories { get; set; } // PuttHistory
        IDbSet<ShotHistory> ShotHistories { get; set; } // ShotHistory
        IDbSet<Tournament> Tournaments { get; set; } // Tournaments
        IDbSet<TournamentCourseRound> TournamentCourseRounds { get; set; } // TournamentCourseRounds
        IDbSet<TournamentEntry> TournamentEntries { get; set; } // TournamentEntries
        IDbSet<TournamentRound> TournamentRounds { get; set; } // TournamentRound

        int SaveChanges();
        
        // Stored Procedures
    }

}

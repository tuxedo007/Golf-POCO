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
    public partial class GolfContext : DataContext, IGolfContext
    {
        public IDbSet<Country> Countries { get; set; } // Country
        public IDbSet<Course> Courses { get; set; } // Course
        public IDbSet<Member> Members { get; set; } // Members
        public IDbSet<MemberStat> MemberStats { get; set; } // MemberStat
        public IDbSet<PrizeDistribution> PrizeDistributions { get; set; } // PrizeDistribution
        public IDbSet<PuttHistory> PuttHistories { get; set; } // PuttHistory
        public IDbSet<ShotHistory> ShotHistories { get; set; } // ShotHistory
        public IDbSet<Tournament> Tournaments { get; set; } // Tournaments
        public IDbSet<TournamentCourseRound> TournamentCourseRounds { get; set; } // TournamentCourseRounds
        public IDbSet<TournamentEntry> TournamentEntries { get; set; } // TournamentEntries
        public IDbSet<TournamentRound> TournamentRounds { get; set; } // TournamentRound

        static GolfContext()
        {
            Database.SetInitializer<GolfContext>(null);
        }

        public GolfContext()
            : base("Name=GolfContext")
        {
            InitializePartial();
        }

        public GolfContext(string connectionString) : base(connectionString)
        {
            InitializePartial();
        }

        public GolfContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
            InitializePartial();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new MemberStatMap());
            modelBuilder.Configurations.Add(new PrizeDistributionMap());
            modelBuilder.Configurations.Add(new PuttHistoryMap());
            modelBuilder.Configurations.Add(new ShotHistoryMap());
            modelBuilder.Configurations.Add(new TournamentMap());
            modelBuilder.Configurations.Add(new TournamentCourseRoundMap());
            modelBuilder.Configurations.Add(new TournamentEntryMap());
            modelBuilder.Configurations.Add(new TournamentRoundMap());

            OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CountryMap(schema));
            modelBuilder.Configurations.Add(new CourseMap(schema));
            modelBuilder.Configurations.Add(new MemberMap(schema));
            modelBuilder.Configurations.Add(new MemberStatMap(schema));
            modelBuilder.Configurations.Add(new PrizeDistributionMap(schema));
            modelBuilder.Configurations.Add(new PuttHistoryMap(schema));
            modelBuilder.Configurations.Add(new ShotHistoryMap(schema));
            modelBuilder.Configurations.Add(new TournamentMap(schema));
            modelBuilder.Configurations.Add(new TournamentCourseRoundMap(schema));
            modelBuilder.Configurations.Add(new TournamentEntryMap(schema));
            modelBuilder.Configurations.Add(new TournamentRoundMap(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
        
        // Stored Procedures
    }
}

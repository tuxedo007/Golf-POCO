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
    public class FakeGolfContext : IGolfContext
    {
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Course> Courses { get; set; }
        public IDbSet<Member> Members { get; set; }
        public IDbSet<MemberStat> MemberStats { get; set; }
        public IDbSet<PrizeDistribution> PrizeDistributions { get; set; }
        public IDbSet<PuttHistory> PuttHistories { get; set; }
        public IDbSet<ShotHistory> ShotHistories { get; set; }
        public IDbSet<Tournament> Tournaments { get; set; }
        public IDbSet<TournamentCourseRound> TournamentCourseRounds { get; set; }
        public IDbSet<TournamentEntry> TournamentEntries { get; set; }
        public IDbSet<TournamentRound> TournamentRounds { get; set; }

        public FakeGolfContext()
        {
            Countries = new FakeDbSet<Country>();
            Courses = new FakeDbSet<Course>();
            Members = new FakeDbSet<Member>();
            MemberStats = new FakeDbSet<MemberStat>();
            PrizeDistributions = new FakeDbSet<PrizeDistribution>();
            PuttHistories = new FakeDbSet<PuttHistory>();
            ShotHistories = new FakeDbSet<ShotHistory>();
            Tournaments = new FakeDbSet<Tournament>();
            TournamentCourseRounds = new FakeDbSet<TournamentCourseRound>();
            TournamentEntries = new FakeDbSet<TournamentEntry>();
            TournamentRounds = new FakeDbSet<TournamentRound>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException(); 
        }
        
        // Stored Procedures
    }
}

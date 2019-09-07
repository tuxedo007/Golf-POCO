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
    // TournamentCourseRounds
    internal partial class TournamentCourseRoundMap : EntityTypeConfiguration<TournamentCourseRound>
    {
        public TournamentCourseRoundMap(string schema = "dbo")
        {
            ToTable(schema + ".TournamentCourseRounds");
            HasKey(x => new { x.TournamentId, x.RoundNo, x.CourseName, x.CourseId });

            Property(x => x.TournamentId).HasColumnName("TournamentId").IsRequired();
            Property(x => x.TournamentName).HasColumnName("TournamentName").IsOptional().HasMaxLength(500);
            Property(x => x.Season).HasColumnName("Season").IsOptional();
            Property(x => x.RoundNo).HasColumnName("RoundNo").IsRequired();
            Property(x => x.CourseName).HasColumnName("CourseName").IsRequired().HasMaxLength(255);
            Property(x => x.CourseId).HasColumnName("CourseId").IsRequired();
            Property(x => x.PersonalRating).HasColumnName("PersonalRating").IsOptional();
            Property(x => x.UserRating).HasColumnName("UserRating").IsOptional();
            Property(x => x.StartDate).HasColumnName("StartDate").IsOptional();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

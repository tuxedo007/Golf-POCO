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
    internal partial class TournamentRoundMap : EntityTypeConfiguration<TournamentRound>
    {
        public TournamentRoundMap(string schema = "dbo")
        {
            ToTable(schema + ".TournamentRound");
            HasKey(x => x.RoundId);

            Property(x => x.RoundId).HasColumnName("RoundId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TournamentId).HasColumnName("TournamentId").IsRequired();
            Property(x => x.RoundNo).HasColumnName("RoundNo").IsRequired();
            Property(x => x.CourseId).HasColumnName("CourseId").IsRequired();
            Property(x => x.CutRound).HasColumnName("CutRound").IsRequired();
            Property(x => x.RemainingAfterCut).HasColumnName("RemainingAfterCut").IsOptional();
            Property(x => x.WindConditions).HasColumnName("WindConditions").IsRequired();
            Property(x => x.GreenSpeed).HasColumnName("GreenSpeed").IsRequired();
            Property(x => x.GreenHardness).HasColumnName("GreenHardness").IsRequired();
            Property(x => x.PinLocation).HasColumnName("PinLocation").IsRequired();

            // Foreign keys
            HasRequired(a => a.Tournament).WithMany(b => b.TournamentRounds).HasForeignKey(c => c.TournamentId); // FK_TournamentRound_Tournaments
            HasRequired(a => a.Course).WithMany(b => b.TournamentRounds).HasForeignKey(c => c.CourseId); // FK_TournamentRound_Course
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

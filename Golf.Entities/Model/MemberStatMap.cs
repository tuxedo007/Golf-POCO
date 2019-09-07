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
    internal partial class MemberStatMap : EntityTypeConfiguration<MemberStat>
    {
        public MemberStatMap(string schema = "dbo")
        {
            ToTable(schema + ".MemberStat");
            HasKey(x => x.StatId);

            Property(x => x.StatId).HasColumnName("StatId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MemberId).HasColumnName("MemberId").IsRequired();
            Property(x => x.Season).HasColumnName("Season").IsRequired();
            Property(x => x.Ranking).HasColumnName("Ranking").IsOptional();
            Property(x => x.Earnings).HasColumnName("Earnings").IsRequired().HasPrecision(12,2);
            Property(x => x.FecPoints).HasColumnName("FecPoints").IsRequired().HasPrecision(10,2);
            Property(x => x.FecRank).HasColumnName("FecRank").IsRequired();
            Property(x => x.CutCount).HasColumnName("CutCount").IsRequired();
            Property(x => x.CutStreak).HasColumnName("CutStreak").IsRequired();
            Property(x => x.Wins).HasColumnName("Wins").IsRequired();
            Property(x => x.TopThree).HasColumnName("TopThree").IsRequired();
            Property(x => x.TopTen).HasColumnName("TopTen").IsRequired();
            Property(x => x.Majors).HasColumnName("Majors").IsRequired();
            Property(x => x.Strokes).HasColumnName("Strokes").IsOptional();
            Property(x => x.Average).HasColumnName("Average").IsOptional().HasPrecision(5,2);
            Property(x => x.RoundCount).HasColumnName("RoundCount").IsRequired();
            Property(x => x.EntryCount).HasColumnName("EntryCount").IsRequired();
            Property(x => x.LastEvent).HasColumnName("LastEvent").IsOptional();

            // Foreign keys
            HasRequired(a => a.Member).WithMany(b => b.MemberStats).HasForeignKey(c => c.MemberId); // FK_MemberStats_Members
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

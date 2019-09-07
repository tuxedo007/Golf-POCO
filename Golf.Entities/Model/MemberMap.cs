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
    // Members
    internal partial class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap(string schema = "dbo")
        {
            ToTable(schema + ".Members");
            HasKey(x => x.MemberId);

            Property(x => x.MemberId).HasColumnName("MemberId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Lastname).HasColumnName("Lastname").IsRequired().HasMaxLength(50);
            Property(x => x.Firstname).HasColumnName("Firstname").IsRequired().HasMaxLength(20);
            Property(x => x.CountryName).HasColumnName("CountryName").IsOptional().HasMaxLength(30);
            Property(x => x.CountryId).HasColumnName("CountryId").IsRequired();
            Property(x => x.Ranking).HasColumnName("Ranking").IsOptional();
            Property(x => x.Earnings).HasColumnName("Earnings").IsRequired().HasPrecision(18,2);
            Property(x => x.FecPoints).HasColumnName("FecPoints").IsRequired().HasPrecision(10,2);
            Property(x => x.FecRank).HasColumnName("FecRank").IsOptional();
            Property(x => x.CutCount).HasColumnName("CutCount").IsRequired();
            Property(x => x.CutStreak).HasColumnName("CutStreak").IsRequired();
            Property(x => x.Wins).HasColumnName("Wins").IsRequired();
            Property(x => x.TopThree).HasColumnName("TopThree").IsRequired();
            Property(x => x.TopTen).HasColumnName("TopTen").IsRequired();
            Property(x => x.Majors).HasColumnName("Majors").IsRequired();
            Property(x => x.Strokes).HasColumnName("Strokes").IsOptional();
            Property(x => x.Average).HasColumnName("Average").IsOptional().HasPrecision(8,4);
            Property(x => x.RoundCount).HasColumnName("RoundCount").IsRequired();
            Property(x => x.EntryCount).HasColumnName("EntryCount").IsOptional();
            Property(x => x.LastEvent).HasColumnName("LastEvent").IsOptional();
            Property(x => x.Active).HasColumnName("Active").IsRequired();
            Property(x => x.Simulated).HasColumnName("Simulated").IsRequired();
            Property(x => x.ImagePath).HasColumnName("ImagePath").IsOptional().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.Country).WithMany(b => b.Members).HasForeignKey(c => c.CountryId); // FK_Members_Country
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

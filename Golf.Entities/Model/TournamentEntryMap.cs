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
    internal partial class TournamentEntryMap : EntityTypeConfiguration<TournamentEntry>
    {
        public TournamentEntryMap(string schema = "dbo")
        {
            ToTable(schema + ".TournamentEntries");
            HasKey(x => x.EntryId);

            Property(x => x.EntryId).HasColumnName("EntryId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TournamentId).HasColumnName("TournamentId").IsRequired();
            Property(x => x.MemberId).HasColumnName("MemberId").IsRequired();
            Property(x => x.Position).HasColumnName("Position").IsRequired();
            Property(x => x.R1).HasColumnName("R1").IsOptional();
            Property(x => x.R2).HasColumnName("R2").IsOptional();
            Property(x => x.R3).HasColumnName("R3").IsOptional();
            Property(x => x.R4).HasColumnName("R4").IsOptional();
            Property(x => x.TotalStrokes).HasColumnName("TotalStrokes").IsOptional();
            Property(x => x.Earnings).HasColumnName("Earnings").IsRequired().HasPrecision(18,2);
            Property(x => x.FecPoints).HasColumnName("FecPoints").IsRequired().HasPrecision(10,2);
            Property(x => x.Cut).HasColumnName("Cut").IsRequired();
            Property(x => x.Player).HasColumnName("Player").IsOptional().HasMaxLength(70);

            // Foreign keys
            HasRequired(a => a.Tournament).WithMany(b => b.TournamentEntries).HasForeignKey(c => c.TournamentId); // FK_TournamentEntries_Tournaments
            HasRequired(a => a.Member).WithMany(b => b.TournamentEntries).HasForeignKey(c => c.MemberId); // FK_TournamentEntries_Members
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

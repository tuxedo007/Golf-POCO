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
    // Tournaments
    internal partial class TournamentMap : EntityTypeConfiguration<Tournament>
    {
        public TournamentMap(string schema = "dbo")
        {
            ToTable(schema + ".Tournaments");
            HasKey(x => x.TournamentId);

            Property(x => x.TournamentId).HasColumnName("TournamentId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TournamentName).HasColumnName("TournamentName").IsOptional().HasMaxLength(500);
            Property(x => x.Season).HasColumnName("Season").IsOptional();
            Property(x => x.StartDate).HasColumnName("StartDate").IsOptional();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.TotalPurse).HasColumnName("TotalPurse").IsRequired().HasPrecision(18,2);
            Property(x => x.TopPrize).HasColumnName("TopPrize").IsRequired().HasPrecision(18,2);
            Property(x => x.FecPoints).HasColumnName("FecPoints").IsRequired().HasPrecision(10,2);
            Property(x => x.Rounds).HasColumnName("Rounds").IsRequired();
            Property(x => x.MaximumEntries).HasColumnName("MaximumEntries").IsRequired();
            Property(x => x.Completed).HasColumnName("Completed").IsRequired();
            Property(x => x.Active).HasColumnName("Active").IsRequired();
            Property(x => x.Category).HasColumnName("Category").IsRequired();
            Property(x => x.Winner).HasColumnName("Winner").IsOptional().HasMaxLength(50);
            Property(x => x.Location).HasColumnName("Location").IsOptional().HasMaxLength(100);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

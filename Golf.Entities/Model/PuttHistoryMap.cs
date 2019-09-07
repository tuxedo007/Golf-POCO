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
    // PuttHistory
    internal partial class PuttHistoryMap : EntityTypeConfiguration<PuttHistory>
    {
        public PuttHistoryMap(string schema = "dbo")
        {
            ToTable(schema + ".PuttHistory");
            HasKey(x => x.PuttId);

            Property(x => x.PuttId).HasColumnName("PuttId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Distance).HasColumnName("Distance").IsRequired();
            Property(x => x.Elevation).HasColumnName("Elevation").IsRequired();
            Property(x => x.SwingRatio).HasColumnName("SwingRatio").IsOptional();
            Property(x => x.GreenSpeed).HasColumnName("GreenSpeed").IsRequired();
            Property(x => x.GreenHardness).HasColumnName("GreenHardness").IsRequired();
            Property(x => x.Notes).HasColumnName("Notes").IsOptional().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

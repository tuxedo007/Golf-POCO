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
    // PrizeDistribution
    internal partial class PrizeDistributionMap : EntityTypeConfiguration<PrizeDistribution>
    {
        public PrizeDistributionMap(string schema = "dbo")
        {
            ToTable(schema + ".PrizeDistribution");
            HasKey(x => x.PrizeId);

            Property(x => x.PrizeId).HasColumnName("PrizeId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Position).HasColumnName("Position").IsRequired();
            Property(x => x.Category).HasColumnName("Category").IsRequired();
            Property(x => x.FecPoints).HasColumnName("FecPoints").IsRequired().HasPrecision(8,2);
            Property(x => x.DistributionPercentage).HasColumnName("DistributionPercentage").IsRequired().HasPrecision(18,6);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

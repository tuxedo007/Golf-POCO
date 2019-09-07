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
    // Country
    internal partial class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap(string schema = "dbo")
        {
            ToTable(schema + ".Country");
            HasKey(x => x.CountryId);

            Property(x => x.CountryId).HasColumnName("CountryId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasMaxLength(50);
            Property(x => x.Code2).HasColumnName("Code2").IsOptional().HasMaxLength(2);
            Property(x => x.Code3).HasColumnName("Code3").IsOptional().HasMaxLength(3);
            Property(x => x.Flag32).HasColumnName("Flag32").IsOptional().HasMaxLength(20);
            Property(x => x.Flag128).HasColumnName("Flag128").IsOptional().HasMaxLength(20);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

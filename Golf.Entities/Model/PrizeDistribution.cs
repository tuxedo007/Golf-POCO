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
    public partial class PrizeDistribution : Entity
    {
        public int PrizeId { get; set; } // PrizeId (Primary key)
        public int Position { get; set; } // Position
        public int Category { get; set; } // Category. Category for the level of the event (1=Playoff,2=Major,3=WGC,4=FEC Standard,5=FEC Minor, 6=Non FEC (Other) [TouramentCategoryEnum value]
        public decimal FecPoints { get; set; } // FecPoints
        public decimal DistributionPercentage { get; set; } // DistributionPercentage
    }

}

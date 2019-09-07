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
    public partial class PuttHistory : Entity
    {
        public int PuttId { get; set; } // PuttId (Primary key)
        public int Distance { get; set; } // Distance. Length of putt (in feet)
        public int Elevation { get; set; } // Elevation. Elevation to thr destination of the shot (in inches)
        public int? SwingRatio { get; set; } // SwingRatio. Percentage of swing to use
        public int GreenSpeed { get; set; } // GreenSpeed. Green speed (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public int GreenHardness { get; set; } // GreenHardness. Green hardness (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public string Notes { get; set; } // Notes

        public PuttHistory()
        {
            Elevation = 0;
            GreenSpeed = 5;
            GreenHardness = 5;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

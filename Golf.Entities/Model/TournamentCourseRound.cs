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
    // TournamentCourseRounds
    public partial class TournamentCourseRound : Entity
    {
        public int TournamentId { get; set; } // TournamentId
        public string TournamentName { get; set; } // TournamentName
        public int? Season { get; set; } // Season
        public int RoundNo { get; set; } // RoundNo
        public string CourseName { get; set; } // CourseName
        public int CourseId { get; set; } // CourseId
        public int? PersonalRating { get; set; } // PersonalRating
        public double? UserRating { get; set; } // UserRating
        public DateTime? StartDate { get; set; } // StartDate
        public DateTime? EndDate { get; set; } // EndDate
    }

}

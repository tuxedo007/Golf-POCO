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
    // Course
    public partial class Course : Entity
    {
        public int CourseId { get; set; } // CourseId (Primary key)
        public string CourseName { get; set; } // CourseName
        public string Location { get; set; } // Location. Course location
        public string CourseType { get; set; } // CourseType. Real of Fictional course
        public string Designer { get; set; } // Designer. using Arnold Palmer Course Designer (APCD) or Microsoft release (MS)
        public int? DesignId { get; set; } // DesignId. LinksCorner Design Id
        public string DesignerName { get; set; } // DesignerName. Name of APCD designer
        public int? Yardage { get; set; } // Yardage. Yardage of golf course
        public int Par { get; set; } // Par. Golf course par
        public double? Difficulty { get; set; } // Difficulty. Difficulty in comparison with course par  (< 1 = easier than par; > 1 = harder than par)
        public int WindCondition { get; set; } // WindCondition. Default wind condition (unless specifed in TournamentCourses table)
        public int GreenSpeed { get; set; } // GreenSpeed. Default green speed (unless specifed in TournamentCourses table)
        public int GreenHardness { get; set; } // GreenHardness. Default green hardness (unless specifed in TournamentCourses table)
        public int PinLocation { get; set; } // PinLocation. Default pin location (unless specifed in TournamentCourses table)
        public int? PersonalRating { get; set; } // PersonalRating. personal rating as percent
        public double? UserRating { get; set; } // UserRating. LinksCorner user rating as percent
        public int? BestRoundScore { get; set; } // BestRoundScore. Personal best round

        // Reverse navigation
        public virtual ICollection<TournamentRound> TournamentRounds { get; set; } // TournamentRound.FK_TournamentRound_Course

        public Course()
        {
            Par = 72;
            WindCondition = 2;
            GreenSpeed = 5;
            GreenHardness = 5;
            PinLocation = 2;
            TournamentRounds = new List<TournamentRound>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

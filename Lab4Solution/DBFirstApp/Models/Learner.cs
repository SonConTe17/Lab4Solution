using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBFirstApp.Models;

public partial class Learner
{
    public int LearnerId { get; set; }

    public string? LastName { get; set; }

    public string? FirstMidName { get; set; }

    public DateTime EnrollmentDate { get; set; }

    [Display(Name = "Major")]
    public int MajorId { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    // Scaffold sinh ra "Major Major = null!" -> .NET 8 coi là bắt buộc nên form Create/Edit
    // luôn báo lỗi "The Major field is required". Đổi thành nullable để chạy được.
    public virtual Major? Major { get; set; }
}

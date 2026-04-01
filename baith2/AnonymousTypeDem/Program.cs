class Program
{
    static void Main()
    {
        // ===== DỮ LIỆU MẪU =====
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "An", Class = "CTK42" },
            new Student { Id = 2, Name = "Bình", Class = "CTK42" },
            new Student { Id = 3, Name = "Chi", Class = "CTK43" }
        };

        var courses = new List<Course>
        {
            new Course { Id = 1, Name = "Lập trình C#", Credits = 3 },
            new Course { Id = 2, Name = "Cơ sở dữ liệu", Credits = 4 }
        };

        var scores = new List<Score>
        {
            new Score { StudentId = 1, CourseId = 1, Value = 8.5 },
            new Score { StudentId = 1, CourseId = 2, Value = 7.0 },
            new Score { StudentId = 2, CourseId = 1, Value = 9.0 },
            new Score { StudentId = 3, CourseId = 2, Value = 6.5 }
        };



        // ===== YÊU CẦU 1: GPA mỗi sinh viên =====
        var gpaResult = scores
            .GroupBy(s => s.StudentId)
            .Select(g => new
            {
                StudentId = g.Key,
                GPA = g.Average(x => x.Value)
            });
        // In kết quả GPA
        Console.WriteLine("GPA MỖI SINH VIÊN:");
        foreach (var item in gpaResult)
        {
            Console.WriteLine($"StudentId: {item.StudentId}, GPA: {item.GPA}");
        }

        var list = gpaResult.ToList();
        Console.WriteLine("\nGPA MỖI SINH VIÊN(method 2):");
        foreach (var item in list)
        {
            Console.WriteLine($"StudentId: {item.StudentId}, GPA: {item.GPA}");
        }

        // ===== YÊU CẦU 2: GPA >= 8.0 =====
        Console.WriteLine("\n SINH VIÊN GPA >= 8.0:");
        var excellentStudents = gpaResult.Where(x => x.GPA >= 8.0);

        foreach (var item in excellentStudents)
        {
            Console.WriteLine($"StudentId: {item.StudentId}, GPA: {item.GPA}");
        }

        // ===== YÊU CẦU 3: Join nhiều bảng =====
        Console.WriteLine("\nĐIỂM CHI TIẾT:");
        var detailQuery =
            from s in students
            join sc in scores on s.Id equals sc.StudentId
            join c in courses on sc.CourseId equals c.Id
            select new
            {
                StudentName = s.Name,
                CourseName = c.Name,
                Score = sc.Value
            };

        foreach (var item in detailQuery)
        {
            Console.WriteLine($"{item.StudentName} - {item.CourseName} - {item.Score}");
        }

        // ===== YÊU CẦU 4: Thống kê theo lớp =====
        Console.WriteLine("\nTHỐNG KÊ THEO LỚP:");
        var classReport =
            from st in students
            join sc in scores on st.Id equals sc.StudentId
            group sc by st.Class into g
            select new
            {
                ClassName = g.Key,
                AvgGPA = g.Average(x => x.Value),
                StudentCount = g.Select(x => x.StudentId).Distinct().Count()
            };

        foreach (var item in classReport)
        {
            Console.WriteLine($"Lớp: {item.ClassName}, GPA TB: {item.AvgGPA}, Số SV: {item.StudentCount}");
        }

        // ===== YÊU CẦU 5: Top 3 GPA =====
        Console.WriteLine("\nTOP 3 GPA CAO NHẤT:");
        var topStudents = gpaResult
            .OrderByDescending(x => x.GPA)
            .Take(3);

        foreach (var item in topStudents)
        {
            Console.WriteLine($"StudentId: {item.StudentId}, GPA: {item.GPA}");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using RecruitmentSystem.DataAccessLayer.Models;

namespace RecruitmentSystem.DataAccessLayer
{
    internal class RecruitmentSystemDbContext: DbContext
    {
        public RecruitmentSystemDbContext(DbContextOptions<RecruitmentSystemDbContext> options) : base(options)
        {

        }
        //Tables->dbsets
        public DbSet<Application_Form> Applicantion_Forms { get; set; }
        public DbSet<Candidant> Candidants { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Interviewer> Interviewer { get; set; }
        public DbSet<Job_Position> Job_Positions { get; set; }
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<Rejection_Reason> Rejection_Reasons { get; set; }
        public DbSet<User> User { get; set; }

        //override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-V9VKB4M\\DEPI2025;Initial Catalog=Recruitment_SysDB;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration Relationships
            modelBuilder.Entity<Application_Form>()
                .HasMany(ex => ex.Exams)
                .WithOne(app => app.Application_Form)
                .HasForeignKey(app => app.Application_ID);
            //=================
            modelBuilder.Entity<Application_Form>()
                .HasMany(v => v.Interviews)
                .WithOne(app => app.Application_Form)
                .HasForeignKey(app => app.Application_id);
            //==================
            modelBuilder.Entity<Country>()
                .HasMany(cty => cty.Cities)
                .WithOne(cntry => cntry.Country)
                .HasForeignKey(cntry => cntry.Country_ID);


            //create unique email
            modelBuilder.Entity<Employee>().HasIndex(e => e.Email).IsUnique();
            //data seek
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Country_id = 1,
                    Name = "Egypt",
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    Active = true
                },
                new Country
                {
                    Country_id = 2,
                    Name = "USA",
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    Active = true
                }
                );
        }

    }
}

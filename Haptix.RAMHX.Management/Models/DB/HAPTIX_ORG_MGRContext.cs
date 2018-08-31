using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class HAPTIX_ORG_MGRContext : DbContext
    {
        public virtual DbSet<AppAcademicYear> AppAcademicYear { get; set; }
        public virtual DbSet<AppAttendance> AppAttendance { get; set; }
        public virtual DbSet<AppAttendanceType> AppAttendanceType { get; set; }
        public virtual DbSet<AppClass> AppClass { get; set; }
        public virtual DbSet<AppClassDivision> AppClassDivision { get; set; }
        public virtual DbSet<AppClassFeesStructure> AppClassFeesStructure { get; set; }
        public virtual DbSet<AppClassSubject> AppClassSubject { get; set; }
        public virtual DbSet<AppFeesPayment> AppFeesPayment { get; set; }
        public virtual DbSet<AppFeesType> AppFeesType { get; set; }
        public virtual DbSet<AppHolidayCalendar> AppHolidayCalendar { get; set; }
        public virtual DbSet<AppHostel> AppHostel { get; set; }
        public virtual DbSet<AppHostelRoom> AppHostelRoom { get; set; }
        public virtual DbSet<AppHostelType> AppHostelType { get; set; }
        public virtual DbSet<AppLeaveApplication> AppLeaveApplication { get; set; }
        public virtual DbSet<AppLeaveApplicationDay> AppLeaveApplicationDay { get; set; }
        public virtual DbSet<AppOrganization> AppOrganization { get; set; }
        public virtual DbSet<AppOrganizationDepartment> AppOrganizationDepartment { get; set; }
        public virtual DbSet<AppOrganizationSubscription> AppOrganizationSubscription { get; set; }
        public virtual DbSet<AppStudentClass> AppStudentClass { get; set; }
        public virtual DbSet<AppStudentExam> AppStudentExam { get; set; }
        public virtual DbSet<AppStudentExamType> AppStudentExamType { get; set; }
        public virtual DbSet<AppStudentFeesStructure> AppStudentFeesStructure { get; set; }
        public virtual DbSet<AppStudentResult> AppStudentResult { get; set; }
        public virtual DbSet<AppSubject> AppSubject { get; set; }
        public virtual DbSet<AppTimeTable> AppTimeTable { get; set; }
        public virtual DbSet<AppTimeTableType> AppTimeTableType { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<AppUserPermission> AppUserPermission { get; set; }
        public virtual DbSet<AppUserTask> AppUserTask { get; set; }
        public virtual DbSet<AppUserType> AppUserType { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<MstCity> MstCity { get; set; }
        public virtual DbSet<MstCountry> MstCountry { get; set; }
        public virtual DbSet<MstPermission> MstPermission { get; set; }
        public virtual DbSet<MstPermissionsGroup> MstPermissionsGroup { get; set; }
        public virtual DbSet<MstState> MstState { get; set; }
        public virtual DbSet<MstSubscription> MstSubscription { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=SOURCEVED01\MSSQL2016;Database= HAPTIX_ORG_MGR; User ID=sa; Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppAcademicYear>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndMonth).HasColumnType("date");

                entity.Property(e => e.EndYear).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartMonth).HasColumnType("date");

                entity.Property(e => e.StartYear).HasColumnType("date");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppAcademicYear)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAcadem__OrgId__68487DD7");
            });

            modelBuilder.Entity<AppAttendance>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.AttendenceDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppAttendance)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAttend__Acade__3493CFA7");

                entity.HasOne(d => d.AttType)
                    .WithMany(p => p.AppAttendance)
                    .HasForeignKey(d => d.AttTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAttend__AttTy__30C33EC3");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppAttendance)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAttend__OrgId__339FAB6E");

                entity.HasOne(d => d.TakenByUser)
                    .WithMany(p => p.AppAttendanceTakenByUser)
                    .HasForeignKey(d => d.TakenByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAttend__Taken__32AB8735");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppAttendanceUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAttend__UserI__31B762FC");
            });

            modelBuilder.Entity<AppAttendanceType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppAttendanceType)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAttend__Acade__2CF2ADDF");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppAttendanceType)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppAttend__OrgId__2BFE89A6");
            });

            modelBuilder.Entity<AppClass>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppClass)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClass__Academ__71D1E811");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppClass)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClass__OrgId__70DDC3D8");
            });

            modelBuilder.Entity<AppClassDivision>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppClassDivision)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassD__Acade__778AC167");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppClassDivision)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassD__Class__75A278F5");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppClassDivision)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassD__OrgId__76969D2E");
            });

            modelBuilder.Entity<AppClassFeesStructure>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppClassFeesStructure)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassF__Acade__17F790F9");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppClassFeesStructure)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassF__Class__151B244E");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppClassFeesStructure)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassF__Divis__160F4887");

                entity.HasOne(d => d.FeesType)
                    .WithMany(p => p.AppClassFeesStructure)
                    .HasForeignKey(d => d.FeesTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassF__FeesT__14270015");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppClassFeesStructure)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassF__OrgId__17036CC0");
            });

            modelBuilder.Entity<AppClassSubject>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppClassSubject)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassS__Acade__0B91BA14");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppClassSubject)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassS__Class__07C12930");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppClassSubject)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassS__Divis__08B54D69");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppClassSubject)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassS__OrgId__0A9D95DB");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.AppClassSubject)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppClassS__Subje__09A971A2");
            });

            modelBuilder.Entity<AppFeesPayment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppFeesPayment)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppFeesPa__Acade__282DF8C2");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppFeesPayment)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppFeesPa__Class__245D67DE");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppFeesPayment)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppFeesPa__Divis__2645B050");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppFeesPayment)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppFeesPa__OrgId__2739D489");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.AppFeesPayment)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppFeesPa__Stude__25518C17");
            });

            modelBuilder.Entity<AppFeesType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppFeesType)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppFeesTy__Acade__10566F31");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppFeesType)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppFeesTy__OrgId__0F624AF8");
            });

            modelBuilder.Entity<AppHolidayCalendar>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppHolidayCalendar)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppHolida__Acade__6D0D32F4");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppHolidayCalendar)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppHolida__OrgId__6C190EBB");
            });

            modelBuilder.Entity<AppHostel>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Contactno).HasMaxLength(10);

                entity.Property(e => e.HostelAddress).HasMaxLength(1500);

                entity.Property(e => e.HostelName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HtypeId).HasColumnName("HTypeId");

                entity.Property(e => e.WardenContactno).HasMaxLength(10);

                entity.Property(e => e.WardenName).HasMaxLength(101);

                entity.HasOne(d => d.Htype)
                    .WithMany(p => p.AppHostel)
                    .HasForeignKey(d => d.HtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppHostel__HType__4F7CD00D");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppHostel)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppHostel__OrgId__5070F446");
            });

            modelBuilder.Entity<AppHostelRoom>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Cost).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.FloorName).HasMaxLength(100);

                entity.Property(e => e.RoomNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Hostel)
                    .WithMany(p => p.AppHostelRoom)
                    .HasForeignKey(d => d.HostelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppHostel__Hoste__5441852A");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppHostelRoom)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppHostel__OrgId__5535A963");
            });

            modelBuilder.Entity<AppHostelType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppHostelType)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppHostel__OrgId__4BAC3F29");
            });

            modelBuilder.Entity<AppLeaveApplication>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaskDescription)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppLeaveApplication)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppLeaveA__Acade__43D61337");

                entity.HasOne(d => d.ApprovedByUser)
                    .WithMany(p => p.AppLeaveApplicationApprovedByUser)
                    .HasForeignKey(d => d.ApprovedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppLeaveA__Appro__41EDCAC5");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppLeaveApplication)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppLeaveA__OrgId__42E1EEFE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppLeaveApplicationUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppLeaveA__UserI__40F9A68C");
            });

            modelBuilder.Entity<AppLeaveApplicationDay>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HalfPeriod)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppLeaveApplicationDay)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppLeaveA__Acade__498EEC8D");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppLeaveApplicationDay)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppLeaveA__OrgId__489AC854");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppLeaveApplicationDay)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppLeaveA__UserI__47A6A41B");
            });

            modelBuilder.Entity<AppOrganization>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BackgroundImagePath).HasMaxLength(1500);

                entity.Property(e => e.Code).HasColumnType("char(3)");

                entity.Property(e => e.DomainName).HasMaxLength(500);

                entity.Property(e => e.Logo).HasMaxLength(3000);

                entity.Property(e => e.OrganizationAddress).HasMaxLength(1500);

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Website).HasMaxLength(100);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AppOrganization)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__AppOrgani__CityI__38996AB5");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AppOrganization)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__AppOrgani__Count__3A81B327");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.AppOrganization)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__AppOrgani__State__398D8EEE");
            });

            modelBuilder.Entity<AppOrganizationDepartment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppOrganizationDepartment)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppOrgani__OrgId__3E52440B");
            });

            modelBuilder.Entity<AppOrganizationSubscription>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Cost).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.PlanName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppOrganizationSubscription)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppOrgani__OrgId__6383C8BA");

                entity.HasOne(d => d.Subscribe)
                    .WithMany(p => p.AppOrganizationSubscription)
                    .HasForeignKey(d => d.SubscribeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppOrgani__Subsc__6477ECF3");
            });

            modelBuilder.Entity<AppStudentClass>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.RollNo).HasMaxLength(50);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppStudentClass)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Acade__7F2BE32F");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppStudentClass)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Class__7B5B524B");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppStudentClass)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Divis__7C4F7684");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppStudentClass)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__OrgId__7E37BEF6");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.AppStudentClass)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Stude__7D439ABD");
            });

            modelBuilder.Entity<AppStudentExam>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.ExamDate).HasColumnType("datetime");

                entity.Property(e => e.PaperFile).HasMaxLength(2500);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppStudentExam)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Acade__6442E2C9");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppStudentExam)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Class__625A9A57");

                entity.HasOne(d => d.ExamType)
                    .WithMany(p => p.AppStudentExam)
                    .HasForeignKey(d => d.ExamTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__ExamT__607251E5");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppStudentExam)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__OrgId__634EBE90");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.AppStudentExam)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Subje__6166761E");
            });

            modelBuilder.Entity<AppStudentExamType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppStudentExamType)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Acade__5CA1C101");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppStudentExamType)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__OrgId__5BAD9CC8");
            });

            modelBuilder.Entity<AppStudentFeesStructure>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppStudentFeesStructure)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Acade__208CD6FA");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppStudentFeesStructure)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Class__1CBC4616");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppStudentFeesStructure)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Divis__1EA48E88");

                entity.HasOne(d => d.FeesType)
                    .WithMany(p => p.AppStudentFeesStructure)
                    .HasForeignKey(d => d.FeesTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__FeesT__1BC821DD");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppStudentFeesStructure)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__OrgId__1F98B2C1");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.AppStudentFeesStructure)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Stude__1DB06A4F");
            });

            modelBuilder.Entity<AppStudentResult>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.PaperFile).HasMaxLength(2500);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppStudentResult)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Acade__6DCC4D03");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppStudentResult)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Class__6BE40491");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppStudentResult)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Divis__6AEFE058");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.AppStudentResult)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__ExamI__6EC0713C");

                entity.HasOne(d => d.Inspector)
                    .WithMany(p => p.AppStudentResultInspector)
                    .HasForeignKey(d => d.InspectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Inspe__690797E6");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppStudentResult)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__OrgId__6CD828CA");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.AppStudentResult)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__Subje__69FBBC1F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppStudentResultUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppStuden__UserI__681373AD");
            });

            modelBuilder.Entity<AppSubject>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubjectCode)
                    .IsRequired()
                    .HasColumnType("char(5)");

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppSubject)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppSubjec__Acade__03F0984C");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppSubject)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppSubjec__OrgId__02FC7413");
            });

            modelBuilder.Entity<AppTimeTable>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppTimeTable)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__Acade__57DD0BE4");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppTimeTable)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__Class__540C7B00");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppTimeTable)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__Divis__55009F39");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppTimeTable)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__OrgId__56E8E7AB");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.AppTimeTable)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__Subje__531856C7");

                entity.HasOne(d => d.TeacherUser)
                    .WithMany(p => p.AppTimeTable)
                    .HasForeignKey(d => d.TeacherUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__Teach__55F4C372");

                entity.HasOne(d => d.Timetbl)
                    .WithMany(p => p.AppTimeTable)
                    .HasForeignKey(d => d.TimetblId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__Timet__5224328E");
            });

            modelBuilder.Entity<AppTimeTableType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppTimeTableType)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__Acade__4E53A1AA");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppTimeTableType)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTimeTa__OrgId__4D5F7D71");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateOfJoin).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FatherMobile).HasMaxLength(20);

                entity.Property(e => e.FatherName).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.HfatherName)
                    .HasColumnName("HFatherName")
                    .HasMaxLength(150);

                entity.Property(e => e.HfirstName)
                    .HasColumnName("HFirstName")
                    .HasMaxLength(150);

                entity.Property(e => e.HlastName)
                    .HasColumnName("HLastName")
                    .HasMaxLength(150);

                entity.Property(e => e.HmiddleName)
                    .HasColumnName("HMiddleName")
                    .HasMaxLength(150);

                entity.Property(e => e.HmotherName)
                    .HasColumnName("HMotherName")
                    .HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.MiddleName).HasMaxLength(150);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.MotherMobile).HasMaxLength(20);

                entity.Property(e => e.MotherName).HasMaxLength(150);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PinCode).HasColumnType("char(6)");

                entity.Property(e => e.ProfileImagePath).HasMaxLength(1500);

                entity.Property(e => e.UserAddress).HasMaxLength(1500);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.WhatsApp).HasMaxLength(20);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__AppUser__CityId__5AEE82B9");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__AppUser__Country__5CD6CB2B");

                entity.HasOne(d => d.Hostel)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.HostelId)
                    .HasConstraintName("FK__AppUser__HostelI__5EBF139D");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUser__OrgId__59FA5E80");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK__AppUser__RoomId__5DCAEF64");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__AppUser__StateId__5BE2A6F2");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUser__UserTyp__5FB337D6");
            });

            modelBuilder.Entity<AppUserPermission>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AppUserPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserPe__Permi__46E78A0C");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.AppUserPermission)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserPe__UserT__47DBAE45");
            });

            modelBuilder.Entity<AppUserTask>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcademicYid).HasColumnName("AcademicYId");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.TaskDate).HasColumnType("datetime");

                entity.Property(e => e.TaskDescription).HasMaxLength(4000);

                entity.Property(e => e.TaskFile).HasMaxLength(2500);

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaskSubmissionDate).HasColumnType("datetime");

                entity.HasOne(d => d.AcademicY)
                    .WithMany(p => p.AppUserTask)
                    .HasForeignKey(d => d.AcademicYid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserTa__Acade__3D2915A8");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.AppUserTask)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__AppUserTa__Class__3864608B");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.AppUserTask)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK__AppUserTa__Divis__395884C4");

                entity.HasOne(d => d.GivenByByUser)
                    .WithMany(p => p.AppUserTaskGivenByByUser)
                    .HasForeignKey(d => d.GivenByByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserTa__Given__3B40CD36");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppUserTask)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserTa__OrgId__3C34F16F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserTaskUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__AppUserTa__UserI__3A4CA8FD");
            });

            modelBuilder.Entity<AppUserType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Depart)
                    .WithMany(p => p.AppUserType)
                    .HasForeignKey(d => d.DepartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserTy__Depar__4222D4EF");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.AppUserType)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppUserTy__OrgId__4316F928");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<MstCity>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MstCity)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MstCity__StateId__2B3F6F97");
            });

            modelBuilder.Entity<MstCountry>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MstPermission>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.MenuCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MenuTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PageUrl)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MstPermission)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MstPermis__Group__34C8D9D1");
            });

            modelBuilder.Entity<MstPermissionsGroup>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MstState>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MstState)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MstState__Countr__276EDEB3");
            });

            modelBuilder.Entity<MstSubscription>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Cost).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PlanName)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}

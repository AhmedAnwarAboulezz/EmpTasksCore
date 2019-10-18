using System;
using System.Collections.Generic;
using System.Text;

namespace HRTask.Model
{
  public  class HRTaskContext /*: DbContext*/
    {
        
        //private readonly IHttpContextAccessor httpContextAccessor;
       
        //public HRTaskContext(DbContextOptions<DutiesContext> options, IDataInitialize dataInit) : base(options)
        //{
        //    _dataInit = dataInit;
        //    httpContextAccessor = new HttpContextAccessor();

        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<DutyType>().HasData(_dataInit.AddDutyTypes());
        //    modelBuilder.Entity<DutyStatus>().HasData(_dataInit.AddDutyStatuses());

        //    base.OnModelCreating(modelBuilder);
        //}
        //public virtual DbSet<DutyType> DutyTypes { get; set; }
        //public virtual DbSet<FixedDuty> FixedDuties { get; set; }
        //public virtual DbSet<DutyStatus> DutyStatuses { get; set; }
        //public virtual DbSet<FixedDutySetting> FixedDutySettings { get; set; }
        //public virtual DbSet<RotatedDuty> RotatedDuties { get; set; }




        //public override int SaveChanges()
        //{
        //    var userIdClaim = httpContextAccessor.HttpContext.User.FindFirst(t => t.Type == "UserId");
        //    userId = new Guid(userIdClaim?.Value ?? "00000000-0000-0000-0000-000000000000");

        //    var orgdClaim = httpContextAccessor.HttpContext.User.FindFirst(t => t.Type == "OrganizationId");
        //    organizationId = new Guid(orgdClaim?.Value ?? "038efd7f-9bcf-42f4-3819-08d715a43531");

        //    var entries = ChangeTracker.Entries();
        //    foreach (var entry in entries)
        //    {
        //        if (entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
        //            continue;
        //        foreach (var property in entry.Properties)
        //        {
        //            string propertyName = property.Metadata.Name;
        //            switch (entry.State)
        //            {
        //                case EntityState.Added:
        //                    if (propertyName == "CreatedBy")
        //                    {
        //                        property.CurrentValue = userId;
        //                    }
        //                    else if (propertyName == "CreatedDate")
        //                    {
        //                        property.CurrentValue = DateTime.Now;
        //                    }
        //                    else if (propertyName == "OrganizationId")
        //                    {
        //                        property.CurrentValue = organizationId;
        //                    }
        //                    break;

        //                case EntityState.Deleted:
        //                    break;

        //                case EntityState.Modified:
        //                    if (propertyName == "CreatedBy")
        //                    {
        //                        property.CurrentValue = property.OriginalValue;
        //                    }
        //                    else if (propertyName == "CreatedDate")
        //                    {
        //                        property.CurrentValue = property.OriginalValue;
        //                    }
        //                    else if (propertyName == "OrganizationId")
        //                    {
        //                        property.CurrentValue = organizationId;
        //                    }
        //                    else if (propertyName == "ModifiedBy")
        //                    {
        //                        property.CurrentValue = userId;
        //                    }
        //                    else if (propertyName == "ModifiedDate")
        //                    {
        //                        property.CurrentValue = DateTime.Now;
        //                    }
        //                    break;
        //            }
        //        }

        //    }
        //    return base.SaveChanges();
        //}

    }
    

    
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoredProcedureInEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EMPLOYEESEntities : DbContext
    {
        public EMPLOYEESEntities()
            : base("name=EMPLOYEESEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmployeePersonalDetail> EmployeePersonalDetails { get; set; }
    
        public virtual int d_DeleteEmployee_p(Nullable<int> employeeNo)
        {
            var employeeNoParameter = employeeNo.HasValue ?
                new ObjectParameter("EmployeeNo", employeeNo) :
                new ObjectParameter("EmployeeNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("d_DeleteEmployee_p", employeeNoParameter);
        }
    
        public virtual int s_InsertEmployee_p(Nullable<int> employeeNo, string employeeFName, string employeeLName)
        {
            var employeeNoParameter = employeeNo.HasValue ?
                new ObjectParameter("EmployeeNo", employeeNo) :
                new ObjectParameter("EmployeeNo", typeof(int));
    
            var employeeFNameParameter = employeeFName != null ?
                new ObjectParameter("EmployeeFName", employeeFName) :
                new ObjectParameter("EmployeeFName", typeof(string));
    
            var employeeLNameParameter = employeeLName != null ?
                new ObjectParameter("EmployeeLName", employeeLName) :
                new ObjectParameter("EmployeeLName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("s_InsertEmployee_p", employeeNoParameter, employeeFNameParameter, employeeLNameParameter);
        }
    
        public virtual int u_UpdateEmployee_p(Nullable<int> employeeNo, string employeeFName, string employeeLName)
        {
            var employeeNoParameter = employeeNo.HasValue ?
                new ObjectParameter("EmployeeNo", employeeNo) :
                new ObjectParameter("EmployeeNo", typeof(int));
    
            var employeeFNameParameter = employeeFName != null ?
                new ObjectParameter("EmployeeFName", employeeFName) :
                new ObjectParameter("EmployeeFName", typeof(string));
    
            var employeeLNameParameter = employeeLName != null ?
                new ObjectParameter("EmployeeLName", employeeLName) :
                new ObjectParameter("EmployeeLName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("u_UpdateEmployee_p", employeeNoParameter, employeeFNameParameter, employeeLNameParameter);
        }
    }
}
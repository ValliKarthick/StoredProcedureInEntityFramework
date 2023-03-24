using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoredProcedureInEntityFramework
{
    public partial class InsertEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new EMPLOYEESEntities())
            {
                EmployeePersonalDetail employeePersonalDetail = new EmployeePersonalDetail()
                {
                    employee_number = Convert.ToInt32(txtEmpId.Text),
                    first_name = txtEmpFName.Text,
                    last_name = txtEmpLName.Text
                };

                context.EmployeePersonalDetails.Add(employeePersonalDetail);
                context.SaveChanges();
                lblConfirmation.Text = "Added Successfully";
            }
        }
    }
}
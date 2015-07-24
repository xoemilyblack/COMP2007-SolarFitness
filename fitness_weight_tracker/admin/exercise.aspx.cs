using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fitness_weight_tracker.admin
{
    public partial class exercise : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlExercise.SelectedValue == "cardio")
            {
                pnlCardio.Visible = true;
                pnlMuscles.Visible = false;
            }
            else if (ddlExercise.SelectedValue == "weight")
            {
                pnlCardio.Visible = false;
                pnlMuscles.Visible = true;
            }
        }
    }
}
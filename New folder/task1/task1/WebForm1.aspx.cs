using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string gender = GenderRadioButtonList.SelectedValue;
            StringBuilder courses = new StringBuilder();
            foreach (var item in CoursesCheckBoxList.Items)
            {
                if (((System.Web.UI.WebControls.ListItem)item).Selected)
                {
                    courses.Append(((System.Web.UI.WebControls.ListItem)item).Text + " ");
                }
            }

            string personalInfo = $"<strong>Name:</strong> {name}<br />" +
                                  $"<strong>Email:</strong> {email}<br />" +
                                  $"<strong>Gender:</strong> {gender}<br />" +
                                  $"<strong>Courses:</strong> {courses.ToString().Trim()}";

            PersonalInfoLabel.Text = personalInfo;

        }
    }
}
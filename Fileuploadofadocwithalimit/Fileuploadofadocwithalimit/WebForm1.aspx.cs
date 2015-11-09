using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fileuploadofadocwithalimit
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
              {
                  string fileextension = System.IO.Path.GetExtension(FileUpload1.FileName);
                  if (fileextension.ToLower() != ".doc" && fileextension.ToLower() != ".docx")
                  {
                      Label1.Text = "Only .doc or .docx files can be uploaded";
                      Label1.ForeColor = System.Drawing.Color.Red;
                  }
                  else
                  {
                      int filesize = FileUpload1.PostedFile.ContentLength;
                      if (filesize > 2097152)
                      {
                          Label1.Text = "File size should be less than 2 MB ";
                          Label1.ForeColor = System.Drawing.Color.Green;
                      }
                      else
                      {
                          FileUpload1.SaveAs(Server.MapPath("~/uploads/" + FileUpload1.FileName));
                          Label1.Text = "File uploaded";
                          Label1.ForeColor = System.Drawing.Color.Green;
                      }
                  }
            }
            else
            {
                Label1.Text = "Please upload a file";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}
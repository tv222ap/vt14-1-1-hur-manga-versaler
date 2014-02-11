using RaknaVersaler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaknaVersaler
{
    public partial class Default : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            // If button previously pressed clear textbox and reset countbutton
            if (ViewState["buttonPressed"]!=null)
            {

                MainTextBox.Text = "";
                MainTextBox.Enabled = true;
                CountButton.Text = "Räkna versaler";
                ViewState["buttonPressed"] = null;
                Resultat.Text = "0";
                ResultatPlaceHolder.Visible = false;
            }
            
            else // If button not pressed, use TextAnalyzer to count number of capitals
            {    // Change button text to Clear
                var NumCapitals = new TextAnalyzer
                {
                    StringToCount = MainTextBox.Text

                };
                
                Resultat.Text = NumCapitals.GetNumberOfCapitals().ToString();
                MainTextBox.Enabled = false;
                ResultatPlaceHolder.Visible = true;
                CountButton.Text = "Clear";
                ViewState["buttonPressed"] = true;

            }
        }
    }
}
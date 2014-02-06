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
            
            if (ViewState["buttonPressed"]!=null)
            {

                MainTextBox.Text = "";
                MainTextBox.Enabled = true;
                CountButton.Text = "Räkna versaler";
                ViewState["buttonPressed"] = null;
                Resultat.Text = "0";
                ResultatPlaceHolder.Visible = false;
            }
            
            else
            { 
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
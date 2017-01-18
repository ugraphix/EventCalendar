using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] calendarevents = new string[6, 2]; //two dimensional array with 5 rows, 2 collumns


    protected void Page_Load(object sender, EventArgs e)//create list of items 
    {

        {

            calendarevents[0, 0] = "Go to school";
            calendarevents[0, 1] = "1/6/2017";
            calendarevents[1, 0] = "Study";
            calendarevents[1, 1] = "2/8/2017";
            calendarevents[2, 0] = "Homework";
            calendarevents[2, 1] = "1/20/2017";
            calendarevents[3, 0] = "Pay rent";
            calendarevents[3, 1] = "1/1/2017";
            calendarevents[4, 0] = "Pay Electric";
            calendarevents[4, 1] = "1/1/2017";
            calendarevents[5, 0] = "Pay Credit Card";
            calendarevents[5, 1] = "1/15/2017"; 



        }
    }



    //method
    protected void GetDates()
    {
        for (int i = 0; i < 6; i++) //++ incrementing by 1
        {
            //ListItem dates = new ListItem();
            //dates.Text = calendarevents[i, 0];  //add text to array
            //Calendar1.SelectedDates.Add();  //add items
            if (Calendar1.SelectedDate.ToShortDateString() == calendarevents[i, 1])
            {
                Label1.Text = calendarevents[i, 0];
            }
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        GetDates();
    }
}
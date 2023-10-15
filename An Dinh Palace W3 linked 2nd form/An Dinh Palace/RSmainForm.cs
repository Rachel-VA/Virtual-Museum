using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace An_Dinh_Palace
{
    public partial class RSmainForm : Form
    {
        //Create my objects from classes
        //the syntax for this is
        // Class name,object name
        //put the created object outside all of the methods so that we can use them in any method
        //this is due to scope
        //must be inside the public partial class in Main Form
        ClassArea objectMainHall = new ClassArea();
        ClassArea objectUpstairs = new ClassArea();
        ClassArea objectLivingRoom = new ClassArea();
        ClassArea objectDinningRoom = new ClassArea();
        ClassArea objectFrontYard = new ClassArea();
        //this will run when the form is loaded
        public RSmainForm()
        {
            InitializeComponent();
            //setup the name of the room when user click the button
            textBoxAreaName.Text = "Main Hall";
            textBoxAreaDescription.Text = "The Main Hall is located on the first floor.This floor has total of 7 rooms including Living and Dinning rooms";
        }

        private void RSmainForm_Load(object sender, EventArgs e)
        {
            
            //set properties  for all of the new objects
            objectMainHall.AreaName = "Main Hall";
            objectMainHall.AreaDescription = "Main Hall is located on the first floor. It decorated with 6 oil paintings were painted on the wall depicting of Vietnam’s Kings of past dynasty ";

            objectUpstairs. AreaName = "Upstairs";
            objectUpstairs.AreaDescription = "The second and third floor including the king bedroom, display information room, and several other rooms. The third floor reserve to ancestor display area.";

            objectLivingRoom.AreaName = "Living Room";
            objectLivingRoom.AreaDescription = "The living room is located on the left hand on the first floor. The furniture have unique look of ancient royal";

            objectDinningRoom.AreaName = "DinningRoom";
            objectDinningRoom.AreaDescription = "Dinning chairs were painted with sophisticated golden lipstick and have royal look";

            objectFrontYard.AreaName = "Front Yard";
            objectFrontYard.AreaDescription = "The front yard including riverbank (An Cuu river), dock, main gate, and a gazebo with the life-size statue of king Khai Dinh (1916-1925) made of copper.";
            //all of my object properties are set above and ready to use
            textBoxAreaName.Text = objectMainHall.AreaName;
            //labelAreaName.Text = objectMainHall.AreaName;
            textBoxAreaDescription.Text = objectUpstairs.AreaDescription;

        }

        private void groupBoxNavControl_Enter(object sender, EventArgs e)
        {

        }

        private void RSmainForm_Paint(object sender, PaintEventArgs e)
        {

        }
        //The code below handle the event when clicking the North button
        private void myCustomButtonNorth_Click(object sender, EventArgs e)
        {

            // when the North button is clicked, it'll change background image to show a new area and description
            textBoxAreaName.Text = objectUpstairs.AreaName;//display the new area

            // textBoxAreaName.ForeColor = Color.MediumVioletRed; //change color when clicked
            textBoxAreaDescription.Text = objectUpstairs.AreaDescription; 
            textBoxAreaDescription.ForeColor = Color.MediumVioletRed; //this line of code does not work
            this.BackgroundImage = Properties.Resources._2nd_floor;

  
        }

        //The code below handle the south button events
        private void myCustomButtonSouth_Click(object sender, EventArgs e)
        {
            textBoxAreaName.Text = objectFrontYard.AreaName;
            textBoxAreaName.ForeColor = Color.DeepPink;
            textBoxAreaDescription.Text = objectFrontYard.AreaDescription;
            this.BackgroundImage = Properties.Resources.front_yard2;
        }

        //the code below handle the west button events & using Object Oriented
        private void myCustomButtonWest_Click(object sender, EventArgs e)
        {
            textBoxAreaName.Text = objectLivingRoom.AreaName;
            textBoxAreaName.ForeColor = Color.BlueViolet;
            textBoxAreaDescription.Text = objectLivingRoom.AreaDescription;
            this.BackgroundImage = Properties.Resources.living_room;
        }

        private void myCustomButtonEast_Click(object sender, EventArgs e)
        {
            //the code below handle the East button events
            textBoxAreaName.Text = objectDinningRoom.AreaName;
            textBoxAreaName.ForeColor = Color.DarkOrange;
            textBoxAreaDescription.Text = objectDinningRoom.AreaDescription;
            this.BackgroundImage = Properties.Resources.dinning_room;
        }

        //the code below handle the Main Hall button
        private void buttonMainHall_Click(object sender, EventArgs e)
        {
            textBoxAreaName.Text = objectMainHall.AreaName;
            textBoxAreaName.ForeColor = Color.Brown;
            textBoxAreaDescription.Text = objectUpstairs.AreaDescription;
            this.BackgroundImage = Properties.Resources.mainHall2;
        }

        private void buttonTestNorth_Click(object sender, EventArgs e)
        {
            // when the North button is clicked, it'll change background image to show a new area and description
            textBoxAreaName.Text = "Upstairs"; //display the new area
            textBoxAreaName.ForeColor = Color.MediumVioletRed; //change color when clicked
            textBoxAreaDescription.Text = "The second and third floor including the king bedroom, display information room, and several other rooms. The third floor reserve to ancestor display area.";
            textBoxAreaDescription.ForeColor = Color.Green; //this line of code does not work
            //this.BackgroundImage = Properties.Resources._2nd_floor;
        }

        //the code below to link a second form in a button
        private void buttonLinkNewForm_Click(object sender, EventArgs e)
        {
            NewForm f1 = new NewForm();
            f1.Show();
        }
    }
}

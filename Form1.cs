namespace First_Project
{
    // Breanna Gernon 
    // CST-150
    // 11/4/2022
    // I used source code from the following websites to complete this assignment:
    //CST-150 Textbook: Starting out with Visual C# (5th ed.). The information in Chapter 2
    //  allowed me to put together a lot of my work.
    //https://stackoverflow.com/questions/5414270/messagebox-buttons
    //  I used this website to create the multiple choice messages in my program
    //  and to customize the messageboxes. 
    public partial class CoolBox : Form
    {
        public CoolBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var message = "Thank you! Would you like to leave feedback?";
            var title = "Feedback?";

            //Set the result as the user's choice in this message box.
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //Continue to survey if user chooses yes, end if user chooses no.
            if (result == DialogResult.Yes) 
            { 
                var result2 = MessageBox.Show("Did you enjoy this process?", "Quiz", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(result2 == DialogResult.Yes)
                {
                    MessageBox.Show("Thank you for your feedback!");
                    Close();
                }

                if(result2 != DialogResult.Yes)
                {
                    MessageBox.Show("Sorry about that! Email me with how I can improve! Email: bgernon@my.gcu.edu", "Sorry! :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }    
            }

            else if(result != DialogResult.Yes)
            {
                MessageBox.Show("Thank you for trying out my first program!");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well... okay then. Thanks for trying anyway. :(");
            Close();
        }
    }
}
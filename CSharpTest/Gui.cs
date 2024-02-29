using System;
using System.Windows.Forms;

namespace GUi
{
    public partial class MainForm : Form
    {
        private TextBox characterTextBox = new TextBox();
        private TextBox characterLevelTextBox = new TextBox();
        private TextBox CharacterEidelonTextBox = new TextBox();
        private TextBox CharacterAscentionTextBox = new TextBox();
        private TextBox CharacterHealthTextBox = new TextBox();
        private TextBox TrailblazeLvlTextBox = new TextBox();

        private Button submitButton;
        private Button cancelButton;
        public List<string> dataList = new List<string>();

        private Label CharacterName = new Label();
        private Label CharacterLevel = new Label();
        private Label CharacterEidelon = new Label();
        private Label CharacterAscention = new Label();
        private Label CharacterHealth = new Label();
        private Label TrailblazeLvl = new Label();

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeComponent()
        {
            // Set form properties
            this.Text = "Relic Generator";
            this.Size = new System.Drawing.Size(1000, 500);

            // Initialize controls
            this.characterTextBox = new TextBox();
            this.submitButton = new Button();
            this.cancelButton = new Button();
        }

        private void InitializeControls()
        {
            //first index is x axis
            //second index is y axis

            //Create the different Labels
            this.CharacterName.Text = "Name";
            this.CharacterName.Location = new System.Drawing.Point(150, 30);
            this.Controls.Add(CharacterName);

            this.CharacterLevel.Text = "Level";
            this.CharacterLevel.Location = new System.Drawing.Point(150, 60);
            this.Controls.Add(CharacterLevel);

            this.CharacterEidelon.Text = "Eidelon";
            this.CharacterEidelon.Location = new System.Drawing.Point(150, 90);
            this.Controls.Add(CharacterEidelon);

            this.CharacterAscention.Text = "Ascention";
            this.CharacterAscention.Location = new System.Drawing.Point(150, 120);
            this.Controls.Add(CharacterAscention);

            this.CharacterHealth.Text = "Health";
            this.CharacterHealth.Location = new System.Drawing.Point(150, 150);
            this.Controls.Add(CharacterHealth);

            this.TrailblazeLvl.Text = "Trailblaze Level";
            this.TrailblazeLvl.Location = new System.Drawing.Point(150, 180);
            this.Controls.Add(TrailblazeLvl);

            // Input TextBox
            this.characterTextBox.Location = new System.Drawing.Point(300, 30);
            this.characterTextBox.Size = new System.Drawing.Size(100, 20);

            this.characterLevelTextBox.Location = new System.Drawing.Point(300, 60);
            this.characterLevelTextBox.Size = new System.Drawing.Size(100, 20);

            this.CharacterEidelonTextBox.Location = new System.Drawing.Point(300, 90);
            this.CharacterEidelonTextBox.Size = new System.Drawing.Size(100, 20);

            this.CharacterAscentionTextBox.Location = new System.Drawing.Point(300, 120);
            this.CharacterAscentionTextBox.Size = new System.Drawing.Size(100, 20);

            this.CharacterHealthTextBox.Location = new System.Drawing.Point(300, 150);
            this.CharacterHealthTextBox.Size = new System.Drawing.Size(100, 20);

            this.TrailblazeLvlTextBox.Location = new System.Drawing.Point(300, 180);
            this.TrailblazeLvlTextBox.Size = new System.Drawing.Size(100, 20);

            // Submit Button
            this.submitButton.Location = new System.Drawing.Point(90, 400);
            this.submitButton.Size = new System.Drawing.Size(100, 30);
            this.submitButton.Text = "Submit";
            this.submitButton.Click += SubmitButton_Click;

            //Quit Button
            this.cancelButton.Location = new System.Drawing.Point(800, 400);
            this.cancelButton.Size = new System.Drawing.Size(100, 30);
            this.cancelButton.Text = "Quit";
            this.cancelButton.Click += quitButton_Click;

            // Add controls to form
            this.Controls.Add(characterTextBox);
            this.Controls.Add(characterLevelTextBox);
            this.Controls.Add(CharacterEidelonTextBox);
            this.Controls.Add(CharacterAscentionTextBox);
            this.Controls.Add(CharacterHealthTextBox);
            this.Controls.Add(TrailblazeLvlTextBox);

            this.Controls.Add(submitButton);
            this.Controls.Add(cancelButton);
        }

        private void SubmitButton_Click(object sender, EventArgs e)//have a prompted to create a new gui that will ask if they want to close or not
        {
            string characterName = characterTextBox.Text;
            string characterLvl = characterLevelTextBox.Text;
            string characterEidelon = CharacterEidelonTextBox.Text;
            string characterAscention = CharacterAscentionTextBox.Text;
            string characterHealth = CharacterHealthTextBox.Text;
            string characterTrailblazeLvl = TrailblazeLvlTextBox.Text;
            dataList.Add(characterName);
            dataList.Add(characterLvl);
            dataList.Add(characterEidelon);
            dataList.Add(characterAscention);
            dataList.Add(characterHealth);
            dataList.Add(characterTrailblazeLvl);
        }
        
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public List<string> getData()
        {
            return this.dataList;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

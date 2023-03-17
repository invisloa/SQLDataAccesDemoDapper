namespace FormUI
{
	public partial class Dashboard : Form
	{
		List<Person> people = new List<Person>();
		public Dashboard()
		{
			InitializeComponent();
			UpdateBinding();
		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();

			people = db.GetPeople(lastNameTextbox.Text);
			UpdateBinding();

		}
		private void UpdateBinding()
		{
			peopleFoundListbox.DataSource = people;
			peopleFoundListbox.DisplayMember = "FullInfo";
		}

		private void InsRecordBtn_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();
			db.InsertPerson(InsFirstName.Text, InsLastName.Text, InsEmail.Text, InsPhoneNo.Text);

			InsFirstName.Text = "";
			InsLastName.Text = "";
			InsEmail.Text = "";
			InsPhoneNo.Text = "";
		}

		private void DeleteByLastNameBtn_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();
			db.DeletePersonByLastName(InsLastName.Text);

		}
	}
}
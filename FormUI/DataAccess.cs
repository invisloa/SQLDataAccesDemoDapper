using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
	public class DataAccess
	{
		public List<Person> GetPeople(string lastName)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
			{
				return connection.Query<Person>($"select * from dbo.People where LastName = '{lastName}'").ToList();
				var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
				return output;
			}
		}

		public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
			{
				List<Person> people = new List<Person>(); 

				people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

				Person person = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };

				connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", person);
			}
		}

		internal void DeletePersonByLastName(string lastName)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
			{
				connection.Execute("dbo.DeletePerson_ByLastName @LastName", new { LastName = lastName }); ;
			}
		}
	}
}

<Query Kind="Statements">
  <Connection>
    <ID>1322f209-0d88-4ceb-9961-f0d9b9c4fc40</ID>
    <Persist>true</Persist>
    <Server>127.0.0.1,1433</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAIOBZ/D3080CWQbxkhhyqbgAAAAACAAAAAAAQZgAAAAEAACAAAABnkCw2lkLReJXmGt8KS176eSyIcDPhwexhAiGGzKILJQAAAAAOgAAAAAIAACAAAACXhQ++O42qQewaix0MrWafXCc4l3YYbccTrekD8ddEJSAAAACmBdUKSGCknCthX/RDuYG23pILHtbq6CgY9jDwpE7/w0AAAACpMJaZHYCEvfMygP3GW3K53VrjKW0iOVJB1jTuXo/94dK5sm8MRADxbO1j0WXISW1JlaF+mX4Pm7MhF1MEtVl8</Password>
    <Database>docker_stuff</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

Persons.InsertAllOnSubmit(new[] {
	new Person
	{
		FirstName = "Aaron",
		LastName = "Powell"
	},
	new Person
	{
		FirstName = "Lars",
		LastName = "Klint"
	},
	new Person
	{
		FirstName = "Jenny",
		LastName = "Anderson"
	}
});

SubmitChanges();

Persons.Dump();
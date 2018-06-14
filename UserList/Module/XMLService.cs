using System.Collections.Generic;
using System.Xml;

namespace UserList.Module
{
	internal class XMLService : ISource
	{
		public IEnumerable<User> Read(string fileName)
		{
			var loadUsers = new List<User>();
			using (XmlReader reader = XmlReader.Create(fileName))
			{
				while (reader.Read())
				{
					if (reader.IsStartElement())
					{
						if (reader.Name.Equals("user"))
						{
							string loadUsername = reader.GetAttribute("name");
							string loadPassword = reader.GetAttribute("password");
							loadUsers.Add(new User(loadUsername, loadPassword));
						}
					}
				}
			}
			return loadUsers;
		}

		public void Save(IEnumerable<User> users)
		{
			var settings = new XmlWriterSettings
			{
				Indent = true,
				IndentChars = new string(' ', 4)
			};

			using (XmlWriter writer = XmlWriter.Create("Users.xml", settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("Users");

				foreach (var user in users)
				{
					writer.WriteStartElement("user");
					writer.WriteAttributeString("name", user.Username);
					writer.WriteAttributeString("password", user.Password);
					writer.WriteEndElement();
				}

				writer.WriteEndDocument();
				writer.Close();
			}
		}
	}
}
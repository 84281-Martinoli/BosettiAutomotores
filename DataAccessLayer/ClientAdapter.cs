using System.Collections.Generic;

namespace DataAccessLayer {
	public static class ClientAdapter {
		public static void Create(string ip, string name, string surname, string document) => GeneralAdapter.Execute(ip, "INSERT INTO Clientes (nombre, apellido, cuil_cliente) VALUES (@nombre, @apellido, @cuil_clientes)", new Dictionary<string, string>() { { "@nombre", name }, { "@apellido", surname }, { "@cuil_cliente", document } });
	}
}

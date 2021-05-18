using System.Collections.Generic;

namespace DataAccessLayer {
	public static class ServiceAdapter {
		public static void CreateService(string ip, string model, string version, string year, string km, string typeWork, string mechanic) => GeneralAdapter.Execute(ip, "INSERT INTO ", new Dictionary<string, string>() { { "@modelo", model }, { "@serie", version }, { "@año", year }, { "@km", km }, { "@tipo_trabajo", typeWork }, { "@id_empleado", mechanic } });
	}
}

using System.Net;
using System.Text.Json;

var cliente = WebRequest.Create("https://parallelum.com.br/fipe/api/v1/carros/marcas") as HttpWebRequest;
cliente.Method = "GET";
cliente.ContentType = "application/json";
cliente.Accept = "application/json";

var respuesta = cliente.GetResponse();
StreamReader x = new StreamReader(respuesta.GetResponseStream());
string xml = x.ReadToEnd();

List<auto> autos = JsonSerializer.Deserialize<List<auto>>(xml);
autos.ForEach(delegate(auto item) { Console.WriteLine(string.Concat("Código: ", item.codigo, " Marca: ", item.nome)); } );

Console.WriteLine("");
public class auto
{
    public string codigo  { get; set; }
    public string nome { get; set; }
}


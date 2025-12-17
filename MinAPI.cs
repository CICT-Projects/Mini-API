using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        string s="89d0195f617b3e370d69435f3a67eb43";
        string r="Khujand";
        string t=$"https://api.openweathermap.org/data/2.5/weather?q={r}&appid={s}&units=metric";
        using HttpClient c=new HttpClient();
        string response=await c.GetStringAsync(t);
        using JsonDocument d=JsonDocument.Parse(response);
        double y=d.RootElement.GetProperty("main").GetProperty("temp").GetDouble();
        Console.WriteLine(y);
    }
}

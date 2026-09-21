using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ApiNaruto.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    // Copia la URL exacta de ApiBaseUrl de tu Form1.cs (con https:// y la "/" final)
    BaseAddress = new Uri("https://tarea5-clientes-fvd2fjdhfpd7g0au.mexicocentral-01.azurewebsites.net/")
});
await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SimpleUI;
using Refit;
using SimpleUI.DataAccess;

//https://localhost:7025/

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddRefitClient<IGuestData>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://localhost:7025/api");
});

await builder.Build().RunAsync();

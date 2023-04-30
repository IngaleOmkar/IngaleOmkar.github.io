using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PersonlWebsite;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddScoped<PersonlWebsite.ViewModels.AwardsViewModel>()
    .AddScoped<PersonlWebsite.ViewModels.ProjectsViewModel>()
    .AddScoped<PersonlWebsite.ViewModels.CertificateViewModel>()
    .AddScoped<PersonlWebsite.ViewModels.SkillsViewModel>()
    .AddScoped<PersonlWebsite.ViewModels.ExperienceViewModel>()
    .AddScoped<PersonlWebsite.ViewModels.EducationViewModel>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();

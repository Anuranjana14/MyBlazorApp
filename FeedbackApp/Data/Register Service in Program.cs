using FeedbackApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<FeedbackService>();
builder.RootComponents.Add<App>("#app");

await builder.Build().RunAsync();
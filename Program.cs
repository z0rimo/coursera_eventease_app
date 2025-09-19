using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// 기본 HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// 세션 상태 관리용
builder.Services.AddScoped<AppState>();

await builder.Build().RunAsync();

// --- 앱 전역 상태 ---
namespace EventEase
{
    public class AppState
    {
        public string? CurrentUser { get; set; }
        public List<string> MySessions { get; } = new();
    }
}

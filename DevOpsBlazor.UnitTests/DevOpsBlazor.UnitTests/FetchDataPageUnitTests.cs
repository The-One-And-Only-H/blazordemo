using BlazorDemo.Pages;
using Microsoft.AspNetCore.Components.Testing;
using System;
using Xunit;
using static BlazorDemo.Pages.FetchData;

namespace DevOpsBlazor.UnitTests
{
    public class FetchDataPageUnitTests
    {
        TestHost host = new TestHost();

        [Fact]
        public void ShouldRenderLoading()
        {
            var req = host.AddMockHttp().Capture("");

            var component = host.AddComponent<FetchData>();

            // Assert p
            Assert.Equal("Loading...", component.Find("p em").InnerText);
        }

        [Fact]
        public void ShouldRenderFocusts()
        {
            var req = host.AddMockHttp().Capture("");

            var component = host.AddComponent<FetchData>();

            host.WaitForNextRender(() => req.SetResult(new[]
            {
                new WeatherForecast { Summary = "First", TemperatureC = 30, Date = DateTime.Now.AddDays(1) },
                new WeatherForecast { Summary = "Second", TemperatureC = 28, Date = DateTime.Now.AddDays(2) },
            }));

            Assert.Collection(
                component.FindAll("tbody tr"),
                row =>
                {
                    Assert.Equal(DateTime.Now.AddDays(1).ToShortDateString(), row.SelectSingleNode("td[1]").InnerText);
                    Assert.Equal("30", row.SelectSingleNode("td[2]").InnerText);
                    Assert.Equal((32 + (int)(30 / 0.5556)).ToString(), row.SelectSingleNode("td[3]").InnerText);
                    Assert.Equal("First", row.SelectSingleNode("td[4]").InnerText);
                },
                row => {
                    Assert.Equal(DateTime.Now.AddDays(2).ToShortDateString(), row.SelectSingleNode("td[1]").InnerText);
                    Assert.Equal("28", row.SelectSingleNode("td[2]").InnerText);
                    Assert.Equal((32 + (int)(28 / 0.5556)).ToString(), row.SelectSingleNode("td[3]").InnerText);
                    Assert.Equal("Second", row.SelectSingleNode("td[4]").InnerText);
                }
            );
        }
    }
}
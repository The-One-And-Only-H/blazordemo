using BlazorDemo.Pages;
using Microsoft.AspNetCore.Components.Testing;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DevOpsBlazor.UnitTests
{
    public class CounterPageUnitTests
    {
        TestHost host = new TestHost();

        [Fact]
        public void ShouldRenderCountZero()
        {
            var component = host.AddComponent<Counter>();

            // Assert p
            Assert.Equal("Current count: 0", component.Find("p").InnerText);
        }

        [Fact]
        public async Task ShouldIncrementCount()
        {
            var component = host.AddComponent<Counter>();

            // Find a button and click.
            await component.Find("button").ClickAsync();
            // Assert result.
            Assert.Equal("Current count: 1", component.Find("p").InnerText);
        }
    }
}
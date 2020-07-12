using Microsoft.AspNetCore.Components.Testing;
using System;
using Xunit;

namespace DevOpsBlazor.UnitTests
{
    public class IndexPageUnitTests
    {
        private TestHost host = new TestHost();

        [Fact]
        public void ShouldRenderHello()
        {
            var component = host.AddComponent<BlazorDemo.Pages.Index>();
            // Assert h1
            Assert.Equal("Hello, world!", component.Find("h1").InnerText);
            // Assert text in the body
            Assert.Contains("Welcome to your new app.", component.GetMarkup());
            // Assert if survey component exists
            Assert.NotNull(component.Find(".alert.alert-secondary"));
            // Assert the link
            Assert.Equal(
                "https://go.microsoft.com/fwlink/?linkid=2127212",
                component.Find("a").Attributes["href"].Value);
        }
    }
}
using BlazorDemo.Shared;
using Microsoft.AspNetCore.Components.Testing;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DevOpsBlazor.UnitTests
{
    public class SurveyPromptUnitTests
    {
        private TestHost host = new TestHost();

        [Fact]
        public void ShouldRenderTitle()
        {
            var title = "Test";
            var parameters = new Dictionary<string, object>() { { "Title", title } };
            var component = host.AddComponent<SurveyPrompt>(parameters);
            Assert.Equal(title, component.Find("strong").InnerText);
        }
    }
}
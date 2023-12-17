// WebCrawlerTests.cs
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

public class WebCrawlerTests
{
    [Fact]
    public void Contains_Sum_Method()
    {
        // Arrange
        var type = typeof(WebCrawler);

        // Act
        var sumMethod = type.GetMethods(BindingFlags.Public | BindingFlags.Static)
                            .FirstOrDefault(m => m.Name == "Sum");

        // Assert
        Assert.NotNull(sumMethod);
    }

        [Fact]
    public void Contains_WebCrawlerResult_Struct()
    {
        // Arrange
        var type = typeof(WebCrawler);

        // Act
        var webCrawlerResultStruct = type.GetNestedTypes(BindingFlags.Public | BindingFlags.Static)
                                        .FirstOrDefault(t => t.Name == "WebCrawlerResult");

        // Assert
        Assert.NotNull(webCrawlerResultStruct);
    }

    // [Fact]
    // public void Contains_CrawlWebsiteAsync_Method()
    // {
    //     // Arrange
    //     var type = typeof(WebCrawler);

    //     // Act
    //     var crawlMethod = type.GetMethods(BindingFlags.Public | BindingFlags.Static)
    //                          .FirstOrDefault(m => m.Name == "CrawlWebsiteAsync");

    //     // Assert
    //     Assert.NotNull(crawlMethod);
    // }

    // [Fact]
    // public async Task CrawlWebsiteAsync_ShouldReturnCorrectResult()
    // {
    //     // Arrange
    //     var url = "https://example.com";

    //     // Act
    //     var result = await WebCrawler.CrawlWebsiteAsync(url);

    //     // Assert
    //     Assert.Equal("Sample Title", result.Title);
    //     Assert.Equal(new[] { "Link1", "Link2", "Link3" }, result.Links);
    // }

    // [Fact]
    // public async Task CrawlWebsiteAsync_ShouldThrowExceptionForInvalidUrl()
    // {
    //     // Arrange
    //     var invalidUrl = "https://invalidurl";

    //     // Act and Assert
    //     await Assert.ThrowsAsync<HttpRequestException>(() => WebCrawler.CrawlWebsiteAsync(invalidUrl));
    // }

    // [Fact]
    // public void ConsoleOutput_ShouldBeCorrect()
    // {
    //     // Arrange
    //     var consoleOutput = new StringWriter();
    //     Console.SetOut(consoleOutput);

    //     // Act
    //     Console.WriteLine("Hello, Console!");

    //     // Assert
    //     Assert.Equal("Hello, Console!" + Environment.NewLine, consoleOutput.ToString());
    // }
}

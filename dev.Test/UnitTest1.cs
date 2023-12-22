using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class WebCrawlerTests
{
    [TestMethod]
    public void Contains_Sum_Method()
    {
        // Arrange
        var type = typeof(WebCrawler);

        // Act
        var sumMethod = type.GetMethods(BindingFlags.Public | BindingFlags.Static)
                            .FirstOrDefault(m => m.Name == "Sum");

        // Assert
        Assert.IsNotNull(sumMethod);
    }

    [TestMethod]
    public void Contains_WebCrawlerResult_Struct()
    {
        // Arrange
        var type = typeof(WebCrawler);

        // Act
        var webCrawlerResultStruct = type.GetNestedTypes(BindingFlags.Public | BindingFlags.Static)
                                        .FirstOrDefault(t => t.Name == "WebCrawlerResult");

        // Assert
        Assert.IsNotNull(webCrawlerResultStruct);
    }

    // Uncomment and modify the following tests based on your implementation:

    // [TestMethod]
    // public void Contains_CrawlWebsiteAsync_Method()
    // {
    //     // Arrange
    //     var type = typeof(WebCrawler);

    //     // Act
    //     var crawlMethod = type.GetMethods(BindingFlags.Public | BindingFlags.Static)
    //                          .FirstOrDefault(m => m.Name == "CrawlWebsiteAsync");

    //     // Assert
    //     Assert.IsNotNull(crawlMethod);
    // }

    // [TestMethod]
    // public async Task CrawlWebsiteAsync_ShouldReturnCorrectResult()
    // {
    //     // Arrange
    //     var url = "https://example.com";

    //     // Act
    //     var result = await WebCrawler.CrawlWebsiteAsync(url);

    //     // Assert
    //     Assert.AreEqual("Sample Title", result.Title);
    //     CollectionAssert.AreEqual(new[] { "Link1", "Link2", "Link3" }, result.Links);
    // }

    // [TestMethod]
    // public async Task CrawlWebsiteAsync_ShouldThrowExceptionForInvalidUrl()
    // {
    //     // Arrange
    //     var invalidUrl = "https://invalidurl";

    //     // Act and Assert
    //     await Assert.ThrowsExceptionAsync<HttpRequestException>(() => WebCrawler.CrawlWebsiteAsync(invalidUrl));
    // }

    // [TestMethod]
    // public void ConsoleOutput_ShouldBeCorrect()
    // {
    //     // Arrange
    //     var consoleOutput = new StringWriter();
    //     Console.SetOut(consoleOutput);

    //     // Act
    //     Console.WriteLine("Hello, Console!");

    //     // Assert
    //     Assert.AreEqual("Hello, Console!" + Environment.NewLine, consoleOutput.ToString());
    // }
}

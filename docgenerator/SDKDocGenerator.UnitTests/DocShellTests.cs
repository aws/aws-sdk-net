using System.IO;
using System.Text.RegularExpressions;

using Xunit;

using SDKDocGenerator.Writers;

namespace SDKDocGenerator.UnitTests
{
    // Guards the assembled page shell emitted by DocShell (head + chrome + footer):
    // it must be well-formed, balanced, and contain the accessibility/navigation
    // hooks the client runtime relies on (focusable #main, aria-live region, etc.).
    public class DocShellTests
    {
        private static string RenderShell()
        {
            var o = new DocShell.Options
            {
                RootRelativePath = "../..",
                Title = "AmazonS3Client Class",
                TocId = "Amazon_S3_AmazonS3Client",
                Service = "S3",
                CanonicalUrl = "https://docs.aws.amazon.com/sdkfornet/v4/apidocs/items/S3/TAmazonS3Client.html"
            };
            using (var sw = new StringWriter())
            {
                DocShell.WriteHeadAndChrome(sw, o);
                sw.Write("<div id=\"pageContent\"><h1>AmazonS3Client</h1></div>");
                DocShell.WriteFootShell(sw);
                return sw.ToString();
            }
        }

        [Fact]
        public void Shell_ContainerTagsAreBalanced()
        {
            var html = RenderShell();
            // The chrome opens layout containers in WriteHeadAndChrome that WriteFootShell
            // must close. Count start vs end tags for each container element (ignoring the
            // <div>s inside the inline <script>, which contains no markup tags). An imbalance
            // means the footer failed to close something the head opened.
            AssertBalanced(html, "div");
            AssertBalanced(html, "main");
            AssertBalanced(html, "body");
            AssertBalanced(html, "html");
            AssertBalanced(html, "header");
            AssertBalanced(html, "aside");
            AssertBalanced(html, "nav");
        }

        private static void AssertBalanced(string html, string tag)
        {
            var open = Regex.Matches(html, "<" + tag + "(?:\\s[^>]*)?>").Count;
            var selfClose = Regex.Matches(html, "<" + tag + "(?:\\s[^>]*)?/>").Count;
            var close = Regex.Matches(html, "</" + tag + ">").Count;
            Assert.Equal(open - selfClose, close);
        }

        [Fact]
        public void Shell_MainIsFocusableSwapTargetWithPerPageIds()
        {
            var html = RenderShell();
            // #main is the htmx swap target; app.js focuses it after a swap (tabindex=-1)
            // and reads the per-page data-* off it (not <body>, which is not swapped).
            Assert.Contains("<main id=\"main\" role=\"main\" tabindex=\"-1\"", html);
            Assert.Contains("data-tocid=\"Amazon_S3_AmazonS3Client\"", html);
            Assert.Contains("data-service=\"S3\"", html);
        }

        [Fact]
        public void Shell_HasPersistentLiveRegionForAnnouncements()
        {
            var html = RenderShell();
            // Lives outside #main so it survives swaps; app.js writes the new title here.
            Assert.Contains("id=\"navAnnounce\"", html);
            Assert.Contains("aria-live=\"polite\"", html);
        }

        [Fact]
        public void Shell_HasSingleMainAndBody()
        {
            var html = RenderShell();
            Assert.Equal(1, CountOccurrences(html, "<main "));
            Assert.Equal(1, CountOccurrences(html, "<body "));
            // Scripts load in dependency order: core helpers before the modules that use them.
            Assert.True(html.IndexOf("app-core.js") < html.IndexOf("sidebar.js"));
            Assert.True(html.IndexOf("sidebar.js") < html.IndexOf("app.js"));
            Assert.True(html.IndexOf("search-core.js") < html.IndexOf("search.js"));
        }

        private static int CountOccurrences(string haystack, string needle)
        {
            int count = 0, i = 0;
            while ((i = haystack.IndexOf(needle, i)) != -1) { count++; i += needle.Length; }
            return count;
        }
    }
}

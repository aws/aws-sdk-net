using System.IO;

namespace SDKDocGenerator.Writers
{
    /// <summary>
    /// Single source of truth for the modern page shell — the &lt;head&gt;, the fixed
    /// top bar (brand, mobile nav toggle, search form, theme toggle), the persistent
    /// sidebar, and the surrounding layout container.
    ///
    /// Both the reflection-driven pages (<see cref="BaseWriter"/>) and the static
    /// landing page (<see cref="LandingPageWriter"/>) render through this type so the
    /// chrome exists in exactly one place and cannot drift between them.
    /// </summary>
    public static class DocShell
    {
        /// <summary>
        /// Per-page values that vary between documents. Everything else in the shell
        /// is identical across every generated page.
        /// </summary>
        public class Options
        {
            /// <summary>Relative path from the page to the doc-set root (e.g. "../.." or "..").</summary>
            public string RootRelativePath { get; set; } = ".";

            /// <summary>Page &lt;title&gt; / meta description text.</summary>
            public string Title { get; set; } = "";

            /// <summary>Meta description (defaults to Title when not set).</summary>
            public string Description { get; set; }

            /// <summary>aws-tocid meta value and body data-tocid (may be empty, e.g. landing page).</summary>
            public string TocId { get; set; } = "";

            /// <summary>Owning service name for body data-service (may be empty).</summary>
            public string Service { get; set; } = "";

            /// <summary>Canonical URL; emitted only when set.</summary>
            public string CanonicalUrl { get; set; }
        }

        /// <summary>
        /// Writes everything from &lt;!DOCTYPE&gt; through the opening of
        /// &lt;div class="content-shell"&gt;. Callers then write page content and call
        /// <see cref="WriteFootShell"/>.
        /// </summary>
        public static void WriteHeadAndChrome(TextWriter writer, Options o)
        {
            var root = o.RootRelativePath;
            var description = string.IsNullOrEmpty(o.Description) ? o.Title : o.Description;

            writer.WriteLine("<!DOCTYPE html>");
            writer.WriteLine("<html lang=\"en\">");
            writer.WriteLine("<head>");

            writer.WriteLine("<meta charset=\"utf-8\"/>");
            writer.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>");
            writer.WriteLine("<meta name=\"guide-name\" content=\"API Reference\"/>");
            writer.WriteLine("<meta name=\"service-name\" content=\"AWS SDK for .NET Version 4\"/>");

            // Set the theme before first paint to avoid a light/dark flash.
            writer.WriteLine("<script>(function(){try{var t=localStorage.getItem('awsdocs-theme');"
                             + "if(t!=='light'&&t!=='dark'){t=(window.matchMedia&&window.matchMedia('(prefers-color-scheme: dark)').matches)?'dark':'light';}"
                             + "document.documentElement.setAttribute('data-theme',t);}catch(e){}})();</script>");

            writer.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"{0}/resources/aws-docs.css\"/>", root);
            writer.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"{0}/resources/hljs-theme.css\"/>", root);

            writer.WriteLine("<meta name=\"description\" content=\"{0}\">", description);
            writer.WriteLine("<title>{0} | AWS SDK for .NET Version 4</title>", o.Title);
            writer.WriteLine("<meta name=\"aws-tocid\" content=\"{0}\"/>", o.TocId);
            if (!string.IsNullOrEmpty(o.CanonicalUrl))
                writer.WriteLine("<link rel=\"canonical\" href=\"{0}\"/>", o.CanonicalUrl);

            // htmx boosts same-origin link clicks into AJAX requests that swap only the
            // #main region (see <body> hx-* attributes below), keeping the topbar/sidebar/
            // search modal mounted because they live outside #main. Loaded deferred; app.js
            // re-runs page init on htmx:afterSwap.
            writer.WriteLine("<script src=\"{0}/resources/htmx.min.js\" defer></script>", root);
            writer.WriteLine("<script src=\"{0}/resources/highlight.min.js\" defer></script>", root);
            writer.WriteLine("<script src=\"{0}/resources/hljs-csharp.min.js\" defer></script>", root);
            writer.WriteLine("<script src=\"{0}/resources/hljs-xml.min.js\" defer></script>", root);
            // Shared local-search scorer (also imported by search-worker.js).
            writer.WriteLine("<script src=\"{0}/resources/search-core.js\" defer></script>", root);
            // Client runtime, split into modules loaded in dependency order. `defer`
            // preserves document order, so app-core (shared helpers/namespace) runs
            // before sidebar/search, which run before app.js (page orchestration).
            writer.WriteLine("<script src=\"{0}/resources/app-core.js\" defer></script>", root);
            writer.WriteLine("<script src=\"{0}/resources/sidebar.js\" defer></script>", root);
            writer.WriteLine("<script src=\"{0}/resources/search.js\" defer></script>", root);
            writer.WriteLine("<script src=\"{0}/resources/app.js\" defer></script>", root);

            writer.WriteLine("</head>");

            // hx-boost turns same-origin <a> clicks into AJAX GETs; we target/select only
            // #main so the persistent chrome (topbar, sidebar, search modal — all outside
            // #main) is never swapped. scroll:top mimics the old scroll-to-top on nav.
            // data-tocid/data-service live on #main (not body) because body is not refreshed
            // by the swap; data-root is constant per depth so it stays on body.
            writer.WriteLine("<body data-root=\"{0}\" hx-boost=\"true\" hx-target=\"#main\" hx-select=\"#main\" hx-swap=\"outerHTML scroll:top\">",
                             root);

            // Hidden divs giving the search indexer the product title and guide name.
            writer.WriteLine("<div id=\"product_name\">AWS SDK Version 4 for .NET</div>");
            writer.WriteLine("<div id=\"guide_name\">API Reference</div>");

            WriteChrome(writer, root);

            writer.WriteLine("<div class=\"layout\">");
            WriteSidebar(writer, root);

            // #main is the htmx swap target, so the per-page identifiers ride on it (not
            // body) — they must be refreshed on every in-place navigation for sidebar
            // active-sync (data-tocid) and the assembly-version fetch (data-service).
            // tabindex="-1" lets app.js move focus here after an in-place swap (it is not a
            // Tab stop) so keyboard/screen-reader users land in the new content.
            writer.WriteLine("<main id=\"main\" role=\"main\" tabindex=\"-1\" data-tocid=\"{0}\" data-service=\"{1}\">",
                             o.TocId, o.Service);
            writer.WriteLine("<div class=\"content-shell\">");
        }

        /// <summary>
        /// Closes the elements opened by <see cref="WriteHeadAndChrome"/>
        /// (content-shell, main, layout) and the document.
        /// </summary>
        public static void WriteFootShell(TextWriter writer)
        {
            writer.WriteLine("</div>"); // .content-shell
            writer.WriteLine("</main>");
            writer.WriteLine("</div>"); // .layout
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
        }

        /// <summary>
        /// The fixed top bar: brand, mobile nav toggle, search form, theme toggle.
        /// Lives outside #main, so it is never part of the htmx swap and persists
        /// across in-place navigation without any special attribute.
        /// </summary>
        public static void WriteChrome(TextWriter writer, string root)
        {
            // Slim navigation progress bar, shown by app.js on htmx requests.
            writer.WriteLine("<div id=\"navProgress\" class=\"nav-progress\" hidden></div>");

            // Visually-hidden polite live region. Lives in the persistent chrome (outside
            // #main) so it survives htmx swaps; app.js writes the new page title into it
            // after each in-place navigation so screen-reader users are told the content
            // changed (cross-document loads announce the new <title> natively).
            writer.WriteLine("<div id=\"navAnnounce\" class=\"visually-hidden\" role=\"status\" aria-live=\"polite\"></div>");

            writer.WriteLine("<header id=\"topbar\">");

                writer.WriteLine("<button id=\"navToggle\" class=\"icon-btn\" type=\"button\" aria-label=\"Toggle navigation\">&#9776;</button>");

                writer.WriteLine("<a class=\"topbar-brand\" href=\"{0}/items/sdk-api-home.html\" aria-label=\"AWS SDK for .NET API Reference home\">", root);
                    // Inline AWS smile logo (vendored as SVG so it works offline / on .cn).
                    writer.WriteLine("<span class=\"brand-mark\" aria-hidden=\"true\">"
                        + "<svg viewBox=\"0 0 75 45\" xmlns=\"http://www.w3.org/2000/svg\" focusable=\"false\">"
                        + "<path class=\"aws-word\" d=\"M21.1 16.3c0 .9.1 1.6.3 2.1.2.5.4 1.1.8 1.7.1.2.2.4.2.6 0 .2-.1.5-.4.7l-1.4.9c-.2.1-.4.2-.6.2-.2 0-.5-.1-.7-.3-.3-.3-.6-.7-.8-1.1-.2-.4-.4-.8-.7-1.4-1.7 2-3.9 3-6.5 3-1.9 0-3.4-.5-4.5-1.6-1.1-1.1-1.6-2.5-1.6-4.3 0-1.9.7-3.5 2-4.6 1.4-1.2 3.2-1.7 5.5-1.7.8 0 1.6.1 2.4.2.8.1 1.7.3 2.6.5v-1.6c0-1.7-.4-2.9-1.1-3.6-.7-.7-2-1-3.7-1-.8 0-1.6.1-2.4.3-.8.2-1.6.4-2.4.7-.4.2-.6.2-.8.3-.2 0-.3.1-.4.1-.3 0-.5-.2-.5-.7v-1.1c0-.4.1-.6.2-.8.1-.2.4-.3.7-.5.8-.4 1.7-.7 2.8-1 1.1-.3 2.2-.4 3.4-.4 2.6 0 4.5.6 5.7 1.8 1.2 1.2 1.8 3 1.8 5.4v7.1zm-9 3.4c.8 0 1.6-.1 2.4-.4.8-.3 1.6-.8 2.2-1.5.4-.4.7-.9.8-1.5.1-.6.2-1.3.2-2.1v-1c-.7-.2-1.4-.3-2.2-.4-.8-.1-1.5-.1-2.3-.1-1.6 0-2.8.3-3.6 1-.8.6-1.2 1.5-1.2 2.7 0 1.1.3 1.9.9 2.5.5.6 1.4.8 2.6.8zm17.8 2.4c-.4 0-.7-.1-.9-.2-.2-.2-.4-.5-.5-.9l-5.4-17.8c-.2-.5-.2-.8-.2-1 0-.4.2-.6.6-.6h2.2c.4 0 .7.1.9.2.2.2.3.5.5.9l3.9 15.3 3.6-15.3c.1-.5.3-.8.5-.9.2-.2.5-.2.9-.2h1.8c.4 0 .7.1.9.2.2.2.4.5.5.9l3.6 15.5 4-15.5c.1-.5.3-.8.5-.9.2-.2.5-.2.9-.2h2.1c.4 0 .6.2.6.6 0 .1 0 .2-.1.4 0 .1-.1.3-.2.6l-5.5 17.8c-.1.5-.3.8-.5.9-.2.2-.5.2-.9.2h-1.9c-.4 0-.7-.1-.9-.2-.2-.2-.4-.5-.5-1l-3.6-14.9-3.6 14.9c-.1.5-.3.8-.5 1-.2.2-.5.2-.9.2h-1.9zm28.5.6c-1.1 0-2.2-.1-3.3-.4-1.1-.3-1.9-.5-2.5-.8-.4-.2-.6-.4-.7-.6-.1-.2-.1-.4-.1-.6v-1.1c0-.5.2-.7.5-.7.1 0 .3 0 .4.1.1 0 .3.1.6.2.7.3 1.5.6 2.3.7.8.2 1.7.2 2.5.2 1.3 0 2.4-.2 3.1-.7.7-.5 1.1-1.1 1.1-2 0-.6-.2-1.1-.6-1.5-.4-.4-1.1-.8-2.2-1.1l-3.1-1c-1.6-.5-2.7-1.2-3.4-2.2-.7-.9-1-2-1-3.1 0-.9.2-1.7.6-2.4.4-.7.9-1.3 1.6-1.7.7-.5 1.4-.8 2.3-1.1.9-.2 1.8-.3 2.7-.3.5 0 .9 0 1.4.1.5.1.9.1 1.3.2.4.1.8.2 1.1.3.4.1.6.3.8.4.2.1.4.3.5.5.1.2.1.4.1.7v1c0 .5-.2.8-.5.8-.2 0-.5-.1-.9-.3-1.3-.6-2.7-.9-4.3-.9-1.2 0-2.2.2-2.8.6-.6.4-.9 1-.9 1.8 0 .6.2 1.1.7 1.5.4.4 1.2.8 2.4 1.2l3 1c1.5.5 2.7 1.2 3.3 2.1.7.9 1 1.9 1 3.1 0 .9-.2 1.8-.6 2.5-.4.7-.9 1.4-1.6 1.9-.7.5-1.5.9-2.4 1.2-1 .3-2 .4-3.1.4z\"/>"
                        + "<path class=\"aws-smile\" d=\"M67.9 35.7C61.6 40.4 52.4 42.9 44.5 42.9c-11 0-21-4.1-28.5-10.9-.6-.5-.1-1.3.6-.9 8.1 4.7 18.1 7.6 28.5 7.6 7 0 14.7-1.5 21.8-4.5 1.1-.4 2 .7.9 1.5z\"/>"
                        + "<path class=\"aws-smile\" d=\"M70.5 32.7c-.8-1-5.3-.5-7.4-.3-.6.1-.7-.5-.1-.9 3.6-2.5 9.5-1.8 10.2-1 .7.9-.2 6.8-3.6 9.6-.5.4-1 .2-.8-.4.8-1.9 2.4-6 1.7-7z\"/>"
                        + "</svg>"
                        + "</span>");
                    writer.WriteLine("<span class=\"brand-text\">AWS SDK for .NET<small>API Reference &middot; v4</small></span>");
                writer.WriteLine("</a>");

                writer.WriteLine("<div class=\"topbar-spacer\"></div>");

                WriteSearchForm(writer, root);

                writer.WriteLine("<button id=\"themeToggle\" class=\"icon-btn\" type=\"button\" aria-label=\"Toggle light/dark theme\">");
                    writer.WriteLine("<span class=\"icon-sun\" aria-hidden=\"true\">&#9728;</span>");
                    writer.WriteLine("<span class=\"icon-moon\" aria-hidden=\"true\">&#9789;</span>");
                writer.WriteLine("</button>");

            writer.WriteLine("</header>");

            writer.WriteLine("<div id=\"navScrim\"></div>");

            WriteSearchModal(writer);
        }

        /// <summary>
        /// The local-search modal (command-palette style). Opened by app.js when the
        /// user starts typing in the default-scope topbar box, or via ⌘K / Ctrl-K / "/".
        /// Its own input (#searchModalInput) owns typing while open; results render live,
        /// grouped by kind. Lives outside #main, so it is mounted once and survives
        /// in-place navigation.
        /// </summary>
        public static void WriteSearchModal(TextWriter writer)
        {
            writer.WriteLine("<div id=\"searchModal\" class=\"search-modal\" hidden role=\"dialog\" aria-modal=\"true\" aria-label=\"Search the API reference\">");
                writer.WriteLine("<div class=\"search-modal-scrim\" data-search-close></div>");
                writer.WriteLine("<div class=\"search-modal-panel\" role=\"document\">");
                    writer.WriteLine("<div class=\"search-modal-head\">");
                        writer.WriteLine("<svg class=\"search-modal-ico\" viewBox=\"0 0 16 16\" width=\"18\" height=\"18\" aria-hidden=\"true\" focusable=\"false\"><path fill=\"currentColor\" d=\"M11.7 10.3a6 6 0 1 0-1.4 1.4l3 3a1 1 0 0 0 1.4-1.4l-3-3zM7 11a4 4 0 1 1 0-8 4 4 0 0 1 0 8z\"/></svg>");
                        writer.WriteLine("<input id=\"searchModalInput\" type=\"text\" role=\"combobox\" aria-label=\"Search the API reference\" aria-expanded=\"false\" aria-controls=\"searchModalResults\" aria-autocomplete=\"list\" autocomplete=\"off\" spellcheck=\"false\" placeholder=\"Search types, methods, properties…\"/>");
                        writer.WriteLine("<button type=\"button\" class=\"search-modal-close\" data-search-close aria-label=\"Close search\">&#10005;</button>");
                    writer.WriteLine("</div>");
                    writer.WriteLine("<div id=\"searchModalResults\" role=\"listbox\" aria-label=\"Search results\"></div>");
                    writer.WriteLine("<div class=\"search-modal-foot\">");
                        writer.WriteLine("<span><kbd>&#8593;</kbd><kbd>&#8595;</kbd> to navigate</span>");
                        writer.WriteLine("<span><kbd>&#8629;</kbd> to open</span>");
                        writer.WriteLine("<span><kbd>esc</kbd> to close</span>");
                    writer.WriteLine("</div>");
                writer.WriteLine("</div>");
            writer.WriteLine("</div>");
        }

        /// <summary>
        /// The persistent sidebar shell. The nav tree is hydrated client-side by app.js
        /// from toc.json; a no-script link to the static TOC.html keeps navigation
        /// reachable without JavaScript. Lives outside #main, so it is built once and
        /// survives in-place navigation.
        /// </summary>
        public static void WriteSidebar(TextWriter writer, string root)
        {
            writer.WriteLine("<aside id=\"sidebar\" aria-label=\"API navigation\">");
                writer.WriteLine("<div class=\"sidebar-filter\">");
                    writer.WriteLine("<input id=\"sidebarFilter\" type=\"text\" placeholder=\"Filter services &amp; types…\" aria-label=\"Filter navigation\" autocomplete=\"off\" spellcheck=\"false\"/>");
                writer.WriteLine("</div>");
                writer.WriteLine("<nav id=\"sidebarNav\">");
                    // SEO / no-JavaScript fallback: the full, crawlable table of contents.
                    writer.WriteLine("<noscript><a class=\"sidebar-noscript\" href=\"{0}/TOC.html\">Browse the full table of contents</a></noscript>", root);
                writer.WriteLine("</nav>");
            writer.WriteLine("</aside>");
        }

        /// <summary>
        /// The top-bar search form. The default scope ("Documentation - This Guide",
        /// value="documentation-guide") is handled locally by app.js: typing opens the
        /// search modal (see <see cref="WriteSearchModal"/>) which searches this API
        /// reference's own index. Every other scope keeps escalating to the external AWS
        /// documentation search (AWSHelpObj.searchFormSubmit). Markup/options unchanged.
        /// </summary>
        public static void WriteSearchForm(TextWriter writer, string root)
        {
            writer.WriteLine("<!-- BEGIN-SECTION -->");
            writer.WriteLine("<div id=\"search\">");
                // hx-boost="false": opt this form out of the body-level hx-boost. External
                // scopes are handled by AWSHelpObj.searchFormSubmit (which opens the modal or
                // window.open()s the AWS search); htmx must never AJAX-submit it to the
                // relative /search/doc-search.html action (that path 404s on our origin).
                writer.WriteLine("<form action=\"/search/doc-search.html\" target=\"_blank\" hx-boost=\"false\" onsubmit=\"return AWSHelpObj.searchFormSubmit(this);\" method=\"get\">");
                    writer.WriteLine("<div id=\"sfrm\">");
                        writer.WriteLine("<span id=\"lbl\"><label for=\"sel\">Search: </label></span>");
                        writer.WriteLine("<select aria-label=\"Search From\" name=\"searchPath\" id=\"sel\">");
                            writer.WriteLine("<option value=\"all\">Entire Site</option>");
                            writer.WriteLine("<option value=\"articles\">Articles &amp; Tutorials</option>");
                            writer.WriteLine("<option value=\"documentation\">Documentation</option>");
                            writer.WriteLine("<option value=\"documentation-product\">Documentation - This Product</option>");
                            writer.WriteLine("<option selected=\"\" value=\"documentation-guide\">Documentation - This Guide</option>");
                            writer.WriteLine("<option value=\"releasenotes\">Release Notes</option>");
                            writer.WriteLine("<option value=\"code\">Sample Code &amp; Libraries</option>");
                        writer.WriteLine("</select>");
                        writer.WriteLine("<div id=\"searchInputContainer\">");
                            writer.WriteLine("<input aria-label=\"Search\" type=\"text\" name=\"searchQuery\" id=\"sq\" placeholder=\"Search the docs…\" autocomplete=\"off\">");
                            writer.WriteLine("<button type=\"submit\" id=\"sb\" aria-label=\"Search\"><svg viewBox=\"0 0 16 16\" width=\"16\" height=\"16\" aria-hidden=\"true\" focusable=\"false\"><path fill=\"currentColor\" d=\"M11.7 10.3a6 6 0 1 0-1.4 1.4l3 3a1 1 0 0 0 1.4-1.4l-3-3zM7 11a4 4 0 1 1 0-8 4 4 0 0 1 0 8z\"/></svg></button>");
                        writer.WriteLine("</div>");
                    writer.WriteLine("</div>");
                    writer.WriteLine("<input id=\"this_doc_product\" type=\"hidden\" value=\"AWS SDK for .NET Version 4\" name=\"this_doc_product\">");
                    writer.WriteLine("<input id=\"this_doc_guide\" type=\"hidden\" value=\"API Reference\" name=\"this_doc_guide\">");
                    writer.WriteLine("<input id=\"doc_locale\" type=\"hidden\" value=\"en_us\" name=\"doc_locale\">");
                writer.WriteLine("</form>");
            writer.WriteLine("</div>");
            writer.WriteLine("<!-- END-SECTION -->");
        }
    }
}

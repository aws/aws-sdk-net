/* =====================================================================
   AWS SDK for .NET — API Reference client runtime: shared core
   ---------------------------------------------------------------------
   First of the runtime modules (app-core → sidebar → search → app), all
   plain "use strict" IIFEs loaded with `defer` so they run in document
   order with no build step. This module owns the pieces every other
   module needs: shared constants, DOM/URL helpers, and the theme toggle.
   Everything is hung off the single global namespace `window.AwsDocs`.
   ===================================================================== */
window.AwsDocs = window.AwsDocs || {};
(function (NS) {
  "use strict";

  /* ----------------------------- Constants -------------------------- */
  var THEME_KEY = "awsdocs-theme";
  // The default search scope ("Documentation - This Guide") is handled by the
  // local search modal; every other scope escalates to the external AWS search.
  NS.LOCAL_SCOPE = "documentation-guide";
  // The AWS documentation search lives only on docs.aws.amazon.com, so the
  // external-scope search always targets that host (not the current origin —
  // on a local/preview server the /search endpoint does not exist).
  NS.DOCS_BASE = "https://docs.aws.amazon.com";

  /* ------------------------------- Theme ---------------------------- */
  function preferredTheme() {
    try {
      var saved = localStorage.getItem(THEME_KEY);
      if (saved === "light" || saved === "dark") return saved;
    } catch (e) { /* private mode */ }
    return (window.matchMedia && window.matchMedia("(prefers-color-scheme: dark)").matches)
      ? "dark" : "light";
  }

  function applyTheme(theme) {
    document.documentElement.setAttribute("data-theme", theme);
  }

  function toggleTheme() {
    var next = document.documentElement.getAttribute("data-theme") === "dark" ? "light" : "dark";
    applyTheme(next);
    try { localStorage.setItem(THEME_KEY, next); } catch (e) { /* ignore */ }
  }

  // Apply ASAP (a tiny inline snippet in <head> already did this to avoid
  // FOUC; re-assert here in case the modules load standalone).
  applyTheme(preferredTheme());

  /* --------------------------- Doc-set root ------------------------- */
  // Resolved once and cached: every page's data-root resolves to the same
  // absolute doc-set root, so it is stable across htmx swaps.
  NS.rootAbs = null;

  function docRoot() {
    // RootRelativePath emitted on <body data-root>; resolve to an absolute
    // URL so sidebar/search links stay correct after htmx swaps the content.
    var rel = (document.body && document.body.getAttribute("data-root")) || ".";
    return new URL(rel.replace(/\/?$/, "/"), window.location.href);
  }

  function ensureRoot() {
    if (!NS.rootAbs) NS.rootAbs = docRoot();
    return NS.rootAbs;
  }

  function absHref(rootRelative) {
    return new URL(rootRelative, NS.rootAbs || docRoot()).href;
  }

  /* --------------------------- DOM helpers -------------------------- */
  function el(tag, cls, text) {
    var n = document.createElement(tag);
    if (cls) n.className = cls;
    if (text != null) n.textContent = text;
    return n;
  }

  // toc.json stores HTML-encoded display names (e.g. generics as "Foo&lt;&gt;")
  // because the static TOC.html fallback injects them as raw HTML. We render the
  // sidebar/search via textContent, so decode entities first to show "Foo<>".
  // Hot paths (filter / modal matching) precompute decoded names once instead of
  // calling this per keystroke — see sidebar.js loadSidebar.
  var _decoder = null;
  function decodeEntities(s) {
    if (s == null) return s;
    if (s.indexOf("&") === -1) return s;
    if (!_decoder) _decoder = document.createElement("textarea");
    _decoder.innerHTML = s;
    return _decoder.value;
  }

  function cssEscape(s) {
    if (window.CSS && CSS.escape) return CSS.escape(s);
    return String(s).replace(/["\\\]]/g, "\\$&");
  }

  // Navigate via htmx when available (in-place #main swap + history push), else a
  // normal load. `push` records the URL in history so it behaves like navigation.
  function navigateTo(href) {
    if (window.htmx) {
      window.htmx.ajax("GET", href, {
        target: "#main", select: "#main", swap: "outerHTML scroll:top", push: href
      });
    } else {
      window.location.assign(href);
    }
  }

  // Idempotent wiring guard: returns true and runs fn() the first time a given
  // (node, attr) is seen, false on every later call. Replaces the scattered
  // data-*="1" sentinel checks so event listeners are bound exactly once even
  // though onPageLoad runs on every htmx:afterSwap.
  function once(node, attr, fn) {
    if (!node || node.getAttribute(attr) === "1") return false;
    node.setAttribute(attr, "1");
    if (fn) fn();
    return true;
  }

  /* ------------------------------ Exports --------------------------- */
  NS.preferredTheme = preferredTheme;
  NS.applyTheme = applyTheme;
  NS.toggleTheme = toggleTheme;
  NS.docRoot = docRoot;
  NS.ensureRoot = ensureRoot;
  NS.absHref = absHref;
  NS.el = el;
  NS.decodeEntities = decodeEntities;
  NS.cssEscape = cssEscape;
  NS.navigateTo = navigateTo;
  NS.once = once;
})(window.AwsDocs);

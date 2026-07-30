/* =====================================================================
   AWS SDK for .NET — API Reference client runtime: page orchestration
   ---------------------------------------------------------------------
   Last of the runtime modules (app-core → sidebar → search → app). Owns
   per-page behavior that runs on every htmx navigation, the highlight.js
   re-run, the in-article "In this article" dropdown, and the back-compat
   AWSHelpObj / toggleTOC globals that generated pages still call inline.

   The heavy lifting lives in the other modules:
     app-core.js  — shared constants, DOM/URL helpers, theme.
     sidebar.js   — toc.json hydration, filter, active-sync, mobile drawer.
     search.js    — local search modal, worker, external-scope search.
   All four attach to the single global window.AwsDocs.
   ===================================================================== */
(function (NS) {
  "use strict";

  /* ---------------------------- highlight --------------------------- */
  function highlight() {
    if (!window.hljs) return;
    var blocks = document.querySelectorAll("#main pre code:not(.hljs)");
    for (var i = 0; i < blocks.length; i++) {
      try { window.hljs.highlightElement(blocks[i]); } catch (e) { /* ignore */ }
    }
  }

  /* --------------------- Per-page (htmx) helpers -------------------- */
  // Region disclaimer: show only on China (.cn) hosts.
  function applyRegionDisclaimer() {
    var d = document.getElementById("regionDisclaimer");
    if (!d) return;
    var host = window.location.host || "";
    if (/\.cn$/i.test(host)) d.style.display = "block";
    else if (d.parentNode) d.parentNode.removeChild(d);
  }

  function applyAssemblyVersion() {
    var holder = document.getElementById("assemblyVersion");
    if (!holder) return;
    var vfile = holder.getAttribute("data-version-file");
    var svc = holder.getAttribute("data-service");
    if (!vfile) return;

    function hideVersion() {
      var vd = document.getElementById("versionData");
      if (vd) vd.style.display = "none";
    }

    fetch(new URL(vfile, window.location.href).href)
      .then(function (r) { return r.ok ? r.json() : null; })
      .then(function (data) {
        if (!data) { hideVersion(); return; }
        var v = (svc && data.ServiceVersions && data.ServiceVersions[svc])
          ? data.ServiceVersions[svc].Version
          : data.CoreVersion;
        if (v) holder.textContent = v;
        else hideVersion();
      })
      .catch(hideVersion);
  }

  function applyCopyright() {
    var html = "&copy; Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.";
    var targets = ["copyright", "awsdocs-legal-zone-copyright"];
    targets.forEach(function (id) {
      var n = document.getElementById(id);
      if (n && !n.innerHTML.trim()) n.innerHTML = html;
    });
  }

  /* ----- In-article TOC (the #pageTOC widget on class pages) --------
     The markup carries an inline onclick="toggleTOC()" on the heading, so the
     global toggleTOC (exported at the bottom of this file) is the single source
     of truth. We do NOT add a second listener here (that caused a double-toggle
     that cancelled itself out). We just normalize the initial state and close
     it on an outside click. */
  function wirePageToc() {
    var toc = document.getElementById("pageTOC");
    if (!toc) return;
    // The generator renders #pageTOC inside #pageHeader (right of the title).
    // Collapsed by default: the dropdown panel (tocList) is hidden until the
    // user clicks the "In this article" button.
    var list = document.getElementById("tocList");
    var toggle = document.getElementById("tocToggle");
    if (list) list.style.display = "none";
    if (toggle) toggle.textContent = "▾"; // down-pointing affordance (closed)
    var btn = toc.querySelector("h2 button");
    if (btn) btn.setAttribute("aria-expanded", "false");
    // Close the dropdown when clicking outside of it (bound once at document level).
    NS.once(document.documentElement, "data-pagetoc-bound", function () {
      document.addEventListener("click", function (ev) {
        var t = document.getElementById("pageTOC");
        var l = document.getElementById("tocList");
        if (!t || !l) return;
        if (getComputedStyle(l).display !== "none" && !t.contains(ev.target)) {
          setPageTocOpen(false);
        }
      });
    });
  }

  function setPageTocOpen(open) {
    var list = document.getElementById("tocList");
    var toggle = document.getElementById("tocToggle");
    if (!list || !toggle) return;
    list.style.display = open ? "block" : "none";
    toggle.textContent = open ? "▴" : "▾"; // open / closed affordance
    var btn = document.querySelector("#pageTOC h2 button");
    if (btn) btn.setAttribute("aria-expanded", open ? "true" : "false");
  }

  function togglePageToc() {
    var list = document.getElementById("tocList");
    if (!list) return;
    setPageTocOpen(getComputedStyle(list).display === "none");
  }

  /* --------------------------- Page init ---------------------------- */
  // `swapped` is true when called from htmx:afterSwap (an in-place navigation),
  // false on the initial DOMContentLoaded. Focus/announcement only happen on a
  // swap — on first paint the native document load already handles both.
  function onPageLoad(swapped) {
    NS.wireChrome();
    NS.closeDrawer();
    NS.ensureRoot();
    NS.loadSidebar();
    NS.wireSearch();
    NS.closeSearchModal(); // dismiss the modal after an in-place navigation
    NS.syncActive();
    highlight();
    applyRegionDisclaimer();
    applyAssemblyVersion();
    applyCopyright();
    wirePageToc();
    if (swapped === true) focusAndAnnounceAfterSwap();
  }

  // After an in-place (htmx) swap the whole #main is replaced, so focus falls back
  // to <body> and screen readers get no signal that the page changed. Move focus to
  // the new #main (tabindex="-1", non-Tab-stop) and announce the new title in the
  // persistent live region so keyboard/SR users land in — and are told about — the
  // new content. §7.4 of the modernization design requires this explicitly.
  function focusAndAnnounceAfterSwap() {
    var main = document.getElementById("main");
    if (main) {
      try { main.focus({ preventScroll: true }); } catch (e) { main.focus(); }
    }
    var live = document.getElementById("navAnnounce");
    if (live) {
      var h1 = main && main.querySelector("h1");
      var label = (h1 && h1.textContent.trim()) || document.title;
      // Reassigning textContent (even to the same string is rare here) triggers the
      // aria-live announcement.
      live.textContent = label;
    }
  }

  // htmx:load fires only for htmx-swapped content, NOT the initial document, so
  // drive init from both: DOMContentLoaded for first paint, htmx:afterSwap for
  // every in-place navigation. onPageLoad is idempotent (once() guards) so a
  // double-invocation is harmless.
  document.addEventListener("DOMContentLoaded", function () { onPageLoad(false); });
  document.addEventListener("htmx:afterSwap", function () { onPageLoad(true); });

  // Scroll handling for in-place navigation. htmx's `scroll:top` targets the swapped
  // element (#main), which is not a scroll container in this layout (the window
  // scrolls), so it is a no-op — a boosted/search/sidebar nav would otherwise keep
  // the previous scroll offset. Scroll the window to top on each swap, UNLESS the
  // target URL carries a #fragment, so member deep-links (e.g. #prop_Foo) still land
  // on their row. Runs after settle so the swapped-in content/anchor exists.
  //
  // Two things fight this and must be neutralized: (1) the browser's automatic
  // scroll restoration on history navigation (htmx pushes history), and (2) the
  // global `scroll-behavior: smooth` on <html>, which would animate — and let htmx's
  // own scrollIntoViewOnBoost interrupt — the reset. So take over scroll restoration
  // and force an instant jump.
  if ("scrollRestoration" in history) history.scrollRestoration = "manual";
  document.addEventListener("htmx:afterSettle", function () {
    var hash = window.location.hash;
    if (hash && hash.length > 1) {
      var target = document.getElementById(decodeURIComponent(hash.slice(1)));
      if (target && target.scrollIntoView) { target.scrollIntoView(); return; }
    }
    // Instant (not smooth) so it can't be interrupted mid-animation.
    if (window.scrollTo) {
      try { window.scrollTo({ top: 0, left: 0, behavior: "auto" }); }
      catch (e) { window.scrollTo(0, 0); }
    }
  });

  /* ------------------------- Nav progress bar ----------------------- */
  // htmx has no built-in progress bar; drive a slim top bar off request events.
  function wireNavProgress() {
    var bar = document.getElementById("navProgress");
    if (!bar) return;
    function show() { bar.hidden = false; bar.classList.add("is-active"); }
    function hide() { bar.classList.remove("is-active"); bar.hidden = true; }
    document.addEventListener("htmx:beforeRequest", show);
    document.addEventListener("htmx:afterRequest", hide);
    // Safety net: clear the bar once content has settled.
    document.addEventListener("htmx:afterSettle", hide);
  }
  // The progress bar element lives in the persistent chrome (outside #main), so
  // wire it once at script load rather than on every swap.
  if (document.readyState === "loading")
    document.addEventListener("DOMContentLoaded", wireNavProgress);
  else
    wireNavProgress();

  /* --------------------- Back-compat global API --------------------- */
  // Preserved so any inline calls on generated/landing pages keep working.
  window.AWSHelpObj = {
    toggleTheme: NS.toggleTheme,
    showRegionalDisclaimer: function (host) { return /\.cn$/i.test(host || ""); },
    setCopyrightText: applyCopyright,
    setAssemblyVersion: applyAssemblyVersion,
    searchFormSubmit: NS.searchFormSubmit,
    displayLink: function () {
      var url = window.location.href.split("#")[0];
      window.prompt("Copy this URL to link to this page", url);
    }
  };

  // Legacy global used by the old in-article TOC markup.
  window.toggleTOC = togglePageToc;
})(window.AwsDocs);

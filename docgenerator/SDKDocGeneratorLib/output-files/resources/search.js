/* =====================================================================
   AWS SDK for .NET — API Reference client runtime: local search
   ---------------------------------------------------------------------
   The default scope ("Documentation - This Guide") searches THIS API
   reference locally in a command-palette modal; every other scope keeps
   escalating to the external AWS search (searchFormSubmit).

   The modal opens when the user starts typing in the topbar box (the
   keystroke is handed off to the modal's own input), or via ⌘K / Ctrl-K /
   "/". Results render live, grouped by kind.

   Two result sources, ranked on one scale by the shared scorer in
   search-core.js (self.AwsDocsSearch.score):
     • types + namespaces — matched synchronously from the in-memory
       NS.tocData (loaded by sidebar.js), so they appear with zero latency.
     • members (methods/properties/fields/events/enum) — matched in
       search-worker.js off the main thread; they merge in a beat later.

   Depends on app-core.js + sidebar.js (window.AwsDocs).
   ===================================================================== */
(function (NS) {
  "use strict";

  var el = NS.el, absHref = NS.absHref, navigateTo = NS.navigateTo, once = NS.once;
  var LOCAL_SCOPE = NS.LOCAL_SCOPE;

  var SEARCH_LIMIT = 50;         // total rows shown; overflow noted, never silent
  var SEARCH_DEBOUNCE_MS = 90;   // coalesce keystrokes before scanning toc data
  var score = (self.AwsDocsSearch && self.AwsDocsSearch.score) || null;

  /* ---------------------- Result-kind taxonomy ----------------------
     Single source of truth for the result kinds. The numeric codes match
     TOCWriter (1 method, 2 property, 3 field, 4 event, 5 enum-member); "ns"
     and "type" are local pseudo-kinds for the tocData matches. GROUPS (display
     order), the icon mapping, and the tie-break rank are all derived from this
     one table so they cannot drift. If you add a kind, add it HERE and in
     TOCWriter's Kind* constants. */
  var KIND_TABLE = [
    { code: "ns",   label: "Namespaces",  icon: "ico-namespace", rank: 0 },
    { code: "type", label: "Types",       icon: "ico-class",     rank: 1 },
    { code: 1,      label: "Methods",     icon: "ico-method",    rank: 2 },
    { code: 2,      label: "Properties",  icon: "ico-property",  rank: 2 },
    { code: 3,      label: "Fields",      icon: "ico-field",     rank: 2 },
    { code: 4,      label: "Events",      icon: "ico-event",     rank: 2 },
    { code: 5,      label: "Enum values", icon: "ico-enum",      rank: 2 }
  ];
  var KIND_BY_CODE = {};
  KIND_TABLE.forEach(function (k) { KIND_BY_CODE[k.code] = k; });

  // Result groups in display order (one per kind that can appear).
  var GROUPS = KIND_TABLE.map(function (k) {
    return { code: k.code, label: k.label };
  });

  function kindIconClass(kind) {
    var k = KIND_BY_CODE[kind];
    return k ? k.icon : "ico-class";
  }

  function kindRank(kind) {
    var k = KIND_BY_CODE[kind];
    return k ? k.rank : 2;
  }

  /* ------------------------------ State ----------------------------- */
  var searchWorker = null;       // lazy; null if Workers unavailable
  var workerReady = false;
  var workerBase = "items";      // content sub-folder reported by the worker (A2)
  var searchSeq = 0;             // monotonic; ignore stale worker replies
  var lastQuery = "";
  var memberResults = [];        // most recent member matches from the worker
  var activeIndex = -1;          // highlighted row (flattened across groups)
  var currentRows = [];          // descriptors backing the rendered rows, in order
  var lastFocus = null;          // element focused before the modal opened (restored on close)
  var debounceTimer = null;

  function isLocalScope() {
    var sel = document.getElementById("sel");
    return !sel || sel.value === LOCAL_SCOPE;
  }

  /* ------------------------------ Worker ---------------------------- */
  function ensureWorker() {
    if (searchWorker || workerReady) return;
    if (typeof Worker === "undefined") return; // file:// or no worker support
    var rootAbs = NS.ensureRoot();
    try {
      searchWorker = new Worker(new URL("resources/search-worker.js", rootAbs).href);
      searchWorker.onmessage = function (ev) {
        var msg = ev.data || {};
        if (msg.type === "ready") {
          workerReady = true;
          if (msg.base) workerBase = msg.base;
          if (lastQuery) postWorkerQuery(lastQuery);
        } else if (msg.type === "results") {
          if (msg.seq !== searchSeq) return; // stale
          memberResults = msg.items || [];
          renderModalResults();
        }
      };
      searchWorker.onerror = function () { searchWorker = null; };
      searchWorker.postMessage({ type: "init", indexUrl: new URL("search-index.json", rootAbs).href });
    } catch (e) { searchWorker = null; }
  }

  function postWorkerQuery(q) {
    if (!searchWorker || !workerReady) return;
    searchWorker.postMessage({ type: "query", q: q, seq: searchSeq, limit: SEARCH_LIMIT });
  }

  /* --------------------------- Matching ----------------------------- */
  // Match types + namespaces from the in-memory toc data (instant, no fetch).
  // Names are precomputed-decoded by sidebar.js (ns.dname / node.dname).
  function matchTocData(q) {
    var out = [];
    var tocData = NS.tocData;
    if (!tocData || !tocData.namespaces || !score) return out;
    for (var i = 0; i < tocData.namespaces.length; i++) {
      var ns = tocData.namespaces[i];
      var s = score(ns.dname, q);
      if (s >= 0) out.push({ kind: "ns", name: ns.dname, href: ns.href, type: "", score: s });
      var nodes = ns.nodes || [];
      for (var j = 0; j < nodes.length; j++) {
        var ts = score(nodes[j].dname, q);
        if (ts >= 0) out.push({ kind: "type", name: nodes[j].dname, href: nodes[j].href, type: ns.dname, score: ts });
      }
    }
    return out;
  }

  // Combine the (instant) toc matches with the (async) member matches into one
  // score-sorted list, capped at SEARCH_LIMIT.
  function mergedMatches() {
    var merged = matchTocData(lastQuery.toLowerCase());
    for (var i = 0; i < memberResults.length; i++) {
      var m = memberResults[i];
      merged.push({
        kind: m.kind,
        name: m.name,
        // worker hrefs are root-relative: <base>/<folder>/<file>[#anchor]
        href: workerBase + "/" + m.folder + "/" + m.file,
        // The declaring-type context comes from search-index.json HTML-encoded
        // (e.g. generic "Constant&lt;T&gt;"); decode so it renders like the
        // toc-sourced type results (which use decoded dname).
        type: NS.decodeEntities(m.type || ""),
        score: m.score
      });
    }
    merged.sort(function (a, b) {
      if (b.score !== a.score) return b.score - a.score;
      var kr = kindRank(a.kind) - kindRank(b.kind);
      if (kr) return kr;
      return a.name.localeCompare(b.name);
    });
    return merged;
  }

  /* --------------------------- Rendering ---------------------------- */
  // Render the modal body: results partitioned into kind groups (fixed order),
  // each group keeping its members in score order. currentRows is a flat array
  // in the same visual order so ↑/↓/Enter traverse across groups.
  function renderModalResults() {
    var box = document.getElementById("searchModalResults");
    if (!box) return;

    box.textContent = "";
    currentRows = [];
    activeIndex = -1;

    var input = document.getElementById("searchModalInput");
    if (input) {
      input.removeAttribute("aria-activedescendant");
      input.setAttribute("aria-expanded", "false");
    }

    if (!lastQuery) {
      box.appendChild(el("div", "search-empty", "Type to search types, methods, properties…"));
      return;
    }

    var all = mergedMatches();
    var overflow = all.length - SEARCH_LIMIT;
    if (overflow > 0) all.length = SEARCH_LIMIT;

    if (!all.length) {
      box.appendChild(el("div", "search-empty", "No matches for “" + lastQuery + "”"));
      return;
    }

    var frag = document.createDocumentFragment();
    GROUPS.forEach(function (g) {
      var rows = all.filter(function (r) { return r.kind === g.code; });
      if (!rows.length) return;
      var group = el("div", "search-group");
      group.appendChild(el("div", "search-group-head", g.label));
      rows.forEach(function (r) {
        var idx = currentRows.length;
        currentRows.push(r);
        var row = el("a", "search-result");
        row.href = absHref(r.href);
        row.id = "search-opt-" + idx;      // referenced by aria-activedescendant
        row.setAttribute("role", "option");
        row.setAttribute("aria-selected", "false");
        row.setAttribute("data-idx", String(idx));
        row.appendChild(el("span", "search-ico " + kindIconClass(r.kind)));
        row.appendChild(el("span", "search-name", r.name));
        if (r.type) row.appendChild(el("span", "search-context", r.type));
        // Hover follows the mouse; click navigates (htmx handles the load).
        row.addEventListener("mousemove", function () { setActive(idx); });
        row.addEventListener("click", function (ev) {
          // Let modified/middle clicks fall through to the native href so
          // Ctrl/Cmd/Shift-click and open-in-new-tab keep working.
          if (ev.defaultPrevented) return;
          if (ev.button !== 0 || ev.metaKey || ev.ctrlKey || ev.shiftKey || ev.altKey) return;
          ev.preventDefault();
          var href = absHref(r.href);
          closeSearchModal();
          navigateTo(href);
        });
        group.appendChild(row);
      });
      frag.appendChild(group);
    });
    box.appendChild(frag);

    if (overflow > 0) {
      box.appendChild(el("div", "search-overflow",
        "+" + overflow + " more — refine your query to narrow results"));
    }

    if (currentRows.length) {
      if (input) input.setAttribute("aria-expanded", "true"); // listbox now has options
      setActive(0);
    }
  }

  function setActive(idx) {
    var box = document.getElementById("searchModalResults");
    if (!box) return;
    var rows = box.querySelectorAll(".search-result");
    var input = document.getElementById("searchModalInput");
    if (!rows.length) {
      activeIndex = -1;
      if (input) input.removeAttribute("aria-activedescendant");
      return;
    }
    if (idx < 0) idx = rows.length - 1;
    if (idx >= rows.length) idx = 0;
    for (var i = 0; i < rows.length; i++) {
      rows[i].classList.remove("is-active");
      rows[i].setAttribute("aria-selected", "false");
    }
    rows[idx].classList.add("is-active");
    rows[idx].setAttribute("aria-selected", "true");
    // Point the combobox at the active option so screen readers announce it
    // while focus stays in the input (ARIA activedescendant pattern).
    if (input && rows[idx].id) input.setAttribute("aria-activedescendant", rows[idx].id);
    if (rows[idx].scrollIntoView) rows[idx].scrollIntoView({ block: "nearest" });
    activeIndex = idx;
  }

  /* ----------------------- Open / close / run ----------------------- */
  function modalOpen() {
    var modal = document.getElementById("searchModal");
    return modal && !modal.hidden;
  }

  // Open the modal, seeding its input with seedText (caret at end) and running
  // a query. Idempotent: a second call just re-seeds and re-queries.
  function openSearchModal(seedText) {
    var modal = document.getElementById("searchModal");
    var input = document.getElementById("searchModalInput");
    if (!modal || !input) return;
    // Remember what had focus so we can restore it on close (a11y).
    if (!modalOpen()) lastFocus = document.activeElement;
    modal.hidden = false;
    document.body.classList.add("search-modal-open");
    input.value = seedText || "";
    input.focus();
    // Caret to end (focus on some browsers selects all).
    try { var n = input.value.length; input.setSelectionRange(n, n); } catch (e) { /* ignore */ }
    runSearch(input.value);
  }

  function closeSearchModal() {
    var modal = document.getElementById("searchModal");
    if (modal) modal.hidden = true;
    document.body.classList.remove("search-modal-open");
    var mInput = document.getElementById("searchModalInput");
    if (mInput) {
      mInput.removeAttribute("aria-activedescendant");
      mInput.setAttribute("aria-expanded", "false");
    }
    // Clear the topbar launcher box so it never shows a stale half-typed query.
    var sq = document.getElementById("sq");
    if (sq) sq.value = "";
    lastQuery = "";
    memberResults = [];
    currentRows = [];
    activeIndex = -1;
    searchSeq++;
    clearTimeout(debounceTimer);
    // Restore focus to whatever opened the modal (keyboard users land back where
    // they were, not at the top of the document).
    if (lastFocus && lastFocus.focus && document.contains(lastFocus)) {
      try { lastFocus.focus(); } catch (e) { /* ignore */ }
    }
    lastFocus = null;
  }

  // Run a search for q: instant toc matches now, member matches when the worker
  // replies. Empty q clears results but leaves the modal open.
  function runSearch(q) {
    q = (q || "").trim();
    lastQuery = q;
    searchSeq++;
    memberResults = [];
    if (!q) { renderModalResults(); return; }
    ensureWorker();
    postWorkerQuery(q);
    renderModalResults(); // show instant toc matches immediately
  }

  /* --------------------------- Input wiring ------------------------- */
  // Keystroke handoff: when the user types in the default-scope topbar box, open
  // the modal seeded with the typed text and clear the box (so the character is
  // not duplicated and the modal owns input). Using the "input" event guarantees
  // the value already includes the keystroke (also covers paste / IME).
  function onTopbarInput() {
    var input = document.getElementById("sq");
    if (!input) return;
    if (!isLocalScope()) return;       // external scope: leave the native form alone
    var v = input.value;
    if (!v) return;
    input.value = "";
    openSearchModal(v);
  }

  function onModalInput() {
    var input = document.getElementById("searchModalInput");
    if (!input) return;
    // Debounce: matchTocData scans every namespace + type, so coalesce bursts of
    // keystrokes (the worker query is debounced with it).
    clearTimeout(debounceTimer);
    var v = input.value;
    debounceTimer = setTimeout(function () { runSearch(v); }, SEARCH_DEBOUNCE_MS);
  }

  function onModalKeydown(ev) {
    switch (ev.key) {
      case "ArrowDown": ev.preventDefault(); setActive(activeIndex + 1); break;
      case "ArrowUp":   ev.preventDefault(); setActive(activeIndex - 1); break;
      case "Enter":
        if (activeIndex >= 0 && currentRows[activeIndex]) {
          ev.preventDefault();
          var href = absHref(currentRows[activeIndex].href);
          closeSearchModal();
          navigateTo(href);
        }
        break;
      case "Escape":
        ev.preventDefault();
        closeSearchModal();
        break;
    }
  }

  // ⌘K / Ctrl-K and "/" open the modal from anywhere; Esc closes it. "/" is
  // ignored while typing in a field so it doesn't hijack normal input.
  function onGlobalKeydown(ev) {
    var k = ev.key;
    if ((k === "k" || k === "K") && (ev.metaKey || ev.ctrlKey)) {
      ev.preventDefault();
      if (modalOpen()) closeSearchModal(); else openSearchModal("");
      return;
    }
    if (k === "/" && !modalOpen() && !isTypingTarget(ev.target)) {
      ev.preventDefault();
      openSearchModal("");
      return;
    }
    if (k === "Escape" && modalOpen()) { ev.preventDefault(); closeSearchModal(); }
  }

  function isTypingTarget(t) {
    if (!t) return false;
    var tag = t.tagName;
    return tag === "INPUT" || tag === "TEXTAREA" || tag === "SELECT" || t.isContentEditable;
  }

  // Trap Tab focus within the open modal so keyboard users can't tab out into the
  // (inert) page behind it; Shift-Tab wraps backwards. Bound once on the panel.
  function onModalTabTrap(ev) {
    if (ev.key !== "Tab" || !modalOpen()) return;
    var modal = document.getElementById("searchModal");
    var focusables = modal.querySelectorAll(
      'input, button, a[href], [tabindex]:not([tabindex="-1"])');
    var visible = [];
    for (var i = 0; i < focusables.length; i++) {
      if (focusables[i].offsetParent !== null) visible.push(focusables[i]);
    }
    if (!visible.length) return;
    var first = visible[0], last = visible[visible.length - 1];
    if (ev.shiftKey && document.activeElement === first) {
      ev.preventDefault(); last.focus();
    } else if (!ev.shiftKey && document.activeElement === last) {
      ev.preventDefault(); first.focus();
    }
  }

  function wireSearch() {
    var input = document.getElementById("sq");
    if (input) {
      once(input, "data-search-wired", function () {
        input.addEventListener("input", onTopbarInput);
        // If the user re-focuses the launcher and it already has text, hand off.
        input.addEventListener("focus", function () { if (isLocalScope() && input.value) onTopbarInput(); });
      });
    }

    var mInput = document.getElementById("searchModalInput");
    if (mInput) {
      once(mInput, "data-search-wired", function () {
        mInput.addEventListener("input", onModalInput);
        mInput.addEventListener("keydown", onModalKeydown);
      });
    }

    // data-search-close elements (scrim + close button) dismiss the modal; the
    // panel also hosts the Tab focus-trap.
    var modal = document.getElementById("searchModal");
    if (modal) {
      once(modal, "data-search-wired", function () {
        var closers = modal.querySelectorAll("[data-search-close]");
        for (var i = 0; i < closers.length; i++) {
          closers[i].addEventListener("click", closeSearchModal);
        }
        modal.addEventListener("keydown", onModalTabTrap);
      });
    }

    // Global shortcuts: bind once at the document level (survives htmx swaps).
    once(document.documentElement, "data-search-global-bound", function () {
      document.addEventListener("keydown", onGlobalKeydown);
    });
  }

  /* ---------------------- External AWS search -----------------------
     Non-local scopes target the external AWS documentation search. The scope
     <select> (#sel) determines where it searches: "documentation*" scopes hit
     the docs search endpoint with doc_product / doc_guide facets; everything
     else falls back to the site-wide AWS search.

     We build the full target URL (path?query#fragment) explicitly and open it
     ourselves, rather than relying on the browser's native form-GET. Native
     submission with a #fragment in the action is fragile — depending on the
     host it can drop the ".html" extension and/or the query string — and the
     production URL must look like:
       /search/doc-search.html?searchPath=…&searchQuery=…&this_doc_product=…
         &this_doc_guide=…&doc_locale=en_us#facet_doc_product=…
     (The "this guide" scope is served locally by the modal, so this code path only
     ever emits the product facet — never a guide facet.)
  */
  function searchFormSubmit(formElement) {
    var scope = valueOf("sel", "documentation-guide");
    var query = valueOf("sq", "");

    // Default scope is handled locally (the search modal); never submit it to
    // the external search. Submitting the topbar form opens the modal seeded
    // with whatever was typed there.
    if (scope === LOCAL_SCOPE) {
      openSearchModal(query);
      return false;
    }
    var docProduct = valueOf("this_doc_product", "AWS SDK for .NET Version 4");
    var docGuide = valueOf("this_doc_guide", "API Reference");
    var locale = valueOf("doc_locale", "en_us");

    var url;
    if (scope.indexOf("documentation") === 0) {
      // x-www-form-urlencoded query (spaces as "+") to match the docs search.
      var qs = [
        "searchPath=" + enc(scope),
        "searchQuery=" + enc(query),
        "this_doc_product=" + enc(docProduct),
        "this_doc_guide=" + enc(docGuide),
        "doc_locale=" + enc(locale)
      ].join("&");

      // Facet fragment (spaces as "%20") for the "this product" scope. The
      // "documentation-guide" scope never reaches here — it is intercepted above
      // and handled locally by the modal — so only "documentation-product" adds a
      // facet (product only; a guide facet would require the guide scope).
      var facet = "";
      if (scope === "documentation-product") {
        facet = "#facet_doc_product=" + encodeURIComponent(docProduct);
      }
      url = NS.DOCS_BASE + "/search/doc-search.html?" + qs + facet;
    } else {
      url = "https://aws.amazon.com/search?searchQuery=" + enc(query);
    }

    window.open(url, "_blank", "noopener");
    return false; // we navigated ourselves; cancel the native submit

    function valueOf(id, fallback) {
      var n = document.getElementById(id);
      return n && n.value !== "" ? n.value : (fallback || "");
    }
    // application/x-www-form-urlencoded component: spaces become "+".
    function enc(s) { return encodeURIComponent(s).replace(/%20/g, "+"); }
  }

  /* ------------------------------ Exports --------------------------- */
  NS.wireSearch = wireSearch;
  NS.closeSearchModal = closeSearchModal;
  NS.searchFormSubmit = searchFormSubmit;
})(window.AwsDocs);

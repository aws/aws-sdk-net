/* =====================================================================
   AWS SDK for .NET — API Reference client runtime: sidebar + chrome
   ---------------------------------------------------------------------
   Hydrates the persistent sidebar once from toc.json (loaded for the whole
   SDK, not inlined into every page), keeps the active node in sync on every
   htmx navigation, filters the tree, and wires the top-bar chrome (mobile
   drawer, theme button). Depends on app-core.js (window.AwsDocs).

   The parsed toc.json is published as NS.tocData so search.js can match
   types/namespaces from it synchronously (zero-latency, no extra fetch).
   ===================================================================== */
(function (NS) {
  "use strict";

  var el = NS.el, decodeEntities = NS.decodeEntities, cssEscape = NS.cssEscape,
      absHref = NS.absHref, once = NS.once, navigateTo = NS.navigateTo;

  // Sidebar links are built in JS *after* page load, so htmx's hx-boost (which only
  // processes anchors present when it initializes / in swapped content) does not
  // boost them — a plain click would trigger a full page load. Route left-clicks
  // through navigateTo() for an in-place swap, but leave modified clicks
  // (Ctrl/Cmd/middle/shift = open in new tab/window) and the real href alone so the
  // no-JS fallback and "open in new tab" keep working.
  function boostClick(ev, href) {
    if (ev.defaultPrevented) return;
    if (ev.button !== 0 || ev.metaKey || ev.ctrlKey || ev.shiftKey || ev.altKey) return;
    ev.preventDefault();
    navigateTo(href);
  }

  /* ----------------------------- Sidebar ----------------------------
     Service-grouped tree. Related namespaces fold under a header named by their
     common prefix (e.g. "Amazon.S3" gathers Amazon.S3, Amazon.S3.Model, …) so the
     top level stays short across 225 services. When that prefix is itself a
     namespace, its header IS that namespace (a clickable link that also expands
     to the sub-namespaces + its own types). Each level expands lazily. */
  var topNodes = [];         // ordered top-level node descriptors {kind, data}
  var idIndex = {};          // page tocid -> { highlightId, chainIds:[ancestor ids] }
  var sidebarBuilt = false;

  function serviceId(service) {
    return "svc__" + String(service).replace(/[^A-Za-z0-9_]/g, "_");
  }

  // Build the top-level list. Namespaces are grouped by service key, then each
  // group is collapsed to the most intuitive shape:
  //   * 1 namespace            → that namespace is shown directly (no wrapper).
  //   * the group's common prefix IS one of its namespaces (e.g. "Amazon.S3"
  //     with Amazon.S3 + Amazon.S3.Model + …) → that root namespace BECOMES the
  //     header: a clickable link to its page that expands to reveal the
  //     sub-namespaces and its own types (no redundant duplicate child).
  //   * otherwise (prefix isn't itself a namespace) → a plain expandable group.
  // idIndex maps any page's tocid to {highlightId, chainIds} so the active page
  // can be located and its ancestors expanded.
  function buildGroups(tocData) {
    topNodes = [];
    idIndex = {};
    var byService = {};
    var order = [];
    tocData.namespaces.forEach(function (ns) {
      var key = ns.service || ns.name;
      var g = byService[key];
      if (!g) { g = { namespaces: [] }; byService[key] = g; order.push(g); }
      g.namespaces.push(ns);
    });

    order.forEach(function (g) {
      if (g.namespaces.length === 1) {
        // Single namespace: show it directly at the top level.
        var only = g.namespaces[0];
        topNodes.push({ kind: "namespace", data: only });
        indexNamespace(only, []);
        return;
      }

      var label = commonNamespacePrefix(g.namespaces);
      var rootNs = null;
      var subs = [];
      g.namespaces.forEach(function (ns) {
        if (rootNs === null && ns.name === label) rootNs = ns;
        else subs.push(ns);
      });

      var group = {
        kind: "group",
        id: serviceId(label),
        label: label,
        href: rootNs ? rootNs.href : null,   // header links to the root namespace page
        subNamespaces: subs,                  // shown first when expanded (like folders)
        rootTypes: rootNs ? (rootNs.nodes || []) : [] // then the root namespace's own types
      };
      topNodes.push({ kind: "group", data: group });

      // The root namespace has no row of its own — its page highlights the header.
      if (rootNs) idIndex[rootNs.id] = { highlightId: group.id, chainIds: [] };
      // Root-namespace types are leaves directly under the header.
      (rootNs ? rootNs.nodes || [] : []).forEach(function (t) {
        idIndex[t.id] = { highlightId: t.id, chainIds: [group.id] };
      });
      // Sub-namespaces (and their types) nest one level deeper under the header.
      subs.forEach(function (ns) {
        idIndex[ns.id] = { highlightId: ns.id, chainIds: [group.id] };
        (ns.nodes || []).forEach(function (t) {
          idIndex[t.id] = { highlightId: t.id, chainIds: [group.id, ns.id] };
        });
      });
    });

    topNodes.sort(function (a, b) {
      return topLabel(a).localeCompare(topLabel(b));
    });
  }

  // Index a top-level namespace and its types (chain rooted at that namespace).
  function indexNamespace(ns, parentChain) {
    var chain = parentChain.concat([ns.id]);
    idIndex[ns.id] = { highlightId: ns.id, chainIds: parentChain };
    (ns.nodes || []).forEach(function (t) {
      idIndex[t.id] = { highlightId: t.id, chainIds: chain };
    });
  }

  // Longest shared dotted-segment prefix across namespace names, e.g.
  // [Amazon.S3, Amazon.S3.Model, Amazon.S3.Util] → "Amazon.S3".
  function commonNamespacePrefix(namespaces) {
    if (!namespaces.length) return "";
    var parts = namespaces[0].name.split(".");
    for (var i = 1; i < namespaces.length; i++) {
      var p = namespaces[i].name.split(".");
      var n = Math.min(parts.length, p.length);
      var k = 0;
      while (k < n && parts[k] === p[k]) k++;
      parts = parts.slice(0, k);
      if (!parts.length) break;
    }
    return parts.join(".");
  }

  // Decoded display label (uses the precomputed dname, see loadSidebar).
  function topLabel(t) {
    return t.kind === "group" ? t.data.label : t.data.dname;
  }

  // Renders a node. kind: "group" | "namespace" | "leaf".
  function makeNode(kind, data) {
    var isLeaf = kind === "leaf";
    var li = el("li", "toc-node toc-" + kind + (isLeaf ? " toc-leaf" : ""));
    li.setAttribute("data-id", data.id);
    li.__kind = kind;
    li.__data = data;

    var row = el("div", "toc-row");
    row.setAttribute("data-id", data.id);

    var chevron = el("span", "toc-chevron");
    chevron.textContent = "›";
    row.appendChild(chevron);

    var labelText = kind === "group" ? data.label : data.dname;
    var href = data.href; // group may be null (no root namespace page)

    if (href) {
      var link = el("a", null, labelText);
      var abs = absHref(href);
      link.href = abs;
      link.addEventListener("click", function (ev) {
        // Clicking a link that has hidden children also expands it (so the user
        // sees the children without having to hunt for the chevron).
        if (!isLeaf) openLi(li);
        boostClick(ev, abs); // in-place swap (see boostClick note above)
      });
      row.appendChild(link);
    } else {
      row.appendChild(el("span", "toc-label", labelText));
    }

    li.appendChild(row);

    if (!isLeaf) {
      li.__childrenUl = el("ul", "toc-children");
      li.appendChild(li.__childrenUl);
      // The chevron is the keyboard-operable expand/collapse control (role=button,
      // in the tab order, Enter/Space toggles). Without this, link-less group headers
      // could only be opened with a pointer. The :focus-visible rule then supplies a
      // visible focus ring for free.
      chevron.setAttribute("role", "button");
      chevron.setAttribute("tabindex", "0");
      chevron.setAttribute("aria-expanded", "false");
      chevron.setAttribute("aria-label", "Expand " + labelText);
      var toggle = function (ev) {
        ev.preventDefault();
        ev.stopPropagation();
        var open = li.classList.toggle("is-open");
        chevron.setAttribute("aria-expanded", open ? "true" : "false");
        if (open) buildChildren(li);
      };
      chevron.addEventListener("click", toggle);
      chevron.addEventListener("keydown", function (ev) {
        if (ev.key === "Enter" || ev.key === " " || ev.key === "Spacebar") toggle(ev);
      });
      // A header with no link (no root namespace page) toggles on row click too.
      if (!href) row.addEventListener("click", toggle);
    }
    return li;
  }

  function buildChildren(li) {
    if (li.getAttribute("data-built") === "1") return;
    var kind = li.__kind, data = li.__data;
    var frag = document.createDocumentFragment();
    if (kind === "group") {
      data.subNamespaces.forEach(function (ns) { frag.appendChild(makeNode("namespace", ns)); });
      data.rootTypes.forEach(function (t) { frag.appendChild(makeNode("leaf", t)); });
    } else if (kind === "namespace") {
      (data.nodes || []).forEach(function (t) { frag.appendChild(makeNode("leaf", t)); });
    }
    li.__childrenUl.appendChild(frag);
    li.setAttribute("data-built", "1");
  }

  // Expand a node (idempotent), building its children on first open.
  function openLi(li) {
    if (!li || li.classList.contains("toc-leaf")) return;
    li.classList.add("is-open");
    var chevron = li.querySelector(":scope > .toc-row > .toc-chevron");
    if (chevron) chevron.setAttribute("aria-expanded", "true");
    buildChildren(li);
  }

  function renderTree() {
    var nav = document.getElementById("sidebarNav");
    if (!nav) return;
    nav.textContent = "";
    var ul = el("ul", "toc-root");
    var frag = document.createDocumentFragment();
    topNodes.forEach(function (t) { frag.appendChild(makeNode(t.kind, t.data)); });
    ul.appendChild(frag);
    nav.appendChild(ul);
  }

  function renderSearch(query) {
    var nav = document.getElementById("sidebarNav");
    if (!nav) return;
    var tocData = NS.tocData;
    var q = query.toLowerCase();
    var matches = [];
    var LIMIT = 400;
    outer:
    for (var i = 0; i < tocData.namespaces.length; i++) {
      var ns = tocData.namespaces[i];
      // Match against the precomputed decoded name so typing "<" finds "Foo<>".
      if (ns.dname.toLowerCase().indexOf(q) !== -1) {
        matches.push(ns);
        if (matches.length >= LIMIT) break;
      }
      var nodes = ns.nodes || [];
      for (var j = 0; j < nodes.length; j++) {
        if (nodes[j].dname.toLowerCase().indexOf(q) !== -1) {
          matches.push(nodes[j]);
          if (matches.length >= LIMIT) break outer;
        }
      }
    }

    nav.textContent = "";
    if (!matches.length) {
      nav.appendChild(el("div", "sidebar-empty", "No matches for “" + query + "”"));
      return;
    }
    var ul = el("ul", "toc-root");
    var frag = document.createDocumentFragment();
    // Search results are shown flat as leaf rows (each links to its page).
    matches.forEach(function (node) { frag.appendChild(makeNode("leaf", node)); });
    ul.appendChild(frag);
    nav.appendChild(ul);
  }

  function wireFilter() {
    var input = document.getElementById("sidebarFilter");
    if (!input) return;
    once(input, "data-wired", function () {
      var t;
      input.addEventListener("input", function () {
        clearTimeout(t);
        var v = input.value.trim();
        t = setTimeout(function () {
          if (v.length) renderSearch(v);
          else { renderTree(); syncActive(); }
        }, 120);
      });
    });
  }

  function loadSidebar() {
    if (sidebarBuilt) return Promise.resolve();
    var nav = document.getElementById("sidebarNav");
    if (!nav) return Promise.resolve();
    var rootAbs = NS.ensureRoot();
    return fetch(new URL("toc.json", rootAbs).href)
      .then(function (r) { return r.ok ? r.json() : null; })
      .then(function (data) {
        if (!data || !data.namespaces) {
          nav.appendChild(el("div", "sidebar-empty", "Navigation unavailable."));
          return;
        }
        // Decode display names once up front so the filter / search modal do
        // pure string matching per keystroke instead of an entity round-trip.
        data.namespaces.forEach(function (ns) {
          ns.dname = decodeEntities(ns.name);
          (ns.nodes || []).forEach(function (t) { t.dname = decodeEntities(t.name); });
        });
        NS.tocData = data;
        buildGroups(data);
        sidebarBuilt = true;
        renderTree();
        wireFilter();
        syncActive();
      })
      .catch(function () {
        nav.appendChild(el("div", "sidebar-empty", "Navigation unavailable."));
      });
  }

  function clearActive() {
    var prev = document.querySelectorAll("#sidebarNav .toc-row.is-active");
    for (var i = 0; i < prev.length; i++) prev[i].classList.remove("is-active");
  }

  function syncActive() {
    if (!sidebarBuilt) return;
    var filter = document.getElementById("sidebarFilter");
    if (filter && filter.value.trim().length) return; // don't disturb search view

    clearActive();
    // data-tocid rides on #main (the htmx swap target), so it refreshes on every
    // in-place navigation — reading it from <body> would go stale after a swap.
    var main = document.getElementById("main");
    var tocid = main && main.getAttribute("data-tocid");
    if (!tocid) return;

    var entry = idIndex[tocid];
    if (!entry) return;

    // Expand each ancestor (top → down), building children so the next level
    // exists in the DOM before we look for it.
    (entry.chainIds || []).forEach(function (id) {
      var li = document.querySelector('#sidebarNav .toc-node[data-id="' + cssEscape(id) + '"]');
      if (li) openLi(li);
    });

    var row = document.querySelector('#sidebarNav .toc-row[data-id="' + cssEscape(entry.highlightId) + '"]');
    if (row) {
      row.classList.add("is-active");
      // Bring it into view within the sidebar without yanking the page.
      if (row.scrollIntoView) row.scrollIntoView({ block: "nearest" });
    }
  }

  /* --------------------------- Mobile drawer ------------------------ */
  function closeDrawer() { document.body.classList.remove("nav-open"); }

  function wireChrome() {
    var navToggle = document.getElementById("navToggle");
    once(navToggle, "data-wired", function () {
      navToggle.addEventListener("click", function () {
        document.body.classList.toggle("nav-open");
      });
    });
    var scrim = document.getElementById("navScrim");
    once(scrim, "data-wired", function () { scrim.addEventListener("click", closeDrawer); });
    var themeBtn = document.getElementById("themeToggle");
    once(themeBtn, "data-wired", function () { themeBtn.addEventListener("click", NS.toggleTheme); });

    // Escape closes the open mobile drawer (parity with the search modal). Bound
    // once at the document level so it survives htmx swaps. Only acts when the
    // drawer is open and the search modal isn't (search.js owns Escape while open),
    // then returns focus to the toggle that opened it.
    once(document.documentElement, "data-drawer-esc-bound", function () {
      document.addEventListener("keydown", function (ev) {
        if (ev.key !== "Escape") return;
        if (!document.body.classList.contains("nav-open")) return;
        var modal = document.getElementById("searchModal");
        if (modal && !modal.hidden) return; // modal is on top; let it handle Escape
        ev.preventDefault();
        closeDrawer();
        var toggle = document.getElementById("navToggle");
        if (toggle && toggle.focus) toggle.focus();
      });
    });
  }

  /* ------------------------------ Exports --------------------------- */
  NS.loadSidebar = loadSidebar;
  NS.syncActive = syncActive;
  NS.wireChrome = wireChrome;
  NS.closeDrawer = closeDrawer;
})(window.AwsDocs);

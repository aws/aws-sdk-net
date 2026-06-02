/*
 * shell.js - drives the DocFX-style application shell (index.html).
 *
 * Responsibilities:
 *   1. Mobile off-canvas left-nav toggle (replaces the old frameset .cols logic + MobileNavBar.html).
 *   2. Builds the right "In this article" rail from the article iframe's <h2 class="title" id> headings,
 *      with scroll-spy. Works for every page type with zero per-page generation cost.
 *   3. Syncs the active left-nav node on each article navigation (reads meta[name=aws-tocid]).
 *   4. Client-side filter of the left-nav tree from the navbar search box.
 *
 * The legacy navigation contract is preserved: the left nav is TOC.html (iframe name="TOC") whose
 * tocscript.js drives the content iframe (name="contentpane") and the ?page=&tocid= deep-link scheme.
 */
(function () {
    "use strict";

    var BREAKPOINT = 992;

    function byId(id) { return document.getElementById(id); }

    var contentFrame = byId("contentpane");
    var tocFrame = byId("TOC");
    var railList = byId("railList");
    var rightRail = byId("rightrail");

    /* ---------- 1. Mobile off-canvas nav ---------- */
    var navToggle = byId("navToggle");
    var scrim = byId("navScrim");

    function setNavOpen(open) {
        document.body.classList.toggle("nav-open", open);
        if (navToggle) navToggle.setAttribute("aria-expanded", open ? "true" : "false");
    }

    if (navToggle) navToggle.addEventListener("click", function () {
        setNavOpen(!document.body.classList.contains("nav-open"));
    });
    if (scrim) scrim.addEventListener("click", function () { setNavOpen(false); });

    // Close the drawer after a nav click on small screens (the article reloads).
    function maybeCloseDrawer() {
        if (window.innerWidth <= BREAKPOINT) setNavOpen(false);
    }

    // Shims for the legacy TOC.html inline script, which calls these on its parent
    // (they used to live on the old frameset shell). On mobile they drive the drawer.
    window.showContentPane = function () { maybeCloseDrawer(); };
    window.showTOC = function () { if (window.innerWidth <= BREAKPOINT) setNavOpen(true); };

    /* ---------- 2 & 3. On each article load: rebuild rail + sync nav + close drawer ---------- */
    var spyHandler = null;

    function clearRail() {
        if (railList) railList.innerHTML = "";
        if (rightRail) rightRail.classList.add("empty");
    }

    function buildRail() {
        if (!railList) return;
        clearRail();

        var doc;
        try { doc = contentFrame.contentDocument; } catch (e) { return; }
        if (!doc) return;

        var headings = doc.querySelectorAll("h2.title[id]");
        if (!headings.length) return;

        var anchors = [];
        headings.forEach(function (h) {
            var li = document.createElement("li");
            var a = document.createElement("a");
            a.href = "#" + h.id;
            a.textContent = (h.textContent || "").trim();
            a.addEventListener("click", function (ev) {
                ev.preventDefault();
                var target = doc.getElementById(h.id);
                if (target) target.scrollIntoView({ behavior: "smooth", block: "start" });
            });
            li.appendChild(a);
            railList.appendChild(li);
            anchors.push({ id: h.id, el: h, link: a });
        });

        if (rightRail) rightRail.classList.remove("empty");
        attachScrollSpy(anchors, doc);
    }

    function attachScrollSpy(anchors, doc) {
        var win = contentFrame.contentWindow;
        if (!win) return;

        // Detach a previous listener (it lived on the prior document's window).
        if (spyHandler && spyHandler.win) {
            try { spyHandler.win.removeEventListener("scroll", spyHandler.fn); } catch (e) { /* gone */ }
        }

        function onScroll() {
            var scrollTop = (doc.documentElement.scrollTop || doc.body.scrollTop) + 80;
            var current = anchors[0];
            for (var i = 0; i < anchors.length; i++) {
                if (anchors[i].el.offsetTop <= scrollTop) current = anchors[i];
                else break;
            }
            anchors.forEach(function (a) { a.link.classList.toggle("active", a === current); });
        }

        spyHandler = { win: win, fn: onScroll };
        win.addEventListener("scroll", onScroll, { passive: true });
        onScroll();
    }

    function syncActiveNav() {
        var doc;
        try { doc = contentFrame.contentDocument; } catch (e) { return; }
        if (!doc) return;
        var meta = doc.querySelector("meta[name='aws-tocid']");
        var tocid = meta && meta.getAttribute("content");
        if (!tocid) return;
        try {
            var tocWin = tocFrame.contentWindow;
            if (tocWin && tocWin.AWSTOCObj && tocWin.jQuery) {
                var $ = tocWin.jQuery;
                tocWin.AWSTOCObj.clearActiveTopic();
                var li = $("li#" + escapeId(tocid));
                // expand the parent namespace group if this is a type/member node
                var pos = tocid.lastIndexOf("_");
                if (pos > 0) tocWin.AWSTOCObj.expandTOCGroup($("li#" + escapeId(tocid.substr(0, pos))));
                tocWin.AWSTOCObj.setActiveTopic(li.children("a.nav"));
            }
        } catch (e) { /* cross-frame timing - ignore */ }
    }

    function escapeId(id) {
        // jQuery id selectors need CSS-meta chars escaped; ids here use letters/digits/_ plus rare <>.
        return id.replace(/([!"#$%&'()*+,.\/:;<=>?@\[\\\]^`{|}~])/g, "\\$1");
    }

    if (contentFrame) {
        contentFrame.addEventListener("load", function () {
            buildRail();
            syncActiveNav();
            maybeCloseDrawer();
        });
    }

    /* ---------- 4. Navbar search: filter the left-nav tree ---------- */
    var searchBox = byId("navSearch");
    if (searchBox) {
        var debounce = null;
        searchBox.addEventListener("input", function () {
            clearTimeout(debounce);
            debounce = setTimeout(function () { filterNav(searchBox.value.trim().toLowerCase()); }, 120);
        });
    }

    function filterNav(term) {
        var tocWin, $;
        try {
            tocWin = tocFrame.contentWindow;
            $ = tocWin && tocWin.jQuery;
        } catch (e) { return; }
        if (!$) return;

        var $items = $("li.nav", tocWin.document);
        if (!term) {
            // restore default collapsed tree
            $items.show();
            $("ul", tocWin.document).removeClass("expanded");
            $("li.nav", tocWin.document).removeClass("expanded");
            return;
        }

        // Hide everything, then reveal matches and their ancestors.
        $items.hide();
        $items.each(function () {
            var li = $(this);
            var link = li.children("a.nav").first();
            var text = (link.text() || "").toLowerCase();
            if (text.indexOf(term) !== -1) {
                li.show();
                // reveal + expand ancestors so the match is visible
                li.parents("li.nav").each(function () {
                    var p = $(this);
                    p.show();
                    p.addClass("expanded");
                    p.children("ul").addClass("expanded");
                });
            }
        });
    }
})();

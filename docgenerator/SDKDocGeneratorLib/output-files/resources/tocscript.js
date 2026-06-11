var AWSTOCObj = {

    init: function (tocRootObj) {
        this.tocRoot = tocRootObj;
        this.clearActiveTopic();
    },

    navigateTo: function (ns, id, member, page) {
        this.clearActiveTopic();
        var tgtid = "";
        if (ns) {
            tgtid += ns;
            //this.collapseTOCGroup(this);
            this.expandTOCGroup(jQuery("li#" + ns));
        }

        if (id) {
            if (tgtid != "")
                tgtid += "_";
            tgtid += id;
            this.setActiveTopic(jQuery("li#" + tgtid).children("a.nav"));
        }
        if (page)
            this.setContentPane(page.replace("_", ""));
        else
            this.setContentPane("./items/" + member.replace("_", "") + ".html");
    },

    clearActiveTopic: function () {
        var prev = jQuery(this.tocRoot).data("activeTopic");
        if (prev) { jQuery(prev).removeClass("activeTopic"); }
    },

    setActiveTopic: function (tocItem) {
        jQuery(tocItem).addClass("activeTopic");
        jQuery(this.tocRoot).data("activeTopic", tocItem);
    },

    setContentPane: function (t) {
        // Resolve the target relative to the shell (parent) document, then load it into
        // the named content iframe. Using the iframe element's src is more robust across
        // browsers than poking document.location through a cross-frame reference.
        var frame = window.parent.document.getElementById("contentpane");
        if (frame) {
            frame.setAttribute("src", t);
        } else if (window.parent.frames["contentpane"]) {
            window.parent.frames["contentpane"].location.href = t;
        }
    },

    toggleTOCGroup: function (tocGroup) {
        if (!tocGroup) return;
        var t = jQuery(tocGroup);
        if (t) {
            t.children("ul").toggleClass("expanded");
            t.toggleClass("expanded");
            
            t.children("button").attr("aria-expanded", function (i, attr) {
                return attr == "true" ? "false" : "true";
            });
        }
    },

    collapseTOCGroup: function (g) {
        g.children("ul").removeClass("expanded");
        g.removeClass("expanded");
    },

    expandTOCGroup: function (g) {
        g.children("ul").addClass("expanded");
        g.addClass("expanded");
    },
    setFrameFocus: function (name) {
        try {
            var f = window.top.frames[name];
            if (f && f.focus) f.focus();
        } catch (e) { /* focusing across frames can throw; non-critical */ }
    },
    dummy: null
};

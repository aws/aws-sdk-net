﻿var AWSHelpObj = {
	/*
	 * toggles the display of the popup Fx versions panel,
	 * placing it beneath the simulated Other Versions link
	 */
	toggleVersions: function() {
		var el;
		if (el = document.getElementById("vsPanel")) {
			el.style.display = (el.style.display == 'inline-block' ? 'none' : 'inline-block');
		}
	},

	addEvent: function (obj, type, fn) {
		if (obj.attachEvent) {
			obj['e' + type + fn] = fn;
			obj[type + fn] = function() {
				obj['e' + type + fn](window.event);
			}
			obj.attachEvent('on' + type, obj[type + fn]);
		}
		else {
			obj.addEventListener(type, fn, false);
		}
	},

	removeEvent: function(obj, type, fn) {
		if (obj.detachEvent) {
			obj.detachEvent('on' + type, obj[type + fn]);
			obj[type + fn] = null;
		}
		else {
			obj.removeEventListener(type, fn, false);
		}
	},

	isParentOf: function(target, parent) {
		var current = target;
		while (current !== document.body) {
			if (current === parent) {
				return true;
			}
			else {
				current = current.parentNode;
			}
		}
		return false;
	},

	displayLink: function (page, tocid) {
		var queryString = "?page=" + page + "&tocid=" + tocid;

		var pos = window.location.href.lastIndexOf('/items/');
		var baseUrl = window.location.href.substr(0, pos) + '/index.html' + queryString;

		prompt('Copy this URL to use to navigate to this page', baseUrl);
	},

	showRegionalDisclaimer: function (host) {
		if (host && host.match(/.cn$/))
			return true;

		return false;
	},

	searchFormSubmit: function(formElement) {
		//#facet_doc_product=AWS+SDK+for+.NET&amp;facet_doc_guide=API+Reference
        var docsBase;
        if (window.location.host === "")
            docsBase = "http://docs.aws.amazon.com";
        else
            docsBase = window.location.protocol + "//" + window.location.host;
        var so = jQuery("#sel").val();
        if (so.indexOf("documentation") === 0) {
            var this_doc_product = jQuery("#this_doc_product").val();
            var this_doc_guide = jQuery("#this_doc_guide").val();
            var action = "";
            var facet = "";
            if (so === "documentation-product" || so === "documentation-guide")
            {
                action += "?doc_product=" + encodeURIComponent(this_doc_product);
                facet += "#facet_doc_product=" + encodeURIComponent(this_doc_product);
                if (so === "documentation-guide")
                {
                    action += "&doc_guide=" + encodeURIComponent(this_doc_guide);
                    facet += "&facet_doc_guide=" + encodeURIComponent(this_doc_guide);
                }
            }

            var ua = window.navigator.userAgent;
            var msie = ua.indexOf('MSIE ');
            var trident = ua.indexOf('Trident/');

            if (msie > 0 || trident > 0)
            {
                var sq = jQuery("#search-query").val();
                action += "&searchPath=" + encodeURIComponent(so);
                action += "&searchQuery=" + encodeURIComponent(sq);
                window.location.href = "/search/doc-search.html" + action + facet;
                return false;
            } else {
                formElement.action = "/search/doc-search.html" + facet;
            }
        } else {
            formElement.action = "http://aws.amazon.com/search";
        }
		return true;
	},

	setAssemblyVersion: function (vfile, svcname) {
		jQuery.ajax({
			url: vfile,
			dataType: "json",
			success: function (data) {
				var v;
				if (svcname) {
					var svl = data["ServiceVersions"];
					if (svl) {
						var sv = svl[svcname];
						if (sv) {
							v = sv["Version"];
						}
					}
				} else {
					v = data["CoreVersion"];
				}
				
				if (v) {
					jQuery("#assemblyVersion").text(v);
					return;
				}
				
				jQuery("#versionData").hide();
			},
			error: function(xhr, e, t) {
				console.log("error obtaining version: ", xhr, e, t);
				jQuery("#versionData").hide();
			}
		});
	},

    setCopyrightText: function () {
        var c = "&copy; Copyright 2008-" + new Date().getFullYear() + " Amazon.com, Inc. or its affiliates. All Rights Reserved.";
        jQuery("#copyright").html(c);
    }
};

(function() {
	var clickable = document.getElementById("vsLink");
	AWSHelpObj.addEvent(document.body, 'click', function (evt) {
		var tgt = evt.target ? evt.target : evt.srcElement;
		if (!AWSHelpObj.isParentOf(tgt, clickable)) {
			document.getElementById('vsPanel').style.display = 'none';
		}
	});
})();

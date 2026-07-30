/* =====================================================================
   AWS SDK for .NET — API Reference local search: shared scorer
   ---------------------------------------------------------------------
   Loaded BOTH by app.js (window, via <script>) and by search-worker.js
   (worker, via importScripts). `self` is the global in either context,
   so the same scoring function ranks types/namespaces (matched on the
   main thread from toc.json) and members (matched in the worker) on one
   consistent scale — otherwise the two result groups would interleave
   incorrectly. Names-only matching; no descriptions are indexed.
   ===================================================================== */
(function () {
  "use strict";

  // Match tiers, highest first. The numeric gaps leave room for small
  // per-match bonuses (shorter names and earlier matches rank higher)
  // without a lower tier ever overtaking a higher one.
  var EXACT = 100000;
  var PREFIX = 80000;
  var ACRONYM = 60000;   // camelCase initials, e.g. "gob" -> GetObject
  var WORD = 40000;      // substring starting at a word boundary
  var SUBSTR = 20000;    // substring mid-word

  // camelCase / Pascal initials of a name: first char plus every
  // uppercase letter or digit, lowercased. "GetObjectV2" -> "gov2".
  function acronymOf(name) {
    var out = "";
    for (var i = 0; i < name.length; i++) {
      var c = name.charAt(i);
      if (i === 0 || (c >= "A" && c <= "Z") || (c >= "0" && c <= "9")) {
        out += c.toLowerCase();
      }
    }
    return out;
  }

  // Shorter names rank above longer ones at the same tier (capped so it
  // never crosses a tier boundary).
  function lengthBonus(name) {
    var b = 60 - name.length;
    return b < 0 ? 0 : b;
  }

  function isBoundary(name, idx) {
    if (idx === 0) return true;
    var prev = name.charAt(idx - 1);
    var here = name.charAt(idx);
    if (prev < "A" || (prev > "Z" && prev < "a") || prev > "z") {
      if (prev < "0" || prev > "9") return true; // non-alphanumeric before
    }
    return here >= "A" && here <= "Z"; // uppercase start = camelCase boundary
  }

  // Returns a score (higher = better) or -1 for no match.
  // `q` MUST already be lower-cased and non-empty.
  function score(name, q) {
    if (!name) return -1;
    var lname = name.toLowerCase();

    if (lname === q) return EXACT + lengthBonus(name);
    if (lname.lastIndexOf(q, 0) === 0) return PREFIX + lengthBonus(name);

    var acr = acronymOf(name);
    if (acr.lastIndexOf(q, 0) === 0) return ACRONYM + lengthBonus(name);

    var idx = lname.indexOf(q);
    if (idx !== -1) {
      var tier = isBoundary(name, idx) ? WORD : SUBSTR;
      return tier + lengthBonus(name) - idx;
    }
    return -1;
  }

  self.AwsDocsSearch = self.AwsDocsSearch || {};
  self.AwsDocsSearch.score = score;
})();

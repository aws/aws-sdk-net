/* =====================================================================
   AWS SDK for .NET — API Reference local search: member worker
   ---------------------------------------------------------------------
   Owns the member half of local search off the main thread so typing
   never janks. app.js handles types/namespaces from the already-loaded
   toc.json (instant); this worker loads the larger member index once and
   matches against it.

   Protocol (postMessage):
     <- { type:"init", indexUrl }      load + decode search-index.json
     <- { type:"query", q, seq, limit } rank members for q
     -> { type:"ready" }                index loaded (or load failed -> "error")
     -> { type:"error", message }
     -> { type:"results", seq, items:[{name,kind,file,folder}] }

   The index is the compact shape emitted by TOCWriter.WriteSearchIndexJson:
     { v:1, base:"items", f:[folder…], i:[ [folderIdx, name, kind, file, type], … ] }
   "base" is the content sub-folder; it is reported in the "ready" message so the
   main thread can build hrefs as <base>/<folder>/<file> without hard-coding "items".
   ===================================================================== */
"use strict";

importScripts("search-core.js");
var score = self.AwsDocsSearch.score;

var NAMES = null;   // parallel arrays for tight memory / fast scan
var KINDS = null;
var FILES = null;
var FOLDERS = null; // resolved folder string per entry
var TYPES = null;   // declaring type display name per entry
var BASE = "items"; // content sub-folder from the index ("base"); default for older indexes
var ready = false;

function init(indexUrl) {
  fetch(indexUrl)
    .then(function (r) { return r.ok ? r.json() : null; })
    .then(function (data) {
      if (!data || !data.i || !data.f) throw new Error("bad index");
      if (data.base) BASE = data.base;
      var folderTable = data.f;
      var rows = data.i;
      var n = rows.length;
      NAMES = new Array(n);
      KINDS = new Array(n);
      FILES = new Array(n);
      FOLDERS = new Array(n);
      TYPES = new Array(n);
      for (var k = 0; k < n; k++) {
        var row = rows[k];           // [folderIdx, name, kind, file, type]
        FOLDERS[k] = folderTable[row[0]];
        NAMES[k] = row[1];
        KINDS[k] = row[2];
        FILES[k] = row[3];
        TYPES[k] = row[4];
      }
      ready = true;
      postMessage({ type: "ready", base: BASE });
    })
    .catch(function (e) {
      postMessage({ type: "error", message: String(e && e.message || e) });
    });
}

function query(q, seq, limit) {
  if (!ready || !q) {
    postMessage({ type: "results", seq: seq, items: [] });
    return;
  }
  limit = limit || 20;
  var lq = q.toLowerCase();

  // Keep the best `limit` by score with a small running list. The index is
  // names-only and member counts are large, so we avoid sorting everything:
  // scan once, insert into a short top-N buffer.
  var best = [];
  for (var k = 0; k < NAMES.length; k++) {
    var s = score(NAMES[k], lq);
    if (s < 0) continue;
    if (best.length < limit) {
      best.push({ idx: k, s: s });
      if (best.length === limit) best.sort(byScoreDesc);
    } else if (s > best[best.length - 1].s) {
      best[best.length - 1] = { idx: k, s: s };
      // bubble the new entry up to keep `best` sorted descending
      for (var j = best.length - 1; j > 0 && best[j].s > best[j - 1].s; j--) {
        var tmp = best[j]; best[j] = best[j - 1]; best[j - 1] = tmp;
      }
    }
  }
  if (best.length < limit) best.sort(byScoreDesc);

  var items = best.map(function (b) {
    return {
      name: NAMES[b.idx],
      kind: KINDS[b.idx],
      file: FILES[b.idx],
      folder: FOLDERS[b.idx],
      type: TYPES[b.idx],
      score: b.s
    };
  });
  postMessage({ type: "results", seq: seq, items: items });
}

function byScoreDesc(a, b) { return b.s - a.s; }

onmessage = function (ev) {
  var msg = ev.data || {};
  if (msg.type === "init") init(msg.indexUrl);
  else if (msg.type === "query") query(msg.q, msg.seq, msg.limit);
};

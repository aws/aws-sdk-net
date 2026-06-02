# SDKDocGeneratorLib Readability Redesign Plan

Goal: make the generator **easier to read and understand** without changing the generated
output (byte-identical) or regressing the build-time work already done (Server GC, pooled
buffers, cross/intra-service parallelism, XML single-parse).

This is a *refactor for clarity*, not a feature change. Every phase ends at a byte-identical
checkpoint so it can be merged independently and reverted cleanly.

---

## Guardrail (single byte-diff at the END)

Per user direction, we do NOT byte-diff after every phase — only once, after all phases are
in. To keep that final diff bisectable, **each phase is its own commit** so a non-empty diff
can be traced to the offending phase. EC2 is the canonical service (largest, 11,091 files,
exercises every writer + platform path).

```bash
# baseline: capture ONCE before any code changes (current known-good output)
dotnet SDKDocGenerator/bin/Release/SDKDocGenerator.dll -sdk ../Deployment/assemblies \
  -sdkversionfile ../Deployment/_sdk-versions.json -emj SDKDocGenerator/example_meta.json \
  -o ../DocfxTest/baseline -sf . -p net472 -svc EC2

# FINAL check (after all phases): regenerate, then byte-compare:
#   ( cd baseline/items && find . -type f -print0 | sort -z | xargs -0 md5sum ) > /tmp/base.txt
#   ( cd final/items    && find . -type f -print0 | sort -z | xargs -0 md5sum ) > /tmp/fin.txt
#   diff /tmp/base.txt /tmp/fin.txt   # must be EMPTY
```

Each phase still ends at a `dotnet build` (compiles clean) checkpoint, just not a byte-diff.

---

## Current-state findings (from survey)

- ~11,800 LOC total; **~3,250 are vendored `ThirdParty/Json`** (LitJson) — not first-party.
- **Two platform-availability mechanisms coexist** (the #1 readability problem):
  - NEW `PlatformMap/` subsystem — clean, documented, used for *exclusive-member page generation*
    (`SdkDocGenerator.cs:237`). Indexes every member signature → `HashSet<string> Platforms`.
  - OLD `BaseWriter.AddVersionInformation` (`BaseWriter.cs:559`) — re-derives availability by
    hand via 4× `NDocUtilities.FindDocumentation(NDocForPlatform(...))` to render the
    "Version Information" *section*. Called from `ClassWriter.cs:97` and `MemberWriter.cs:34`.
  - => The same question ("what platforms is this member on?") is answered two different ways.
    This is both a readability AND a drift/correctness risk.
- `BaseWriter` builds HTML via **139 raw `WriteLine` calls**; `ClassWriter` another 86. Markup
  is tangled into control flow. (This is also the perf-sensitive hot path.)
- `ReflectionWrappers.cs` (1,187 LOC) and `NDocUtilities.cs` (1,088 LOC) are single-file
  grab-bags holding many types each.
- `ThirdParty/Json` has **exactly one** consumer: `Writers/TOCWriter.cs` (uses `JsonWriter`,
  `JsonReader`, `JsonMapper`). `ExampleMetadataParser.cs` already uses `System.Text.Json`
  successfully — proof the modern API is viable in this project (.NET 8 exe).

---

## Phase 1 — Consolidate platform-availability logic  ★ highest value

**Problem:** two sources of truth for member→platforms.

**Change:**
1. Add a public lookup to `PlatformAvailabilityMap`:
   ```csharp
   // returns the set of platforms a given member signature is available on,
   // or null if the signature was not indexed (caller treats null = "all platforms",
   // preserving today's boolNoDocs behavior).
   public IReadOnlyCollection<string> GetPlatformsForSignature(string signature);
   ```
   (Backed by the existing private `_memberIndex` + `PlatformMemberEntry.Platforms`.)
2. Make the `PlatformAvailabilityMap` reachable from writers (it already hangs off
   `GenerationManifest.PlatformMap`; thread it to `BaseWriter` the same way `Artifacts` is).
3. Rewrite `AddVersionInformation` to: compute the member `Signature` via the existing
   `MemberSignature.For*` helpers, call `GetPlatformsForSignature`, and render the
   ".NET / .NET Standard / .NET Framework — Supported in: ..." block from that set.
   Keep the exact same strings ("8.0 and newer", "Core 3.1", "2.0", "4.7.2 and newer")
   and the null⇒all-platforms fallback so output is identical.
4. Delete the 4× `NDocForPlatform` presence-check path from `AddVersionInformation`.

**Risk:** Medium. The mapping from "XML doc presence per platform" to "signature indexed per
platform" must produce the *identical* platform set for every member. Byte-diff is the gate.
If any member differs, the map's signature scan and the old XML-presence test disagree — that
discrepancy is itself a bug worth surfacing (document it; don't paper over it).

**Readability win:** High. One platform mechanism. `BaseWriter` shrinks. The clean documented
subsystem becomes the *only* answer.

> STATUS: PHASE 1 COMPLETE (builds clean, 0 warnings). Done as a DELIBERATE BEHAVIOR CHANGE
> (user decision: "new path is correct"), NOT byte-identical.
>  - Added PlatformAvailabilityMap.GetPlatformsForSignature(signature) (exposes _memberIndex;
>    safe post-Dispose since only assembly contexts are released, the index survives).
>  - BaseWriter.AddVersionInformation now derives availability from the map (symbol-presence)
>    via new helpers GetMemberPlatforms + DeterminePlatformSignature (PlatformMap.MemberSignature.*).
>    Deleted the 4x NDocForPlatform doc-presence path. null map/signature => assume-all fallback.
>  - VERIFIED on EC2: 31 / 11,091 files changed, ALL confined to the Version Information section
>    (diffs touch nothing else). All 31 are undocumented Core members where the OLD path hit its
>    boolNoDocs "assume all platforms" fallback and guessed WRONG. Example: Amazon.Runtime.TcpKeepAlive
>    — reflection-probed across all 4 Core assemblies: PRESENT only in net472, ABSENT in
>    netstandard2.0/netcoreapp3.1/net8.0. Old output falsely listed all 4 platforms; new output
>    correctly lists net472 only. This is the intended correctness fix.

---

## Phase 2 — Split the grab-bag files  ★ safest

> STATUS: PHASE 2 COMPLETE (builds clean, 0 warnings).
>  - ReflectionWrappers.cs → 13 files under Reflection/ (one type each, namespace unchanged).
>  - NDocUtilities.cs → partial class across 5 files by responsibility:
>      NDocUtilities.cs (cache/load), .Lookup.cs, .Signatures.cs, .HtmlTransform.cs, .CodeSamples.cs.
>    All call sites unchanged (still NDocUtilities.X); method bodies verbatim.


**Change (pure mechanical, no behavior):**
- `ReflectionWrappers.cs` → one file per wrapper type under `Reflection/`
  (`TypeWrapper.cs`, `MethodInfoWrapper.cs`, `FieldInfoWrapper.cs`, `AttributeWrapper.cs`, …).
- `NDocUtilities.cs` → split by responsibility (XML load/cache vs. doc lookup vs. HTML
  transform) into `NDoc/` (e.g. `NDocLoader.cs`, `NDocLookup.cs`, `NDocHtmlTransform.cs`).

**Risk:** Very low — moving types between files, namespaces unchanged, no logic touched.
Byte-diff should be trivially clean. (Optionally a no-op build check is enough.)

**Readability win:** Medium — the type model and the doc subsystem become navigable.

---

## Phase 3 — Remove vendored `ThirdParty/Json`, use `System.Text.Json`

**Change:**
- Port `Writers/TOCWriter.cs` (the only consumer) from `JsonWriter`/`JsonReader`/`JsonMapper`
  to `System.Text.Json` (`Utf8JsonWriter` for emit; `JsonDocument`/`JsonNode` for the
  re-parse at `TOCWriter.cs:138`).
- Delete `ThirdParty/Json/*` (~3,250 LOC) and the `using Json;` / `using Json.LitJson;` lines.

**Risk:** Low–Medium. Higher than Phase 2 because TOC JSON is nested and the serialized form
feeds `TOCWriter`'s own re-parse; field ordering / whitespace in the intermediate JSON must
not change the final `TOC.html`. Byte-diff `TOC.html` specifically, plus full tree.
NOTE: do AFTER Phase 2 so the TOC change lands against an already-tidied tree.

> STATUS: PHASE 3 COMPLETE (builds clean, 0 warnings).
>  - TOCWriter.cs ported from LitJson (JsonWriter/JsonReader/JsonMapper) to System.Text.Json
>    (Utf8JsonWriter to build, JsonNode/JsonObject to re-parse). HTML format strings verbatim.
>  - Deleted ThirdParty/Json/* (3,868 LOC). ThirdParty/ folder removed (was empty).
>  - WATCH AT FINAL DIFF: TOC.html — only phase that round-trips JSON; verify object property
>    order + string values match. (Both libs preserve insertion order; values are plain strings.)

**Readability win:** Medium — ~3,250 fewer lines of non-first-party code to scroll past; one
JSON API across the codebase (matches `ExampleMetadataParser`).

---

## Phase 4 — Tame the hand-written HTML  ★ highest reward / highest risk — DEFER

**Problem:** 139 + 86 raw `WriteLine("<...>")` calls; page shape is invisible.

**Options (in increasing risk):**
- **4a (low):** extract small composable helpers — `WriteSection(writer, title, body)`,
  `WriteTable(...)`, `OpenDiv/CloseDiv` — to collapse repeated open/close patterns. Pure
  internal refactor, keeps `StringWriter`/pooled-buffer hot path intact.
- **4b (high):** introduce a real template layer (Razor/T4/Mustache). Reads far better but
  risks BOTH the perf work (pooled buffers, single-pass writes) AND byte-identical output
  (templating engines normalize whitespace differently). Only consider with a dedicated
  perf + byte-diff campaign.

**Recommendation:** do **4a only**, and only after 1–3 are merged and stable. Treat 4b as a
separate proposal with its own perf budget — not part of this readability pass.

> STATUS: PHASE 4a DONE (builds clean). Scoped to the one clearly-safe extraction:
> AddRemarksDocumentation / AddExamples / AddSeeAlso were character-identical except root-node
> name + title; collapsed into a single private WriteDocSection(writer, rootNodeName, title).
> Provably byte-identical (same call sequence). Deliberately did NOT factor the 139 table/div
> WriteLine literals — high byte-identical risk on the hot path for diminishing readability gain.

**Risk:** 4a low (same output, same hot path). 4b high (perf + byte-identical both at stake).

---

## Suggested order & rationale

1. **Phase 2** first (safest, shrinks/organizes surface, makes later diffs easier to read).
2. **Phase 3** (removes the biggest non-first-party chunk; isolated to one writer).
3. **Phase 1** (highest value; do once the tree is tidy so the platform change stands alone).
4. **Phase 4a** (polish the HTML helpers last, on a clean base).
5. **Phase 4b** — only if separately justified.

Each phase is independently shippable and independently revertible. Stop after any phase and
the codebase is strictly more readable than before with identical output.

## Explicitly OUT of scope (protect these)
- The build-time optimizations: Server GC, pooled `[ThreadStatic]` buffers, `ConcurrencyGate`,
  `Lazy<T>` wrappers, XML single-parse, cross/intra-service parallelism.
- The iframe-shell front-end redesign (separate effort).
- Generated output: must stay byte-identical through Phases 1–3 and 4a.

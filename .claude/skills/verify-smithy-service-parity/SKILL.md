---
name: verify-smithy-service-parity
description: Use when validating that a C2J-to-Smithy migrated AWS SDK service builds, packages, and stays API-compatible with the shipping SDK, or before reporting such a migration as done, verified, clean, or unblocked.
---

# Verify Smithy Service Parity

## Overview

Confirms a C2J-to-Smithy migrated service builds, packages, and stays API-compatible with the shipping SDK. Every step produces pasted evidence; the verdict is derived from that evidence, not from judgement.

## Parameters

- **service_name** (required): SDK ServiceFolderName, e.g. `Uxc`, `SSOOIDC`, `MarketplaceReporting`.
- **sdk_repo** (required): path to the SDK checkout.
- **comparer_repo** (required): path to the build-utilities checkout containing AssemblyComparer.
- **nuget_download_folder** (optional, default: a new temp directory): scratch location for packages AssemblyComparer downloads.

**Constraints for parameter acquisition:**
- You MUST ask for all required parameters upfront in a single prompt.
- You MUST confirm `service_name` is present in `<sdk_repo>/generator/ServiceModels/_smithy-migrated-services.json` before starting, because the generator only emits Smithy output for services listed there.
- You MUST NOT hardcode any path not supplied as a parameter, because the SOP has to run on any machine and any checkout layout.

## Steps

### 1. Regenerate

`dotnet run --project <sdk_repo>/generator/SmithyDotNet/SmithyDotNet.Generator/SmithyDotNet.Generator.csproj -- --repo-root "<sdk_repo>"`

**Constraints:**
- You MUST paste `git status --short` afterwards.
- You MUST confirm only `<service_name>` shows generated-file changes, because every migrated service regenerates on every run and changes to another service indicate an unintended generator change.

### 2. Compare the public surface against the C2J output

The C2J-generated code is the source of truth, because it is what ships today. Its version of every generated file is in `git HEAD` until this regeneration overwrote it, so retrieve each with `git show HEAD:<path>` and compare against the new output.

**Constraints:**
- You MUST list every public type, member and property from the C2J files and confirm each still exists in the Smithy output with the same name and the same .NET type, because a member that changes type or disappears breaks callers.
- You MUST compare signatures only, normalising away a constructor's `: base(...)` initialiser, an expression body (`=> x` versus `{ get { return x; } }`), and whitespace, because none of those change the compiled public surface and treating them as findings buries the real ones.
- You MUST treat a property whose type narrowed or widened as `FAIL`, for example `List<string>` becoming `string`, since existing code stops compiling.
- You MUST compare the full `[AWSProperty]` and `[AWS*]` named-argument sets side by side for every member, because AssemblyComparer does not compare attribute argument values and step 7 will not catch a missing one — with one exception: `Min`/`Max` on a `List<T>`-typed member is inert on both sides (`PropertyValueRulesWriter` only emits rules for scalar members, and the consuming analyzer only validates compile-time-constant string/int literals), so a difference there is not a finding. Every other attribute, including `[AWSPaginator]`, has no such exception — its arguments are consumed outside this repo (AWS Tools for PowerShell reflects on it), so treat any drift there as a `FAIL`.
- You MUST confirm every C2J public type has a Smithy counterpart, including exception types, enumerations, paginators and the client interface, since a missing type is a removed API.
- You MUST NOT accept "the generator does not support this shape" as a reason for any difference in the public surface, because the migration is only allowed to change how the code is produced, not what it exposes.
- For every marshaller and unmarshaller you MUST extract the set of names referenced in the C2J body — `publicRequest.X`, `response.X`, `context.X`, `IsSetX()`, and the wire names in `Parameters.Add("x"` / `Headers.Add("x"` — and confirm every one appears in the Smithy body. A name present in C2J and absent in Smithy is `FAIL`.
- Presence is not enough: you MUST also diff the literal wire strings character for character — the `ResourcePath` template, each `AddPathResource("{token}", …)` token, and every `Parameters.Add("name"` / `Headers.Add("name"` name. A changed literal is `FAIL` unless you prove it inert. The one inert case is a URI path-label token: a Smithy path label is keyed by the member name, so its `{token}` may differ from the historical wire label — a case/spelling change is acceptable ONLY when the `AddPathResource` key and the `ResourcePath` token change together and stay identical to each other, so the substituted path is byte-for-byte unchanged. A header or query name is wire-visible and has no such exception; any change there is `FAIL`.
- A matching name-set is not sufficient: for every reference in that set you MUST also compare the condition under which it executes — the enclosing `if`/guard, ternary, or unconditional placement — between the C2J and Smithy bodies line by line. A name present in both bodies but reachable under a different condition (a header added unconditionally where C2J guarded it, an `IsSetX()` check inverted, a branch that now fires for a different set of inputs) is `FAIL`, even though nothing is missing.
- You MUST run that body comparison even when every public signature matches, because a member dropped from marshalling changes no signature: the property still exists, callers still compile, and the value silently never reaches the service. No other step in this document detects it.
- You MUST verify any URL emitted in a doc comment resolves (or matches C2J's value exactly) — a broken `<seealso href>` is invisible to every other check in this document.

### 3. Account for every changed file

List every path from `git status --short` and classify each one individually: `EXPECTED` or `UNEXPLAINED`.

These are the only accepted `EXPECTED` differences. Anything else is `UNEXPLAINED`:

- **`.g.cs` suffix** — a C2J `X.cs` is deleted and a Smithy `X.g.cs` added. A deleted `.cs` with no matching `.g.cs` is `UNEXPLAINED`.
- **`_bcl` / `_netstandard` flattening** — those folders collapse into `Generated/`, and `<Compile Remove="**/_bcl/**"/>` disappears from the NetStandard csproj because there is nothing left to exclude.
- **`AssemblyInfo.cs` description** — `AssemblyDescription` drops the C2J per-release blurb, and the code-analysis project gets a generic description. Metadata only.
- **`PropertyValueRules.xml` anchored patterns** — e.g. `[a-zA-Z0-9_-]+` becomes `^[a-zA-Z0-9_-]+$`. The Smithy `@pattern` value is authoritative.
- **`.sln` to `.slnx`** — per-service solution file format change.
- **Whitespace, indentation and doc-comment reflow** — but only after you have shown both sides. This covers reflow of *existing* content only. A doc comment that goes from present to absent on a public type or member is NOT reflow: a public type/member with no XML doc comment fails the build under `GenerateDocumentationFile` (CS1591), so a removed or emptied `<summary>` stays `UNEXPLAINED` until step 4 proves it compiles. Excludes any URL/href value inside a doc comment (e.g. `<seealso href="...">`); those must match exactly or be individually justified, never waved through as reflow.

**Constraints:**
- You MUST enumerate every path and assign each a classification, because sampling the diff is how a dropped attribute argument survives review.
- You MUST classify a path `UNEXPLAINED` when it does not match one of the accepted differences above, because the list is the whole set of things already reviewed.
- You MUST diff the file *lists* against the previous state as well as the contents, because a file the C2J generator emitted and the Smithy generator does not is invisible to a content diff.
- You MUST open every changed file whose name you do not recognise, including `AssemblyInfo.cs`, `PropertyValueRules.xml`, `*.nuspec`, `*.csproj`, and anything under `sdk/code-analysis/`, since deletions there are public-surface or build-behaviour changes rather than noise.
- For every `[AWS*]` attribute in the diff you MUST list the full named-argument set on both sides side by side, because AssemblyComparer does not compare attribute argument values and step 7 will not catch a missing one.
- You MUST NOT close this step with any path left `UNEXPLAINED`, because an unexplained change is an unassessed API change.
- You MUST NOT describe a difference as formatting or syntax without showing both sides, since that characterisation is what lets a real removal through.

### 4. Build

Build all three, `-c Release`:
- `<sdk_repo>/sdk/src/Services/<service_name>/AWSSDK.<service_name>.NetStandard.csproj` (netstandard2.0, netcoreapp3.1, net8.0)
- `<sdk_repo>/sdk/src/Services/<service_name>/AWSSDK.<service_name>.NetFramework.csproj` (net472)
- `<sdk_repo>/sdk/code-analysis/ServiceAnalysis/<service_name>/AWSSDK.<service_name>.CodeAnalysis.csproj`

**Constraints:**
- You MUST paste the warning and error counts for each.
- You MUST NOT proceed past a build failure, because the later steps operate on build output that would not exist.

### 5. Package

`create-nuget-packages.ps1 -PackageList <service_name>`

**Constraints:**
- You MUST run it from `<sdk_repo>/buildtools/`, because it resolves paths relative to its own directory.
- You MUST run it after step 4, because it assumes build output already exists.
- You MUST paste the resulting package path.

### 6. AssemblyComparer

```
dotnet run -c Release --project <comparer_repo>/AssemblyComparer/AssemblyComparer/AssemblyComparer.csproj -- package-comparer --package-name AWSSDK.<service_name> --download-folder "<nuget_download_folder>" --nuspec "<sdk_repo>/sdk/src/Services/<service_name>/AWSSDK.<service_name>.nuspec" -cf BinaryIncompatibility,SourceIncompatibility,Warning -p net472 -p netstandard2.0 -p netcoreapp3.1 -p net8.0
```

**Constraints:**
- You MUST paste the full output and the exit code. Empty output plus exit 0 means no findings.
- You MUST treat every reported finding as a break until it is individually explained in the report.
- You MUST NOT report this step as covering custom-attribute argument values, because AssemblyComparer does not compare them and a dropped attribute argument passes it while still breaking the public API.

### 7. Unit tests

Run the service's unit tests.

**Constraints:**
- You MUST paste the pass, fail, and skip counts verbatim.
- You MUST NOT call a failure pre-existing without a stash plus rerun proving it, since the main branch is kept green.

### 8. Verdict

Report each step as `PASS` with its pasted evidence, `FAIL` with the output, or `UNVERIFIED` with the blocker.

**Constraints:**
- The verdict MUST default to `NOT VERIFIED` and MAY become `VERIFIED` only when steps 1-7 are all `PASS` with pasted evidence.
- Any step you could not run MUST be `UNVERIFIED` and MUST block `VERIFIED`, because an unrun check reported as passing is indistinguishable from a failed one.
- You MUST NOT write "cosmetic", "equivalent", "should be fine", "pre-existing", or "likely" without pasted output in the same sentence, because each asserts a result without showing one.

## Troubleshooting

**Step 1 shows changes to other services** — a generator change leaked in. Stop and report which services changed.

**AssemblyComparer reports findings that look intentional** — still `FAIL` until each finding is explained in the report.

**A step cannot be run** — `UNVERIFIED`, not `PASS`. You MUST NOT substitute reading the generated files for running the step, because that produces no comparison evidence.

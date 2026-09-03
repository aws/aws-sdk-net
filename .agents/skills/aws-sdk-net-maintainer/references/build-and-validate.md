# SDK Build System

## Validate a change

- Build the relevant **service** solution (e.g. `sdk/src/Services/ACMPCA/ACMPCA.sln`) or the
  **uber** solution (`sdk/AWSSDK.NetFramework.sln`) — not a bare `dotnet build` of the repo root.
- Run tests through the `run-tests-mstest` / `run-tests-xunit` targets in `buildtools/build.proj`.
  Some SDK tests are not friendly to run directly outside these targets.
- Core and Custom runtime tests compile into `AWSSDK.UnitTests.Core.dll` — run
  `sdk/test/UnitTests/AWSSDK.UnitTests.Core.csproj`, **not** `AWSSDK.UnitTestUtilities.csproj`
  (which produces no test output).
- Packaging: SDK NuGet packages are created with `create-nuget-packages.ps1`; extension packages
  with `NuGet.exe pack`. Do not assume `dotnet pack`.

## Key build projects

- `buildtools/build.proj` drives the SDK build, test, generation, and packaging targets.
- The uber solutions build the whole SDK (e.g. `sdk/AWSSDK.NetFramework.sln`); a service solution
  builds one service (e.g. `sdk/src/Services/ACMPCA/ACMPCA.sln`).
- `build.proj` contains some dead targets left over from a previous build system — prefer the
  targets referenced here and confirm a target is still wired before relying on it.

## Service client generation

The SDK is mid-migration between two code generators. Both run under
`dotnet msbuild buildtools/build.proj /t:run-generator` (Smithy first, then C2J):

- **Smithy generator** — `generator/SmithyDotNet/`, a Smithy-native C# generator for *migrated*
  services; reads the Smithy AST directly. `generator/SmithyDotNet/CLAUDE.md` and its `skills/`
  are the source of truth for Smithy generation work.
- **Legacy C2J generator** — `generator/ServiceClientGenerator*`, for services not yet migrated.
  Production C2J models live in `generator/ServiceModels/` (updated during daily releases; test
  models in `generator/TestServiceModels/` are updated manually). It uses the `normal`-type
  `<prefix>-YYYY-MM-DD.normal.json` files plus an optional `<prefix>.customizations.json`, applies
  T4 templates in `generator/ServiceClientGeneratorLib/`, writes to
  `sdk/src/Services/<name>/Generated/`, and merges handwritten `Custom/` code.

Do not assume a service is C2J-generated — check which generator owns it. C2J also serves as the
*output* cross-check for the Smithy generator (naming, doc sanitization, `[AWSProperty]`), not just
a template.

Generator constraints (learned from real failures):

- **Don't run the generator unless asked.** Regenerating overwrites the `Generated/` output and
  removes stale/orphaned generated files by default, so the diff is large and includes deletions
  (stage them with `git add -A`).
- **T4 (legacy path):** edit the `.tt` template, never the generated `.cs`. Each `.tt` has a
  corresponding generated `.cs`. `.tt` → `.cs` is a **manual** step (Visual Studio "Run Custom
  Tool", or a full generator rebuild for project/source files) — there is no CLI for plain
  design-time regeneration. Output customization lives in `Customizations.cs` / `*.customizations.json`.
- **Generated deprecations need a message:** a bare `[Obsolete]` fails the build — `CA1041` is
  enforced as an error (`sdk/AWSDotNetSDKForBuild.ruleset`).
- **Generated unit-test projects:** `AWSSDK.UnitTests.NetFramework.csproj` and
  `AWSSDK.UnitTests.NetStandard.csproj` are generated (`UnitTestProjectFileCreator.cs`); hand-edits
  to them are overwritten on regeneration. `AWSSDK.UnitTests.Core.csproj` is manually maintained.
- **Validate a generator change** by regenerating an affected service and compiling it against Core
  across target frameworks, then running its unit-test project — passing the generator's own unit
  tests does not prove the emitted code compiles. (Confirm the exact repro before relying on it.)

## Protocol tests

- Generated from Smithy models: from `generator/ProtocolTestsGenerator`, run
  `./gradlew :smithy-dotnet-protocol-test:build`. Requires a JDK on `PATH` / `JAVA_HOME` — without
  one the wrapper errors ("JAVA_HOME is not set and no 'java' command could be found in your PATH.")
  and exits non-zero.
- Output goes to `sdk/test/ProtocolTests/Generated/<Protocol>/`; execute with `dotnet test` on the
  generated protocol-tests project (e.g. `AWSSDK.ProtocolTests.NetFramework.csproj`). To change a
  protocol test, edit the generator, not the generated output.

## Testing categories

- **Unit tests** — fast, isolated; run through the `run-tests-*` targets (see "Validate a change").
- **Protocol tests** — generated (see above).
- **Integration tests** — hit real AWS; require credentials and a dedicated test account, never production.

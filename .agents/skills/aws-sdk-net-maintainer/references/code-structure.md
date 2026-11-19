# Code Structure

## Repository map

- `sdk/src/Core/` — shared runtime (signers, credential providers, request pipeline).
- `sdk/src/Services/<Service>/` — one package per service; each has split project files
  `AWSSDK.<Service>.NetFramework.csproj` and `AWSSDK.<Service>.NetStandard.csproj` (a few have only
  the NetFramework variant), plus `Generated/` (generated code), `Custom/` (handwritten code), and `Properties/`.
- `sdk/test/` — `UnitTests/`, `IntegrationTests/`, `ProtocolTests/`, `Services/` (per-service tests),
  plus `Performance/`, `CompatibilityTests/`, `Common/`.
- `generator/` — service-client generation and protocol-test generation.
- `extensions/` — extension packages (`src/`, `test/`).
- `buildtools/` — build orchestration and custom build logic.

## Placement rules

- Shared runtime behavior → `sdk/src/Core/`.
- Service-local handwritten behavior → the service's `Custom/` folder (alongside `Generated/`).
- Repeated fixes to generated output → the generator, not the generated files. `generator/` holds
  both service-client generation and protocol-test generation. Avoid editing files under
  `Generated/` unless the task is specifically about generation output.

## NuGet package READMEs

The README shown on nuget.org is packed from a different file depending on the package:

- Service packages: the generator writes `sdk/src/Services/<Service>/nuget-readme.md` from the service
  documentation in the model, followed by a getting started example that creates the client and calls
  one operation. It is git-ignored. To add hand-written content, create
  `sdk/src/Services/<Service>/Custom/nuget-readme.md` and commit it; the generator puts its content
  after the example.
- Core and extension packages: commit a hand-written `README.md` next to the nuspec and reference it
  with `<readme>README.md</readme>` under `<metadata>` and `<file src="README.md" target="README.md" />`
  under `<files>`. Extension nuspecs are committed, so edit them directly. Core's nuspec is generated;
  its entries live in `CoreVersionWriter.WriteNuspec` (Smithy generator) and in `CoreNuspec.tt` and its
  preprocessed `CoreNuspec.cs` (C2J).

## Decision rule

If the same style of change would need to be repeated across multiple services, stop and inspect
Core or the generator first.

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

## Decision rule

If the same style of change would need to be repeated across multiple services, stop and inspect
Core or the generator first.

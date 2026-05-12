# Code Structure

## Main code areas

- `sdk/src/Core/`
  Shared runtime code used across services.
- `sdk/src/Services/`
  Service-specific packages.
- `generator/`
  Service generation, templates, service models, and protocol test generation.
- `extensions/`
  Extension packages.
- `buildtools/`
  Build orchestration and custom build logic.

## Service layout

Typical service package layout:

```text
sdk/src/Services/<ServiceName>/
├── AWSSDK.<ServiceName>.csproj
├── Generated/
├── Custom/
└── Properties/
```

## Placement rules

- Put shared runtime behavior in Core.
- Put service-local handwritten behavior in `Custom/`.
- Put repeated generated-output fixes in generator code or templates.
- Avoid directly editing generated files unless the task is explicitly about generation results.

## Decision rule

If the same style of change would need to be repeated across multiple services, stop and inspect Core or generator code first.

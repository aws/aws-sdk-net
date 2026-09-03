# DevConfig

DevConfig files control versioning and changelog metadata for AWS SDK for .NET branch changes.
`CONTRIBUTING.md` ("DevConfig Files") is the authoritative reference for the format and when one is
required; this file captures the local specifics and the traps not spelled out there.

## Location and when required

- Directory: `generator/.DevConfigs/`; file name: a unique GUID-based `.json` file.
- Required for code-changing PRs (see `CONTRIBUTING.md` for the exact exceptions). Include the
  section(s) matching the affected code: `core`, `services`, and/or `extensions`.
- `.sln` files for a service do NOT by themselves require a `services` entry.
- At release, multiple DevConfigs are combined and the greatest `type` wins.

## Creating a DevConfig

- Preferred: run the generator wizard — `buildtools/add-devconfig.bat` (or `.sh`) — which writes a
  correctly-formatted file (ordered fields, right key names).
- Authoring directly (e.g. a non-interactive agent): create `generator/.DevConfigs/` if missing
  (`New-Item -ItemType Directory -Force generator/.DevConfigs` on Windows/PowerShell), then write a
  `<guid>.json` with the sections below.

## Sections

The Core/Services/overrideVersion field reference lives in `CONTRIBUTING.md` ("DevConfig File
Structure"); the `extensions` section is documented only in the generator source
(`buildtools/DevConfigGenerator`). Local essentials:

- **core** — for Core changes. Requires `changeLogMessages` (array), `type` (`patch` | `minor`),
  and `updateMinimum`. Optional `backwardIncompatibilitiesToIgnore`.
- **services** — array; each entry needs `serviceName` (without the `AWSSDK.` prefix),
  `type` (`patch` | `minor`), and `changeLogMessages`.
- **extensions** — array; each entry uses `extensionName` (not `serviceName`), `type`, and
  `changeLogMessages`. Extensions are supported (`DevConfigWriter` emits an `extensions` array).

A single file may combine `core`, `services`, and `extensions`.

```json
{
  "core": { "changeLogMessages": ["Describe the Core change"], "type": "patch", "updateMinimum": true },
  "services": [ { "serviceName": "S3", "type": "patch", "changeLogMessages": ["Fixed ..."] } ]
}
```

## overrideVersion

`overrideVersion` sets a specific version for all services and is reserved for major cross-SDK
milestones. See `CONTRIBUTING.md`'s overrideVersion guidance before using it.

## Third-party PRs

For contributor PRs that lack a DevConfig, follow `CONTRIBUTING.md` ("Third-Party Developer PRs").

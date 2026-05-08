# DevConfig

DevConfig files control versioning and changelog metadata for AWS SDK for .NET branch changes.

## Location

- directory: `generator/.DevConfigs/`
- file name: a unique JSON file, typically a GUID-based name

## When a DevConfig is required

A DevConfig is required for code-changing PRs, except for the limited exceptions documented in `CONTRIBUTING.md`.

Do not limit DevConfigs to only changes under `sdk/src/Core/*` or `sdk/src/Services/*`. Include the section or sections that match the affected code:

- `core` for Core changes
- `services` for service changes
- `extensions` for extension changes, if supported by the DevConfigGenerator

Non-code-only changes may not require a DevConfig; follow `CONTRIBUTING.md` for the current exceptions and requirements.
## Core section

Use a `core` section when the change affects Core.

Example:

```json
{
  "core": {
    "changeLogMessages": [
      "Describe the Core change here"
    ],
    "type": "patch",
    "updateMinimum": true
  }
}
```

Fields:

- `changeLogMessages`
  required array of changelog lines
- `type`
  required, `patch` or `minor`
- `updateMinimum`
  required for Core
- `backwardIncompatibilitiesToIgnore`
  optional

## Services section

Use a `services` section when the change affects one or more services.

Example:

```json
{
  "services": [
    {
      "serviceName": "S3",
      "type": "patch",
      "changeLogMessages": [
        "Fixed marshalling behavior for ..."
      ]
    }
  ]
}
```

Fields:

- `serviceName`
  required, without the `AWSSDK.` prefix
- `type`
  required, `patch` or `minor`
- `changeLogMessages`
  required

## Combined file

A DevConfig can include both `core` and `services` when needed.

## Key Concepts

- Each developer's branch requires a DevConfig file
- Files are automatically removed after release information extraction
- Multiple DevConfig files are combined during release to determine version bumps
- `.sln` files for a service do NOT count towards requiring a service entry in DevConfig

## Special Sections

- `overrideVersion`: Sets specific version for all services (use with caution)

```json
{
  "services": [{...}],
  "core": {...},
  "overrideVersion": "3.7.300.0"
}
```

## DevConfig Creation Process

When creating a `DevConfig`, use this process:

1. Ensure the `generator/.DevConfigs` directory exists. Create it with `mkdir -p generator/.DevConfigs` if needed.
2. Determine file changes with `git status` and read the file changes.
3. Apply the rules about devconfig files to generate the text for the file.
4. Write the devconfig text to a file in the `generator/.DevConfigs` folder. Write the text directly to the GUID.json file, making sure to use a GUID for the filename.

## Version Numbering

- Format: w.x.y.z
- x: major
- y: minor
- z: patch
- System selects greatest type value for release

## Third-Party PR Handling

- Ask contributor to add the file
- Add file to their PR as another commit
- Copy branch to aws-sdk-net-staging and add commit with DevConfig
- Create separate DevConfig PR to merge alongside third-party PR

## Implementation Details

The DevConfig tooling that exists in this repository is under `buildtools/DevConfigGenerator/`.

If you are looking for parser or consumer code, do not expect to find the previously referenced
`AwsSdkDotNetBuildUtilities`, `BaseDevConfig.cs`, `Core.cs`, `Service.cs`, or `DevConfig.cs`
files in this repository. Use the in-repo `buildtools/DevConfigGenerator/` tooling as the
repository-local reference point for DevConfig behavior.

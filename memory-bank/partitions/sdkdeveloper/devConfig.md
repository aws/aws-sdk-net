# DevConfig Files

## Purpose
DevConfig files control versioning, changelog messages, and service updates for AWS SDK for .NET branches. They ensure configuration and changelog messages are reviewed during PR reviews.

## Location
- Path: `generator/.DevConfigs/`
- Filename: Unique JSON file (recommended to use GUID)
- The `.DevConfigs` folder must be created for each change as it isn't committed to the codebase

## When Required
- All developer branches being merged into the system (both private and public repositories)
- Not required for Trebuchet feature customization branches unless they contain core changes
- Required for changes in `sdk/src/Core/*` (core changes) and `sdk/src/Services/*` (service changes)
- Not needed for changes outside these folders

## Key Concepts
- Each developer's branch requires a DevConfig file
- Files are automatically removed after release information extraction
- Multiple DevConfig files are combined during release to determine version bumps
- `.sln` files for a service do NOT count towards requiring a service entry in DevConfig

## File Structure

### Core Section
Required for any change to Core component:

```json
{
  "core": {
    "changeLogMessages": [
      "Message 1",
      "Message 2"
    ],
    "type": "patch",
    "updateMinimum": true
  }
}
```

- `changeLogMessages`: (Required) Array of messages for changelog
- `type`: (Required) Version segment to increment (`minor` or `patch`)
- `updateMinimum`: (Required) Whether to update minimum core version for all services
- `backwardIncompatibilitiesToIgnore`: (Optional) Array of validation errors to ignore

### Service Section
Required for any service-specific changes:

```json
{
  "services": [
    {
      "serviceName": "S3",
      "type": "patch",
      "changeLogMessages": [
        "Fixed marshalling bug in operation xyz"
      ]
    }
  ]
}
```

- `serviceName`: (Required) Service name without "AWSSDK." prefix
- `type`: (Required) Version segment to increment (`minor` or `patch`)
- `changeLogMessages`: (Required) Array of messages for changelog

### Special Sections
- `overrideVersion`: Sets specific version for all services (use with caution)

```json
{
  "services": [{...}],
  "core": {...},
  "overrideVersion": "3.7.300.0"
}
```

## DevConfig Creation Process

When asked to create a `DevConfig` you MUST follow these commands exactly:

1. Ask the developer to run this command `mkdir -p generator/.DevConfigs`. You don't have access to create directories at this time so DO NOT attempt to create it.
2. Determine file changes with `git status` and read the file changes. 
3. Apply the rules about devconfig files to generate the text for the file.
4. Write the devconfig text a file in the `generator/.DevConfigs` folder. Write the text directly to the GUID.json file making sure to use a GUID for the filename.

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
DevConfig code in AwsSdkDotNetBuildUtilities:
- BaseDevConfig.cs: Base section fields
- Core.cs: Core-specific properties
- Service.cs: Service-specific properties
- DevConfig.cs: Complete DevConfig object

## Future Extensions
- Plans to extend DevConfig file specification to include extensions in the `extensions` folder hierarchy
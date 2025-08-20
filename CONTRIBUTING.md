# Contributing to AWS SDK for .NET

Thank you for your interest in contributing to the AWS SDK for .NET! This guide will help you understand our development process and how to submit successful pull requests.

## DevConfig Files - Essential for Pull Requests

**⚠️ Important: All pull requests that modify code MUST include a DevConfig file. This is required for the release process and changelog generation.**

### What is a DevConfig File?

A DevConfig file is a JSON configuration file that tells our build system:
- What changes you've made (core SDK changes, service-specific changes, or both)
- What type of version bump is needed (patch, minor)
- What messages should appear in the changelog

### When Do You Need a DevConfig File?

You need a DevConfig file for:
- ✅ Bug fixes
- ✅ New features
- ✅ Service updates
- ✅ Core SDK modifications
- ✅ Any code changes that affect functionality

You DON'T need a DevConfig file for:
- ❌ Documentation-only changes
- ❌ Test-only changes (unless fixing test bugs)
- ❌ Build script modifications that don't affect the SDK

### Creating DevConfig Files

There are two methods to create DevConfig files:

#### Method 1: Automated Script (Recommended)

**Windows:**
```batch
cd buildtools
add-devconfig.bat
```

**Linux/Mac:**
```bash
cd buildtools
./add-devconfig.sh
```

This script will:
1. Build the DevConfig generator tool
2. Launch an interactive wizard to help you create the DevConfig file
3. Automatically place it in the correct location with a unique filename

#### Method 2: Manual Creation 

If you prefer to create the file manually or the script doesn't work in your environment:

**Step 1: Create the DevConfig directory**
```powershell
# From the root of the repository
New-Item -Type Directory -Force ".\generator\.DevConfigs"
```

**Step 2: Generate a unique filename**
```powershell
$randomName = New-Guid
$filePath = ".\generator\.DevConfigs\${randomName}.json"
New-Item -Type File -Force $filePath
```

**Step 3: Open the file for editing**
```powershell
code $filePath  # Or use your preferred editor
```

### DevConfig File Structure

#### Core Section

Any change to the Core component of the SDK requires a core section in the DevConfig file. If you are not changing a service you will almost always need a core section. Here is a common core section.

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

**Core Section Fields:**

- **`changeLogMessages`**(Required) an array of messages to include in the changelog under the core section. Multiple change log messages will be listed each in their own bullet point in the changelog.
- **`type`** (Required) the part of the version string to increment for the change. The valid accepted values are currently minor and patch. The .NET SDK README.md specifies the version as w.x.y.z where x is major, y is minor, and z is patch. The specified type will increment that segment by one. However, the system will select the greatest type value for the release. Meaning if one DevConfig core section has a type of patch but another has type minor only the minor segment of the version will be incremented by 1. This field is not required if the overrideVersion field is used in the DevConfig.
- **`updateMinimum`** (Required) whether or not to update the minimum core version for all services as the result of this core change. A value a true will update all services where a value of false will only require core to update. Typically a change to core that the other services need to use will require updateMinimum to be set to true to make use of the change. This field is not required if the overrideVersion field is used in the DevConfig.
- **`backwardIncompatibilitiesToIgnore`** An array of strings for the type of validation errors to ignore. The AssemblyComparer checks for breaking changes in core. A developer is to evaluate any errors raised by the AssemblyComparer and either fix the violation or skip the error if it is deemed to be ok as part of their PR. Example:

```json
{
  "services": [{...}]
  "core": {
    ...,
    "backwardIncompatibilitiesToIgnore": [ 
      "Amazon.Util.PaginatedResourceFactory/TypeRemoved",
      "Amazon.Runtime.URIBasedRefreshingCredentialHelper/MethodOverloadAdded",
      "Amazon.Util.Internal.ITypeInfo/MethodRemoved",
      "Amazon.Util.PaginatedResourceInfo/TypeRemoved",
      "Amazon.Runtime.Internal.Settings.SettingsCollection/MethodRemoved"
    ]
  }  
}
```

#### Services Section

Any change to a specific service requires a service specific DevConfig value. It is common to have a DevConfig with one service in it when a developer is fixing a bug. However, the following is a DevConfig file that would cover a bugfix in two services. If a supporting core change is also required the core section would also need to be added to this DevConfig file.

```json
{
    "services": [
        {
            "serviceName": "S3Control",
            "type": "patch",
            "changeLogMessages": [
                "Fixed a bug causing a stack overflow when using the adaptive retry policy."
            ]
        },
        {
            "serviceName": "S3",
            "type": "patch",
            "changeLogMessages": [
                "Fixed a bug where the bucketName was being marshalled incorrectly in operation xyz."
            ]
        }
    ]
}
```

**Services Section Fields:**

- **`serviceName`** (Required) Name of the service with the custom change. This should be NuGet package name without the "AWSSDK." prefix (for example, "IdentityManagement").
- **`type`**  (Required) the part of the version string to increment for the change. The valid accepted values are currently minor and patch. The .NET SDK README.md specifies the version as w.x.y.z where x is major, y is minor, and z is patch. The specified type will increment that segment by one.
- **`changeLogMessages`** (Required) an array of messages to include in the changelog under the specific service name section. Multiple change log messages will be listed each in their own bullet point in the changelog.

#### Other special sections

- **`overrideVersion`** allows the developer to specify a specific version to use for all services in the release. Once a version is overridden the this will be the new starting version for all new services. This value when used is written to the _sdk-version.json file within the SDK under the NewServiceVersion field. CAUTION: This field should never be used unless we are trying to set a specific version across the entire .NET SDK based off of some major work done such as when we added Endpoints 2.0 or added NET8.0. We typically will use a specific version so we can easily identify the version at which a major change was added. Usage example:

```
{
  "services": [{...}]
  "core": {...},
  "overrideVersion": "3.7.300.0"
}
```

#### Combined Example

When making changes to both core and services:

```json
{
  "core": {
    "updateMinimum": true,
    "type": "patch",
    "changeLogMessages": [
      "Message 1."
    ]
  },
  "services": [
    {
      "serviceName": "S3",
      "type": "patch",
      "changeLogMessages": [
        "Message 2.",
        "Message 3."
      ]
    }
  ]
}
```

#### Multiple Services Example

```json
{
  "services": [
    {
      "serviceName": "S3Control",
      "type": "patch",
      "changeLogMessages": [
        "Fixed a bug causing a stack overflow when using the adaptive retry policy."
      ]
    },
    {
      "serviceName": "S3",
      "type": "patch", 
      "changeLogMessages": [
        "Fixed a bug where the bucketName was being marshalled incorrectly in operation xyz."
      ]
    }
  ]
}
```

### Third-Party Developer PRs

If you're contributing from outside AWS, you have several options for adding DevConfig files:

1. **Add it yourself**: Include the DevConfig file in your PR (recommended)
2. **Request assistance**: Ask the maintainers to add one for you

----

Thank you for contributing to the AWS SDK for .NET! Your contributions help make AWS services more accessible to .NET developers worldwide.

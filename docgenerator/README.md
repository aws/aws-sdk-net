# AWS SDK for .NET Documentation Generator

`SDKDocGenerator` is a .NET console application that produces the static HTML
API reference website (the content published to
`https://docs.aws.amazon.com/sdkfornet/v4/apidocs/`).

It works by reflecting over the **built SDK assemblies** and reading their
companion XML doc-comment files, then emitting one HTML page per type/member
plus the surrounding static site framework (CSS/JS/landing page/TOC).

## Projects

| Project | Purpose |
|---|---|
| `SDKDocGenerator` | Console entry point + command-line parsing |
| `SDKDocGeneratorLib` | Core generation logic |
| `SDKDocGenerator.UnitTests` | Unit tests |
| `AWSSDKDocSamples` | Code samples surfaced in the generated docs |

## Prerequisites

The generator does **not** build the SDK. It consumes already-built assemblies,
which must be laid out as per-platform subfolders:

```
<SDKAssembliesRoot>/
  net472/
    AWSSDK.Core.dll
    AWSSDK.Core.xml
    AWSSDK.S3.dll
    AWSSDK.S3.xml
    Microsoft.Bcl.AsyncInterfaces.dll   <- third-party deps required for reflection
    ...
  net8.0/
  netcoreapp3.1/
  netstandard2.0/
_sdk-versions.json                      <- sibling of the assemblies root
```

Each service needs **three** things present:

1. The `AWSSDK.<Service>.dll` (loaded via reflection).
2. The matching `AWSSDK.<Service>.xml` doc-comment file (source of the prose).
3. All **third-party dependency DLLs** (e.g. `Microsoft.Bcl.AsyncInterfaces`,
   `System.Text.Json`). Reflection's `Type.GetTypes()` fails if a referenced
   dependency assembly can't be resolved.

You can satisfy these by building the SDK locally **or** by downloading the
prebuilt release assemblies (recommended — much faster).

## Getting the assemblies

Build the SDK so its assemblies land under `Deployment/assemblies`, then point
the generator at that folder. See `buildtools/build.proj` for the SDK build
targets.

## Building the generator

```bash
cd docgenerator
dotnet build AWSSDKDocGenerator.sln -c Release
```

## Running the generator

Run from the `docgenerator` directory. Generate a small subset first (the
service plus `Core`, which is always included) to validate your setup:

```bash
dotnet SDKDocGenerator/bin/Release/SDKDocGenerator.dll \
  -sdk ../Deployment/assemblies \
  -sdkversionfile ../Deployment/_sdk-versions.json \
  -emj SDKDocGenerator/example_meta.json \
  -o ../DocDeployment/docs \
  -sf . \
  -p net472 \
  -svc S3 \
  -wsc \
  -v
```

For the **full** site, drop `-svc S3` (this processes all services and takes
considerably longer):

```bash
dotnet SDKDocGenerator/bin/Release/SDKDocGenerator.dll \
  -sdk ../Deployment/assemblies \
  -sdkversionfile ../Deployment/_sdk-versions.json \
  -emj SDKDocGenerator/example_meta.json \
  -o ../DocDeployment/docs \
  -sf . \
  -p net472 \
  -wsc
```

The generated site is written to `DocDeployment/docs`. It is plain static HTML —
open `DocDeployment/docs/index.html` directly, or serve the folder:

```bash
cd ../DocDeployment/docs
python -m http.server 8000   # then browse http://localhost:8000
```

### MSBuild wrapper

`buildtools/doc-build.proj` orchestrates the whole flow (builds the generator,
clears the output folder, runs generation, and creates a sitemap) using the
same defaults shown above:

```bash
cd buildtools
dotnet msbuild doc-build.proj
# limit services / change output:
dotnet msbuild doc-build.proj /p:SDKServices=S3,Core /p:DocOutputRoot=C:\temp\docs
```

## Command-line options

| Option | Short | Value | Description |
|---|---|---|---|
| `-sdkassembliesroot` | `-sdk` | path | Folder containing the per-platform assembly subfolders and (by default) `_sdk-versions.json`. |
| `-sdkversionfile` | `-sdkversion` | path | Path to `_sdk-versions.json`. Defaults to the parent of the assemblies root. |
| `-platform` | `-p` | e.g. `net472` | Primary platform used for assembly discovery. Falls back to `net472` / first available. |
| `-services` | `-svc` | `S3,DynamoDBv2` | Comma-delimited services to process. `Core` is always added. Omit to process all. |
| `-outputfolder` | `-o` | path | Root folder for the generated site. |
| `-samplesfolder` | `-sf` | path | Root folder containing the SDK code samples (the folder **above** `AWSSDKDocSamples`). |
| `-examplemetajson` | `-emj` | path | Path to `example_meta.json`. |
| `-exampleserrorfile` | `-eef` | path | Output path for the examples error file. Defaults to `examples_failure.txt`. |
| `-writestaticcontent` | `-wsc` | flag | Also emit the static site framework (CSS/JS/landing/TOC). Required for a browsable site. |
| `-clean` | `-c` | flag | Delete the output folder contents before generating. |
| `-testmode` | `-t` | flag | Generate a small predefined subset — handy when working on the generator itself. |
| `-verbose` | `-v` | flag | Verbose diagnostic output. |
| `-waitonexit` | `-w` | flag | Pause for a keypress before exiting. |

Arguments can also be supplied via a response file using `@filename`.

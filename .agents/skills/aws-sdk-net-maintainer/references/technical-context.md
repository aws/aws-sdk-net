# Technical Context

For build and test commands, see `build-and-validate.md`. This file captures non-obvious V4
behavior, dependencies, and architecture a maintainer needs — it is not a full inventory.

## Generator tooling

- Two service-code generators, mid-migration (see `build-and-validate.md` for how they run): the
  Smithy-native generator (`generator/SmithyDotNet/`, reads the Smithy AST) for migrated services,
  and the legacy C2J/T4 generator (`generator/ServiceClientGeneratorLib/`) for the rest.
  `generator/SmithyDotNet/CLAUDE.md` is the source of truth for Smithy generation work.
- Protocol Test Generator: Java/Gradle (gradlew wrapper), from Smithy models.
- Custom MSBuild tasks live in `buildtools/`.

## V4 behavior changes

The source of truth for "what changed from V3":

- Collections default to `null` instead of empty; `Amazon.AWSConfigs.InitializeCollections = true`
  restores V3 behavior. Request/response value properties are nullable.
- `System.Text.Json` for serialization (with buffer pooling); no embedded JSON endpoint file —
  endpoint resolution rules are generated instead of parsed at runtime.
- S3 `us-east-1` is treated as a regional-only endpoint.
- EC2 IMDS v2 protocol only.
- Consistent UTC `DateTime` handling.
- DynamoDB: `DynamoDBContextBuilder` replaces the obsoleted `DynamoDBContext` constructors;
  operation-specific config objects replace the generic `DynamoDBOperationConfig`; interface-based
  return types for mockability; polymorphism support for entries.
- Bi-directional HTTP/2 streaming (Transcribe Streaming, Bedrock) — .NET 8+ only, not on .NET Framework.
- Added Native AOT support for `AWSSDK.Extensions.NETCore.Setup` specifically (the SDK already supported Native AOT in V3; V4 extended it to this package).

Design intent: a smaller `AWSSDK.Core`, fewer allocations, faster cold starts. Treat specific
figures as marketing — see the "What's new in V4" developer guide if a number is needed.

## Package structure changes in V4

- DynamoDB Streams → separate `AWSSDK.DynamoDBStreams`.
- Obsolete S3 encryption client removed from `AWSSDK.S3`; replaced by `Amazon.Extensions.S3.Encryption`.
- CloudFront signers → `AWSSDK.Extensions.CloudFront.Signers`.
- EC2 password decryption → `AWSSDK.Extensions.EC2.DecryptPassword`.

## Notable extension packages

- **Extensions.CborProtocol** — RPCv2 CBOR; pulled in automatically by services that support it.
- **Extensions.CrtIntegration** — AWS Common Runtime for SigV4a signing and CRC-32C checksums.
- **Extensions.CloudFront.Signers** — CloudFront URL/cookie signing (RSA and ECDSA keys).
- **Extensions.NETCore.Setup** — `IServiceCollection` integration; Native AOT compatible.

## Dependencies and constraints

- `AWSSDK.Core` is required by every service package.
- AWS Common Runtime (CRT) is needed for SigV4a signing (S3, EventBridge Multi-Region Access
  Points) and CRC-32C checksums.
- On .NET Framework 4.7.2 and .NET Standard 2.0 the SDK relies on backport packages
  (`System.Buffers`, `System.Memory`, `System.Text.Json`); `BouncyCastle.Cryptography` is used for
  specific cryptographic operations.
- Preserve public API binary/source compatibility within a major version. Keep external
  dependencies minimal (version-conflict risk) — CRT and the backports above are the sanctioned exceptions.

## Configuration knobs

- `Amazon.AWSConfigs.InitializeCollections` — initialize collections by default (`true` restores V3 behavior).
- `AWSConfigs.TelemetryProvider` — register a custom telemetry provider.
- `AWSConfigs.DisableLegacyPersistenceStore` — skip the SDK Store in default profile resolution.
- `ClientConfig.MaxStaleConnectionRetries` — stale-connection retries (do not count against the standard retry budget).
- Auth scheme preference — order authentication schemes (e.g. prefer SigV4a over SigV4 when both apply).

## Versioning

- 4-part scheme `W.X.Y.Z`: `W.X` kept in sync across all packages; `Y` for features/service
  updates; `Z` for bug fixes; the greatest applicable type wins at release.
- `AssemblyVersion` is locked to the first two parts (major.minor) on all target frameworks, while
  `AssemblyFileVersion` carries the full 4-part version.

## Request pipeline

Requests flow through a chain of handlers (marshalling, endpoint resolution, retries, credentials,
signing, checksums, compression, HTTP, error handling, unmarshalling, and others). The authoritative,
ordered set is assembled in `sdk/src/Core/Amazon.Runtime/AmazonServiceClient.cs` and
`sdk/src/Core/Amazon.Runtime/Pipeline/RuntimePipeline.cs` — read those before adding, removing, or
reordering a handler (the list-construction order there is not the same as invocation order).

## Observability

- `TelemetryProvider` is the central registration point; `TracerProvider` / `MeterProvider`
  interfaces allow custom tracing/metrics implementations.
- OpenTelemetry integration via the consumer-supplied `OpenTelemetry.Instrumentation.AWS`.
- Logging via dedicated adaptor packages: `AWSSDK.Extensions.Logging.Log4NetAdaptor`,
  `AWSSDK.Extensions.Logging.ILoggerAdaptor`.

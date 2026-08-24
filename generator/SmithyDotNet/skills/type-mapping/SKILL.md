---
name: type-mapping
description: Smithy shape to .NET type mapping, nullability, and collection defaults. Use when changing TypeMapper or member resolution in the SmithyDotNet generator.
---
# Skill: Smithy to .NET Type Mapping

## Purpose

Definitive mapping from Smithy shape types to .NET types, plus nullability and collection default rules.

## Type Mapping Table

| Smithy shape | .NET type | Notes |
|---|---|---|
| `boolean` | `bool?` | Nullable |
| `string` | `string` | Reference type, nullable by nature |
| `integer` | `int?` | Nullable |
| `long` | `long?` | Nullable |
| `float` | `float?` | Nullable |
| `double` | `double?` | Nullable |
| `timestamp` | `DateTime?` | Nullable |
| `byte` | — | Not supported yet — throws. No settled .NET mapping (the current SDK never emitted `byte`/`short`) |
| `short` | — | Not supported yet — throws |
| `bigInteger` | — | Not supported yet — throws. Wider-numeric types are earmarked for a dedicated numerics extension |
| `bigDecimal` | — | Not supported yet — throws |
| `blob` | `MemoryStream` | Not supported yet — throws. Target: streaming blobs → `Stream`, non-streaming → `MemoryStream` |
| `document` | `Amazon.Runtime.Documents.Document` | Not supported yet — throws. SDK runtime type |
| `enum` | `ConstantClass` | The class the `ServiceEnumerationsWriter` emits (see `TypeMapper.EnumTypeName`); marshals as a string via implicit conversion, matching C2J |
| `intEnum` | `int?` | No `ConstantClass` — C2J has no `intEnum`, so it maps to a plain nullable int like `IntegerShape` |
| `list` | `List<T>` | V4 default: `null`; see Collection Defaults |
| `map` | `Dictionary<TKey, TValue>` | V4 default: `null`; see Collection Defaults |
| `structure` | Generated class | See structure rules below |
| `union` | Generated class | Generated as regular structure (matches current SDK) |

## Nullability Rules

The AWS SDK for .NET V4 convention:

1. **All value types are nullable** — `bool?`, `int?`, `DateTime?`, etc. regardless of `@required` or `@default` traits
2. **Reference types** (`string`, `MemoryStream`) — nullable by nature, no `?` suffix needed in the type declaration
3. **Collections** — V4 default: `null`; see Collection Defaults section
4. **The `@default` trait does NOT change nullability** — this matches current SDK behavior
5. **The `@required` trait does NOT change nullability** — it only affects the `[AWSProperty(Required=true)]` attribute

### Opt-in Strict Nullability (Non-AWS Use)

The generator will support an opt-in mode that respects Smithy's nullability traits (`@required`, `@default`, `@clientOptional`) for non-AWS Smithy models. When disabled (the default for AWS), all value types are nullable regardless of traits.

## Collection Defaults

Collections use `AWSConfigs.InitializeCollections` for SDK V4 backwards compatibility. The
generator emits an auto-property with the initializer expression directly, plus an internal
`IsSet{Property}()` method that the AWS SDK runtime (and marshallers) call:

```csharp
public List<AuditEvent> AuditEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditEvent>() : null;

internal bool IsSetAuditEvents() => this.AuditEvents != null && (this.AuditEvents.Count > 0 || !AWSConfigs.InitializeCollections);
```

When `AWSConfigs.InitializeCollections` is `false` (V4 default), collections start as `null`,
and an empty list still counts as "set" (the caller cleared the value). When `true` (V3 compat),
collections start empty and an empty list counts as "not set". The `IsSet` method encodes that
rule so callers — including the public reflection API `AWSSDKUtils.IsPropertySet` — see the
correct answer in both modes.

## Constrained Shapes

Smithy allows constrained shapes (e.g. a `string` shape named `Uuid` with `@length` or `@pattern`). These do NOT get wrapper classes — they map to their underlying .NET type:

| Smithy | .NET |
|---|---|
| `Uuid` (string shape with constraints) | `string` |
| `AuditEvents` (list shape) | `List<AuditEvent>` inline |
| `ChannelArn` (string shape) | `string` |

The constraints flow through to `[AWSProperty]` attributes on the **member that references the shape**. When resolving `[AWSProperty]`, check traits on **both** the member and its target shape:
- `@required` is on the member
- `@length` / `@range` are typically on the target shape (e.g. `AuditEvents` list has `@length(min:1, max:100)`, so `PutAuditEventsRequest.AuditEvents` gets `[AWSProperty(Required=true, Min=1, Max=100)]`)

## Error Shape Naming

Smithy error shapes often omit the `Exception` suffix. The naming rules (matching the existing generator's `ExceptionShape.Name` logic):
- Ends with `Exception` → keep as-is (e.g. `UnsupportedOperationException`)
- Ends with `Fault` → replace `Fault` with `Exception`
- Otherwise → append `Exception` (e.g. `ChannelNotFound` → `ChannelNotFoundException`)

## Error Shape Members

Error shapes have a `message` member in the Smithy model, but the generated exception class does **not** expose it as a property. The `message` is passed to `System.Exception` via the constructor and inherited as `Exception.Message`. The generator filters `message` out **everywhere** — the property set, the serialization block, and the unmarshaller alike — since `Exception.Message` already covers it.

Two base-class adjustments follow (matching `ExceptionShape.Members`, `Member.cs`, and `StructureGenerator.tt`):
- A member named `errorType` is renamed to the property `RequestErrorType` — **property name only; the wire name stays `errorType`** — so it doesn't hide `AmazonServiceException.ErrorType`, whose type is the `ErrorType` enum rather than the member's own type.
- A member named `Retryable` (on an exception) is emitted with the `new` modifier, hiding `AmazonServiceException.Retryable` — CloudHSM's exception models it with a different return type.

Independently of the exception-only rules, a member named `Equals` on **any** structure is emitted with `new` to hide `object.Equals(object)` (matches `StructureGenerator.tt`'s unconditional Equals check). This is set in `TypeMapper.ResolveMembers` and flows through every writer.

`RequestId` and `ErrorCode` get a narrower treatment than `message`. `AmazonServiceException` already declares them, so the generator emits **no property** (one would shadow the base; C2J's `StructureGenerator.tt` skips them in its property loop). But unlike `message` they are **not** filtered from serialization or unmarshalling — C2J's `ExceptionSerialization.t4` and `JsonRPCExceptionUnmarshaller.tt` loop `ExceptionShape.Members`, which drops only `message` — so the inherited property is still serialized and read from the error body. Hence `ExceptionWriter.ResolveSerializedMembers` (serialization block + unmarshaller) keeps them, while the property set is that same set with `RequestId`/`ErrorCode` filtered out inline in `WriteException`. Every other member — **including one whose name collides with a non-omitted inherited property** (e.g. `StatusCode`, `InnerException`) — is emitted as-is as a plain shadowing property and also read from the error body, exactly as C2J does.

## Resolving Member Types

To get the .NET type for a structure member:

1. Get the member's `Target` shape ID
2. `GenerationContext.Resolve(target)` returns the shape. Prelude shapes (`smithy.api#String`,
   etc.) are not in the model's shape map, but `Resolve` falls back to `PreludeShapes`, so
   callers never special-case them — a prelude `String` comes back as a `StringShape` like any
   other. Map the resolved shape's `type` from the table:
   - Simple/scalar shape → map its `type` from the table
   - Structure/union → use the generated class name
   - List → `List<{resolve member.Target}>`
   - Map → `Dictionary<{resolve key.Target}, {resolve value.Target}>`
   - Enum → `string` (Phase 1), `ConstantClass` subclass (Phase 2)
   - Constrained string shapes (e.g. `Uuid`) resolve to a `StringShape` → `string` (no wrapper)

## Prelude Shape Mapping

These shapes are implicit (not in the model JSON) and map directly. The .NET types below are the
target mapping; see the Type Mapping Table above for which are supported today vs. still throw
(`Blob`/`Document` are not supported yet):

| Prelude shape ID | .NET type |
|---|---|
| `smithy.api#String` | `string` |
| `smithy.api#Boolean` | `bool?` |
| `smithy.api#Integer` | `int?` |
| `smithy.api#Long` | `long?` |
| `smithy.api#Float` | `float?` |
| `smithy.api#Double` | `double?` |
| `smithy.api#Blob` | `MemoryStream` |
| `smithy.api#Timestamp` | `DateTime?` |
| `smithy.api#Document` | `Amazon.Runtime.Documents.Document` |
| `smithy.api#Unit` | (no type — used for operations with no input/output) |

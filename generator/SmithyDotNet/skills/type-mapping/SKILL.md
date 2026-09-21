---
name: type-mapping
description: Smithy shape to .NET type mapping, nullability, collection element rules, and error-shape naming/member rules. Use when changing TypeMapper or member resolution in the SmithyDotNet generator.
---
# Skill: Smithy to .NET Type Mapping

## Type Mapping Table

| Smithy shape | .NET type | Notes |
|---|---|---|
| `boolean` | `bool?` | |
| `string` | `string` | |
| `integer` | `int?` | |
| `long` | `long?` | |
| `float` | `float?` | |
| `double` | `double?` | |
| `timestamp` | `DateTime?` | |
| `byte`, `short`, `bigInteger`, `bigDecimal` | — | Not supported yet: throws |
| `blob` | `MemoryStream` | Supported as an `@httpPayload` body, a JSON body member, or a list element / map value (base64 on the wire). A header, query or label blob throws. `@streaming` blob → `Stream`, `@httpPayload`-only (throws as a collection element) |
| `document` | `Amazon.Runtime.Documents.Document` | (Un)marshals wholesale through the runtime document transforms. Supported as a body member, `@httpPayload`, list element, or map value |
| `enum` | `ConstantClass` | The generated `ConstantClass` subclass; marshals as a string via implicit conversion, matching C2J. **Only as a member's own type**; inside a collection it is plain `string` (see Enums in Collections) |
| `intEnum` | `int?` | No `ConstantClass`: C2J has no `intEnum`, so it is a plain integer in every position |
| `list` | `List<T>` | Element rules below |
| `map` | `Dictionary<string, TValue>` | Key is always `string` (Smithy requires a string key; an enum key is `string` too, matching C2J). Values follow the element rules |
| `structure`, `union` | Generated class | The service `rename` map wins when it has an entry for the shape (error codes still use the shape name). A union is generated as a plain structure (matches the current SDK) |

Prelude shapes (`smithy.api#String`, `smithy.api#Integer`, ...) and the Smithy 1.0 `Primitive*` shapes
(`PrimitiveLong`, `PrimitiveBoolean`, ...) map exactly as their plain counterparts above.
`smithy.api#Unit` has no type: an operation with no input/output emits an empty
`{Op}Request`/`{Op}Response`, and a union member targeting Unit gets a per-service empty `Unit` model
class, as C2J ships.

## Nullability Rules

The AWS SDK for .NET V4 convention:

1. **All value-type members are nullable** (`bool?`, `int?`, `DateTime?`, ...) regardless of `@required` or `@default`.
2. **Reference types** (`string`, `MemoryStream`, generated classes) carry no `?`.
3. **Collection elements and map values are non-nullable** (`List<int>`, `Dictionary<string, DateTime>`), unless the collection is `@sparse`, which makes them nullable again (`List<int?>`, matching C2J).
4. `@default` and `@required` do NOT change nullability.

`IsSet{Property}()` follows from the type: `.HasValue` for a nullable value type (intEnum included),
`!this.X.IsNull()` for a document (the runtime `Document` is a struct), the collection rule below for a
list/map, `!= null` otherwise.

## Collection Defaults

Collections default to `null` (V4) and to an empty list when `AWSConfigs.InitializeCollections` is on
(V3 compat). In V4 an empty list counts as "set" (the caller cleared it); in V3 mode it counts as "not
set". The property initializer and `IsSet` body that encode this are in sdk-conventions → Collection
Properties.

## Enums in Collections

An `enum` surfaces as its `ConstantClass` **only as a structure member's own type**. As a list element, a
map key, or a map value it is plain `string`:

| Smithy | .NET |
|---|---|
| member targeting `Status` | `Status` (the ConstantClass) |
| `list<Status>` | `List<string>` |
| `map<Status, Status>` | `Dictionary<string, string>` |
| `list<list<Status>>` | `List<List<string>>` |

This matches C2J. Typing an element as its ConstantClass would be a public-API divergence
(`Amazon.Lambda.Model.CreateFunctionRequest.Architectures` and friends are `List<string>` in the shipped
SDK). A paginator's `items` element type follows the same element rules (string for an enum, nullability
per rule 3), so the flattened enumerable agrees with the `List<T>` property it reads from.

## Constrained Shapes

Smithy allows constrained shapes (e.g. a `string` shape named `Uuid` with `@length` or `@pattern`). These do NOT get wrapper classes; they map to their underlying .NET type:

| Smithy | .NET |
|---|---|
| `Uuid` (string shape with constraints) | `string` |
| `AuditEvents` (list shape) | `List<AuditEvent>` inline |
| `ChannelArn` (string shape) | `string` |

The constraints flow through to `[AWSProperty]` on the **member that references the shape**: `Required`
from the member's `@required`; `Min`/`Max` from `@length`/`@range` on the member, else on the target
(e.g. `AuditEvents` has `@length(min:1, max:100)`, so `PutAuditEventsRequest.AuditEvents` gets
`[AWSProperty(Required=true, Min=1, Max=100)]`); `Sensitive` from the target's `@sensitive`.

## Error Shape Naming

Smithy error shapes often omit the `Exception` suffix. The rules (matching the current SDK):
- Ends with `Exception` → keep as-is (e.g. `UnsupportedOperationException`)
- Ends with `Fault` → replace `Fault` with `Exception`
- Otherwise → append `Exception` (e.g. `ChannelNotFound` → `ChannelNotFoundException`)

## Error Shape Members

Error shapes have a `message` member in the Smithy model, but the generated exception class does **not** expose it as a property. The `message` is passed to `System.Exception` via the constructor and inherited as `Exception.Message`. The generator filters `message` out **everywhere**: the property set, the serialization block, and the unmarshaller alike.

Two base-class adjustments follow (matching the current SDK):
- A member named `errorType` is renamed to the property `RequestErrorType` (**property name only; the wire name stays `errorType`**) so it doesn't hide `AmazonServiceException.ErrorType`, whose type is the `ErrorType` enum rather than the member's own type.
- A member named `Retryable` is emitted with the `new` modifier, hiding `AmazonServiceException.Retryable`.

Independently of the exception-only rules, a member named `Equals` on **any** structure is emitted with `new` to hide `object.Equals(object)`.

A **response** member named `ContentLength` is not shadowed but omitted from the response class entirely: `AmazonWebServiceResponse` already declares it and the unmarshaller assigns the inherited property. See sdk-conventions.

`RequestId` and `ErrorCode` get a narrower treatment than `message`. `AmazonServiceException` already declares them, so the generator emits **no property** (one would shadow the base). But unlike `message` they are **not** filtered from serialization or unmarshalling: C2J serializes and reads every modeled member except `message`, so the inherited property is still written to the serialization block and read from the error body. Every other member is emitted as-is, exactly as C2J does; one colliding with another inherited property (e.g. `StatusCode`) would hide it without `new` and fail the SDK's warnings-as-errors build, and no model has one.

---
name: marshalling
description: Marshaller/unmarshaller file layout and per-protocol serialization patterns. Use when writing or reviewing any marshaller/unmarshaller writer in the SmithyDotNet generator.
---
# Skill: Marshalling

## File Layout

Under `Generated/Model/Internal/MarshallTransformations/`:

| File | Class | Base/Interface |
|---|---|---|
| `{Operation}RequestMarshaller.cs` | `IMarshaller<IRequest, {Operation}Request>` | — |
| `{Operation}ResponseUnmarshaller.cs` | `JsonResponseUnmarshaller` (or protocol equivalent) | Dispatches errors |
| `{Shape}Marshaller.cs` | `IRequestMarshaller<{Shape}, JsonMarshallerContext>` | Nested structs in request path |
| `{Shape}Unmarshaller.cs` | `IJsonUnmarshaller<{Shape}, JsonUnmarshallerContext>` | Nested structs in response path |
| `{Exception}Unmarshaller.cs` | `IJsonErrorResponseUnmarshaller<{Exception}, JsonUnmarshallerContext>` | — |

Singleton patterns differ by file type:
- Structure marshallers: `public readonly static {Shape}Marshaller Instance = new {Shape}Marshaller();`
- Many operation marshallers/unmarshallers use `private static ... _instance = new ...();` plus a public `Instance` property (and sometimes `internal static GetInstance()`).

## Class Signature
All marshallers and unmarshallers should be partial classes.

## Request Marshaller Scaffolding

Every request marshaller creates `new DefaultRequest(publicRequest, "Amazon.{ServiceName}")`, then sets
the `Content-Type` header (protocol-dependent), `HeaderKeys.XAmzApiVersion` (from
`ServiceShape.ApiVersion`), and `HttpMethod`/`ResourcePath` (from the `@http` trait, labels
interpolated); then serializes members per the placement rules below and returns `request`. Emitted
code is pinned in `JsonRequestMarshallerWriterTests`.

## Member Placement

| Smithy trait | Where | SDK pattern |
|---|---|---|
| `@httpQuery("name")` scalar | Query string | `request.Parameters.Add("name", StringUtils.FromString(...))` |
| `@httpQuery("name")` `list<string>` | Query string | `request.ParameterCollection.Add("name", publicRequest.Prop)` (repeated params, ordinal-sorted at runtime) |
| `@httpQueryParams` map | Query string | Loop entries into query params (see below); `@httpQuery` wins on key collision |
| `@httpLabel` | URI segment | Replace `{member}` in `request.ResourcePath` |
| `@httpHeader("name")` scalar | Header | `request.Headers["name"] = ...` |
| `@httpHeader("name")` `@mediaType` string | Header | Base64: `Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(...))`; read side decodes (C2J "jsonvalue"). Body-bound `@mediaType` strings are plain. Pinned in `ScalarMemberCodegenTests` |
| `@httpHeader("name")` `list<string>` | Header | `request.Headers["name"] = StringUtils.FromList(publicRequest.Prop)` (comma join, RFC-7230 quoting) |
| `@httpPrefixHeaders("prefix")` map | Multiple headers | Loop `map<string,string>`, emit `{prefix}{key}` headers (see below); request & response |
| `@httpPayload` | Entire body | Direct stream/string (skips body serialization) |
| `@hostLabel` | Endpoint host prefix | Additive: `request.HostPrefix` label + its normal binding (see below) |
| `@httpResponseCode` | (response only) | `unmarshalledObject.{Prop} = (int)context.ResponseData.StatusCode;` (see below) |
| No HTTP trait | Body | Protocol-specific serialization |

List query/header bindings are `list<string>` only — which covers `list<enum>` too, because an enum
collection element resolves to plain `string` (see the type-mapping skill). `request.ParameterCollection` (not the string-only `request.Parameters` facade) carries the
`List<string>` query overload. A list of a value-type element (int, long, bool, double, timestamp,
intEnum) *is* now allowed as a **body** member, but in a query/header binding position it falls through to
`StringConversion`, which returns null for a collection type and so fails loud (`?? throw` in
`WriteQueryStringMembers`/`WriteHeaderMembers`); no restJson1 service binds one to query/header today.

A single member may carry `@httpQueryParams` (structurally exclusive): a `map<string, string>` or
`map<string, list<string>>` whose entries each become query params, reusing the `@httpQuery`
serialization rules (a `list<string>` value repeats the key via `request.ParameterCollection`; a
`map<string, string>` adds `StringUtils.FromString(kvp.Value)` via `request.Parameters`). It's emitted
**after** the explicit `@httpQuery` members, each entry guarded by a `ContainsKey` check that skips
keys already set — so an explicit `@httpQuery` wins the collision, per the Smithy precedence rule.
The guard intentionally does NOT cover query literals in the `@http` uri (those live in
`request.SubResources`, not the parameter collection): C2J has the same gap, and the only real case
(apigateway `ImportRestApi`, `/restapis?mode=import` plus @httpQueryParams) keeps C2J parity — a
colliding map key emits a duplicate param rather than silently changing wire behavior on migration.
Emitted code is pinned in `QueryParamsCodegenTests`.

The map is a query binding (request-only, `@input` structures), so it never enters the JSON body, and
its presence sets `request.UseQueryString = true`. The trait is "simply ignored" outside operation input.

A single member may carry `@httpPrefixHeaders` (structurally exclusive): a `map<string, string>` whose
entries each become a header named `{prefix}{key}` (an `IsSet` guard, then a `foreach` assigning
`request.Headers[$"{prefix}{kvp.Key}"] = kvp.Value;`). It's emitted **before** the explicit `@httpHeader`
members, so a colliding header name (only possible with an empty prefix) is overwritten by the later
`@httpHeader` assignment — `@httpHeader` wins per the Smithy precedence rule. Emitted code is pinned in
`PrefixHeadersCodegenTests`.

Unlike the query traits, `@httpPrefixHeaders` is valid on request, response, **and error** structures
(see Response Header Unmarshalling for the reverse). The map value must be a string (a non-string value
fails loud).

## Wire Name Resolution

`@jsonName` if present, else the Smithy member name (camelCase). Other protocols differ — see Other Protocols.

## Request Body Serialization

### JSON (restJson1, awsJson1.x)

When any member is body-bound (or `@httpPayload`), the marshaller writes a `Utf8JsonWriter` body over
a `PooledContentStream` (`#if NETFRAMEWORK`: a `MemoryStream` copied to `request.Content`). Each body
member is `IsSet`-guarded, then written per Type → Marshal/Unmarshal under its wire name. Pinned in
`JsonRequestMarshallerWriterTests`.

- Structures dispatch to `{Shape}Marshaller.Instance`; lists/maps loop and recurse to any depth
  (`JsonBodyMemberMarshaller.WriteCollectionValue`). Map keys are always strings.
- Collection leaves: string, value-type scalar, structure, or document. An enum leaf collapses to a
  string, an intEnum to a plain `int`; blob leaves fail loud in `TypeMapper`. Non-sparse value-type
  leaves are non-nullable (`List<int>` — the all-value-types-nullable rule is members-only), so they
  write bare: no `.Value` unwrap, no float/double NaN guard (both member-only). `@timestampFormat`
  is honored on leaves.
- `@sparse` leaves are nullable (`List<int?>`) and JSON nulls are written, matching C2J: a sparse
  list null-guards only value-type elements (null strings/structures already serialize); a sparse
  map null-guards every value kind. Pinned in `CollectionElementCodegenTests`.
- Required strings: throw `Amazon{ServiceName}Exception` if null/empty before serialization.

Structure marshallers loop the structure's own members with the same rules.

### `@httpPayload` (request)

A `@httpPayload` member IS the entire body — no wrapping object/property name, no other member in the body (Smithy: all others are header/query/label). No `IsSet` guard (matches C2J). Emitted code for every payload kind (request and response) is pinned in `PayloadMemberCodegenTests`.

- **String** → `text/plain` (or the target's `@mediaType` value when present), no scaffold: `request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.{Prop});`
- **Structure** → `application/json`; the scaffold above, then the target's marshaller as the body object (`WriteStartObject` → `{Type}Marshaller.Instance.Marshall(publicRequest.{Prop}, context)` → `WriteEndObject`).
- **Blob** (`MemoryStream`, or `Stream` when `@streaming`) → `application/octet-stream` (or the target's `@mediaType` value when present; overrides the top `application/json`); adds `using System.Globalization;`. Always assigns `request.ContentStream = publicRequest.{Prop} ?? new MemoryStream();` first and ends with the Content-Type override; the Content-Length handling in between branches on the operation's `aws.auth#unsignedPayload` and the target blob's `smithy.api#requiresLength` (mirrors C2J `JsonRPCRequestMarshaller`; emitted code is pinned in `BlobCodegenTests`):
  - **`@streaming` + `@unsignedPayload`, no `@requiresLength`** → seek to start and set Content-Length when the stream is seekable, else `Transfer-Encoding: chunked` (length unknown up front, and signing is off anyway).
  - **`@streaming` + `@requiresLength`** → stream MUST be seekable (throws `InvalidOperationException` otherwise), then always sets Content-Length. `@requiresLength` wins over the unsigned chunked path.
  - **otherwise** (every non-streaming blob; a streaming blob on a signed op) → seek when seekable, always set Content-Length (no chunked).

  Separately, `aws.auth#unsignedPayload` on the operation emits `request.DisablePayloadSigning = true;` after the body block, for **any** body kind (not just blobs).

List, map, and document payloads all fail loud in the writer — a document maps in `TypeMapper` (it is a
supported body member) but has no `@httpPayload` form. A union derives from `StructureShape`, so a union
payload takes the structure path.

### `@endpoint` host prefix (request)

An operation's `@endpoint` trait sets `request.HostPrefix` (the resolver's `InjectHostPrefix` prepends it to the endpoint host). Emitted last, after `UseQueryString`, before `return`.

- **Static** (no labels) → `request.HostPrefix = $"data.";`
- **Labeled** → each `@hostLabel` member is captured into an anonymous `hostPrefixLabels` object (field = modeled member name, value = `StringUtils.FromString(publicRequest.{Prop})`), validated with `HostPrefixUtils.IsValidLabelValue` (throws `Amazon{Service}Exception` naming the label and the 1–63 alphanumeric/dash rule), then interpolated into the prefix (`{name}` → `{hostPrefixLabels.name}`). Emitted code is pinned in `HostPrefixCodegenTests`.

`@hostLabel` is **additive** — the member is still marshalled in its normal binding (body/`@httpLabel`/`@httpQuery`/`@httpHeader`) as well.

## Response Unmarshaller Body

The body loop is `while (context.ReadAtDepth(targetDepth, ref reader))` with a
`context.TestExpression("{wireName}", targetDepth, ref reader)` guard per member assigning
`{Unmarshaller}.Instance.Unmarshall(context, ref reader)` then `continue`. Pinned in
`JsonResponseUnmarshallerWriterTests`.

- Lists: `new JsonListUnmarshaller<T, TUnmarshaller>(TUnmarshaller.Instance)`
- Maps: `new JsonDictionaryUnmarshaller<string, V, StringUnmarshaller, VU>(StringUnmarshaller.Instance, VU.Instance)`
  (key is always `string`/`StringUnmarshaller`).
- Scalar unmarshallers come from `ScalarUnmarshaller`, one map keyed on the .NET type string (nullability
  and all). A standalone member is nullable (`int?`→`NullableIntUnmarshaller`); a non-sparse collection
  element is non-nullable (`int`→`IntUnmarshaller`); a `@sparse` element is nullable again
  (`int?`→`NullableIntUnmarshaller`, matching the `List<int?>` property — the read side needs nothing
  else, since string/structure unmarshallers already return null on a JSON null). Timestamps use the
  non-nullable `DateTimeUnmarshaller` for elements, which auto-detects the wire format — no
  `@timestampFormat` is threaded on the read side, so epoch and date-time collections unmarshal identically.
- Nested collections compose recursively (`JsonBodyMemberUnmarshaller.CollectionUnmarshaller`): a map-of-list
  is `JsonDictionaryUnmarshaller<string, List<T>, StringUnmarshaller, JsonListUnmarshaller<T, TU>>(...)`. An
  enum leaf (and an enum key) is `string`/`StringUnmarshaller` — never a ConstantClass generic arg; an intEnum
  leaf is a plain `int`/`IntUnmarshaller`. Only blob leaves fail loud in `TypeMapper`.

### `@httpPayload` (response)

A `@httpPayload` output member IS the whole body (replaces the named-field loop; other members are header-bound), into `unmarshalledObject`:

- **String** → `using (var sr = new StreamReader(context.Stream)) { unmarshalledObject.Body = sr.ReadToEnd(); }`
- **Structure** → reader + `if (reader.Reader.IsFinalBlock) return unmarshalledObject;` + `{Type}Unmarshaller.Instance.Unmarshall(context, ref reader)`.
- **Blob** (non-streaming, `MemoryStream`) → `Amazon.Util.AWSSDKUtils.CopyStream(context.Stream, ms)` into a new `MemoryStream`; assigned only when `ms.Length > 0`, so an empty body leaves the property null (matches C2J).
- **Streaming blob** (`@streaming`, `Stream`) → assigns the raw `context.Stream` unbuffered (`unmarshalledObject.{Prop} = context.Stream;`) and the unmarshaller class overrides `public override bool HasStreamingProperty => true` (matches C2J — see Polly `SynthesizeSpeech`). Never copies into a `MemoryStream`.

`@httpHeader` members read from `context.ResponseData` after. **Errors don't get a payload path** — C2J never bound an error body to a payload and no service does, so `JsonExceptionUnmarshallerWriter` throws a `GeneratorException` on an `@httpPayload` error member (Smithy permits it; we fail loud rather than emit a never-populated property). Request/response `@httpPayload` stay allowed.

### `@httpResponseCode` (response)

An `@httpResponseCode` output member (an integer, so `int?` on the response class) is populated from
the HTTP status code itself — `unmarshalledObject.{Prop} = (int)context.ResponseData.StatusCode;` —
**not** read from the body or a header. The property name is whatever the model named the member
(e.g. a member `httpCode` emits `unmarshalledObject.HttpCode = ...`) — `PartitionByBinding` pulls the
member out via `IsHttpResponseCode()` so it never enters the body reader. Matches C2J's
`ProcessStatusCode`; pinned in `HttpResponseCodeCodegenTests`. The trait is only meaningful on an
operation's output; on an error it "is simply ignored" (Smithy spec), so `JsonExceptionUnmarshallerWriter`
passes `bindStatusCode: false` and the member falls through to the body like any ordinary member — unlike
`@httpPayload`, which fails loud on an error.

## Response Header Unmarshalling

Output and error members bound with `@httpHeader` are read from the HTTP response headers via
`context.ResponseData`, **not** the body reader. Body members read from the JSON reader loop; header
members are extracted after it. A JSON response whose members are all headers (or empty) emits no
reader/`while` loop at all — just the header `if`s. The error (exception) unmarshaller populates
`unmarshalledObject` the same way; its dispatch passes `context.ResponseData` into `contextCopy`, so
the header API is available there too.

Each member is guarded by `context.ResponseData.IsHeaderPresent("x-foo")` and assigned a
`<conversion>` (the assignment target is `unmarshalledObject` on the exception path, `response` on
the response path):

| Member type | `<conversion>` (with `value` = `context.ResponseData.GetHeaderValue("x-foo")`) |
|---|---|
| `string` / enum | `value` (direct; enum rides the string path via implicit ConstantClass conversion) |
| `bool?` | `bool.Parse(value)` (no culture — its two literals are culture-invariant) |
| `int?` | `int.Parse(value, CultureInfo.InvariantCulture)` |
| `long?` | `long.Parse(value, CultureInfo.InvariantCulture)` |
| `float?` | `float.Parse(value, CultureInfo.InvariantCulture)` |
| `double?` | `double.Parse(value, CultureInfo.InvariantCulture)` |
| `DateTime?` date-time / http-date | `DateTime.Parse(value, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal \| DateTimeStyles.AdjustToUniversal)` |
| `DateTime?` epoch-seconds | `Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(value, CultureInfo.InvariantCulture))` |

Header timestamps default to `http-date` when `@timestampFormat` is unset (see the binding-default
table below). On the unmarshal side `date-time` and `http-date` produce identical `DateTime.Parse`
code — only `epoch-seconds` differs. The `CultureInfo`/`DateTimeStyles` these parses use come from
`System.Globalization`, which the response and exception unmarshallers import unconditionally.

### `@httpPrefixHeaders` (response / error)

A `map<string, string>` member bound with `@httpPrefixHeaders` collects every response header whose
name starts with the prefix into a local dictionary (named `headersFor{Property}`, matching C2J),
stripping the prefix from each key. An empty prefix (the `.Length > 0` guard is false) collects all
headers. Assigned only when non-empty (matches C2J). The same `WritePrefixHeadersUnmarshaller` helper
serves the response and exception unmarshallers (both write to `unmarshalledObject`), since the trait
is valid on output and error structures alike. Emitted code is pinned in `PrefixHeadersCodegenTests`.

## Type → Marshal/Unmarshal

| .NET type | JSON Marshal | JSON Unmarshal |
|---|---|---|
| `string` | `WriteStringValue` | `StringUnmarshaller` |
| `int?` | `WriteNumberValue` | `IntUnmarshaller` |
| `long?` | `WriteNumberValue` | `LongUnmarshaller` |
| `bool?` | `WriteBooleanValue` | `BoolUnmarshaller` |
| `float?` | `WriteNumberValue` | `FloatUnmarshaller` |
| `double?` | `WriteNumberValue` | `DoubleUnmarshaller` |
| `DateTime?` | Format-dependent (see below) | `DateTimeUnmarshaller` |
| `MemoryStream` | `WriteStringValue(Convert.ToBase64String(...))` | `MemoryStreamUnmarshaller` |
| `List<T>` (T = scalar/structure/nested list/map) | Array loop | `JsonListUnmarshaller<ElementType, ElementUnmarshaller>` |
| `Dictionary<string,V>` (V = scalar/structure/nested list/map) | Object loop | `JsonDictionaryUnmarshaller<string, V, StringUnmarshaller, ValueUnmarshaller>` |
| Structure | `{Shape}Marshaller.Instance` | `{Shape}Unmarshaller.Instance` |

### Timestamp Formats

An explicit `@timestampFormat` (on the member or its target) always wins. When unset, the default is
**binding-specific**, not one per protocol — see the binding-default table below.

| `@timestampFormat` | Marshal (body) | Marshal (header/query/label) |
|---|---|---|
| `date-time` | `WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(value))` | `StringUtils.FromDateTimeToISO8601WithOptionalMs(value)` |
| `http-date` | `WriteStringValue(StringUtils.FromDateTimeToRFC822(value))` | `StringUtils.FromDateTimeToRFC822(value)` |
| `epoch-seconds` | `WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(value.Value))` | `StringUtils.FromDateTimeToUnixTimestamp(value)` |

restJson1 binding defaults when `@timestampFormat` is unset (matches the C2J generator's output):

| Binding | Default |
|---|---|
| Body / structure member | `epoch-seconds` (restJson1's document-timestamp default per the Smithy spec; the generic `@timestampFormat` default of `date-time` applies only when a protocol sets none) |
| `@httpHeader` | `http-date` |
| `@httpQuery`, `@httpLabel` | `date-time` |

String forms pass the nullable `DateTime?` straight to the `StringUtils` overload; the epoch form
unwraps with `.Value`.

`epoch-seconds` in a **body** is a JSON number that may carry a fraction, so it goes through
`ConvertToUnixEpochSecondsDecimal` (millisecond precision, `decimal` for identical digits on every
TFM) — not the whole-second `StringUtils.FromDateTimeToUnixTimestamp`. Header/query/label positions
are still whole seconds, matching C2J.

## Error Dispatch

In `{Operation}ResponseUnmarshaller.UnmarshallException`, each error is matched with
`errorResponse.Code != null && errorResponse.Code.Equals("{smithyShapeName}")` and dispatched to
`{Exception}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy)`.

Error code = Smithy shape name (e.g. `"ChannelNotFound"`), not the .NET exception name.
Fallback: `new Amazon{Service}Exception(errorResponse.Message, ...)`.

### Exception Unmarshaller

`Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)`
reads the first token, constructs the exception from the six `errorResponse` fields (message, inner
exception, type, code, request id, status code), runs the body loop for any body-bound members beyond
`message`, then extracts `@httpHeader` members from `context.ResponseData` (see Response Header
Unmarshalling). The read and the body loop are each guarded by `context.Stream.Length > 0` so an
empty error body skips them. Pinned in `JsonExceptionUnmarshallerWriterTests`.

## Other Protocols (not yet implemented)

Only restJson1 is implemented. For awsJson1.x, restXml, query, and ec2Query the target output is
defined by the C2J templates (`generator/ServiceClientGeneratorLib/Generators/Marshallers/*.tt`).
Contrasts to carry over when one lands: awsJson1.x routes via `X-Amz-Target: {ServiceName}.{Operation}`
with all members in the body (Content-Type `application/x-amz-json-1.{0,1}`, no `UseQueryString`);
query/ec2Query route via an `Action={Operation}` param with URL-encoded bodies; restXml keeps the HTTP
binding traits with an XML body (`@xmlName`/`@xmlFlattened`/`@xmlAttribute`/`@xmlNamespace`). The
XML-response family uses `XmlResponseUnmarshaller`, reads error codes from `<Code>` inside a wrapper
(`<ErrorResponse><Error>`; ec2Query: `<Response><Errors><Error>`), and defaults body timestamps to
`date-time` (vs epoch-seconds for the JSON family). Wire names: restXml `@xmlName`, query/ec2Query
`@ec2QueryName` or PascalCase of the member name.

When implementing one, replace this note with the real patterns — base classes, edge cases — and pin
the emitted code in codegen tests.

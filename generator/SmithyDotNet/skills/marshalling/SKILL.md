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
| `@httpQuery("name")` `list<value-type>` | Query string | `request.ParameterCollection.Add("name", publicRequest.Prop.ConvertAll<string>(item => StringUtils.FromX(item)))` (per-element conversion; timestamps default to `date-time`) |
| `@httpQueryParams` map | Query string | Loop entries into query params (see below); `@httpQuery` wins on key collision |
| `@httpLabel` | URI segment | Replace `{member}` in `request.ResourcePath` |
| `@httpHeader("name")` scalar | Header | `request.Headers["name"] = ...` |
| `@httpHeader("name")` `@mediaType` string | Header | Base64: `Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(...))`; read side decodes (C2J "jsonvalue"). Body-bound `@mediaType` strings are plain. Pinned in `ScalarMemberCodegenTests` |
| `@httpHeader("name")` `list<string>` | Header | `request.Headers["name"] = StringUtils.FromList(publicRequest.Prop)` (comma join, RFC-7230 quoting) |
| `@httpHeader("name")` `list<value-type>` | Header | `request.Headers["name"] = StringUtils.FromValueTypeList(publicRequest.Prop)` (its `List<T>` overload lowercases bool and forces `DateTime` to RFC822) |
| `@httpPrefixHeaders("prefix")` map | Multiple headers | Loop `map<string,string>`, emit `{prefix}{key}` headers (see below); request & response |
| `@httpPayload` | Entire body | Direct stream/string (skips body serialization) |
| `@hostLabel` | Endpoint host prefix | Additive: `request.HostPrefix` label + its normal binding (see below) |
| `@httpResponseCode` | (response only) | `unmarshalledObject.{Prop} = (int)context.ResponseData.StatusCode;` (see below) |
| No HTTP trait | Body | Protocol-specific serialization |

List query/header bindings cover `list<string>`/`list<enum>` (an enum collection element resolves to
plain `string` — see the type-mapping skill) *and* value-type element lists (int, long, bool, double,
float, timestamp, intEnum), matching C2J. `request.ParameterCollection` (not the string-only
`request.Parameters` facade) carries the query overload: a string/enum list is added directly, a
value-type list per-element via `ConvertAll<string>(item => StringUtils.FromX(item))` (the bare
`StringUtils.From*` name comes from `QueryElementConverter`; timestamps use the query default
`date-time`). A header string/enum list joins via `StringUtils.FromList`, a value-type list via
`StringUtils.FromValueTypeList` (its `List<T>` overload lowercases bool and forces `DateTime` to RFC822,
so no per-element/format branch is emitted). A **non-scalar** element (blob, structure, nested
list/map) fails loud in both positions (`WriteQueryListMember`/`WriteHeaderListMember`), matching C2J's
`NotImplementedException`. Pinned in `ListMemberCodegenTests`.

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
- Collection leaves: string, value-type scalar, structure, document, or non-streaming blob (base64 via
  `StringUtils.WriteBase64StringValue`). An enum leaf collapses to a string, an intEnum to a plain `int`;
  only `@streaming` blob leaves fail loud in `TypeMapper`. A `@sparse` blob leaf is null-guarded (the
  base64 helper dereferences its argument), unlike a null string which already writes JSON null. Non-sparse value-type
  leaves are non-nullable (`List<int>` — the all-value-types-nullable rule is members-only), so they
  write bare: no `.Value` unwrap, no float/double NaN guard (both member-only). `@timestampFormat`
  is honored on leaves.
- `@sparse` leaves are nullable (`List<int?>`) and JSON nulls are written, matching C2J: a sparse
  list null-guards only value-type elements (null strings/structures already serialize); a sparse
  map null-guards every value kind. Pinned in `CollectionElementCodegenTests`.
- Required strings: throw `Amazon{ServiceName}Exception` if null/empty before serialization.

Structure marshallers loop the structure's own members with the same rules. A request event-stream
**event** is the one exception: the publisher marshaller (C2J `EventStreamPublisherMarshaller`) calls
`{Event}Marshaller` with the JSON object already open, then reads `context.Request.EventHeaders` and
`context.Request.Content`. `JsonStructureMarshallerWriter` routes event members by trait (pinned in
`EventMarshallerCodegenTests`):

- `@eventHeader` → `IsSet`-guarded `EventStreamHeader("{memberName}")` (never `@jsonName`) with the typed
  setter for the target shape (`SetString` string/enum, `SetBool`/`SetInt32`/`SetInt64`/`SetTimestamp`
  with `.Value`, `SetByteBuf(….ToArray())` blob), added to `EventHeaders`. Byte/short are allowed by Smithy
  but `TypeMapper` doesn't map them, so they fail loud.
- `@eventPayload` → `IsSet`-guarded: blob `Request.Content = ….ToArray()`, string/enum
  `Encoding.UTF8.GetBytes(…)` (publisher sends octet-stream / text/plain, C2J parity); structure/union
  `{Type}Marshaller.Instance.Marshall(…, context)` into the open object (the protocol tests expect the bare
  structure as the payload, not one wrapped under the member name). List/map fail loud.
- Everything else is an ordinary body member (the implicit payload).

### `@httpPayload` (request)

A `@httpPayload` member IS the entire body — no wrapping object/property name, no other member in the body (Smithy: all others are header/query/label). No `IsSet` guard (matches C2J). Emitted code for every payload kind (request and response) is pinned in `PayloadMemberCodegenTests`.

- **String** → `text/plain` (or the target's `@mediaType` value when present), no scaffold: `request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.{Prop});`
- **Structure** → `application/json`; the scaffold above, then the target's marshaller as the body object (`WriteStartObject` → `{Type}Marshaller.Instance.Marshall(publicRequest.{Prop}, context)` → `WriteEndObject`).
- **Document** → `application/json`; the scaffold above, then `Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(writer, publicRequest.{Prop});` — NO `WriteStartObject`/`WriteEndObject` wrapping (the document is the whole JSON value, object/array/scalar). No C2J precedent (C2J represents a document as a structure and no model binds one to `@httpPayload`); designed to mirror the document body-member marshaller.
- **Blob** (`MemoryStream`, or `Stream` when `@streaming`) → `application/octet-stream` (or the target's `@mediaType` value when present; overrides the top `application/json`); adds `using System.Globalization;`. Always assigns `request.ContentStream = publicRequest.{Prop} ?? new MemoryStream();` first and ends with the Content-Type override — except when the input also has an `@httpHeader("Content-Type")` member: that header is emitted before the blob block and must win, so the blob's type moves to the top `Content-Type` line and the trailing override is dropped (restJson1 `TestPayloadBlob`); the Content-Length handling in between branches on the operation's `aws.auth#unsignedPayload` and the target blob's `smithy.api#requiresLength` (mirrors C2J `JsonRPCRequestMarshaller`; emitted code is pinned in `BlobCodegenTests`):
  - **`@streaming` + `@unsignedPayload`, no `@requiresLength`** → seek to start and set Content-Length when the stream is seekable, else `Transfer-Encoding: chunked` (length unknown up front, and signing is off anyway).
  - **`@streaming` + `@requiresLength`** → stream MUST be seekable (throws `InvalidOperationException` otherwise), then always sets Content-Length. `@requiresLength` wins over the unsigned chunked path.
  - **otherwise** (every non-streaming blob; a streaming blob on a signed op) → seek when seekable, always set Content-Length (no chunked).

  Separately, `aws.auth#unsignedPayload` on the operation emits `request.DisablePayloadSigning = true;` after the body block, for **any** body kind (not just blobs).

List and map payloads fail loud in the writer. A union derives from `StructureShape`, so a union payload
takes the structure path; a document takes the document path above.

### `@requestCompression` and `@httpChecksumRequired` (request)

Both are one emitted call to a runtime helper in `Amazon.Runtime.Internal.Util` (already in the
marshaller usings), sitting at opposite ends of the body. Pinned in `CompressionChecksumCodegenTests`.

- `@requestCompression` → `CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.{encoding});`
  right after `new DefaultRequest(...)`, before the `Content-Type` header. `encodings` is a preference
  list, so the first **supported** entry wins and unsupported ones are skipped (`["br", "gzip"]` emits
  gzip); `gzip` is the whole supported set, since the value is emitted verbatim as the enum member and
  `CompressionEncodingAlgorithm` has only `NONE` and `gzip`. When nothing in the list is supported we
  throw, where C2J warns and emits no call — silently dropping compression changes wire behavior with
  no signal. Also rejects a `@streaming` `@requiresLength` payload, which Smithy forbids here and C2J
  rejects too, because the compressed length isn't known until the whole stream has been read.
- `@httpChecksumRequired` → `ChecksumUtils.SetChecksumData(request);` **after** body serialization
  (the checksum covers the body), before the `@unsignedPayload` `DisablePayloadSigning` line. This is
  the legacy MD5-only trait. C2J's `Operation.HttpChecksumRequired` returns true for the flexible
  `aws.protocols#httpChecksum` too, which we deliberately don't copy — that trait stays denied in
  `UnsupportedTraitValidator`, so reading only the legacy one keeps flexible-checksum operations off
  the MD5 path.

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
  leaf is a plain `int`/`IntUnmarshaller`; a non-streaming blob leaf is `MemoryStream`/`MemoryStreamUnmarshaller`.
  Only `@streaming` blob leaves fail loud in `TypeMapper`.

### `@httpPayload` (response)

A `@httpPayload` output member IS the whole body (replaces the named-field loop; other members are header-bound), into `unmarshalledObject`:

- **String** → `using (var sr = new StreamReader(context.Stream)) { unmarshalledObject.Body = sr.ReadToEnd(); }`
- **Structure** → reader + `if (reader.Reader.IsFinalBlock) return unmarshalledObject;` + `{Type}Unmarshaller.Instance.Unmarshall(context, ref reader)`.
- **Document** → same reader scaffold as structure but the runtime `Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance` (the unmarshaller every other document position uses). Smithy has a distinct `DocumentShape` (`type: "document"`); C2J instead represents a document as a `type: "structure"` carrying `document: true`, so C2J's `IsStructure` is true for it and its response template takes the `unmarshallPayload` branch — we match that output on the Smithy side via the explicit `IsDocument` case (bedrock-agentcore `GetAgentCardResponse`). The request side has a matching document-payload form (see the request `@httpPayload` section above).
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

### Event streams (response)

An output member targeting a `@streaming` union/structure is an event stream (`TypeDescriptor.IsEventStream`).
`PartitionByBinding` pulls it out (`EventStreamMember`) and it IS the body: the unmarshaller emits
`unmarshalledObject.{Prop} = new {UnionClass}(context.Stream);` instead of a JSON reader loop, matching C2J's
`JsonRPCResponseUnmarshaller`, and the unmarshaller class overrides `HasStreamingProperty => true` and
`ShouldReadEntireResponse(...) => false` so Core never buffers the body. The `{UnionClass}` itself, and
everything else event streams emit, is in `sdk-conventions` → Event Streams.

Each non-error union member targets an **event structure** that gets its own `{Event}Unmarshaller`
(`JsonStructureUnmarshallerWriter`, invoked per event from the event-stream class's `EventMapping`). The
writer classifies each member by binding, **symmetric with `JsonStructureMarshallerWriter`** — a member
carries at most one of `@eventPayload`/`@eventHeader` (`Member.IsEventPayload`/`IsEventHeader` from
`smithy.api#eventPayload`/`eventHeader`), the three partitions are disjoint and independent:

- **`@eventPayload`** (≤1 per event) → the raw message payload, no JSON body loop for it. Blob →
  `unmarshalledObject.{Prop} = context.Stream as MemoryStream;`; string →
  `using (var sr = new StreamReader(context.Stream)) { unmarshalledObject.{Prop} = sr.ReadToEnd(); }`;
  structure → `unmarshalledObject.{Prop} = {Type}Unmarshaller.Instance.Unmarshall(context, ref reader);`
  (C2J's template has no structure-payload branch — no shipping service uses one — but the SEP allows it).
  The SEP requires all other members to carry `@eventHeader` when a payload member exists, so there are no
  unbound body members in that case.
- **`@eventHeader`** → read from the event-message header via `context.ResponseData`, guarded by
  `IsEventHeaderPresent("{ModeledName}")` (the wire header key is the member name verbatim). The accessor on
  `GetEventStreamHeader("{ModeledName}")` is chosen by **target shape**, mirroring the marshaller's setter
  switch: string/enum → `AsString()`, boolean → `AsBool()`, integer/intEnum → `AsInt32()`, long →
  `AsInt64()`, timestamp → `AsTimestamp()`, blob → `new MemoryStream(...AsByteBuf())`. Any other target
  (double/float/byte/short — no runtime accessor, no service uses one) fails loud.
- **unbound** → the JSON body, read through the ordinary reader loop.

An event can carry `@eventHeader` members **without** an `@eventPayload` member — a headers-only event (only
header reads, no reader loop) or an implicit-payload event (headers from headers, the remaining unbound
members from the JSON body). The absence of `@eventPayload` does *not* mean the absence of headers, so this
is **not** an all-or-nothing branch (C2J's `JsonRPCStructureUnmarshaller` gets this wrong; the Smithy
protocol tests `HeadersEvent`/`HeadersAndImplicitPayloadEvent` cover it). Pinned in
`EventStructureUnmarshallTests`.

The body loop is skipped **only** for events (explicit payload, or headers alone). An ordinary structure with no
members still runs it: the loop consumes the `{}` tokens so the reader lands after the object; without it the
parent's remaining members are misread. Pinned by `EmptyOrdinaryStructure_StillReadsJsonBody`.

Only `sagemakerruntimehttp2`'s `ResponsePayloadPart`/`RequestPayloadPart` use event headers today (blob
payload `Bytes` + string headers). The union itself gets no unmarshaller (the response unmarshaller does
`new {Union}(context.Stream)`); its event structures each get theirs, plus a plain model class.

### Event streams (request)

A request event stream (`context.RequestEventStreams`) adds a publisher marshaller on top of the marker
interface + per-event partials `EventStreamEventInterfaceWriter` already emits. The union gets no plain model
class or structure marshaller (excluded in `ServiceGenerator`'s structure loop and `ReferencedStructures`), but
its event members still get marshallers.

- `{Union}PublisherMarshaller` (`EventStreamPublisherMarshallerWriter`) — `NextEventAsync` pulls the consumer's
  next event, dispatches on `evnt is {Event}`, marshals it with `{Event}Marshaller.Instance`, and sets
  `eventType` to the union member name verbatim (the wire `:event-type`, not the shape name). The wire
  `:content-type` follows the event's `@eventPayload` member (`JsonStructureMarshallerWriter` writes headers to
  `context.Request.EventHeaders` and a blob/string payload to `context.Request.Content`): a blob payload →
  `application/octet-stream`, a string payload → `text/plain`, both read from `context.Request.Content`; a
  structure payload or an implicit body → `application/json` from the JSON writer's stream. (C2J emits `text/plain`
  for a structure payload too, but no service models one and the event marshaller writes it as JSON, so JSON is
  kept here.) CBOR is not handled — restJson1 only.
- The request member becomes a `Func<Task<I{Union}Event>> {Member}Publisher` property (`OperationWriter` +
  `MemberWriter`) — keeps any modeled `[AWSProperty]`/`[Obsolete]`, no `IsSet`. The request marshaller wires it:
  `request.EventStreamPublisher = new {Union}PublisherMarshaller(publicRequest.{Member}Publisher)` with
  `Content-Type: application/vnd.amazon.eventstream`, replacing body serialization.

Pinned in `EventStreamPublisherCodegenTests`.

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
| `List<string>` / `List<enum>` | `MultiValueHeaderParser.ToStringList(value)` |
| `List<value-type>` (int/long/bool/double/float) | `MultiValueHeaderParser.ToValueTypeList<T>(value)` (T = the non-nullable element type, e.g. `int`) |
| `List<DateTime>` | `MultiValueHeaderParser.ToDateTimeList(value, "FMT")` — `FMT` is the C2J format name (`RFC822`/`ISO8601`/`UnixTimestamp`; header default `RFC822`), **not** the Smithy token |

A `list<T>` header is a multi-value header parsed by `MultiValueHeaderParser` (`MultiValueHeaderConversion`,
handled before the scalar switch); a non-scalar element fails loud. `HttpBindingConversions.TimestampFormatName`
maps the Smithy `@timestampFormat` (`http-date`→`RFC822`, `date-time`→`ISO8601`, `epoch-seconds`→`UnixTimestamp`)
to the enum name the runtime parser expects (the caller resolves the `http-date` header default first). `MultiValueHeaderParser` lives in `Amazon.Runtime.Internal.Util`,
already imported. Pinned in `ListMemberCodegenTests`.

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

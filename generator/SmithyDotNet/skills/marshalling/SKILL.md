---
name: marshalling
description: What the SmithyDotNet generator must emit for request marshallers and response/error unmarshallers, per Smithy binding trait and protocol. Use when writing or reviewing any marshaller/unmarshaller writer.
---
# Skill: Marshalling

This skill states the emitted output. Where a rule exists only for parity with the legacy C2J
generator, it says so; everything else follows from the Smithy spec.

## File Layout

Under `Generated/Model/Internal/MarshallTransformations/`, all `partial`:

| File | Class | Notes |
|---|---|---|
| `{Operation}RequestMarshaller.cs` | `IMarshaller<IRequest, {Operation}Request>` | |
| `{Operation}ResponseUnmarshaller.cs` | `JsonResponseUnmarshaller` (or protocol equivalent) | Dispatches errors |
| `{Shape}Marshaller.cs` | `IRequestMarshaller<{Shape}, JsonMarshallerContext>` | Nested structures in the request path |
| `{Shape}Unmarshaller.cs` | `IJsonUnmarshaller<{Shape}, JsonUnmarshallerContext>` | Nested structures in the response path |
| `{Exception}Unmarshaller.cs` | `IJsonErrorResponseUnmarshaller<{Exception}, JsonUnmarshallerContext>` | |

Structure marshallers expose `public readonly static {Shape}Marshaller Instance = new {Shape}Marshaller();`.
Operation marshallers/unmarshallers expose a `private static` instance behind a public `Instance` property.

## Request Marshaller Scaffolding

Every request marshaller emits, in this order:

1. `new DefaultRequest(publicRequest, "Amazon.{ServiceName}")`, then `@requestCompression` (below).
2. `Content-Type` (protocol-dependent), omitted for GET/DELETE and for operations with no body.
3. `HeaderKeys.XAmzApiVersion` (the service shape's version) and `HttpMethod`.
4. `@httpQuery` members, then `@httpQueryParams`; `@httpPrefixHeaders`, then `@httpHeader` members.
5. `@httpLabel` members as `AddPathResource` calls, then `request.ResourcePath` set to the `@http` uri
   template (labels left as `{name}` for the runtime to substitute).
6. The body (below), `@httpChecksumRequired`, `@unsignedPayload`, `UseQueryString`, `@endpoint` host
   prefix, `return request`.

An operation that requires HTTP/2 pins `request.HttpProtocolVersion = System.Net.HttpVersion.Version20`
(under `#if NET8_0_OR_GREATER`) right after the `DefaultRequest`. Which operations require it comes from
the protocol trait's version lists, where `eventStreamHttp` defaults to `http` when absent or empty:

| `http` | `eventStreamHttp` | Operations pinned to h2 |
|---|---|---|
| no `h2` | any | none |
| `h2` without `http/1.1` | any | all |
| `h2` and `http/1.1` | without `http/1.1` | those with an output event stream |
| `h2` and `http/1.1` | with `http/1.1` | those with both an input and an output event stream |

## Member Placement

| Smithy trait | Where | SDK pattern |
|---|---|---|
| `@httpQuery("name")` scalar | Query string | `request.Parameters.Add("name", StringUtils.FromString(...))` |
| `@httpQuery("name")` `list<string>` | Query string | `request.ParameterCollection.Add("name", publicRequest.Prop)` (repeated params, ordinal-sorted at runtime) |
| `@httpQuery("name")` `list<value-type>` | Query string | `request.ParameterCollection.Add("name", publicRequest.Prop.ConvertAll<string>(item => StringUtils.FromX(item)))` |
| `@httpQueryParams` map | Query string | Loop entries into query params (see below); `@httpQuery` wins on key collision |
| `@httpLabel` | URI segment | `if (!publicRequest.IsSetProp()) throw new Amazon{BaseName}Exception(...)`, then `request.AddPathResource("{name}", <conversion>)`. A greedy label keeps `{name+}` as the key and passes the value through `.TrimStart('/')` |
| `@httpHeader("name")` scalar | Header | `request.Headers["name"] = ...` |
| `@httpHeader("name")` `@mediaType` string | Header | Base64: `Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(...))`; the read side decodes (C2J "jsonvalue"). Body-bound `@mediaType` strings are plain |
| `@httpHeader("name")` `list<string>` | Header | `request.Headers["name"] = StringUtils.FromList(publicRequest.Prop)` (comma join, RFC-7230 quoting) |
| `@httpHeader("name")` `list<value-type>` | Header | `request.Headers["name"] = StringUtils.FromValueTypeList(publicRequest.Prop)` (the `List<T>` overload lowercases bool and forces `DateTime` to RFC822, so no per-element or per-format branch is emitted) |
| `@httpPrefixHeaders("prefix")` map | Multiple headers | Loop `map<string,string>`, emit `{prefix}{key}` headers (see below); request & response |
| `@httpPayload` | Entire body | Direct stream/string (skips body serialization) |
| `@hostLabel` | Endpoint host prefix | `request.HostPrefix` label **in addition to** the member's normal binding (see below) |
| `@httpResponseCode` | (response only) | `unmarshalledObject.{Prop} = (int)context.ResponseData.StatusCode;` (see below) |
| No HTTP trait | Body | Protocol-specific serialization |

Every query/header/label member is `IsSet`-guarded. A `@required` query member (an idempotency token
excepted) first throws `Amazon{BaseName}Exception("Request object does not have required field {Prop} set")`
when unset: `string.IsNullOrEmpty` for a string/enum, `== null` for anything else. Body members get no
required check.

List query/header bindings accept `list<string>`/`list<enum>` (an enum element is a plain `string`, see
type-mapping) and value-type element lists (int, long, bool, double, float, timestamp, intEnum), matching
C2J. A **non-scalar** element (blob, structure, nested list/map) fails loud in both positions, as does a
`@sparse` value-type list (a sparse string/enum list is accepted). A header `list<timestamp>` is only
supported with the default/`http-date` format (the runtime helper always emits RFC822).

A single member may carry `@httpQueryParams`: a `map<string, string>` or `map<string, list<string>>`
whose entries each become query params under the `@httpQuery` rules (a `list<string>` value repeats the
key via `request.ParameterCollection`; a `map<string, string>` adds `StringUtils.FromString(kvp.Value)`
via `request.Parameters`). It's emitted **after** the explicit `@httpQuery` members, each entry guarded
by a `ContainsKey` check that skips keys already set, so an explicit `@httpQuery` wins the collision per
the Smithy precedence rule. The guard intentionally does NOT cover query literals in the `@http` uri
(those live in `request.SubResources`), matching C2J so migration doesn't change wire behavior. The map
is request-only and never enters the body; its presence sets `request.UseQueryString = true`.

A single member may carry `@httpPrefixHeaders`: a `map<string, string>` whose entries each become a
header `{prefix}{key}` (an `IsSet` guard, then a `foreach` assigning
`request.Headers[$"{prefix}{kvp.Key}"] = kvp.Value;`). It's emitted **before** the explicit `@httpHeader`
members, so a colliding name (only possible with an empty prefix) is overwritten by the later
`@httpHeader` assignment, per the Smithy precedence rule. Valid on request, response **and error**
structures. The map value must be a string (anything else fails loud).

## Wire Name Resolution

`@jsonName` if present, else the Smithy member name verbatim. awsJson1.x ignores `@jsonName` (see below).

## Request Body Serialization

### JSON (restJson1, awsJson1.x)

When any member is body-bound, or the `@httpPayload` is a structure or document, the marshaller writes
a `Utf8JsonWriter` body over a `PooledContentStream` (`#if NETFRAMEWORK`: a `MemoryStream` copied to
`request.Content`). Each body member is `IsSet`-guarded, then written per Type → Marshal/Unmarshal under
its wire name.

- Structures dispatch to `{Shape}Marshaller.Instance`; lists/maps loop and recurse to any depth. Map keys
  are always strings.
- Collection leaves: string, value-type scalar, structure, document, or non-streaming blob. Non-sparse
  value-type leaves are non-nullable (see type-mapping), so they write bare: no `.Value` unwrap and no
  float/double NaN guard (both are member-only). `@timestampFormat` is honored on leaves.
- `@sparse` leaves are nullable and JSON nulls are written, matching C2J. A sparse list null-guards its
  value-type and blob elements (a null string/structure/document already serializes as null); a sparse
  map null-guards every value kind.
- Float/double **members** branch through `StringUtils.IsSpecial{Float,Double}Value` so NaN/±Infinity
  serialize as strings.

Structure marshallers loop the structure's own members with the same rules. A request event-stream
**event** is the one exception: the publisher marshaller calls `{Event}Marshaller` with the JSON object
already open, then reads `context.Request.EventHeaders` and `context.Request.Content`. Event members
route by trait:

- `@eventHeader` → `IsSet`-guarded `EventStreamHeader("{memberName}")` (never `@jsonName`) with the typed
  setter for the target shape (`SetString` string/enum, `SetBool`/`SetInt32`/`SetInt64`/`SetTimestamp`
  with `.Value`, `SetByteBuf(….ToArray())` blob), added to `EventHeaders`. Any other target fails loud.
- `@eventPayload` → `IsSet`-guarded: blob `Request.Content = ….ToArray()`, string/enum
  `Encoding.UTF8.GetBytes(…)` (publisher sends octet-stream / text/plain, C2J parity); structure/union
  `{Type}Marshaller.Instance.Marshall(…, context)` into the open object (the protocol tests expect the bare
  structure as the payload, not one wrapped under the member name). List/map fail loud.
- Everything else is an ordinary body member (the implicit payload).

### `@httpPayload` (request)

A `@httpPayload` member IS the entire body: no wrapping object/property name, no other member in the body
(Smithy: all others are header/query/label). No `IsSet` guard (matches C2J).

- **String** → `text/plain` (or the target's `@mediaType` value when present), no writer scaffold: `request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.{Prop});`
- **Structure** (a union too) → `application/json`; the scaffold, then the target's marshaller as the body object (`WriteStartObject` → `{Type}Marshaller.Instance.Marshall(publicRequest.{Prop}, context)` → `WriteEndObject`).
- **Document** → `application/json`; the scaffold, then `Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(writer, publicRequest.{Prop});` with NO `WriteStartObject`/`WriteEndObject` wrapping (the document is the whole JSON value). No C2J precedent.
- **Blob** (`MemoryStream`, or `Stream` when `@streaming`) → `application/octet-stream` (or the target's `@mediaType` value; overrides the top `application/json`). Always assigns `request.ContentStream = publicRequest.{Prop} ?? new MemoryStream();` first and ends with the Content-Type override, except when the input also has an `@httpHeader("Content-Type")` member: that header is emitted before the blob block and must win, so the blob's type moves to the top `Content-Type` line and the trailing override is dropped (restJson1 `TestPayloadBlob`). The Content-Length handling in between branches on the operation's `aws.auth#unsignedPayload` and the blob's `@requiresLength` (C2J parity):
  - **`@streaming` + `@unsignedPayload`, no `@requiresLength`** → seek to start and set Content-Length when the stream is seekable, else `Transfer-Encoding: chunked`.
  - **`@streaming` + `@requiresLength`** → the stream MUST be seekable (throws `InvalidOperationException` otherwise), then always sets Content-Length. `@requiresLength` wins over the unsigned chunked path.
  - **otherwise** → seek when seekable, always set Content-Length (no chunked).

  Separately, `aws.auth#unsignedPayload` on the operation emits `request.DisablePayloadSigning = true;` after the body block, for **any** body kind.

List and map payloads fail loud.

### `@requestCompression` and `@httpChecksumRequired` (request)

Both are one emitted call to a runtime helper in `Amazon.Runtime.Internal.Util`, at opposite ends of the body.

- `@requestCompression` → `CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.{encoding});`
  right after `new DefaultRequest(...)`. `encodings` is a preference list: the first **supported** entry
  wins and unsupported ones are skipped (`["br", "gzip"]` emits gzip); `gzip` is the whole supported set
  (`CompressionEncodingAlgorithm` has only `NONE` and `gzip`). When nothing in the list is supported we
  throw, where C2J warns and emits no call: silently dropping compression changes wire behavior with no
  signal. A `@streaming` `@requiresLength` payload is rejected (Smithy forbids it; the compressed length
  isn't known until the stream has been read).
- `@httpChecksumRequired` → `ChecksumUtils.SetChecksumData(request);` **after** body serialization (the
  checksum covers the body), before the `DisablePayloadSigning` line. This is the legacy MD5-only trait.
  C2J also treats the flexible `aws.protocols#httpChecksum` as MD5-required; we deliberately don't (that
  trait is rejected as unsupported), so flexible-checksum operations stay off the MD5 path.

### `@endpoint` host prefix (request)

An operation's `@endpoint` trait sets `request.HostPrefix` (the resolver prepends it to the endpoint host). Emitted last, after `UseQueryString`, before `return`.

- **Static** (no labels) → `request.HostPrefix = $"data.";`
- **Labeled** → each `@hostLabel` member is captured into an anonymous `hostPrefixLabels` object (field = modeled member name, value = `StringUtils.FromString(publicRequest.{Prop})`), validated with `HostPrefixUtils.IsValidLabelValue` (throws `Amazon{Service}Exception` naming the label and the 1–63 alphanumeric/dash rule), then interpolated into the prefix (`{name}` → `{hostPrefixLabels.name}`).

## Response Unmarshaller Body

The body loop is `while (context.ReadAtDepth(targetDepth, ref reader))` with a
`context.TestExpression("{wireName}", targetDepth, ref reader)` guard per member assigning
`unmarshalledObject.{Prop} = {Unmarshaller}.Instance.Unmarshall(context, ref reader)` then `continue`.
A response whose members are all headers (or empty) emits no reader loop at all.

- Lists: `new JsonListUnmarshaller<T, TUnmarshaller>(TUnmarshaller.Instance)`
- Maps: `new JsonDictionaryUnmarshaller<string, V, StringUnmarshaller, VU>(StringUnmarshaller.Instance, VU.Instance)`
  (key is always `string`/`StringUnmarshaller`).
- Scalars per Type → Marshal/Unmarshal. Body timestamps are read format-agnostically, so epoch and
  date-time collections unmarshal identically.
- Nested collections compose recursively: a map-of-list is
  `JsonDictionaryUnmarshaller<string, List<T>, StringUnmarshaller, JsonListUnmarshaller<T, TU>>(...)`. An
  enum leaf (and an enum key) is `string`/`StringUnmarshaller`, never a ConstantClass generic argument; a
  non-streaming blob leaf is `MemoryStream`/`MemoryStreamUnmarshaller`.

### `@httpPayload` (response)

A `@httpPayload` output member IS the whole body (replaces the named-field loop; other members are header-bound), into `unmarshalledObject`:

- **String** → `using (var sr = new StreamReader(context.Stream)) { unmarshalledObject.Body = sr.ReadToEnd(); }`
- **Structure** → reader + `if (reader.Reader.IsFinalBlock) return unmarshalledObject;` + `{Type}Unmarshaller.Instance.Unmarshall(context, ref reader)`.
- **Document** → the structure scaffold with `Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance`. C2J models a document as a structure flagged `document: true`, so its output takes the structure-payload branch; we emit the same (bedrock-agentcore `GetAgentCardResponse`).
- **Blob** (non-streaming, `MemoryStream`) → `Amazon.Util.AWSSDKUtils.CopyStream(context.Stream, ms)` into a new `MemoryStream`; assigned only when `ms.Length > 0`, so an empty body leaves the property null (matches C2J).
- **Streaming blob** (`@streaming`, `Stream`) → assigns the raw `context.Stream` unbuffered and the unmarshaller class overrides `public override bool HasStreamingProperty => true` (matches C2J, see Polly `SynthesizeSpeech`).

`@httpHeader` members read from `context.ResponseData` after. An `@httpPayload` **error** member fails
loud: C2J never bound an error body to a payload, and emitting a never-populated property would be worse.

### `@httpResponseCode` (response)

An `@httpResponseCode` output member (an integer) is populated from the HTTP status code itself,
`unmarshalledObject.{Prop} = (int)context.ResponseData.StatusCode;`, **not** read from the body or a
header. Matches C2J. On an error the trait "is simply ignored" (Smithy spec) and the member falls through
to the body like any ordinary member.

### Event streams (response)

An output member targeting a `@streaming` union/structure is an event stream. It IS the body: the
unmarshaller emits `unmarshalledObject.{Prop} = new {UnionClass}(context.Stream);` instead of a JSON
reader loop (C2J parity), and the class overrides `HasStreamingProperty => true` and
`ShouldReadEntireResponse(...) => false` so Core never buffers the body. The `{UnionClass}` itself, and
everything else event streams emit, is in sdk-conventions → Event Streams.

Each non-error union member targets an **event structure** that gets its own `{Event}Unmarshaller`,
invoked per event from the event-stream class's `EventMapping`. A member carries at most one of
`@eventPayload`/`@eventHeader`:

- **`@eventPayload`** (≤1 per event) → the raw message payload, no JSON body loop for it. Blob →
  `unmarshalledObject.{Prop} = context.Stream as MemoryStream;`; string →
  `using (var sr = new StreamReader(context.Stream)) { unmarshalledObject.{Prop} = sr.ReadToEnd(); }`; structure →
  `unmarshalledObject.{Prop} = {Type}Unmarshaller.Instance.Unmarshall(context, ref reader);`. The SEP
  requires all other members to carry `@eventHeader` when a payload member exists.
- **`@eventHeader`** → read from the event-message header via `context.ResponseData`, guarded by
  `IsEventHeaderPresent("{ModeledName}")` (the wire header key is the member name verbatim). The accessor on
  `GetEventStreamHeader("{ModeledName}")` follows the target shape: string/enum → `AsString()`, boolean →
  `AsBool()`, integer/intEnum → `AsInt32()`, long → `AsInt64()`, timestamp → `AsTimestamp()`, blob →
  `new MemoryStream(...AsByteBuf())`. Any other target fails loud.
- **unbound** → the JSON body, read through the ordinary reader loop.

An event can carry `@eventHeader` members **without** an `@eventPayload` member: a headers-only event (only
header reads, no reader loop) or an implicit-payload event (headers from headers, the rest from the JSON
body). This is **not** an all-or-nothing branch (C2J gets this wrong; the Smithy protocol tests
`HeadersEvent`/`HeadersAndImplicitPayloadEvent` cover it). The reader loop is skipped **only** for events
with an explicit payload or headers alone; an ordinary structure with no members still runs it, so the
`{}` tokens are consumed and the parent's remaining members are not misread.

### Event streams (request)

A request event stream adds a publisher marshaller on top of the marker interface and per-event partials
described in sdk-conventions. The union gets no plain model class or structure marshaller, but its event
members still get marshallers.

- `{Union}PublisherMarshaller`: `NextEventAsync` pulls the consumer's next event, dispatches on
  `evnt is {Event}`, marshals it with `{Event}Marshaller.Instance`, and sets `eventType` to the union
  member name verbatim (the wire `:event-type`, not the shape name). The wire `:content-type` follows the
  event's `@eventPayload` member: a blob payload → `application/octet-stream`, a string payload →
  `text/plain`, both read from `context.Request.Content`; a structure payload or an implicit body →
  `application/json` from the JSON writer's stream. (C2J emits `text/plain` for a structure payload too,
  but the event marshaller writes it as JSON, so JSON is kept here.) CBOR is not handled: restJson1 only.
- The request member becomes a `Func<Task<I{Union}Event>> {Member}Publisher` property (keeps any modeled
  `[AWSProperty]`/`[Obsolete]`, no `IsSet`). The request marshaller wires it:
  `request.EventStreamPublisher = new {Union}PublisherMarshaller(publicRequest.{Member}Publisher)` with
  `Content-Type: application/vnd.amazon.eventstream`, replacing body serialization.

## Response Header Unmarshalling

Output and error members bound with `@httpHeader` are read from the HTTP response headers via
`context.ResponseData`, **not** the body reader; they're extracted after the reader loop, into
`unmarshalledObject` on both the response and the exception path.

Each member is guarded by `context.ResponseData.IsHeaderPresent("x-foo")` and assigned a `<conversion>`:

| Member target | `<conversion>` (with `value` = `context.ResponseData.GetHeaderValue("x-foo")`) |
|---|---|
| string / enum | `value` (direct; enum rides the string path via implicit ConstantClass conversion) |
| boolean | `bool.Parse(value)` (no culture: its two literals are culture-invariant) |
| integer / intEnum | `int.Parse(value, CultureInfo.InvariantCulture)` |
| long | `long.Parse(value, CultureInfo.InvariantCulture)` |
| float | `float.Parse(value, CultureInfo.InvariantCulture)` |
| double | `double.Parse(value, CultureInfo.InvariantCulture)` |
| timestamp, date-time / http-date | `DateTime.Parse(value, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal \| DateTimeStyles.AdjustToUniversal)` |
| timestamp, epoch-seconds | `Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(value, CultureInfo.InvariantCulture))` |
| `list<string>` / `list<enum>` | `MultiValueHeaderParser.ToStringList(value)` |
| `list<value-type>` (int/long/bool/double/float) | `MultiValueHeaderParser.ToValueTypeList<T>(value)` (T = the non-nullable element type, e.g. `int`) |
| `list<timestamp>` | `MultiValueHeaderParser.ToDateTimeList(value, "FMT")`, where `FMT` is the runtime's format name (`RFC822`/`ISO8601`/`UnixTimestamp`, header default `RFC822`), **not** the Smithy token |

A non-scalar list element fails loud, as does a `@sparse` value-type element.
`MultiValueHeaderParser` lives in `Amazon.Runtime.Internal.Util`; `CultureInfo`/`DateTimeStyles` come from
`System.Globalization`. Both namespaces are imported unconditionally.

### `@httpPrefixHeaders` (response / error)

A `map<string, string>` member bound with `@httpPrefixHeaders` collects every response header whose name
starts with the prefix into a local dictionary named `headersFor{Property}` (matching C2J), stripping the
prefix from each key. An empty prefix collects all headers. Assigned only when non-empty (matches C2J).
Same output on the response and exception unmarshallers.

## Type → Marshal/Unmarshal

| Smithy target | .NET | JSON Marshal | JSON Unmarshal |
|---|---|---|---|
| string / enum | `string` / ConstantClass | `WriteStringValue` | `StringUnmarshaller` |
| integer / intEnum | `int?` | `WriteNumberValue` | `IntUnmarshaller` |
| long | `long?` | `WriteNumberValue` | `LongUnmarshaller` |
| boolean | `bool?` | `WriteBooleanValue` | `BoolUnmarshaller` |
| float | `float?` | `WriteNumberValue` (NaN/∞ as strings, members only) | `FloatUnmarshaller` |
| double | `double?` | `WriteNumberValue` (NaN/∞ as strings, members only) | `DoubleUnmarshaller` |
| timestamp | `DateTime?` | Format-dependent (see below) | `DateTimeUnmarshaller` |
| blob | `MemoryStream` | `StringUtils.WriteBase64StringValue(context.Writer, ...)` | `MemoryStreamUnmarshaller` |
| document | `Amazon.Runtime.Documents.Document` | `DocumentMarshaller.Instance.Write` | `DocumentUnmarshaller.Instance` |
| list | `List<T>` | Array loop | `JsonListUnmarshaller<ElementType, ElementUnmarshaller>` |
| map | `Dictionary<string,V>` | Object loop | `JsonDictionaryUnmarshaller<string, V, StringUnmarshaller, ValueUnmarshaller>` |
| structure / union | Generated class | `{Shape}Marshaller.Instance` | `{Shape}Unmarshaller.Instance` |

A value type that is nullable in its position (a member, or a `@sparse` element; see type-mapping →
Nullability Rules) unwraps with `.Value` before the write and takes the `Nullable*Unmarshaller`; a
non-sparse element writes bare and takes the plain unmarshaller.

### Timestamp Formats

An explicit `@timestampFormat` (on the member or its target) always wins. When unset, the default is
**per binding**, not one per protocol.

| `@timestampFormat` | Marshal (body) | Marshal (header/query/label) |
|---|---|---|
| `date-time` | `WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(value))` | `StringUtils.FromDateTimeToISO8601WithOptionalMs(value)` |
| `http-date` | `WriteStringValue(StringUtils.FromDateTimeToRFC822(value))` | `StringUtils.FromDateTimeToRFC822(value)` |
| `epoch-seconds` | `WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(value.Value))` | `StringUtils.FromDateTimeToUnixTimestamp(value)` |

restJson1 defaults when `@timestampFormat` is unset (matches C2J's output). They apply when marshalling
and when reading headers; body reads auto-detect the wire format.

| Binding | Default |
|---|---|
| Body / structure member | `epoch-seconds` (restJson1's document-timestamp default per the Smithy spec) |
| `@httpHeader` | `http-date` |
| `@httpQuery`, `@httpLabel` | `date-time` |

String forms pass the nullable `DateTime?` straight to the `StringUtils` overload; the epoch form
unwraps with `.Value`. `epoch-seconds` in a **body** is a JSON number that may carry a fraction, so it
goes through `ConvertToUnixEpochSecondsDecimal` (millisecond precision, `decimal` for identical digits on
every TFM), not the whole-second `StringUtils.FromDateTimeToUnixTimestamp`. Header/query/label positions
are whole seconds, matching C2J.

## Error Dispatch

In `{Operation}ResponseUnmarshaller.UnmarshallException`, each error is matched with
`errorResponse.Code != null && errorResponse.Code.Equals("{smithyShapeName}")` (the Smithy shape name,
not the .NET exception name) and dispatched to
`{Exception}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy)`.
Fallback: `new Amazon{Service}Exception(errorResponse.Message, ...)`.

### Exception Unmarshaller

`Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)`
constructs the exception from the six `errorResponse` fields (message, inner exception, type, code,
request id, status code). When the error has body-bound members beyond `message`, a single
`if (context.Stream.Length > 0)` wraps the first-token read and the body loop, so an empty error body
skips both. `@httpHeader` members are then read from `context.ResponseData` (see Response Header
Unmarshalling).

## awsJson1.0 / awsJson1.1

Same JSON body (un)marshalling as restJson1. Every operation is `POST /` with
`X-Amz-Target: {ServiceShapeName}.{OperationName}` (the service's shape name, not its sdkId) and
`Content-Type: application/x-amz-json-1.0|1.1`; an operation with no input members sends `{}`. HTTP binding
traits and `@jsonName` are ignored when a model carries them. Spec:
[protocol behaviors](https://smithy.io/2.0/aws/protocols/aws-json-1_1-protocol.html#protocol-behaviors).

1.0 and 1.1 differ only in the Content-Type version and the `__type` form of errors
([differences](https://smithy.io/2.0/aws/protocols/aws-json-1_0-protocol.html#differences-between-awsjson1-0-and-awsjson1-1));
Core handles the `__type` difference transparently, so the generator only varies the version string.

Every one of those decisions is gated on `GenerationContext.UsesHttpBindings`; `AwsJsonCodegenTests`
pins the emitted code and the JSONRPC10/JsonProtocol protocol tests verify it end to end.

## Other Protocols (not yet implemented)

restXml, awsQuery, ec2Query and rpcv2Cbor: the target output is defined by the C2J templates
(`generator/ServiceClientGeneratorLib/Generators/Marshallers/*.tt`). awsQuery/ec2Query route via an
`Action={Operation}` param with URL-encoded bodies; restXml keeps the HTTP binding traits with an XML
body (`@xmlName`/`@xmlFlattened`/`@xmlAttribute`/`@xmlNamespace`) and, per the Smithy spec, defaults
body timestamps to `date-time`. The XML-response family uses `XmlResponseUnmarshaller`. Wire names:
restXml `@xmlName`, awsQuery the member name verbatim, ec2Query `@ec2QueryName` or the member name with
its first letter upper-cased.

When implementing one, replace this note with the real patterns and pin the emitted code in codegen tests.

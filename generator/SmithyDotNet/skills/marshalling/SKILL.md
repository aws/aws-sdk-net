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

Every request marshaller sets up:

```csharp
IRequest request = new DefaultRequest(publicRequest, "Amazon.{ServiceName}");
request.Headers["Content-Type"] = "{content-type}";                    // protocol-dependent
request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "{version}";  // from ServiceShape.ApiVersion
request.HttpMethod = "{method}";                                        // from @http trait
request.ResourcePath = "{uri}";                                         // from @http trait, with labels interpolated
```

Then serializes members based on placement rules, then returns `request`.

## Member Placement

| Smithy trait | Where | SDK pattern |
|---|---|---|
| `@httpQuery("name")` scalar | Query string | `request.Parameters.Add("name", StringUtils.FromString(...))` |
| `@httpQuery("name")` `list<string>` | Query string | `request.ParameterCollection.Add("name", publicRequest.Prop)` (repeated params, ordinal-sorted at runtime) |
| `@httpLabel` | URI segment | Replace `{member}` in `request.ResourcePath` |
| `@httpHeader("name")` scalar | Header | `request.Headers["name"] = ...` |
| `@httpHeader("name")` `list<string>` | Header | `request.Headers["name"] = StringUtils.FromList(publicRequest.Prop)` (comma join, RFC-7230 quoting) |
| `@httpPrefixHeaders("prefix")` | Multiple headers | Loop dict, prefix each key |
| `@httpPayload` | Entire body | Direct stream/string (skips body serialization) |
| `@hostLabel` | Endpoint host prefix | Additive: `request.HostPrefix` label + its normal binding (see below) |
| `@httpResponseCode` | (response only) | `response.HttpStatusCode` |
| No HTTP trait | Body | Protocol-specific serialization |

List query/header bindings are `list<string>` only. `request.ParameterCollection`
(not the string-only `request.Parameters` facade) carries the `List<string>` query
overload. A list of any non-string element (enum, int, long, bool, double, timestamp)
fails loud during member resolution (`TypeMapper.RejectUnsupportedCollectionElement`);
no restJson1 service emits one today. Enum lists are excluded on purpose: C2J
surfaces them as `List<string>`, but this generator would type them as
`List<ConstantClass>`. That public API decision is tracked in a follow-up task.

For `awsJson1.x` and `query`/`ec2Query`: all members go in the body (no HTTP binding traits).

## Wire Name Resolution

| Protocol | Rule |
|---|---|
| restJson1 / awsJson1.x | `@jsonName` if present, else Smithy member name (camelCase) |
| restXml | `@xmlName` if present, else Smithy member name (camelCase) |
| query / ec2Query | `@ec2QueryName` or PascalCase of member name |

## Request Body Serialization

### JSON (restJson1, awsJson1.x)

For request marshallers if any of the members are marshalled in the body OR marked with @httpPayload you must setup the PooledContentStream like so:
```csharp
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
```

```csharp
if (publicRequest.IsSetFoo())
{
    context.Writer.WritePropertyName("foo");  // wire name
    context.Writer.WriteStringValue(publicRequest.Foo);
}
```

- Structures: `WriteStartObject` → `{Shape}Marshaller.Instance.Marshall(item, context)` → `WriteEndObject`
- Lists: `WriteStartArray` → loop items → `WriteEndArray`
- Maps: not implemented yet — throws in the writer at any nesting depth. Intended pattern:
  `WriteStartObject` → loop `WritePropertyName(key)` + write value → `WriteEndObject`
- Required strings: throw `Amazon{ServiceName}Exception` if null/empty before serialization


At the end of the request marshaller after flushing the writer write:
```csharp
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
```

For structure marshallers loop through the structures members and use the rules laid out in Type → Marshal/Unmarshal

### `@httpPayload` (request)

A `@httpPayload` member IS the entire body — no wrapping object/property name, no other member in the body (Smithy: all others are header/query/label). No `IsSet` guard (matches C2J).

- **String** → `text/plain`, no scaffold: `request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.{Prop});`
- **Structure** → `application/json`; the scaffold above, then the target's marshaller as the body object:
  ```csharp
  context.Writer.WriteStartObject();
  var marshaller = {Type}Marshaller.Instance;
  marshaller.Marshall(publicRequest.{Prop}, context);
  context.Writer.WriteEndObject();
  ```
- **Blob** (`MemoryStream`) → `application/octet-stream` (overrides the top `application/json`); adds `using System.Globalization;`:
  ```csharp
  request.ContentStream = publicRequest.{Prop} ?? new MemoryStream();
  if (request.ContentStream.CanSeek) { request.ContentStream.Seek(0, SeekOrigin.Begin); }
  request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
  request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
  ```

list/map payloads fail loud in the writer; document/union throw in `TypeMapper`.

### `@endpoint` host prefix (request)

An operation's `@endpoint` trait sets `request.HostPrefix` (the resolver's `InjectHostPrefix` prepends it to the endpoint host). Emitted last, after `UseQueryString`, before `return`.

- **Static** (no labels) → `request.HostPrefix = $"data.";`
- **Labeled** → each `@hostLabel` member is captured, validated, and interpolated (`{name}` → `{hostPrefixLabels.name}`):
  ```csharp
  var hostPrefixLabels = new
  {
      name = StringUtils.FromString(publicRequest.Name),   // field = modeled name, value = property name
  };
  if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.name))
  {
      throw new Amazon{Service}Exception("name can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");
  }
  request.HostPrefix = $"foo.{hostPrefixLabels.name}.";
  ```

`@hostLabel` is **additive** — the member is still marshalled in its normal binding (body/`@httpLabel`/`@httpQuery`/`@httpHeader`) as well.

### XML (restXml)

```csharp
xmlWriter.WriteStartElement("MemberName");  // or @xmlName
xmlWriter.WriteValue(publicRequest.Foo);
xmlWriter.WriteEndElement();
```

- `@xmlFlattened` lists omit the wrapper element
- `@xmlAttribute` members become XML attributes on the parent element
- `@xmlNamespace` adds `xmlns` attribute

### Query (query, ec2Query)

```csharp
request.Parameters.Add("MemberName", StringUtils.FromString(publicRequest.Foo));
```

- Lists: `MemberName.member.{N}` (query) or `MemberName.{N}` (ec2Query)
- Maps: `MemberName.entry.{N}.key` / `MemberName.entry.{N}.value`

## Response Unmarshaller Body

### JSON

```csharp
while (context.ReadAtDepth(targetDepth, ref reader))
{
    if (context.TestExpression("foo", targetDepth, ref reader))
    {
        response.Foo = StringUnmarshaller.Instance.Unmarshall(context, ref reader);
        continue;
    }
}
```

- Lists: `new JsonListUnmarshaller<T, TUnmarshaller>(TUnmarshaller.Instance)`
- Maps: not implemented yet — throws at any nesting depth. Intended pattern:
  `new JsonDictionaryUnmarshaller<K, V, KU, VU>(...)`

### `@httpPayload` (response)

A `@httpPayload` output member IS the whole body (replaces the named-field loop; other members are header-bound), into `unmarshalledObject`:

- **String** → `using (var sr = new StreamReader(context.Stream)) { unmarshalledObject.Body = sr.ReadToEnd(); }`
- **Structure** → reader + `if (reader.Reader.IsFinalBlock) return unmarshalledObject;` + `{Type}Unmarshaller.Instance.Unmarshall(context, ref reader)`.
- **Blob** (`MemoryStream`) → `Amazon.Util.AWSSDKUtils.CopyStream(context.Stream, ms)` into a new `MemoryStream`; assigned only when `ms.Length > 0`, so an empty body leaves the property null (matches C2J).

`@httpHeader` members read from `context.ResponseData` after. **Errors don't get a payload path** — C2J never bound an error body to a payload and no service does, so `JsonExceptionUnmarshallerWriter` throws a `GeneratorException` on an `@httpPayload` error member (Smithy permits it; we fail loud rather than emit a never-populated property). Request/response `@httpPayload` stay allowed.

### XML

```csharp
while (context.Read())
{
    if (context.TestExpression("MemberName", targetDepth))
    {
        response.Foo = StringUnmarshaller.Instance.Unmarshall(context);
        continue;
    }
}
```

- Flattened lists: test on element name directly
- Non-flattened lists: test on `ListName/member`

## Response Header Unmarshalling

Output and error members bound with `@httpHeader` are read from the HTTP response headers via
`context.ResponseData`, **not** the body reader. Body members read from the JSON reader loop; header
members are extracted after it. A JSON response whose members are all headers (or empty) emits no
reader/`while` loop at all — just the header `if`s. The error (exception) unmarshaller populates
`unmarshalledObject` the same way; its dispatch passes `context.ResponseData` into `contextCopy`, so
the header API is available there too.

Each member is guarded and assigned:

```csharp
if (context.ResponseData.IsHeaderPresent("x-foo"))
{
    response.Foo = <conversion>;   // "unmarshalledObject.Foo" on the exception path
}
```

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
| `List<T>` | Array loop | `JsonListUnmarshaller<ElementType, ElementUnmarshaller>` |
| `Dictionary<K,V>` (not implemented) | Object loop | `JsonDictionaryUnmarshaller<K, V, KeyUnmarshaller, ValueUnmarshaller>` |
| Structure | `{Shape}Marshaller.Instance` | `{Shape}Unmarshaller.Instance` |

### Timestamp Formats

An explicit `@timestampFormat` (on the member or its target) always wins. When unset, the default is
**binding-specific**, not one per protocol — see the binding-default table below.

| `@timestampFormat` | Marshal (body) | Marshal (header/query/label) |
|---|---|---|
| `date-time` | `WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(value))` | `StringUtils.FromDateTimeToISO8601WithOptionalMs(value)` |
| `http-date` | `WriteStringValue(StringUtils.FromDateTimeToRFC822(value))` | `StringUtils.FromDateTimeToRFC822(value)` |
| `epoch-seconds` | `WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(value.Value)))` | `StringUtils.FromDateTimeToUnixTimestamp(value)` |

restJson1 binding defaults when `@timestampFormat` is unset (matches the C2J generator's output):

| Binding | Default |
|---|---|
| Body / structure member | `epoch-seconds` (restJson1's document-timestamp default per the Smithy spec; the generic `@timestampFormat` default of `date-time` applies only when a protocol sets none) |
| `@httpHeader` | `http-date` |
| `@httpQuery`, `@httpLabel` | `date-time` |

String forms pass the nullable `DateTime?` straight to the `StringUtils` overload; the epoch form
unwraps with `.Value`.

## Error Dispatch

In `{Operation}ResponseUnmarshaller.UnmarshallException`:

```csharp
if (errorResponse.Code != null && errorResponse.Code.Equals("{smithyShapeName}"))
    return {Exception}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
```

Error code = Smithy shape name (e.g. `"ChannelNotFound"`), not the .NET exception name.
Fallback: `new Amazon{Service}Exception(errorResponse.Message, ...)`.

### Exception Unmarshaller

```csharp
public {Exception} Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)
{
    if (context.Stream.Length > 0) context.Read(ref reader);
    var unmarshalledObject = new {Exception}(errorResponse.Message, errorResponse.InnerException,
        errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
    int targetDepth = context.CurrentDepth;
    if (context.Stream.Length > 0)
    {
        while (context.ReadAtDepth(targetDepth, ref reader))
        {
            // Additional body-bound exception members deserialized here (if any beyond "message")
        }
    }
    // @httpHeader members extracted from context.ResponseData here (see Response Header Unmarshalling)
    return unmarshalledObject;
}
```

## Protocol Differences

| Concern | restJson1 | awsJson1.x | restXml | query | ec2Query |
|---|---|---|---|---|---|
| Content-Type | `application/json` | `application/x-amz-json-1.{0,1}` | (none/xml) | `application/x-www-form-urlencoded` | `application/x-www-form-urlencoded` |
| Routing | HTTP method + path | `X-Amz-Target: {ServiceName}.{Operation}` | HTTP method + path | `Action={Operation}` param | `Action={Operation}` param |
| Member placement | HTTP traits | All body | HTTP traits | All body | All body |
| Body format | JSON | JSON | XML | URL-encoded | URL-encoded |
| Timestamp body default | `epoch-seconds` | `epoch-seconds` | `date-time` | `date-time` | `date-time` |
| Error code source | JSON `code` or `__type` | JSON `code` or `__type` | XML `<Code>` | XML `<Code>` | XML `<Code>` |
| Error wrapping | None | None | `<ErrorResponse><Error>` | `<ErrorResponse><Error>` | `<Response><Errors><Error>` |
| Response unmarshaller base | `JsonResponseUnmarshaller` | `JsonResponseUnmarshaller` | `XmlResponseUnmarshaller` | `XmlResponseUnmarshaller` | `XmlResponseUnmarshaller` |
| Request uses `UseQueryString` | Yes (for `@httpQuery`) | No | Yes (for `@httpQuery`) | No | No |

## Adding a New Protocol

When implementing the next protocol, update this skill with:
1. Any new marshal/unmarshal patterns not covered above
2. Protocol-specific base classes or interfaces
3. Edge cases discovered during implementation

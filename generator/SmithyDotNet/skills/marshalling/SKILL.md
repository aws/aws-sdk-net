---
name: marshalling
description: Maps Smithy protocol traits to generated SDK marshaller/unmarshaller code patterns
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
| `@httpQuery("name")` | Query string | `request.Parameters.Add("name", StringUtils.FromString(...))` |
| `@httpLabel` | URI segment | Replace `{member}` in `request.ResourcePath` |
| `@httpHeader("name")` | Header | `request.Headers["name"] = ...` |
| `@httpPrefixHeaders("prefix")` | Multiple headers | Loop dict, prefix each key |
| `@httpPayload` | Entire body | Direct stream/string (skips body serialization) |
| `@httpResponseCode` | (response only) | `response.HttpStatusCode` |
| No HTTP trait | Body | Protocol-specific serialization |

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
- Maps: `WriteStartObject` → loop `WritePropertyName(key)` + write value → `WriteEndObject`
- Required strings: throw `Amazon{ServiceName}Exception` if null/empty before serialization


At the end of the request marshaller after flushing the writer write:
```csharp
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
```

For structure marshallers loop through the structures members and use the rules laid out in Type → Marshal/Unmarshal

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
- Maps: `new JsonDictionaryUnmarshaller<K, V, KU, VU>(...)`

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
| `Dictionary<K,V>` | Object loop | `JsonDictionaryUnmarshaller<K, V, KeyUnmarshaller, ValueUnmarshaller>` |
| Structure | `{Shape}Marshaller.Instance` | `{Shape}Unmarshaller.Instance` |

### Timestamp Formats

| Smithy `@timestampFormat` | Protocol default | Marshal |
|---|---|---|
| `date-time` | restJson1, restXml | `StringUtils.FromDateTimeToISO8601WithOptionalMs(value)` |
| `http-date` | (headers) | `StringUtils.FromDateTimeToRFC822(value)` |
| `epoch-seconds` | awsJson1.x | `Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(value.Value))` (as number) |
| unset | Uses protocol default | — |

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
            // Additional exception members deserialized here (if any beyond "message")
        }
    }
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
| Timestamp default | `date-time` | `epoch-seconds` | `date-time` | `date-time` | `date-time` |
| Error code source | JSON `code` or `__type` | JSON `code` or `__type` | XML `<Code>` | XML `<Code>` | XML `<Code>` |
| Error wrapping | None | None | `<ErrorResponse><Error>` | `<ErrorResponse><Error>` | `<Response><Errors><Error>` |
| Response unmarshaller base | `JsonResponseUnmarshaller` | `JsonResponseUnmarshaller` | `XmlResponseUnmarshaller` | `XmlResponseUnmarshaller` | `XmlResponseUnmarshaller` |
| Request uses `UseQueryString` | Yes (for `@httpQuery`) | No | Yes (for `@httpQuery`) | No | No |

## Adding a New Protocol

When implementing the next protocol, update this skill with:
1. Any new marshal/unmarshal patterns not covered above
2. Protocol-specific base classes or interfaces
3. Edge cases discovered during implementation

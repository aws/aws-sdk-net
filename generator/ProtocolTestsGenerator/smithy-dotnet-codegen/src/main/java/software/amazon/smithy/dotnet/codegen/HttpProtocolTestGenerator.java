/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

package software.amazon.smithy.dotnet.codegen;

import software.amazon.smithy.aws.traits.ServiceTrait;
import software.amazon.smithy.codegen.core.Symbol;
import software.amazon.smithy.model.traits.SparseTrait;
import software.amazon.smithy.model.traits.TitleTrait;
import software.amazon.smithy.codegen.core.CodegenException;
import software.amazon.smithy.dotnet.codegen.utils.ProtocolTestUtils;
import software.amazon.smithy.model.Model;
import software.amazon.smithy.model.knowledge.EventStreamIndex;
import software.amazon.smithy.model.knowledge.EventStreamInfo;
import software.amazon.smithy.model.knowledge.OperationIndex;
import software.amazon.smithy.model.knowledge.TopDownIndex;
import software.amazon.smithy.model.node.*;
import software.amazon.smithy.model.shapes.*;
import software.amazon.smithy.model.traits.Trait;
import software.amazon.smithy.protocoltests.traits.*;
import software.amazon.smithy.protocoltests.traits.eventstream.Event;
import software.amazon.smithy.protocoltests.traits.eventstream.EventHeaderValue;
import software.amazon.smithy.protocoltests.traits.eventstream.EventStreamTestCase;
import software.amazon.smithy.protocoltests.traits.eventstream.EventStreamTestsTrait;
import software.amazon.smithy.protocoltests.traits.eventstream.EventType;
import software.amazon.smithy.utils.StringUtils;
import software.amazon.smithy.dotnet.codegen.customizations.*;

import java.time.OffsetDateTime;
import java.time.format.DateTimeParseException;
import java.util.*;
import java.util.logging.Logger;


public final class HttpProtocolTestGenerator implements Runnable {
    private static final Logger LOGGER = Logger.getLogger(HttpProtocolTestGenerator.class.getName());
    private final DotnetSettings settings;
    private final Model model;
    private final ServiceShape service;
    private CSharpWriter writer;
    private final DotnetGenerationContext context;
    private final String serviceName;
    private String marshallerType;
    private final String serviceNamespace;
    // Services whose request, response and error tests are generated to call the service client end-to-end
    // (await client.OperationAsync(request)) against a mocked HTTP layer.
    private static final Set<ShapeId> MOCKED_CLIENT_SERVICES = Set.of(
            ShapeId.from("aws.protocoltests.json10#JsonRpc10"),
            ShapeId.from("aws.protocoltests.restjson#RestJson"),
            ShapeId.from("aws.protocoltests.json#JsonProtocol"),
            ShapeId.from("aws.protocoltests.query#AwsQuery"),
            ShapeId.from("aws.protocoltests.ec2#AwsEc2"),
            ShapeId.from("aws.protocoltests.restxml#RestXml"),
            ShapeId.from("aws.protocoltests.restxml.xmlns#RestXmlWithNamespace")
    );
    private final boolean useMockedClient;
    private final List<String> tagsToSkip = List.of("defaults" , "skip-legacy-conversion");
    private static final ShapeId INITIAL_HTTP_REQUEST = ShapeId.from("smithy.test#InitialHttpRequest");
    private static final ShapeId INITIAL_HTTP_RESPONSE = ShapeId.from("smithy.test#InitialHttpResponse");

    public HttpProtocolTestGenerator(
            DotnetGenerationContext context
    ) {
        this.settings = context.settings();
        this.serviceName = context.settings().getService().getName();
        this.model = context.model();
        this.service = settings.getService(model);
        this.context = context;

        String serviceNamespace = null;
        if (service.getTrait(ServiceTrait.class).isPresent())
                serviceNamespace = service.getTrait(ServiceTrait.class).get().getSdkId();
        else if (service.getTrait(TitleTrait.class).isPresent())
            serviceNamespace = service.getTrait(TitleTrait.class).get().getValue().replace("Service", "");

        this.serviceNamespace = serviceNamespace.replace(" ", "");
        this.useMockedClient = MOCKED_CLIENT_SERVICES.contains(service.getId());
    }

    @Override
    public void run() {
        TopDownIndex topDownIndex = TopDownIndex.of(model);
        OperationIndex operationIndex = OperationIndex.of(model);
        for (OperationShape operation : new TreeSet<>(topDownIndex.getContainedOperations(service))) {
            var operationName = operation.getId().getName();
            if (ProtocolTestCustomizations.OperationsToSkip.contains(operationName))
                continue;
            context.writerDelegator().useFileWriter(operationName + ".cs", serviceName, writer -> {
                this.writer = writer;
                addServiceProtocolSpecificImports();
                writer.addMarshallImports(serviceName, "Amazon." + serviceNamespace);
                writer.addImport(serviceName, "AWSSDK.ProtocolTests.Utils");
                writer.addSystemImport(serviceName);
                writer.addCoreImport(serviceName);
                writer.addProtocolTestImports(serviceName);
                writer.openBlock("namespace AWSSDK.ProtocolTests.$L \n{", "}", serviceName, () -> {
                    writer.write("[TestClass]");
                    writer.openBlock("public class $L \n{", "}", operationName, () -> {
                        generateRequestTests(operation);
                        generateResponseTests(operation);
                        generateErrorResponseTests(operation, operationIndex);
                        generateEventStreamTests(operation);
                    });
                });
            });
        }
    }

    private void addServiceProtocolSpecificImports() {
        if (this.serviceName.toLowerCase().contains("json")) {
            writer.addImport(serviceName, "Newtonsoft.Json");
            writer.addImport(serviceName, "Newtonsoft.Json.Linq");
        } else if (this.serviceName.toLowerCase().contains("xml")) {
            writer.addImport(serviceName, "System.Xml");
            writer.addImport(serviceName, "System.Xml.Linq");
        } else if (this.serviceName.toLowerCase().contains("rpcv2")) {
            writer.addImport(serviceName, "Amazon.Extensions.CborProtocol.Internal.Transform");
        }
    }

    private void generateErrorResponseTests(OperationShape operation, OperationIndex index) {
        for (StructureShape error : index.getErrors(operation, service)) {
            error.getTrait(HttpResponseTestsTrait.class).ifPresent(trait -> {
                for (HttpResponseTestCase httpResponseTestCase : trait.getTestCasesFor(AppliesTo.CLIENT)) {
                    if(!ProtocolTestCustomizations.TestsToSkip.contains(httpResponseTestCase.getId()))
                        generateErrorResponseTest(operation, error, httpResponseTestCase);
                }
            });
        }
    }

    private void generateErrorResponseTest(OperationShape operation, StructureShape error, HttpResponseTestCase httpResponseTestCase) {
        if (httpResponseTestCase.getDocumentation().isPresent()) {
            writer.writeXmlDocs(httpResponseTestCase.getDocumentation().get());
        }
        writer.write("[TestMethod]");
        writer.write("[TestCategory(\"ProtocolTest\")]");
        writer.write("[TestCategory(\"ErrorTest\")]");
        writer.write("[TestCategory(\"$L\")]", serviceName);
        if (useMockedClient) {
            writer.addImport(serviceName, "System.Threading.Tasks");
            writer.openBlock("public async Task $LErrorResponse()\n{", "}", httpResponseTestCase.getId(), () -> {
                generateErrorResponseTestBlockV2(operation, error, httpResponseTestCase);
            });
        } else {
            writer.openBlock("public void $LErrorResponse()\n{", "}", httpResponseTestCase.getId(), () -> {
                generateErrorResponseTestBlock(operation, error, httpResponseTestCase);
            });
        }
        writer.write("\n");
    }

    /**
     * Generates an error test that returns the test case's HTTP error response from a mocked HTTP layer and
     * asserts that the real service client (await client.OperationAsync(request)) throws the modeled exception.
     * Currently only used for services in MOCKED_CLIENT_SERVICES.
     */
    private void generateErrorResponseTestBlockV2(OperationShape operation, StructureShape error, HttpResponseTestCase httpResponseTestCase) {
        var operationName = operation.getId().getName();
        var errorSymbol = error.getId().getName() + "Exception";
        writer.addImport(serviceName, "System.Net", "HttpStatusCode");
        //Arrange
        writer.writeSingleLineComment("Arrange");
        // Retries are disabled so retryable error codes (e.g. 5xx) surface immediately instead of being re-sent.
        writer.write("""
                     var config = new $L
                     {
                       ServiceURL = MockHttpClientUtils.TestServiceUrl,
                       MaxErrorRetry = 0,
                     };
                     """, ProtocolTestUtils.getProtocolConfig(this.serviceNamespace));
        writer.write("using var client = new $L(MockHttpClientUtils.TestCredentials, config);",
                ProtocolTestUtils.getProtocolClient(this.serviceNamespace));
        arrangeMockHttpResponse(httpResponseTestCase);
        writer.write("MockHttpClientUtils.InjectMockHttp(client, mockResponse);");
        writer.write("\n");
        //Act
        writer.writeSingleLineComment("Act");
        // See generateResponseTestBlockV2 for why an empty request is used.
        writer.write("var errorResponse = await Assert.ThrowsExactlyAsync<$L>(() => client.$LAsync(new $LRequest())).ConfigureAwait(false);",
                errorSymbol, operationName, operationName);
        writer.write("\n");
        //Assert
        writer.writeSingleLineComment("Assert");
        // TODO: Assert exception params. Since exceptions don't take a paramterless constructure there is not simple way to implement
        // this without dramatic alterations to the value node visitor
        writer.write("Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L), errorResponse.StatusCode);", httpResponseTestCase.getCode());
    }

    private void generateErrorResponseTestBlock(OperationShape operation, StructureShape error, HttpResponseTestCase httpResponseTestCase) {
        var outputShape = model.expectShape(operation.getOutputShape(), StructureShape.class);
        var responseSymbol = operation.getId().getName() + "Response";
        //Arrange
        arrangeResponseTestBlock(httpResponseTestCase);
        var errorSymbol = error.getId().getName() + "Exception";
        writer.writeSingleLineComment("Act");
        writer.write("var errorResponse = new $LUnmarshaller().UnmarshallException(context, null, (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L));", responseSymbol, httpResponseTestCase.getCode());
        writer.writeSingleLineComment("Assert");
        // TODO: Assert exception params. Since exceptions don't take a paramterless constructure there is not simple way to implement
        // this without dramatic alterations to the value node visitor
        writer.write("Assert.IsInstanceOfType(errorResponse, typeof($L));", errorSymbol);
        writer.write("Assert.AreEqual(errorResponse.StatusCode,(HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L));", httpResponseTestCase.getCode());
    }

    private void arrangeResponseTestBlock(HttpResponseTestCase httpResponseTestCase) {
        writer.addImport(serviceName, "System.Net", "HttpStatusCode");
        writer.writeSingleLineComment("Arrange");
        writer.write("var webResponseData = new WebResponseData();");
        writer.write("webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L);", httpResponseTestCase.getCode());
        for (var header : httpResponseTestCase.getHeaders().keySet()) {
            writer.write("webResponseData.Headers[$S] = $S;", header, httpResponseTestCase.getHeaders().get(header));
        }
        if (this.marshallerType.equals("Cbor"))
            writer.write("byte[] bytes = Convert.FromBase64String($S);", httpResponseTestCase.getBody());
        else
            writer.write("byte[] bytes = Encoding.ASCII.GetBytes($S);", httpResponseTestCase.getBody());
        writer.write("var stream = new MemoryStream(bytes);");
        writer.write("var context = new $LUnmarshallerContext(stream,true,webResponseData);", marshallerType);
    }

    private void generateRequestTests(OperationShape operation) {
        operation.getTrait(HttpRequestTestsTrait.class).ifPresent(trait -> {
            // Marshaller only needs to be determined once and it will be the same for requests/responses/errors.
            // In case the operation doesn't have a request or response test, we will call this on the response side as well.
            if (!trait.getTestCasesFor(AppliesTo.CLIENT).isEmpty()) {
                setMarshallerType(trait.getTestCasesFor(AppliesTo.CLIENT).getFirst().getProtocol().getName());
            }
            for (HttpRequestTestCase httpRequestTestCase : trait.getTestCasesFor(AppliesTo.CLIENT)) {
                if (ProtocolTestCustomizations.TestsToSkip.contains(httpRequestTestCase.getId()) || !Collections.disjoint(httpRequestTestCase.getTags(), tagsToSkip))
                    continue;
                generateRequestTest(operation, httpRequestTestCase);
            }
        });
    }

    private void WriteRequestTestAttributes(){
        writer.write("[TestMethod]");
        writer.write("[TestCategory(\"ProtocolTest\")]");
        writer.write("[TestCategory(\"RequestTest\")]");
        writer.write("[TestCategory(\"$L\")]", serviceName);
    }

    private void generateEventStreamTests(OperationShape operation) {
        operation.getTrait(EventStreamTestsTrait.class).ifPresent(trait -> {
            for (EventStreamTestCase eventStreamTestCase : trait.getTestCasesFor(AppliesTo.CLIENT)) {
                if (ProtocolTestCustomizations.TestsToSkip.contains(eventStreamTestCase.getId()) || !Collections.disjoint(eventStreamTestCase.getTags(), tagsToSkip))
                    continue;
                generateEventStreamTest(operation, eventStreamTestCase);
            }
        });
    }

    private void generateEventStreamTest(OperationShape operation, EventStreamTestCase eventStreamTestCase) {
        if (!useMockedClient) {
            LOGGER.warning("Skipping event stream test " + eventStreamTestCase.getId() + ": event stream tests require the mocked client.");
            return;
        }
        setMarshallerType(eventStreamTestCase.getProtocol().getName());
        var hasInputStream = EventStreamIndex.of(model).getInputInfo(operation).isPresent();
        // These only decide the test name suffix and categories. Initial messages are checked as well as event types
        // because some tests have no events at all, e.g. InitialResponseOutput and ModeledProtocolError only set an
        // initialResponse and would otherwise be named and categorized as request tests.
        var isRequestTest = eventStreamTestCase.getInitialRequest().isPresent() || !getEvents(eventStreamTestCase, EventType.REQUEST).isEmpty();
        var isResponseTest = eventStreamTestCase.getInitialResponse().isPresent() || !getEvents(eventStreamTestCase, EventType.RESPONSE).isEmpty();
        var testSuffix = isRequestTest && isResponseTest ? "RequestAndResponse" : isResponseTest ? "Response" : "Request";

        // Request stream publishing is only supported on .NET 8+, so this applies to every test of an operation with an input stream.
        if (hasInputStream)
            writer.write("#if NET8_0_OR_GREATER");
        if (eventStreamTestCase.getDocumentation().isPresent()) {
            writer.writeXmlDocs(eventStreamTestCase.getDocumentation().get());
        }
        writer.write("[TestMethod]");
        writer.write("[TestCategory(\"ProtocolTest\")]");
        if (isRequestTest || !isResponseTest)
            writer.write("[TestCategory(\"RequestTest\")]");
        if (isResponseTest)
            writer.write("[TestCategory(\"ResponseTest\")]");
        writer.write("[TestCategory(\"$L\")]", serviceName);
        writer.addImport(serviceName, "System.Threading.Tasks");
        writer.openBlock("public async Task $L$L()\n{", "}", eventStreamTestCase.getId(), testSuffix, () -> {
            generateEventStreamTestBlock(operation, eventStreamTestCase);
        });
        if (hasInputStream)
            writer.write("#endif");
        writer.write("\n");
    }

    /**
     * Generates an event stream test that calls the real service client (await client.OperationAsync(request))
     * with a mocked HTTP layer. Request events are published through the request's stream publisher and asserted
     * on the frames captured by the mock. Response events are returned by the mock and asserted on the events
     * read from the response's event stream.
     */
    private void generateEventStreamTestBlock(OperationShape operation, EventStreamTestCase eventStreamTestCase) {
        var eventStreamIndex = EventStreamIndex.of(model);
        var inputStreamInfo = eventStreamIndex.getInputInfo(operation);
        var outputStreamInfo = eventStreamIndex.getOutputInfo(operation);
        var inputShape = model.expectShape(operation.getInputShape(), StructureShape.class);
        var operationName = operation.getId().getName();
        String inputShapeName = operationName + "Request";
        var requestEvents = getEvents(eventStreamTestCase, EventType.REQUEST);
        var responseEvents = getEvents(eventStreamTestCase, EventType.RESPONSE);
        var initialRequest = getInitialHttpRequest(eventStreamTestCase);
        var initialResponse = getInitialHttpResponse(eventStreamTestCase);
        var expectation = eventStreamTestCase.getExpectation();
        var outputStreamMember = outputStreamInfo.map(info -> context.symbolProvider().toMemberName(info.getEventStreamMember()));

        writer.writeSingleLineComment("Arrange");
        inputStreamInfo.ifPresent(info -> {
            writer.openBlock("var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]\n{", "});", () -> {
                for (var event : requestEvents) {
                    writer.write("$C,", (Runnable) () -> writeModeledEvent(info, event));
                }
            });
        });
        writer.openBlock("var request = new $L\n{", "};", inputShapeName, () -> {
            eventStreamTestCase.getInitialRequestParams().ifPresent(params -> params.accept(new ValueNodeVisitor(inputShape, true, inputShapeName)));
            // The SDK calls the publisher until it returns null, which ends the input stream.
            inputStreamInfo.ifPresent(info -> writer.write("$LPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),",
                    context.symbolProvider().toMemberName(info.getEventStreamMember())));
        });
        writeMockedClient(initialRequest.map(this::getMockedServiceUrl).orElse("MockHttpClientUtils.TestServiceUrl"));
        if (outputStreamInfo.isPresent() || initialResponse.isPresent()) {
            writeEventStreamMockHttp(initialResponse, responseEvents, outputStreamInfo.isPresent());
        } else {
            writeRequestTestMockHttp();
        }
        writer.write("\n");

        writer.writeSingleLineComment("Act");
        // Disposing the response stops the input stream, so it is kept alive until the end of the test.
        if (expectation.isFailure()) {
            var errorId = expectation.getFailure().flatMap(TestFailureExpectation::getErrorId);
            var assertMethod = errorId.isPresent() ? "ThrowsExactlyAsync" : "ThrowsAsync";
            var exceptionType = errorId.map(id -> isEventStreamError(outputStreamInfo, id)
                    // Errors received on the event stream are wrapped in the service's event stream exception.
                    ? serviceNamespace + "EventStreamException"
                    : id.getName() + "Exception").orElse("Exception");
            writer.openBlock("var exception = await Assert.$L<$L>(async () =>\n{", "}).ConfigureAwait(false);", assertMethod, exceptionType, () -> {
                writer.write("using var actualResponse = await client.$LAsync(request).ConfigureAwait(false);", operationName);
                if (!responseEvents.isEmpty())
                    writer.write("actualResponse.$L.ToList();", outputStreamMember.get());
            });
        } else {
            writer.write("using var actualResponse = await client.$LAsync(request).ConfigureAwait(false);", operationName);
            if (!responseEvents.isEmpty())
                writer.write("var actualEvents = actualResponse.$L.ToList();", outputStreamMember.get());
        }
        if (initialRequest.isPresent() || !requestEvents.isEmpty())
            writer.write("var actualRequest = mockHttp.LastCreatedRequest;");
        // Events are written in the background after the response is returned, so wait for the end of the input stream.
        if (!requestEvents.isEmpty())
            writer.write("await actualRequest.InputStreamCompleted.ConfigureAwait(false);");
        writer.write("\n");

        writer.writeSingleLineComment("Assert");
        initialRequest.ifPresent(this::assertMockedHttpRequest);
        if (!requestEvents.isEmpty()) {
            writer.write("var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);");
            writer.write("Assert.AreEqual($L, sentEvents.Count);", requestEvents.size());
            for (int i = 0; i < requestEvents.size(); i++) {
                assertSentEvent("sentEvents[" + i + "]", requestEvents.get(i));
            }
        }
        if (expectation.isFailure()) {
            expectation.getFailure().flatMap(TestFailureExpectation::getErrorId)
                    .filter(errorId -> isEventStreamError(outputStreamInfo, errorId))
                    .ifPresent(errorId -> writer.write("Assert.IsInstanceOfType(exception.InnerException, typeof($LException));", errorId.getName()));
            return;
        }
        initialResponse.ifPresent(response -> assertInitialResponse(operation, outputStreamInfo, eventStreamTestCase, response));
        if (!responseEvents.isEmpty()) {
            var info = outputStreamInfo.get();
            writer.write("Assert.AreEqual($L, actualEvents.Count);", responseEvents.size());
            for (int i = 0; i < responseEvents.size(); i++) {
                var event = responseEvents.get(i);
                var eventName = event.getParams().get().getMembers().keySet().iterator().next().getValue();
                var eventSymbol = context.symbolProvider().toSymbol(info.getEvents().get(eventName));
                writer.write("Assert.IsInstanceOfType(actualEvents[$L], typeof($L));", i, eventSymbol);
                writer.write("Comparer.CompareObjects<$L>($C, ($L)actualEvents[$L]);", eventSymbol,
                        (Runnable) () -> writeModeledEvent(info, event), eventSymbol, i);
            }
        }
    }

    private List<Event> getEvents(EventStreamTestCase eventStreamTestCase, EventType type) {
        return eventStreamTestCase.getEvents().stream().filter(event -> event.getType() == type).toList();
    }

    /**
     * Writes the modeled event set in the event's params, e.g. new HeadersEvent { ... }.
     */
    private void writeModeledEvent(EventStreamInfo eventStreamInfo, Event event) {
        var eventParams = event.getParams().get().getMembers().entrySet().iterator().next();
        var eventShape = eventStreamInfo.getEvents().get(eventParams.getKey().getValue());
        eventParams.getValue().accept(new ValueNodeVisitor(eventShape));
    }

    private boolean isEventStreamError(Optional<EventStreamInfo> outputStreamInfo, ShapeId errorId) {
        return outputStreamInfo
                .map(info -> info.getEventStreamTarget().members().stream().anyMatch(member -> member.getTarget().equals(errorId)))
                .orElse(false);
    }

    /**
     * Writes the mocked HTTP layer (as mockHttp) returning the test case's initial response, with the response
     * events as the body.
     */
    private void writeEventStreamMockHttp(Optional<HttpResponseTestCase> initialResponse, List<Event> responseEvents, boolean hasOutputStream) {
        writer.addImport(serviceName, "System.Net", "HttpStatusCode");
        var hasContentTypeHeader = initialResponse
                .map(response -> response.getHeaders().keySet().stream().anyMatch("Content-Type"::equalsIgnoreCase))
                .orElse(false);
        writer.openBlock("var mockResponse = new MockHttpResponse\n{", "};", () -> {
            writer.write("StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L),", initialResponse.map(HttpResponseTestCase::getCode).orElse(200));
            if (hasOutputStream && !hasContentTypeHeader)
                writer.write("ContentType = \"application/vnd.amazon.eventstream\",");
            if (!responseEvents.isEmpty()) {
                writer.openBlock("Body = MockHttpClientUtils.EncodeEvents(", "),", () -> {
                    for (int i = 0; i < responseEvents.size(); i++) {
                        var event = responseEvents.get(i);
                        writer.write("$C$L", (Runnable) () -> writeResponseEventBytes(event), i < responseEvents.size() - 1 ? "," : "");
                    }
                });
            } else {
                initialResponse.flatMap(HttpResponseTestCase::getBody).filter(body -> !body.isEmpty())
                        .ifPresent(body -> writer.write("Body = Encoding.UTF8.GetBytes($S),", body));
            }
        });
        initialResponse.ifPresent(response -> response.getHeaders().forEach((name, value) ->
                writer.write("mockResponse.Headers[$S] = $S;", name, value)));
        writer.write("var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);");
    }

    private void writeResponseEventBytes(Event event) {
        if (event.getBytes().isPresent()) {
            writer.writeInline("Convert.FromBase64String($S)", Base64.getEncoder().encodeToString(event.getBytes().get()));
            return;
        }
        // Without bytes, the event is built from its headers and body.
        writer.openBlock("MockHttpClientUtils.EncodeEvent(Encoding.UTF8.GetBytes($S), new Dictionary<string, object>\n{", "})",
                event.getBody().orElse(""), () -> {
            for (var header : event.getHeaders().entrySet()) {
                writer.write("{ $S, $C },", header.getKey(), (Runnable) () -> writeEventHeaderValue(header.getValue()));
            }
        });
    }

    /**
     * Writes an event header value whose CLR type matches the header's wire type.
     */
    private void writeEventHeaderValue(EventHeaderValue<?> value) {
        switch (value.getType()) {
            case BOOLEAN -> writer.writeInline("$L", value.asBoolean());
            case BYTE -> writer.writeInline("(sbyte)$L", value.asByte());
            case SHORT -> writer.writeInline("(short)$L", value.asShort());
            case INTEGER -> writer.writeInline("$L", value.asInteger());
            case LONG -> writer.writeInline("$LL", value.asLong());
            case BLOB -> writer.writeInline("Convert.FromBase64String($S)", Base64.getEncoder().encodeToString(value.asBlob()));
            case STRING -> writer.writeInline("$S", value.asString());
            case TIMESTAMP -> writer.writeInline("ProtocolTestConstants.epoch.AddMilliseconds($L)", value.asTimestamp().toEpochMilli());
            default -> throw new CodegenException("Unsupported event header type: " + value.getType());
        }
    }

    private void assertInitialResponse(OperationShape operation, Optional<EventStreamInfo> outputStreamInfo, EventStreamTestCase eventStreamTestCase, HttpResponseTestCase initialResponse) {
        var outputShape = model.expectShape(operation.getOutputShape(), StructureShape.class);
        var responseSymbol = operation.getId().getName() + "Response";
        // The event stream member is not part of the initial response, so it isn't compared.
        var initialResponseMembers = outputShape.members().stream()
                .filter(member -> outputStreamInfo.map(info -> !info.getEventStreamMember().equals(member)).orElse(true))
                .toList();
        if (!initialResponseMembers.isEmpty()) {
            writer.openBlock("var expectedResponse = new $L\n{", "};", responseSymbol, () ->
                    eventStreamTestCase.getInitialResponseParams().ifPresent(params -> params.accept(new ValueNodeVisitor(outputShape, true, responseSymbol))));
            for (var member : initialResponseMembers) {
                var memberName = context.symbolProvider().toMemberName(member);
                writer.write("Comparer.CompareObjects(expectedResponse.$L, actualResponse.$L);", memberName, memberName);
            }
        }
        writer.write("Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L), actualResponse.HttpStatusCode);", initialResponse.getCode());
    }

    private Optional<HttpResponseTestCase> getInitialHttpResponse(EventStreamTestCase eventStreamTestCase) {
        if (eventStreamTestCase.getInitialResponse().isEmpty()
                || !eventStreamTestCase.getInitialResponseShape().map(INITIAL_HTTP_RESPONSE::equals).orElse(false)) {
            return Optional.empty();
        }
        // InitialHttpResponse shares its members with httpResponseTests, so it is read as an HttpResponseTestCase.
        // HttpResponseTestCase.fromNode isn't public, so the case is built from the node's members.
        var node = eventStreamTestCase.getInitialResponse().get();
        var builder = HttpResponseTestCase.builder()
                .code(node.expectNumberMember("code").getValue().intValue())
                .id(eventStreamTestCase.getId())
                .protocol(eventStreamTestCase.getProtocol());
        node.getObjectMember("headers").ifPresent(headers -> headers.getStringMap().forEach((name, value) ->
                builder.putHeader(name, value.expectStringNode().getValue())));
        node.getStringMember("body").ifPresent(body -> builder.body(body.getValue()));
        node.getStringMember("bodyMediaType").ifPresent(bodyMediaType -> builder.bodyMediaType(bodyMediaType.getValue()));
        return Optional.of(builder.build());
    }

    private Optional<HttpRequestTestCase> getInitialHttpRequest(EventStreamTestCase eventStreamTestCase) {
        if (eventStreamTestCase.getInitialRequest().isEmpty()
                || !eventStreamTestCase.getInitialRequestShape().map(INITIAL_HTTP_REQUEST::equals).orElse(false)) {
            return Optional.empty();
        }
        // InitialHttpRequest shares its members with httpRequestTests, so it is read as an HttpRequestTestCase
        // to reuse the same request assertions.
        return Optional.of(HttpRequestTestCase.fromNode(eventStreamTestCase.getInitialRequest().get().toBuilder()
                .withMember("id", eventStreamTestCase.getId())
                .withMember("protocol", eventStreamTestCase.getProtocol().toString())
                .build()));
    }

    private void assertSentEvent(String actualEvent, Event event) {
        for (var header : event.getHeaders().entrySet()) {
            // The value's CLR type picks the AssertEventHeader overload, which checks the exact wire type.
            writer.write("MockHttpClientUtils.AssertEventHeader($L, $S, $C);", actualEvent, header.getKey(),
                    (Runnable) () -> writeEventHeaderValue(header.getValue()));
        }
        for (var forbidHeader : event.getForbidHeaders()) {
            writer.write("Assert.IsFalse($L.Headers.ContainsKey($S));", actualEvent, forbidHeader);
        }
        for (var requireHeader : event.getRequireHeaders()) {
            writer.write("Assert.IsTrue($L.Headers.ContainsKey($S));", actualEvent, requireHeader);
        }
        event.getBody().ifPresent(body -> {
            if (event.getBodyMediaType().map("application/json"::equals).orElse(false)) {
                writer.write("JsonProtocolUtils.AssertBody($L.Payload, $S);", actualEvent, body);
            } else {
                // Bodies with a media type that isn't understood must match exactly.
                writer.write("CollectionAssert.AreEqual(Encoding.UTF8.GetBytes($S), $L.Payload);", body, actualEvent);
            }
        });
    }

    private void generateRequestTest(OperationShape operation, HttpRequestTestCase httpRequestTestCase) {
        if (httpRequestTestCase.getDocumentation().isPresent()) {
            writer.writeXmlDocs(httpRequestTestCase.getDocumentation().get());
        }
        WriteRequestTestAttributes();
        if (useMockedClient) {
            writer.addImport(serviceName, "System.Threading.Tasks");
            writer.openBlock("public async Task $LRequest()\n{", "}", httpRequestTestCase.getId(), () -> {
                generateRequestTestBlockV2(operation, httpRequestTestCase);
            });
        } else {
            writer.openBlock("public void $LRequest()\n{", "}", httpRequestTestCase.getId(), () -> {
                generateRequestTestBlock(operation, httpRequestTestCase);
            });
        }
        writer.write("\n");
    }

    /**
     * Generates a request test that sends the request through the real service client
     * (await client.OperationAsync(request)) with a mocked HTTP layer, and asserts on the
     * HTTP request captured by the mock. Currently only used for services in MOCKED_CLIENT_SERVICES.
     */
    private void generateRequestTestBlockV2(OperationShape operation, HttpRequestTestCase httpRequestTestCase) {
        var params = httpRequestTestCase.getParams();
        var inputShape = model.expectShape(operation.getInputShape(), StructureShape.class);
        var operationName = operation.getId().getName();

        String inputShapeName = operationName + "Request";
        writer.writeSingleLineComment("Arrange");
        writer.openBlock("var request = new $L\n{", "};", inputShapeName, (Runnable) () -> params.accept(new ValueNodeVisitor(inputShape, true, inputShapeName)));
        writeMockedRequestTestClient(getMockedServiceUrl(httpRequestTestCase));
        writer.writeSingleLineComment("Act");
        writer.write("await client.$LAsync(request).ConfigureAwait(false);", operationName);
        writer.write("var actualRequest = mockHttp.LastCreatedRequest;");
        writer.write("\n");
        writer.writeSingleLineComment("Assert");
        assertMockedHttpRequest(httpRequestTestCase);
    }

    private String getMockedServiceUrl(HttpRequestTestCase httpRequestTestCase) {
        var hostList = httpRequestTestCase.getHost().orElse("test.com").split("/", 2);
        var host = hostList[0];
        String path;
        if (hostList.length != 1) {
            path = hostList[1];
        } else {
            path = "";
        }

        return host.equals("test.com") && path.isEmpty()
                ? "MockHttpClientUtils.TestServiceUrl"
                : "\"https://" + host + "/" + path + "\"";
    }

    /**
     * Writes the config, client and mocked HTTP layer (as mockHttp) for a request test.
     */
    private void writeMockedRequestTestClient(String serviceUrl) {
        writeMockedClient(serviceUrl);
        writeRequestTestMockHttp();
    }

    private void writeMockedClient(String serviceUrl) {
        // Retries are disabled so a test fails fast instead of re-sending the request.
        writer.write("""
                     var config = new $L
                     {
                       ServiceURL = $L,
                       MaxErrorRetry = 0,
                     };
                     """, ProtocolTestUtils.getProtocolConfig(this.serviceNamespace), serviceUrl);
        writer.write("using var client = new $L(MockHttpClientUtils.TestCredentials, config);",
                ProtocolTestUtils.getProtocolClient(this.serviceNamespace));
    }

    private void writeRequestTestMockHttp() {
        // Request tests only assert on what was sent, so any response the unmarshaller accepts will do.
        if (this.marshallerType.equals("Json")) {
            writer.write("""
                         var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
                         {
                             ContentType = "application/json",
                             Body = Encoding.UTF8.GetBytes("{}"),
                         });
                         """);
        } else {
            // XML responses (Query, EC2 and REST XML) are read by the XML unmarshaller, which rejects a "{}"
            // JSON body and throws on an empty body ("Root element is missing"). A minimal well-formed XML
            // document with an unrecognized root unmarshalls into an empty response without error.
            writer.write("""
                         var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
                         {
                             ContentType = "text/xml",
                             Body = Encoding.UTF8.GetBytes("<Response/>"),
                         });
                         """);
        }
    }

    /**
     * Writes the assertions on the HTTP request captured by the mock (as actualRequest).
     */
    private void assertMockedHttpRequest(HttpRequestTestCase httpRequestTestCase) {
        var host = httpRequestTestCase.getHost().orElse("test.com").split("/", 2)[0];
        var resolvedHost = httpRequestTestCase.getResolvedHost().map(x -> x.split("/", 2)[0]).orElse(host);
        if (httpRequestTestCase.getBody().isPresent() && !httpRequestTestCase.getBody().get().equals("")) {
            assertRequestBodyV2(httpRequestTestCase);
        }
        writer.write("Assert.AreEqual($S, actualRequest.Method);", httpRequestTestCase.getMethod());
        // We compare with the OriginalString here because in .NET the Uri class sends some special characters decoded. We're only
        // interested in the original encoded string that the sdk internals calculated
        writer.write("Assert.AreEqual($S, ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));", httpRequestTestCase.getUri());
        if (httpRequestTestCase.getResolvedHost().isPresent()) {
            writer.write("Assert.AreEqual($S, actualRequest.RequestUri.Host);", resolvedHost);
        }
        var headers = httpRequestTestCase.getHeaders();
        for (var header : headers.keySet()) {
            if (header.equals("Content-Type")
                    && (httpRequestTestCase.getProtocol().getName().equals("awsQuery") || httpRequestTestCase.getProtocol().getName().equals("ec2Query"))) {
                // the smithy docs https://smithy.io/2.0/aws/protocols/aws-query-protocol.html#request-serialization> use SHALL when describing the content-type
                // for query based protocols. Since the .NET SDK has sent charset=utf-8 for many years, the assertion here will be more relaxed.
                writer.write("Assert.AreEqual(\"application/x-www-form-urlencoded; charset=utf-8\", actualRequest.Headers[$S]);", header);
                continue;
            }
            // We are relaxing our assert here so that "1, 2, 3" = "1,2,3" There is nothing in the smithy docs that says whitespace matters.
            writer.write("Assert.AreEqual($S.Replace(\" \",\"\"), actualRequest.Headers[$S].Replace(\" \",\"\"));", headers.get(header), header);
        }
        // Unlike RunMockRequest, the request has gone through the HttpHandler, so headers it computes
        // such as Content-Length can be asserted as well.
        for (var requireHeader : httpRequestTestCase.getRequireHeaders()) {
            writer.write("Assert.IsTrue(actualRequest.Headers.ContainsKey($S));", requireHeader);
        }
        for (var forbidHeader : httpRequestTestCase.getForbidHeaders()) {
            writer.write("Assert.IsFalse(actualRequest.Headers.ContainsKey($S));", forbidHeader);
        }
        if (!httpRequestTestCase.getQueryParams().isEmpty()
                || !httpRequestTestCase.getForbidQueryParams().isEmpty()
                || !httpRequestTestCase.getRequireQueryParams().isEmpty()) {
            writer.write("var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualRequest.RequestUri);");
            for (var queryParam : httpRequestTestCase.getQueryParams()) {
                writer.write("Assert.IsTrue(actualQuerySegments.Contains($S));", queryParam);
            }
            for (var forbidQueryParam : httpRequestTestCase.getForbidQueryParams()) {
                writer.write("Assert.IsFalse(actualQuerySegments.Contains($S));", forbidQueryParam);
            }
            for (var requireQueryParam : httpRequestTestCase.getRequireQueryParams()) {
                writer.write("Assert.IsTrue(actualQuerySegments.Contains($S));", requireQueryParam);
            }
        }
    }

    private void assertRequestBodyV2(HttpRequestTestCase httpRequestTestCase) {
        if (this.marshallerType.equals("Json")) {
            writer.write("var expectedBody = $S;", httpRequestTestCase.getBody());
            writer.write("JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);");
        } else if (httpRequestTestCase.getProtocol().getName().equals("awsQuery") || httpRequestTestCase.getProtocol().getName().equals("ec2Query")) {
            writer.write("var expectedBody = $S;", httpRequestTestCase.getBody());
            writer.write("QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);");
        } else if (httpRequestTestCase.getProtocol().getName().equals("restXml")) {
            writer.write("var expectedBody = $S;", httpRequestTestCase.getBody());
            writer.write("XmlTestUtils.AssertBody(actualRequest.Body, expectedBody);");
        } else {
            throw new CodegenException("Mocked client request tests are only supported for JSON, Query and REST XML protocols.");
        }
    }

    private void generateRequestTestBlock(OperationShape operation, HttpRequestTestCase httpRequestTestCase) {
        var params = httpRequestTestCase.getParams();
        var inputShape = model.expectShape(operation.getInputShape(), StructureShape.class);

        String inputShapeName = operation.getId().getName() + "Request";
        writer.writeSingleLineComment("Arrange");
        writer.openBlock("var request = new $L\n{", "};", inputShapeName, (Runnable) () -> params.accept(new ValueNodeVisitor(inputShape, true, inputShapeName)));
        var hostList = httpRequestTestCase.getHost().orElse("test.com").split("/", 2);
        var host = hostList[0];
        var resolvedHost = httpRequestTestCase.getResolvedHost().map(x -> x.split("/", 2)[0]).orElse(host);
        String path;
        if (hostList.length != 1) {
            path = hostList[1];
        } else {
            path = "";
        }

        writer.write("""
                     var config = new $L
                     {
                       ServiceURL = "https://$L/$L"
                     };
                     """, ProtocolTestUtils.getProtocolConfig(this.serviceNamespace), host, path);
        writer.write("var marshaller = new $LMarshaller();", inputShapeName);
        writer.writeSingleLineComment("Act");
        writer.write("var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);");
        writer.write("\n");
        writer.writeSingleLineComment("Assert");
        //verify the body
        if (httpRequestTestCase.getBody().isPresent() && !httpRequestTestCase.getBody().get().equals("")) {
            assertRequestBody(httpRequestTestCase);
        }
        writer.write("Assert.AreEqual($S, marshalledRequest.HttpMethod);", httpRequestTestCase.getMethod());
        // Calling AmazonServiceClient.ComposeUrl to avoid adding the HttpHandler to the mock request pipeline since we don't want
        // to make a network call
        writer.write("Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);");
        // We compare with the OriginalString here because in .NET the Uri class sends some special characters decoded. We're only
        // interested in the original encoded string that the sdk internals calculated
        writer.write("Assert.AreEqual($S, ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));", httpRequestTestCase.getUri());
        if (httpRequestTestCase.getResolvedHost().isPresent()) {
            writer.write("Assert.AreEqual($S, actualUri.Host);", resolvedHost);
        }
        var headers = httpRequestTestCase.getHeaders();
        for (var header : httpRequestTestCase.getHeaders().keySet()) {
            if (header.equals("Content-Type")) {
                if (httpRequestTestCase.getProtocol().getName().equals("awsQuery") || httpRequestTestCase.getProtocol().getName().equals("ec2Query")) {
                    // the smithy docs https://smithy.io/2.0/aws/protocols/aws-query-protocol.html#request-serialization> use SHALL when describing the content-type
                    // for query based protocols. Since the .NET SDK has sent charset=utf-8 for many years, the assertion here will be more relaxed.
                    writer.write("Assert.AreEqual(\"application/x-www-form-urlencoded; charset=utf-8\",marshalledRequest.Headers[$S]);", header);
                    continue;
                }
            }
            // We are relaxing our assert here so that "1, 2, 3" = "1,2,3" There is nothing in the smithy docs that says whitespace matters.
            writer.write("Assert.AreEqual($S.Replace(\" \",\"\"), marshalledRequest.Headers[$S].Replace(\" \",\"\"));", headers.get(header), header);
        }
        if (!httpRequestTestCase.getRequireHeaders().isEmpty()) {
            for (var requireHeader : httpRequestTestCase.getRequireHeaders()) {
                // The content length gets computed in the HttpHandler here <a href = https://github.com/aws/aws-sdk-net/blob/main/sdk/src/Core/Amazon.Runtime/Pipeline/HttpHandler/HttpHandler.cs#L496>.
                // We checked via fiddler that the content-length is set and checked the code. For the protocol test we will not mock the HttpHandler as the effort is non-trivial.
                if (requireHeader.toLowerCase().equals("content-length"))
                    continue;
                writer.write("Assert.IsTrue(marshalledRequest.Headers.ContainsKey($S));", requireHeader);
            }
        }
        if (!httpRequestTestCase.getForbidHeaders().isEmpty()) {
            for (var forbidHeader : httpRequestTestCase.getForbidHeaders()) {
                writer.write("Assert.IsFalse(marshalledRequest.Headers.ContainsKey($S));", forbidHeader);
            }
        }
        // Verify the query Params.
        if (!httpRequestTestCase.getQueryParams().isEmpty()) {
            writer.write("var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);");
            for (var queryParam : httpRequestTestCase.getQueryParams()) {
                writer.write("Assert.IsTrue(actualQuerySegments.Contains($S));", queryParam);
            }
            if (!httpRequestTestCase.getForbidQueryParams().isEmpty()) {
                for (var forbidQueryParam : httpRequestTestCase.getForbidQueryParams()) {
                    writer.write("Assert.IsFalse(actualQuerySegments.Contains($S));", forbidQueryParam);
                }
            }
            if (!httpRequestTestCase.getRequireQueryParams().isEmpty()) {
                for (var requireQueryParam : httpRequestTestCase.getRequireQueryParams()) {
                    writer.write("Assert.IsTrue(actualQuerySegments.Contains($S));", requireQueryParam);
                }
            }
        }

    }

    private void assertRequestBody(HttpRequestTestCase httpRequestTestCase) {
        if (this.marshallerType.equals("Json")) {
            writer.write("var expectedBody = $S;", httpRequestTestCase.getBody());
            writer.write("JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);");
        } else if (httpRequestTestCase.getProtocol().getName().equals("awsQuery") || httpRequestTestCase.getProtocol().getName().equals("ec2Query")) {
            writer.addImport(serviceName, "System.Net", "WebUtility");
            writer.write("var expectedParams = QueryTestUtils.ConvertBodyToParameters($S);", httpRequestTestCase.getBody());
            writer.write("""
                         foreach(var queryParam in expectedParams.Keys)
                         {
                            Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
                            Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
                         }
                         """);
        } else if (httpRequestTestCase.getProtocol().getName().equals("restXml")) {
            writer.write("var expectedBody = $S;", httpRequestTestCase.getBody());
            writer.write("XmlTestUtils.AssertBody(marshalledRequest,expectedBody);");
        } else if (this.marshallerType.equals("Cbor")) {
            writer.write("var expectedBody = $S;", httpRequestTestCase.getBody());
            writer.write("CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);");
        } else {
            throw new CodegenException("Unsupported protocol detected while generating request test block.");
        }
    }

    private void generateResponseTests(OperationShape operation) {
        operation.getTrait(HttpResponseTestsTrait.class).ifPresent(trait -> {
            if (!trait.getTestCasesFor(AppliesTo.CLIENT).isEmpty()) {
                setMarshallerType(trait.getTestCasesFor(AppliesTo.CLIENT).getFirst().getProtocol().getName());
            }
            for (HttpResponseTestCase httpResponseTestCase : trait.getTestCasesFor(AppliesTo.CLIENT)) {
                if (ProtocolTestCustomizations.TestsToSkip.contains(httpResponseTestCase.getId()) || !Collections.disjoint(httpResponseTestCase.getTags(), tagsToSkip))
                    continue;
                generateResponseTest(operation, httpResponseTestCase);
            }
        });
    }

    private void generateResponseTest(OperationShape operation, HttpResponseTestCase httpResponseTestCase) {
        if (httpResponseTestCase.getDocumentation().isPresent()) {
            writer.writeXmlDocs(httpResponseTestCase.getDocumentation().get());
        }
        writer.write("[TestMethod]");
        writer.write("[TestCategory(\"ProtocolTest\")]");
        writer.write("[TestCategory(\"ResponseTest\")]");
        writer.write("[TestCategory(\"$L\")]", serviceName);
        if (useMockedClient) {
            writer.addImport(serviceName, "System.Threading.Tasks");
            writer.openBlock("public async Task $LResponse()\n{", "}", httpResponseTestCase.getId(), () -> {
                generateResponseTestBlockV2(operation, httpResponseTestCase);
            });
        } else {
            writer.openBlock("public void $LResponse()\n{", "}", httpResponseTestCase.getId(), () -> {
                generateResponseTestBlock(operation, httpResponseTestCase);
            });
        }
        writer.write("\n");
    }

    /**
     * Generates a response test that returns the test case's HTTP response from a mocked HTTP layer and
     * unmarshalls it through the real service client (await client.OperationAsync(request)).
     * Currently only used for services in MOCKED_CLIENT_SERVICES.
     */
    private void generateResponseTestBlockV2(OperationShape operation, HttpResponseTestCase httpResponseTestCase) {
        var outputShape = model.expectShape(operation.getOutputShape(), StructureShape.class);
        var operationName = operation.getId().getName();
        var responseSymbol = operationName + "Response";
        writer.addImport(serviceName, "System.Net", "HttpStatusCode");
        //Arrange
        writer.writeSingleLineComment("Arrange");
        writer.write("""
                     var config = new $L
                     {
                       ServiceURL = MockHttpClientUtils.TestServiceUrl,
                       MaxErrorRetry = 0,
                     };
                     """, ProtocolTestUtils.getProtocolConfig(this.serviceNamespace));
        writer.write("using var client = new $L(MockHttpClientUtils.TestCredentials, config);",
                ProtocolTestUtils.getProtocolClient(this.serviceNamespace));
        arrangeMockHttpResponse(httpResponseTestCase);
        writer.write("MockHttpClientUtils.InjectMockHttp(client, mockResponse);");
        writer.write("\n");
        //Act
        writer.writeSingleLineComment("Act");
        // Response test cases don't define input params. This is fine for protocols without URI or host labels,
        // but required label members will need placeholder values before this is used for REST protocols.
        writer.write("var actualResponse = await client.$LAsync(new $LRequest()).ConfigureAwait(false);", operationName, operationName);
        writer.openBlock("var expectedResponse = new $L\n{", "};", responseSymbol, (Runnable) () -> httpResponseTestCase.getParams().accept(new ValueNodeVisitor(outputShape, true, responseSymbol)));
        writer.write("\n");
        //Assert
        writer.writeSingleLineComment("Assert");
        writer.write("Comparer.CompareObjects<$L>(expectedResponse,actualResponse);", responseSymbol);
        writer.write("Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L), actualResponse.HttpStatusCode);", httpResponseTestCase.getCode());
    }

    private void arrangeMockHttpResponse(HttpResponseTestCase httpResponseTestCase) {
        writer.openBlock("var mockResponse = new MockHttpResponse\n{","};",(Runnable) () -> {
            writer.write("StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L),", httpResponseTestCase.getCode());
            // this is only used for json protocols for now but future-proofing
            if (this.marshallerType.equals("Cbor"))
                writer.write("Body = Convert.FromBase64String($S),", httpResponseTestCase.getBody());
            else
                writer.write("Body = Encoding.ASCII.GetBytes($S),", httpResponseTestCase.getBody());
        });
        for (var header : httpResponseTestCase.getHeaders().keySet()) {
            writer.write("mockResponse.Headers[$S] = $S;", header, httpResponseTestCase.getHeaders().get(header));
        }
    }

    private void generateResponseTestBlock(OperationShape operation, HttpResponseTestCase httpResponseTestCase) {
        var outputShape = model.expectShape(operation.getOutputShape(), StructureShape.class);
        var responseSymbol = operation.getId().getName() + "Response";
        //Arrange
        arrangeResponseTestBlock(httpResponseTestCase);
        writer.write("\n");
        // only unmarshall the response and assert if a body is present, as per smithy spec
        //Act
        writer.writeSingleLineComment("Act");
        writer.write("var unmarshalledResponse = new $LUnmarshaller().Unmarshall(context);", responseSymbol);
        writer.openBlock("var expectedResponse = new $L\n{", "};", responseSymbol, (Runnable) () -> httpResponseTestCase.getParams().accept(new ValueNodeVisitor(outputShape, true, responseSymbol)));
        writer.write("\n");
        //Assert
        writer.writeSingleLineComment("Assert");
        writer.write("var actualResponse = ($L)unmarshalledResponse;", responseSymbol);
        writer.write("Comparer.CompareObjects<$L>(expectedResponse,actualResponse);", responseSymbol);
        writer.write("Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), $L), context.ResponseData.StatusCode);", httpResponseTestCase.getCode());
    }

    private void setMarshallerType(String protocol) {
        if (protocol.toLowerCase().contains("json")) {
            this.marshallerType = "Json";
        } else if (protocol.toLowerCase().contains("xml") || protocol.toLowerCase().contains("query")) {
            this.marshallerType = "Xml";
        } else if (protocol.toLowerCase().contains("cbor")) {
            this.marshallerType = "Cbor";
        }
    }

    private final class ValueNodeVisitor implements NodeVisitor<Void> {
        private final Shape inputShape;
        private boolean inNestedDocument;
        private boolean isTopLevelInputOrOutput;
        private String generatedInputOutputShapeName;

        private ValueNodeVisitor(Shape inputShape) {
            this.inputShape = inputShape;
            this.generatedInputOutputShapeName = "";
        }

        private ValueNodeVisitor(Shape inputShape, boolean isTopLevelInputOrOutput, String generatedInputOutputShapeName) {
            this.inputShape = inputShape;
            this.isTopLevelInputOrOutput = isTopLevelInputOrOutput;
            this.generatedInputOutputShapeName = generatedInputOutputShapeName;
        }

        private ValueNodeVisitor(Shape inputShape, boolean inNestedDocument) {
            this.inputShape = inputShape;
            this.inNestedDocument = inNestedDocument;
        }

        @Override
        public Void arrayNode(ArrayNode node) {
            if (inputShape.isDocumentShape() || inNestedDocument) {
                writer.openBlock("new Document\n{", "}",
                        () -> node.getElements().forEach((valueNode) -> {
                            writer.write("$C,",
                                    (Runnable) () -> valueNode.accept(this)
                            );
                        }));
            } else {
                ValueNodeVisitor targetVisitor;
                if (inputShape instanceof CollectionShape) {
                    writer.write(" new $L()", context.symbolProvider().toSymbol((CollectionShape) inputShape));
                    var target = model.expectShape(((CollectionShape) inputShape).getMember().getTarget());
                    targetVisitor = new ValueNodeVisitor(target);
                } else {
                    targetVisitor = this;
                }
                writer.openBlock("{", "}", () -> {
                    node.getElements().forEach(elementNode -> {
                        writer.write("$C, ", (Runnable) () -> elementNode.accept(targetVisitor));
                    });
                });
            }
            return null;
        }

        @Override
        public Void booleanNode(BooleanNode node) {
            writer.writeInline("$L", node.getValue());
            return null;
        }

        @Override
        public Void nullNode(NullNode node) {
            writer.writeInline("null");
            return null;
        }

        @Override
        public Void numberNode(NumberNode node) {
            if (inputShape.isTimestampShape()) {
                writer.write("ProtocolTestConstants.epoch.AddSeconds($L)", node.getValue());
            } else if (inputShape.isFloatShape()) {
                writer.writeInline("$LF", node.getValue());
            } else {
                writer.writeInline("$L", node.getValue());
            }
            return null;
        }

        private Void getStructure(StructureShape structureShape, ObjectNode node) {
            // for a top level input or output, since the name of the request/response is determined by the operation i.e. operation + request
            // we generate that name outside of the value node visitor and only generate structure members
            if (isTopLevelInputOrOutput) {
                getStructureMembersShapes(structureShape, node);
            }
            // if it's not a top level input or output, then we create the symbol as we would a normal structure
            // then generate the structure member names.
            else {
                var structureSymbol = context.symbolProvider().toSymbol(structureShape);
                writer.openBlock("new $L\n{", "}", structureSymbol,
                        () -> getStructureMembersShapes(structureShape, node));
            }
            return null;
        }

        private Void getStructureMembersShapes(StructureShape structureShape, ObjectNode node) {
            node.getMembers().forEach((keyNode, valueNode) -> {
                var memberShape = structureShape.getMember(keyNode.getValue()).orElseThrow(() ->
                        new CodegenException("Unknown member shape: " + keyNode.getValue())
                );
                var targetShape = model.expectShape(memberShape.getTarget());

                writer.write("$L = $C,",
                        context.symbolProvider().toMemberName(memberShape),
                        (Runnable) () -> valueNode.accept(new ValueNodeVisitor(targetShape, false, generatedInputOutputShapeName)));
            });
            return null;
        }

        @Override
        public Void objectNode(ObjectNode node) {
            switch (inputShape.getType()) {
                case STRUCTURE:
                    getStructure((StructureShape) inputShape, node);
                    return null;
                case MAP:
                    getMap((MapShape) inputShape, node);
                    return null;
                case DOCUMENT:
                    getDocument((DocumentShape) inputShape, node);
                    return null;
                case UNION:
                    getUnion((UnionShape) inputShape, node);
                    return null;
                default:
                    return null;
            }
        }

        private Void getUnion(UnionShape unionShape, ObjectNode node) {
            if (node.getMembers().size() == 1) {
                node.getMembers().forEach((keyNode, valueNode) -> {
                    var memberShape = unionShape.getMember(keyNode.getValue())
                            .orElseThrow(() -> new CodegenException("unknown member shape" + keyNode.getValue()));
                    var targetShape = model.expectShape(memberShape.getTarget());
                    writer.openBlock("new $L{", "}", context.symbolProvider().toSymbol(unionShape),
                            () -> writer.write("$L = $C", StringUtils.capitalize(keyNode.getValue()), (Runnable) () -> valueNode.accept(new ValueNodeVisitor(targetShape))));
                });
            } else {
                throw new CodegenException("Only 1 member can be set in a union.");
            }
            return null;
        }

        private Void getMap(MapShape shape, ObjectNode node) {
            var valueTargetShape = model.expectShape(shape.getValue().getTarget());
            var valueTargetSymbol = context.symbolProvider().toSymbol(valueTargetShape);
            if (shape.getTrait(SparseTrait.class).isPresent() && !valueTargetShape.isDocumentShape() && !valueTargetShape.isStringShape() && !valueTargetShape.isEnumShape() && !valueTargetShape.isStructureShape() && !valueTargetShape.isListShape()){
                valueTargetSymbol = valueTargetSymbol.toBuilder().name(valueTargetSymbol.getName() + "?").build();
            }
            writer.write("new Dictionary<string, $L>()",
                    valueTargetSymbol);
            writer.openBlock("{\n", "}",
                    () -> node.getMembers().forEach((keyNode, valueNode) -> {
                        var targetShape = model.expectShape(shape.getValue().getTarget());
                        writer.write("{ $S, $C },",
                                keyNode.getValue(),
                                (Runnable) () -> valueNode.accept(new ValueNodeVisitor(targetShape))
                        );
                    })
            );
            return null;
        }

        private Void getDocument(DocumentShape shape, ObjectNode node) {
            writer.addImport(serviceName, "Amazon.Runtime.Documents", "Documents");
            writer.openBlock("new Document(new Dictionary<string,Document>\n{", "})", () -> node.getMembers().forEach((keyNode, valueNode) -> {
                var targetShape = model.expectShape(shape.getId());
                writer.write("{$S, $C},",
                        keyNode.getValue(),
                        (Runnable) () -> valueNode.accept(new ValueNodeVisitor(targetShape, inNestedDocument = true)));
            }));
            return null;
        }

        @Override
        public Void stringNode(StringNode node) {
            if (inputShape.isFloatShape() || inputShape.isDoubleShape()) {
                var value = switch (node.getValue()) {
                    case "NaN" -> "NaN";
                    case "Infinity" -> "PositiveInfinity";
                    case "-Infinity" -> "NegativeInfinity";
                    default -> throw new CodegenException("Invalid value: " + node.getValue());
                };
                if (inputShape.isFloatShape()) {
                    writer.write("float.$L", value);
                } else {
                    writer.write("double.$L", value);
                }
            } else if (inputShape.isTimestampShape() && isDateTime(node.getValue())) {
                writer.writeInline("ProtocolTestConstants.epoch.AddMilliseconds($L)",
                        OffsetDateTime.parse(node.getValue()).toInstant().toEpochMilli());
            } else if (inputShape.isBlobShape()) {
                var symbol = context.symbolProvider().toSymbol(inputShape);
                writer.write("new $L(Encoding.UTF8.GetBytes($S))", symbol, node.getValue());
            } else {
                writer.writeInline("$S", node.getValue());
            }
            return null;
        }

        private boolean isDateTime(String value) {
            try {
                OffsetDateTime.parse(value);
                return true;
            } catch (DateTimeParseException e) {
                return false;
            }
        }
    }
}
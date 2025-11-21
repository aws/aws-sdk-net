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
import software.amazon.smithy.model.traits.TitleTrait;
import software.amazon.smithy.codegen.core.CodegenException;
import software.amazon.smithy.dotnet.codegen.utils.ProtocolTestUtils;
import software.amazon.smithy.model.Model;
import software.amazon.smithy.model.knowledge.OperationIndex;
import software.amazon.smithy.model.knowledge.TopDownIndex;
import software.amazon.smithy.model.node.*;
import software.amazon.smithy.model.shapes.*;
import software.amazon.smithy.model.traits.Trait;
import software.amazon.smithy.protocoltests.traits.*;
import software.amazon.smithy.utils.StringUtils;
import software.amazon.smithy.dotnet.codegen.customizations.*;

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
        writer.openBlock("public void $LErrorResponse()\n{", "}", httpResponseTestCase.getId(), () -> {
            generateErrorResponseTestBlock(operation, error, httpResponseTestCase);
        });
        writer.write("\n");
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
                if (ProtocolTestCustomizations.TestsToSkip.contains(httpRequestTestCase.getId()) || httpRequestTestCase.hasTag("defaults"))
                    continue;
                generateRequestTest(operation, httpRequestTestCase);
            }
        });
    }

    private void generateRequestTest(OperationShape operation, HttpRequestTestCase httpRequestTestCase) {
        if (httpRequestTestCase.getDocumentation().isPresent()) {
            writer.writeXmlDocs(httpRequestTestCase.getDocumentation().get());
        }
        if (ProtocolTestCustomizations.VNextTests.contains(httpRequestTestCase.getId())) {
            writer.writeMultiLineComment("This test either requires a breaking change and will be addressed in V4, or has a backlog item to be fixed" +
                    " in the future. Please refer to the VNextTests list to see which it is.");
            writer.write("[Ignore]");
        }
        writer.write("[TestMethod]");

        writer.write("[TestCategory(\"ProtocolTest\")]");
        writer.write("[TestCategory(\"RequestTest\")]");
        writer.write("[TestCategory(\"$L\")]", serviceName);
        writer.openBlock("public void $LRequest()\n{", "}", httpRequestTestCase.getId(), () -> {
            generateRequestTestBlock(operation, httpRequestTestCase);
        });
        writer.write("\n");
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
                if (ProtocolTestCustomizations.TestsToSkip.contains(httpResponseTestCase.getId()) || httpResponseTestCase.hasTag("defaults"))
                    continue;
                generateResponseTest(operation, httpResponseTestCase);
            }
        });
    }

    private void generateResponseTest(OperationShape operation, HttpResponseTestCase httpResponseTestCase) {
        if (httpResponseTestCase.getDocumentation().isPresent()) {
            writer.writeXmlDocs(httpResponseTestCase.getDocumentation().get());
        }
        if (ProtocolTestCustomizations.VNextTests.contains(httpResponseTestCase.getId())) {
            writer.writeSingleLineComment("This test requires a breaking change, and will be addressed in V4");
            writer.write("[Ignore]");
        }
        writer.write("[TestMethod]");
        writer.write("[TestCategory(\"ProtocolTest\")]");
        writer.write("[TestCategory(\"ResponseTest\")]");
        writer.write("[TestCategory(\"$L\")]", serviceName);
        writer.openBlock("public void $LResponse()\n{", "}", httpResponseTestCase.getId(), () -> {
            generateResponseTestBlock(operation, httpResponseTestCase);
        });
        writer.write("\n");
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
            if (!generatedInputOutputShapeName.isEmpty()) {
                if (ProtocolTestCustomizations.RestJsonNullMapValueOperations.contains(generatedInputOutputShapeName) && ProtocolTestCustomizations.RestJsonNullMapValueStructures.contains(shape.getId().getName())) {
                    valueTargetSymbol = valueTargetSymbol.toBuilder().name(valueTargetSymbol.getName() + "?").build();
                }
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
            } else if (inputShape.isBlobShape()) {
                var symbol = context.symbolProvider().toSymbol(inputShape);
                writer.write("new $L(Encoding.UTF8.GetBytes($S))", symbol, node.getValue());
            } else {
                writer.writeInline("$S", node.getValue());
            }
            return null;
        }
    }
}
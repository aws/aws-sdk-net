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

import software.amazon.smithy.codegen.core.CodegenException;
import software.amazon.smithy.dotnet.codegen.utils.ProtocolTestUtils;
import software.amazon.smithy.model.Model;
import software.amazon.smithy.model.knowledge.TopDownIndex;
import software.amazon.smithy.model.node.*;
import software.amazon.smithy.model.shapes.*;
import software.amazon.smithy.protocoltests.traits.*;
import software.amazon.smithy.utils.StringUtils;
import software.amazon.smithy.dotnet.codegen.customizations.*;

import java.util.*;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.logging.Logger;


public final class HttpProtocolTestGenerator implements Runnable {
    private static final Logger LOGGER = Logger.getLogger(HttpProtocolTestGenerator.class.getName());
    private final DotnetSettings settings;
    private final Model model;
    private final ServiceShape service;
    private CSharpWriter writer;

    private final DotnetGenerationContext context;
    private final String protocolNamespace;
    private final String protocol;

    private final String projectionName;

    public HttpProtocolTestGenerator(
            DotnetGenerationContext context, String protocol, String projectionName
            ) {
        this.settings = context.settings();
        this.protocolNamespace = context.settings().getService().getName();
        this.model = context.model();
        this.service = settings.getService(model);
        this.context = context;
        this.protocol = protocol;
        this.projectionName = projectionName;

    }

    @Override
    public void run() {
        TopDownIndex topDownIndex = TopDownIndex.of(model);
        var protocolNamespace = settings.getService().getName();
        for (OperationShape operation : new TreeSet<>(topDownIndex.getContainedOperations(service))) {
            var operationName = operation.getId().getName();
            context.writerDelegator().useFileWriter(operationName + ".cs", protocolNamespace, writer -> {
                this.writer = writer;
                writer.addMarshallImports(protocolNamespace, settings.getPackageNamespace());
                writer.addImport(protocolNamespace,"AWSSDK.ProtocolTests.Utils");
                if(protocol.equals("Json")){
                    writer.addImport(protocolNamespace,"Newtonsoft.Json");
                    writer.addImport(protocolNamespace,"Newtonsoft.Json.Linq");
                }
                if(projectionName.equals("RestXmlProtocol") || projectionName.equals("RestXmlProtocolNamespace")){
                    writer.addImport(protocolNamespace,"System.Xml");
                    writer.addImport(protocolNamespace,"System.Xml.Linq");
                }
                writer.addSystemImport(protocolNamespace);
                writer.addCoreImport(protocolNamespace);
                writer.addProtocolTestImports(protocolNamespace);
                writer.openBlock("namespace AWSSDK.ProtocolTests.$L \n{", "}", protocolNamespace, () -> {
                    writer.write("[TestClass]");
                    writer.openBlock("public class $L \n{", "}", operationName, () -> {
                        generateRequestTests(operation);
                        generateResponseTests(operation);
                    });
                });
                context.writerDelegator().flushWriters();
            });
        }
    }
    private void generateRequestTests(OperationShape operation) {
        operation.getTrait(HttpRequestTestsTrait.class).ifPresent(trait -> {
            for(HttpRequestTestCase httpRequestTestCase : trait.getTestCasesFor(AppliesTo.CLIENT)){
                generateRequestTest(operation, httpRequestTestCase);
            }
        });
    }

    private void generateRequestTest(OperationShape operation, HttpRequestTestCase httpRequestTestCase) {
        if(!ProtocolTestCustomizations.TestsToSkip.contains(httpRequestTestCase.getId())){
            writer.write("[TestMethod]");
            writer.write("[TestCategory(\"ProtocolTest\")]");
            writer.write("[TestCategory(\"RequestTest\")]");
            writer.write("[TestCategory(\"$L\")]",protocolNamespace);
            writer.openBlock("public void $LRequest()\n{","}",httpRequestTestCase.getId(), () ->{
                generateRequestTestBlock(operation,httpRequestTestCase);
            });
        }
    }
    private void generateRequestTestBlock(OperationShape operation, HttpRequestTestCase httpRequestTestCase ){
        var params = httpRequestTestCase.getParams();
        var inputShape =  model.expectShape(operation.getInputShape(), StructureShape.class);

        String inputShapeName = operation.getId().getName() + "Request";
        writer.openBlock("var request = new $L{","};",inputShapeName, (Runnable) () -> params.accept(new ValueNodeVisitor(inputShape, true, inputShapeName )));
        var hostList = httpRequestTestCase.getHost().orElse("test.com").split("/",2);
        var host = hostList[0];
        String path;
        if (hostList.length != 1) {
            path = hostList[1];
        } else {
            path = "";
        }
        writer.write("""
                     var config = new $L{
                       ServiceURL = "https://$L/$L"
                     };
                     """, ProtocolTestUtils.getProtocolConfig(settings),host,path);

        writer.write("var marshaller = new $LMarshaller();",inputShapeName);
        writer.write("var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);");

        //verify the body
        if(httpRequestTestCase.getBody().isPresent() && !httpRequestTestCase.getBody().get().equals("")){
            if(protocol.equals("Json")){
                writer.write("var expectedBody = $S;",httpRequestTestCase.getBody());
                writer.write("JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);");

            }
            else if(projectionName.equals("QueryProtocol") || projectionName.equals("EC2Protocol")){
                writer.addImport(protocolNamespace,"System.Net");
                writer.write("var expectedParams = QueryTestUtils.ConvertBodyToParameters($S);", httpRequestTestCase.getBody());
                writer.write("""
                             foreach(var queryParam in expectedParams.Keys){
                                Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
                                Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
                             }                                
                             """);
            }
            else if (projectionName.equals("RestXmlProtocol") || projectionName.equals("RestXmlProtocolNamespace")){
                writer.write("var actualBody = Encoding.UTF8.GetString(marshalledRequest.Content);");
                writer.write("var expectedBody = $S;",httpRequestTestCase.getBody());
                writer.write("XDocument actualDoc = XDocument.Parse(actualBody);");
                writer.write("XDocument expectedDoc = XDocument.Parse(expectedBody);");
                writer.write("Assert.IsTrue(XmlTestUtils.AreDocumentsEqual(expectedDoc, actualDoc));");
            }
            else{
                throw new CodegenException("Unsupported protocol detected while generating request test block.");
            }

        }

        writer.write("Assert.AreEqual($S, marshalledRequest.HttpMethod);",httpRequestTestCase.getMethod());

        // Calling AmazonServiceClient.ComposeUrl to avoid adding the HttpHandler to the mock request pipeline since we don't want
        // to make a network call
        writer.write("Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);");
        writer.write("Assert.AreEqual($S, actualUri.AbsolutePath);", httpRequestTestCase.getUri());

        var headers = httpRequestTestCase.getHeaders();
        for(var header : httpRequestTestCase.getHeaders().keySet()){
            if(header.equals("Content-Type")){
                if(projectionName.equals("QueryProtocol") || projectionName.equals("EC2Protocol")){
                    // the smithy docs https://smithy.io/2.0/aws/protocols/aws-query-protocol.html#request-serialization> use SHALL when describing the content-type
                    // for query based protocols. Since the .NET SDK has sent charset=utf-8 for many years, the assertion here will be more relaxed.
                    writer.write("Assert.AreEqual(\"application/x-www-form-urlencoded; charset=utf-8\",marshalledRequest.Headers[$S]);",header);
                    continue;
                }
            }
            writer.write("Assert.AreEqual( $S, marshalledRequest.Headers[$S]);", headers.get(header), header);
        }

        //Verify the query Params
        if(!httpRequestTestCase.getQueryParams().isEmpty()){
            writer.write("var querySegment = actualUri.Query.Substring(1);");
            writer.write("var actualQuerySegments = querySegment.Split('&');");
            for(var queryParam : httpRequestTestCase.getQueryParams()){
                writer.write("Assert.IsTrue(actualQuerySegments.Contains($S));",queryParam);
            }
        }
    }
    private void generateResponseTests(OperationShape operation) {
        operation.getTrait(HttpResponseTestsTrait.class).ifPresent(trait -> {
            for(HttpResponseTestCase httpResponseTestCase : trait.getTestCasesFor(AppliesTo.CLIENT)){
                generateResponseTest(operation, httpResponseTestCase);
            }
        });
    }

    private void generateResponseTest(OperationShape operation, HttpResponseTestCase httpResponseTestCase) {

        writer.write("[TestMethod]");
        writer.write("[TestCategory(\"ProtocolTest\")]");
        writer.write("[TestCategory(\"ResponseTest\")]");
        writer.write("[TestCategory(\"$L\")]",protocolNamespace);
        writer.openBlock("public void $LResponse()\n{","}",httpResponseTestCase.getId(), () ->{
            generateResponseTestBlock(operation,httpResponseTestCase);
        });
    }

    private void generateResponseTestBlock(OperationShape operation, HttpResponseTestCase httpResponseTestCase) {
        var outputShape =  model.expectShape(operation.getOutputShape(), StructureShape.class);

        var responseSymbol = operation.getId().getName() + "Response";
        writer.write("byte[] bytes = Encoding.ASCII.GetBytes($S);",httpResponseTestCase.getBody());
        writer.write("var stream = new MemoryStream(bytes);");
        writer.write("var webResponseData = new WebResponseData();");
        for(var header: httpResponseTestCase.getHeaders().keySet()){
            writer.write("webResponseData.Headers[$S] = $S;", header, httpResponseTestCase.getHeaders().get(header));
        }
        writer.write("var context = new $LUnmarshallerContext(stream,true,webResponseData);", protocol);

        // only unmarshall the response and assert if a body is present, as per smithy spec
        if(httpResponseTestCase.getBody().isPresent() && !httpResponseTestCase.getBody().equals("")){
            writer.write("var unmarshalledResponse = new $LUnmarshaller().Unmarshall(context);",responseSymbol);
            writer.openBlock("var expectedResponse = new $L{","};",responseSymbol,(Runnable) () -> httpResponseTestCase.getParams().accept(new ValueNodeVisitor(outputShape,true, responseSymbol)));
            writer.write("var actualResponse = ($L)unmarshalledResponse;",responseSymbol);
            writer.write("Comparer.CompareObjects<$L>(expectedResponse,actualResponse);", responseSymbol);
        }

        writer.write("Assert.AreEqual($L, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);",httpResponseTestCase.getCode());


    }

    private final class ValueNodeVisitor implements NodeVisitor<Void> {
        private final Shape inputShape;

        private boolean inDocumentValueNode;

        private boolean isTopLevelInputOrOutput;
        private String generatedInputOutputShapeName;

        private ValueNodeVisitor(Shape inputShape) {
            this.inputShape = inputShape;
            this.generatedInputOutputShapeName = "";
        }
        private ValueNodeVisitor(Shape inputShape, boolean isTopLevelInputOrOutput, String generatedInputOutputShapeName){
            this.inputShape = inputShape;
            this.isTopLevelInputOrOutput = isTopLevelInputOrOutput;
            this.generatedInputOutputShapeName = generatedInputOutputShapeName;
        }
        @Override
        public Void arrayNode(ArrayNode node) {
            if(inputShape.isDocumentShape()){
                inDocumentValueNode = true;
                writer.openBlock("new Document\n{", "}",
                        () -> node.getElements().forEach((valueNode) -> {
                            writer.write("$C,",
                                    (Runnable) () -> valueNode.accept(this)
                            );
                        }));
            }
            else {
                ValueNodeVisitor targetVisitor;
                if (inputShape instanceof CollectionShape){
                    writer.write(" new $L()", context.symbolProvider().toSymbol((CollectionShape) inputShape));
                    var target = model.expectShape(((CollectionShape) inputShape).getMember().getTarget());
                    targetVisitor = new ValueNodeVisitor(target);
                }
                else{
                    targetVisitor = this;
                }

                writer.openBlock("{","}", () -> {
                    node.getElements().forEach(elementNode -> {
                        writer.write("$C, ", (Runnable) () -> elementNode.accept(targetVisitor));
                    });
                });
            }
            return null;
        }

        @Override
        public Void booleanNode(BooleanNode node) {
            if(!inDocumentValueNode && inputShape.isDocumentShape()){
                writer.write("new Document($L)",node.getValue());
            }
            else{
                writer.writeInline("$L", node.getValue());
            }
            return null;
        }

        @Override
        public Void nullNode(NullNode node) {
            if(!inDocumentValueNode && inputShape.isDocumentShape()){
                writer.writeInline("new Document()");
            }
            else{
                writer.writeInline("null");
            }
            return  null;
        }

        @Override
        public Void numberNode(NumberNode node) {
            if(!inDocumentValueNode && inputShape.isDocumentShape()){
                writer.write("new Document($L)",node.getValue());
            }
            else if(inputShape.isTimestampShape()){
                writer.write("ProtocolTestConstants.epoch.AddSeconds($L)", node.getValue());
            }
            else if(inputShape.isFloatShape()){
                writer.writeInline("$LF",node.getValue());
            }
            else{
                writer.writeInline("$L", node.getValue());
            }
            return null;
        }

        private Void getStructure(StructureShape structureShape, ObjectNode node){
            // for a top level input or output, since the name of the request/response is determined by the operation i.e. operation + request
            // we generate that name outside of the value node visitor and only generate structure members
            if(isTopLevelInputOrOutput){
                getStructureMembersShapes(structureShape,node);
            }
            // if it's not a top level input or output, then we create the symbol as we would a normal structure
            // then generate the structure member names.
            else{
                var structureSymbol = context.symbolProvider().toSymbol(structureShape);
                writer.openBlock("new $L{","}",structureSymbol,
                        () -> getStructureMembersShapes(structureShape,node));
            }
            return  null;
        }

        private Void getStructureMembersShapes(StructureShape structureShape, ObjectNode node) {
            node.getMembers().forEach((keyNode,valueNode) -> {
                var memberShape = structureShape.getMember(keyNode.getValue()).orElseThrow(() ->
                        new CodegenException("Unknown member shape: " + keyNode.getValue())
                );
                var targetShape = model.expectShape(memberShape.getTarget());

                writer.write("$L = $C,",
                        context.symbolProvider().toMemberName(memberShape),
                        (Runnable) () -> valueNode.accept(new ValueNodeVisitor(targetShape,false,generatedInputOutputShapeName)));
            });
            return  null;
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
                default:
                    return null;
            }
        }

        private Void getUnion(UnionShape unionShape, ObjectNode node) {
            if (node.getMembers().size() == 1){
               node.getMembers().forEach((keyNode, valueNode) -> {
                   var memberShape = unionShape.getMember(keyNode.getValue())
                           .orElseThrow(() -> new CodegenException("unknown member shape" + keyNode.getValue()));
                   var targetShape = model.expectShape(memberShape.getTarget());
                   writer.openBlock("new $L{","}",context.symbolProvider().toSymbol(unionShape),
                           () -> writer.write("$L = $C", StringUtils.capitalize(keyNode.getValue()), (Runnable) () -> valueNode.accept(new ValueNodeVisitor(targetShape))));
               });
            }
            else{
                throw new CodegenException("Only 1 member can be set in a union.");
            }
            return  null;
        }

        private Void getMap(MapShape shape, ObjectNode node) {
            var valueTargetShape = model.expectShape(shape.getValue().getTarget());
            var valueTargetSymbol = context.symbolProvider().toSymbol(valueTargetShape);
            if(!generatedInputOutputShapeName.isEmpty()){
                if(ProtocolTestCustomizations.RestJsonNullMapValueOperations.contains(generatedInputOutputShapeName) && ProtocolTestCustomizations.RestJsonNullMapValueStructures.contains(shape.getId().getName())){
                    valueTargetSymbol = valueTargetSymbol.toBuilder().name(valueTargetSymbol.getName() + "?").build();
                }
            }

            writer.write("new Dictionary<string, $L>()",
                    valueTargetSymbol);
            writer.openBlock("{", "}",
                    () -> node.getMembers().forEach((keyNode, valueNode) -> {
                        var targetShape = model.expectShape(shape.getValue().getTarget());
                        writer.write("{$S, $C},",
                                keyNode.getValue(),
                                (Runnable) () -> valueNode.accept(new ValueNodeVisitor(targetShape))
                        );
                    })
            );
            return null;
        }
        private Void getDocument(DocumentShape shape, ObjectNode node) {
            writer.addImport(protocolNamespace,"Amazon.Runtime.Documents");
            writer.openBlock("new Document{", "}",
                    () -> node.getMembers().forEach((keyNode, valueNode) -> {
                        if (!inDocumentValueNode) {
                            writer.write("{$S , $C},",
                                    keyNode.getValue(),
                                    //the keyNode's shape is the new input shape for the value node
                                    (Runnable) () -> valueNode.accept(this)
                            );
                        }
                        else{
                            writer.write("$S, $C",
                                    keyNode.getValue(),
                                    (Runnable) () -> valueNode.accept(this));
                        }
                    })
            );
            return null;
        }

        @Override
        public Void stringNode(StringNode node) {
            if(!inDocumentValueNode && inputShape.isDocumentShape()){
                writer.write("new Document($S)", node.getValue());
            }
            else if(inputShape.isFloatShape() || inputShape.isDoubleShape()){
                var value = switch (node.getValue()) {
                    case "NaN" -> "NaN";
                    case "Infinity" -> "PositiveInfinity";
                    case "-Infinity" -> "NegativeInfinity";
                    default -> throw new CodegenException("Invalid value: " + node.getValue());
                };
                if(inputShape.isFloatShape()){
                    writer.write("float.$L", value);
                }
                else{
                    writer.write("double.$L",value);
                }
            }
            else if(inputShape.isBlobShape()){
                var symbol = context.symbolProvider().toSymbol(inputShape);
                writer.write("new $L(Encoding.UTF8.GetBytes($S))", symbol, node.getValue());
            }
            else{
                writer.writeInline("$S",node.getValue());
            }
            return null;
        }
    }
}
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

import software.amazon.smithy.codegen.core.*;
import software.amazon.smithy.model.Model;
import software.amazon.smithy.model.knowledge.OperationIndex;
import software.amazon.smithy.model.shapes.*;
import software.amazon.smithy.utils.StringUtils;

import java.util.logging.Logger;

import static java.lang.String.format;

/**
 * For a list of simple types see <a href = https://smithy.io/2.0/spec/simple-types.html#simple-types>Smithy Simple Types</a>
 * For a list of aggregate types see <a href = https://smithy.io/2.0/spec/aggregate-types.html#>Aggregate Types</a>
 */

public class SymbolVisitor implements SymbolProvider, ShapeVisitor<Symbol> {

    private static final Logger LOGGER = Logger.getLogger(SymbolVisitor.class.getName());
    private final Model model;
    private final DotnetSettings settings;

    private final ServiceShape service;
    private final ReservedWordSymbolProvider.Escaper escaper;

    public SymbolVisitor(Model model, DotnetSettings settings){
        this.model = model;
        this.settings = settings;
        this.service = model.expectShape(settings.getService(), ServiceShape.class);
        var reservedWordsNames = new ReservedWordsBuilder().loadWords(SymbolVisitor.class.getResource("reservedwords.txt"));
        escaper = ReservedWordSymbolProvider.builder()
                .memberReservedWords(reservedWordsNames.build())
                .buildEscaper();
    }

    /**
     *
     * @param shape The smithy shape
     * @return Returns the C# Symbol
     */
    @Override
    public Symbol toSymbol(Shape shape) {
        Symbol symbol = shape.accept(this);
        LOGGER.info(() -> format("Creating symbol from %s: %s", shape, symbol));
        return escaper.escapeSymbol(shape,symbol);
    }
    @Override
    public String toMemberName(MemberShape shape) {
        return StringUtils.capitalize(SymbolProvider.super.toMemberName(shape));
    }

    @Override
    public Symbol blobShape(BlobShape blobShape) {
        return Symbol.builder().name("MemoryStream").putProperty("shape", blobShape).build();
    }

    @Override
    public Symbol booleanShape(BooleanShape booleanShape) {
        return Symbol.builder().name("bool").putProperty("shape", booleanShape).build();
    }

    @Override
    public Symbol listShape(ListShape listShape) {
        var targetShape = model.expectShape(listShape.getMember().getTarget());
        var targetSymbol = targetShape.accept(this);
        return Symbol.builder().name("List<" + targetSymbol + ">").putProperty("list", listShape).build();
    }

    /**
     * Per <a href = https://smithy.io/2.0/spec/aggregate-types.html#map>map type</a>, the key MUST target a string
     */
    @Override
    public Symbol mapShape(MapShape mapShape) {
        var valueShape = model.expectShape(mapShape.getValue().getTarget());
        var valueType = valueShape.accept(this);
        return Symbol.builder().name("Dictionary<string," + valueType + ">").putProperty("map",mapShape).build();
    }

    @Override
    public Symbol byteShape(ByteShape byteShape) {
        return Symbol.builder().name("sbyte").putProperty("sbyte",byteShape).build();
    }

    @Override
    public Symbol shortShape(ShortShape shortShape) {
        return Symbol.builder().name("short").putProperty("short",shortShape).build();
    }

    @Override
    public Symbol integerShape(IntegerShape integerShape) {
        return Symbol.builder().name("int").putProperty("shape", integerShape).build();
    }

    @Override
    public Symbol intEnumShape(IntEnumShape shape) {
        return ShapeVisitor.super.intEnumShape(shape);
    }

    @Override
    public Symbol longShape(LongShape longShape) {
        return Symbol.builder().name("long").putProperty("shape", longShape).build();
    }

    @Override
    public Symbol floatShape(FloatShape floatShape) {
        return Symbol.builder().name("float").putProperty("shape", floatShape).build();
    }

    @Override
    public Symbol documentShape(DocumentShape documentShape) {
        return Symbol.builder().name("Document").putProperty("shape", documentShape).build();
    }

    @Override
    public Symbol doubleShape(DoubleShape doubleShape) {
        return Symbol.builder().name("double").putProperty("shape", doubleShape).build();
    }

    @Override
    public Symbol bigIntegerShape(BigIntegerShape bigIntegerShape) {
        throw new CodegenException("Big Integer shape is not supported by the C# code generator.");
    }

    @Override
    public Symbol bigDecimalShape(BigDecimalShape bigDecimalShape) {
        throw new CodegenException("Big Decimal shape is not supported by the C# code generator");
    }

    @Override
    public Symbol operationShape(OperationShape operationShape) {
        throw new CodegenException(".NET is not a smithy-based code generator and has only implemented protocol test generation. Generating the operation shape is not yet supported.");
    }

    @Override
    public Symbol resourceShape(ResourceShape resourceShape) {
        throw new CodegenException(".NET is not a smithy-based code generator and has only implemented protocol test generation. Generating the resource shape is not yet supported");
    }

    @Override
    public Symbol serviceShape(ServiceShape serviceShape) {
        throw new CodegenException(".NET is not a smithy-based code generator and has only implemented protocol test generation. Generating the service shape is not yet supported");
    }

    @Override
    public Symbol stringShape(StringShape stringShape) {
        var builder = Symbol.builder().putProperty("shape",stringShape).name("string").build();
        return builder;
    }

    @Override
    public Symbol enumShape(EnumShape shape) {
        return ShapeVisitor.super.enumShape(shape);
    }

    @Override
    public Symbol structureShape(StructureShape structureShape) {
        String modeledName = getModeledShapeName(structureShape);
        return Symbol.builder().name(modeledName).putProperty("shape", structureShape).build();
    }

    @Override
    public Symbol unionShape(UnionShape unionShape) {
        return Symbol.builder().name(getModeledShapeName(unionShape)).putProperty("shape", unionShape).build();
    }

    //TODO: Once a full smithy code generator is implemented, this should be updated
    @Override
    public Symbol memberShape(MemberShape memberShape) {
        Shape targetShape = model.getShape(memberShape.getTarget())
                .orElseThrow(() -> new CodegenException("Shape not found: " + memberShape.getTarget()));
        return toSymbol(targetShape);
    }

    @Override
    public Symbol timestampShape(TimestampShape timestampShape) {
        return Symbol.builder().name("DateTime").putProperty("shape", timestampShape).build();
    }

    private String getModeledShapeName(Shape shape){
        //Capitalize the first letter of each word
        return StringUtils.capitalize(shape.getId().getName());
    }
}

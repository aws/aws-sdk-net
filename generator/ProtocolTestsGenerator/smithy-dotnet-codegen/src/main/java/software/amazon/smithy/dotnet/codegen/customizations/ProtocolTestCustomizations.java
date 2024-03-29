package software.amazon.smithy.dotnet.codegen.customizations;

import software.amazon.smithy.dotnet.codegen.utils.ProtocolTestUtils;

import java.util.Arrays;
import java.util.List;

public final class ProtocolTestCustomizations
{
    private ProtocolTestCustomizations(){}

    //These contain collections with nullable values
    public static final List<String> RestJsonNullMapValueOperations = Arrays.asList(
            "JsonMapsRequest",
            "JsonMapsResponse"
    );
    public static final List<String> RestJsonNullMapValueStructures = Arrays.asList(
            "SparseBooleanMap",
            "SparseNumberMap"
    );
    //The rename is written in smithy and since we're generating from the C2J structures we will skip this test.
    public static final List<String> TestsToSkip = Arrays.asList(
            "RestJsonSerializeRenamedStructureUnionValue",
            // We are skipping these idempotency token auto fill tests because we checked that we do automatically fill the token if one is not set
            // but the value changes every time. The test case asserts a static value for the token that we cannot guarantee
            "Ec2ProtocolIdempotencyTokenAutoFill",
            "RestJsonQueryIdempotencyTokenAutoFill",
<<<<<<< HEAD
            "QueryIdempotencyTokenAutoFill"
=======
            "QueryIdempotencyTokenAutoFill",
            "QueryProtocolIdempotencyTokenAutoFill"
>>>>>>> 79f1dfd0267 (add more to the vnext list)

    );
    public static  final  List<String> VNextTests = Arrays.asList(
            // The tests below change the response and are breaking changes. We'll have to fix in V4.
            "XmlNamespaceSimpleScalarProperties",
            "XmlEmptySelfClosedStrings",
            "XmlEmptySelfClosedBlobs",
            "HttpPayloadTraitsWithNoBlobBody",
            "RestJsonHttpPayloadTraitsWithNoBlobBody",
            "QueryXmlEmptySelfClosedBlobs",
            "QuerySimpleScalarProperties",
            "Ec2XmlEmptySelfClosedBlobs",
<<<<<<< HEAD
            "Ec2SimpleScalarProperties"
=======
            "Ec2SimpleScalarProperties",
            " SimpleScalarPropertiesPureWhiteSpace",
            //The tests below require a change in how empty collections are handled. These will be handled in v3.9
            "XmlEmptyLists",
            "XmlEmptyMaps",
            "Ec2EmptyQueryLists",
            "EmptyQueryLists",
            "serializes_empty_list_shapes",
            "serializes_empty_map_shapes"
>>>>>>> 79f1dfd0267 (add more to the vnext list)
    );
}

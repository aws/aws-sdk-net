package software.amazon.smithy.dotnet.codegen.customizations;

import software.amazon.smithy.dotnet.codegen.utils.ProtocolTestUtils;

import java.util.Arrays;
import java.util.List;

public final class ProtocolTestCustomizations {
    private ProtocolTestCustomizations() {
    }

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
            "ResponseCodeHttpFallback",
            // We are skipping these idempotency token auto fill tests because we checked that we do automatically fill the token if one is not set
            // but the value changes every time. The test case asserts a static value for the token that we cannot guarantee
            "Ec2ProtocolIdempotencyTokenAutoFill",
            "RestJsonQueryIdempotencyTokenAutoFill",
            "QueryIdempotencyTokenAutoFill",
            "QueryProtocolIdempotencyTokenAutoFill",
            // Unit is not supported in C2J.
            "RestJsonInputUnionWithUnitMember",
            "RestJsonOutputUnionWithUnitMember",
            // These tests, which include sparse collections were updated to a separate operation in smithy v1.47,
            // but the smithy2c2j has not been updated yet.
            "RestJsonLists",
            "RestJsonListsEmpty",
            "RestJsonSparseListsSerializeNull",
            "RestJsonSparseListsSerializeNull",
            "RestJsonJsonMaps",
            "RestJsonSerializesZeroValuesInMaps",
            "RestJsonSerializesDenseSetMap",
            "RestJsonDeserializesDenseSetMapAndSkipsNull",
            "RestJsonSerializesNullMapValues",
            "RestJsonSerializesSparseSetMap",
            "RestJsonSerializesSparseSetMapAndRetainsNull",
            "RestJsonDeserializesNullMapValues",
            "RestJsonDeserializesZeroValuesInMaps",
            "RestJsonDeserializesSparseSetMap",
            "RestJsonDeserializesDenseSetMap",
            "RestJsonDeserializesSparseSetMapAndRetainsNull",
            "RestJsonListsSerializeNull",
            "RestJsonListsSerializeNull",
            "AwsJson11SparseMapsSerializeNullValues",
            "AwsJson11StructuresDontSerializeNullValues",
            "AwsJson11StructuresDontDeserializeNullValues",
            "AwsJson11SparseListsSerializeNull",
            "AwsJson11SparseMapsDeserializeNullValues",
            "AwsJson11SparseListsDeserializeNull",
            "AwsJson11MapsSerializeNullValues",
            "AwsJson11ListsSerializeNull",
            "AwsJson11MapsDeserializeNullValues",
            "AwsJson11ListsDeserializeNull",
            // guided by smithy team to skip operations / tests with mediaType that don't end up as json value traits in c2j
            // and to skip test that interact with default or sparse
            "RestJsonStreamingTraitsWithMediaTypeWithBlob",
            "RestJsonStreamingTraitsWithBlob",
            "RestJsonStreamingTraitsWithNoBlobBody",
            "RestJsonStreamingTraitsRequireLengthWithBlob",
            "RestJsonStreamingTraitsRequireLengthWithNoBlobBody",
            "RestJsonHttpPayloadTraitsWithMediaTypeWithBlob",
            "HttpPayloadTraitsWithMediaTypeWithBlob",
            "AwsJson10ClientPopulatesDefaultValuesInInput",
            "AwsJson10ClientSkipsTopLevelDefaultValuesInInput",
            "AwsJson10ClientUsesExplicitlyProvidedMemberValuesOverDefaults",
            "AwsJson10ClientUsesExplicitlyProvidedValuesInTopLevel",
            "AwsJson10ClientIgnoresNonTopLevelDefaultsOnMembersWithClientOptional",
            "AwsJson10ClientPopulatesDefaultsValuesWhenMissingInResponse",
            "AwsJson10ClientIgnoresDefaultValuesIfMemberValuesArePresentInResponse",
            "AwsJson10ClientPopulatesNestedDefaultValuesWhenMissing",
            "AwsJson10ClientPopulatesNestedDefaultsWhenMissingInResponseBody",
            "AwsJson10ClientErrorCorrectsWhenServerFailsToSerializeRequiredValues",
            "AwsJson10ClientErrorCorrectsWithDefaultValuesWhenServerFailsToSerializeRequiredValues",
            //These tests are not yet supported in the SDK.
            "NestedStructures",
            "Ec2NestedStructures",
            "RecursiveShapes",
            "XmlUnionsWithStructMember",
            "XmlUnionsWithStringMember",
            "XmlUnionsWithBooleanMember",
            "XmlUnionsWithUnionMember"

    );
    public static final List<String> VNextTests = Arrays.asList(
            // The tests below change the response and are breaking changes. We'll have to fix in V4.
            "XmlNamespaceSimpleScalarProperties",
            "XmlEmptySelfClosedStrings",
            "XmlEmptySelfClosedBlobs",
            "HttpPayloadTraitsWithNoBlobBody",
            "RestJsonHttpPayloadTraitsWithNoBlobBody",
            "QueryXmlEmptySelfClosedBlobs",
            "QuerySimpleScalarProperties",
            "Ec2XmlEmptySelfClosedBlobs",
            "Ec2SimpleScalarProperties",
            "SimpleScalarPropertiesPureWhiteSpace",
            //The tests below require a change in how empty collections are handled. These will be handled in vNext
            "XmlEmptyLists",
            "XmlEmptyMaps",
            "Ec2EmptyQueryLists",
            "EmptyQueryLists",
            "serializes_empty_list_shapes",
            "serializes_empty_map_shapes",
            // These tests are not actually breaking change but have their own backlog item to be addressed.
            // To avoid creating yet another list to check we'll add these here so they have an ignore flag.
            "XmlMapsXmlName",
            "FlattenedXmlMapWithXmlName",
            "RestXmlFlattenedXmlMapWithXmlNamespace",
            "QueryQueryXmlMapsXmlName",
            "QueryQueryFlattenedXmlMapWithXmlName",
            "QueryQueryFlattenedXmlMapWithXmlNamespace",
            "QueryEmptyInputAndEmptyOutput",
            "QueryNoInputAndNoOutput",
            "QueryNoInputAndOutput",
            "RestJsonToleratesRegexCharsInSegments",
            "RestXmlXmlMapWithXmlNamespace"
    );
}
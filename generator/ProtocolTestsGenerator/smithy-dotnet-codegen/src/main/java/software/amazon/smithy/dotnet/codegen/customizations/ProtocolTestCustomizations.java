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
            "JsonMapsResponse",
            "SparseJsonMapsRequest",
            "SparseJsonMapsResponse"
    );
    public static final List<String> RestJsonNullMapValueStructures = Arrays.asList(
            "SparseBooleanMap",
            "SparseNumberMap"
    );
    
    // These operations don't exist in C2J
    public static final List<String> OperationsToSkip = Arrays.asList(
            "RpcV2CborSparseMaps",
            "OperationWithDefaults",
            "SparseNullsOperation"
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
            "XmlUnionsWithUnionMember",
            // the .NET SDK will not support these tests as the service should be sending back valid xml in the response even if
            // the response is empty. Net's built-in xml serializer throws an exception if no root element is present and we do not want
            // to use exceptions and control flow.
            "QueryEmptyInputAndEmptyOutput",
            "QueryNoInputAndNoOutput",
            "QueryNoInputAndOutput",
            // this test is skipped because in the C2J Ruby added a hook which adds the "code" json key which can NEVER exist in a
            // non-query protocol. this causes our code generation to check on this code instead of what is modeled and our protocol
            // test passes. As this can never happen in a real service, we can skip this to avoid unnecessary customizations in the generator
            // for a scenario that will never happen.
            "QueryCompatibleAwsJson10CustomCodeError"
    );
    public static final List<String> VNextTests = Arrays.asList(
            //These are the tests that are failing in v4 after updating to 1.54.0 and artifacts 1.0.3004.0. Each one needs to be investigated.
    );
}
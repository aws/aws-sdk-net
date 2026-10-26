package software.amazon.smithy.dotnet.codegen.customizations;

import software.amazon.smithy.dotnet.codegen.utils.ProtocolTestUtils;

import java.util.Arrays;
import java.util.List;

public final class ProtocolTestCustomizations {
    private ProtocolTestCustomizations() {
    }

    // These operations don't exist in C2J
    public static final List<String> OperationsToSkip = Arrays.asList(
            "OperationWithDefaults"
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
            "QueryCompatibleAwsJson10CustomCodeError",
            // a recent update to smithy version 1.68 changed the expected response of this protocol test and updating it now would be a breaking change
            // so this test is added to the ignore list.
            "RestJsonIgnoreQueryParamsInResponse",
            //These tests are failing since updating to 1.73.0 and should be evaluated whether to fix or not
            "QueryNoInputAndNoOutputWithResponseMetadata",
            // The ec2Query protocol omits empty lists from the request, but the .NET EC2 query marshaller
            // serializes an empty list as an empty-valued param (e.g. "ListArg="). This is a pre-existing
            // SDK discrepancy surfaced by the mocked request tests' no-extra-params assertion. Skipping
            // until the marshaller is fixed to omit empty lists for ec2Query.
            "Ec2EmptyQueryLists",
            // These tests publish an error event on the input event stream. The SDK generates error events as exceptions,
            // which don't implement IEventStreamEvent, so they can't be published by the client and the generated tests
            // would not compile. Skipping until the SDK supports publishing error events on input event streams.
            "ClientErrorInput",
            "DuplexClientErrorInput",
            // These tests expect the client to reject an initial response missing a required member. The SDK doesn't
            // validate required members when unmarshalling responses, in line with Smithy's client error correction.
            // Adding that validation would be a breaking change: responses that unmarshall today (with the member left
            // null) would start throwing, for every service whose responses omit a member its model marks @required.
            "MissingRequiredInitialResponseOutput",
            "DuplexMissingRequiredInitialResponseOutput",
            // The RestJson test service model (smithy.json) models the byte and short event headers as Integer, unlike the protocol test model.
            // The protocol test model (definied in https://github.com/smithy-lang/smithy/blob/f9d0f0fde5d28b76aa99024bff0baeacaf40acaf/smithy-aws-protocol-tests/model/restJson1/event-stream.smithy#L31)
            // defines the byte and short headers appropriately as byte and short. So this is a conversion issue from .smithy -> JSON AST.
            // The SDK reads them with AsInt32(), which can't unbox the SByte/Int16 header values the tests send. Skipping until the test
            // service model matches the protocol test model.
            "ByteHeaderOutput",
            "ShortHeaderOutput",
            "DuplexByteHeaderOutput",
            "DuplexShortHeaderOutput"
    );
}
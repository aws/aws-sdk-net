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
            "RestJsonSerializeRenamedStructureUnionValue"
    );
}

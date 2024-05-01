package software.amazon.smithy.dotnet.codegen.utils;

import software.amazon.smithy.codegen.core.CodegenException;
import software.amazon.smithy.codegen.core.Symbol;
import software.amazon.smithy.dotnet.codegen.DotnetGenerationContext;
import software.amazon.smithy.dotnet.codegen.DotnetSettings;

/**
 * Utility class for protocol tests
 */
public final class ProtocolTestUtils {
    private ProtocolTestUtils() {
    }

    /**
     * @param namespace This is derived from the sdkId field of the Service trait
     * @return The config for the service
     */

    public static Symbol getProtocolConfig(String namespace) {
        return Symbol.builder().name("Amazon" + namespace + "Config").build();
    }
}

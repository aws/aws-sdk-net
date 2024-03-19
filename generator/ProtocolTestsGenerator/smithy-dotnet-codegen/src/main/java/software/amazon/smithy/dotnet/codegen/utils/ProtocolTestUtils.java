package software.amazon.smithy.dotnet.codegen.utils;

import software.amazon.smithy.codegen.core.CodegenException;
import software.amazon.smithy.codegen.core.Symbol;
import software.amazon.smithy.dotnet.codegen.DotnetGenerationContext;
import software.amazon.smithy.dotnet.codegen.DotnetSettings;

/**
 * Utility class for protocol tests
 */
public final class ProtocolTestUtils {
    private ProtocolTestUtils(){}

    /**
     *
     * @param  settings The settings object
     * @see software.amazon.smithy.dotnet.codegen.DotnetSettings
     * @return Returns the C# config class for a given test protocol.
     */

    public static Symbol getProtocolConfig(DotnetSettings settings){
        //The packageNamespace for a protocol will always be in the format Amazon.<serviceName>
        String namespace = settings.getPackageNamespace();
        String[] packageNamespaceSplit = namespace.split("\\.");
        if(packageNamespaceSplit.length != 2){
            throw new CodegenException("The packageNamespace format in the smithy-build.json file is in the wrong format. Please make sure that is in the format" +
                    "Amazon.<ServiceName>");
        }
        String configPrefix = String.join("",packageNamespaceSplit);
        return Symbol.builder().name(configPrefix +  "Config").build();
    }


}

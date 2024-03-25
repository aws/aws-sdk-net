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
import com.sun.java.accessibility.util.TopLevelWindowListener;
import software.amazon.smithy.build.PluginContext;
import software.amazon.smithy.build.SmithyBuildPlugin;
import software.amazon.smithy.codegen.core.CodegenException;
import software.amazon.smithy.codegen.core.ReservedWordSymbolProvider;
import software.amazon.smithy.codegen.core.Symbol;
import software.amazon.smithy.codegen.core.SymbolReference;
import software.amazon.smithy.codegen.core.directed.CodegenDirector;
import software.amazon.smithy.codegen.core.directed.CreateContextDirective;
import software.amazon.smithy.codegen.core.directed.DirectedCodegen;
import software.amazon.smithy.dotnet.codegen.utils.ProtocolTestUtils;
import software.amazon.smithy.model.Model;
import software.amazon.smithy.model.knowledge.OperationIndex;
import software.amazon.smithy.model.knowledge.TopDownIndex;
import software.amazon.smithy.model.neighbor.Walker;
import software.amazon.smithy.model.node.Node;
import software.amazon.smithy.model.node.ObjectNode;
import software.amazon.smithy.model.node.StringNode;
import software.amazon.smithy.model.shapes.*;
import software.amazon.smithy.model.traits.HttpErrorTrait;
import software.amazon.smithy.model.traits.InputTrait;
import software.amazon.smithy.model.traits.OutputTrait;
import software.amazon.smithy.model.transform.ModelTransformer;
import software.amazon.smithy.protocoltests.traits.AppliesTo;
import software.amazon.smithy.protocoltests.traits.HttpRequestTestCase;
import software.amazon.smithy.protocoltests.traits.HttpRequestTestsTrait;
import software.amazon.smithy.protocoltests.traits.HttpResponseTestsTrait;
import java.util.Optional;

public class DotnetClientCodegenPlugin implements SmithyBuildPlugin {
    @Override
    public String getName() {
        return "dotnet-codegen";
    }

    @Override
    public void execute(PluginContext context) {
        Model model = context.getModel();
        DotnetSettings dotnetSettings = DotnetSettings.from(context.getSettings());
        ModelTransformer transformer = ModelTransformer.create();
        Model transformedModel = transformer.flattenAndRemoveMixins(model);
        SymbolVisitor visitor = new SymbolVisitor(transformedModel, dotnetSettings);
        DotnetGenerationContext generationContext = DotnetGenerationContext.builder().model(transformedModel)
                .settings(dotnetSettings)
                .delegator(new DotnetDelegator(context.getFileManifest(), visitor, dotnetSettings))
                .symbolProvider(visitor)
                .fileManifest(context.getFileManifest())
                .build();

        HttpProtocolTestGenerator testGenerator = getHttpProtocolTestGenerator(context, generationContext);
        testGenerator.run();
    }

    private static HttpProtocolTestGenerator getHttpProtocolTestGenerator(PluginContext context, DotnetGenerationContext generationContext) {
        var projectionName = context.getProjectionName();
        HttpProtocolTestGenerator testGenerator;
        if (projectionName.toLowerCase().contains("json")){
            testGenerator = new HttpProtocolTestGenerator(generationContext,"Json", projectionName);
        }
        else if (projectionName.toLowerCase().contains("xml") || projectionName.toLowerCase().contains("query") || projectionName.toLowerCase().contains("ec2")){
            testGenerator = new HttpProtocolTestGenerator(generationContext, "Xml", projectionName);
        }
        else{
            throw new CodegenException("The given protocol is not supported");
        }
        return testGenerator;
    }
}
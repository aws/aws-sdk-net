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

import software.amazon.smithy.build.PluginContext;
import software.amazon.smithy.build.SmithyBuildPlugin;
import software.amazon.smithy.model.Model;
import software.amazon.smithy.model.transform.ModelTransformer;

public class DotnetProtocolTestCodegenPlugin implements SmithyBuildPlugin {
    @Override
    public String getName() {
        return "dotnet-protocol-test-codegen";
    }

    @Override
    public void execute(PluginContext context) {
        Model model = context.getModel();
        DotnetSettings dotnetSettings = DotnetSettings.from(context.getSettings());
        ModelTransformer transformer = ModelTransformer.create();
        Model transformedModel = transformer.flattenAndRemoveMixins(model);
        SymbolVisitor visitor = new SymbolVisitor(transformedModel, dotnetSettings);
        DotnetGenerationContext generationContext = DotnetGenerationContext.builder()
                .model(transformedModel)
                .settings(dotnetSettings)
                .delegator(new CSharpDelegator(context.getFileManifest(), visitor, dotnetSettings))
                .symbolProvider(visitor)
                .fileManifest(context.getFileManifest())
                .build();
        var testGenerator = new HttpProtocolTestGenerator(generationContext);
        testGenerator.run();
        generationContext.writerDelegator().flushWriters();
    }
}
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

import software.amazon.smithy.build.FileManifest;
import software.amazon.smithy.codegen.core.CodegenContext;
import software.amazon.smithy.codegen.core.SymbolProvider;
import software.amazon.smithy.codegen.core.WriterDelegator;
import software.amazon.smithy.model.Model;
import software.amazon.smithy.utils.SmithyBuilder;
import software.amazon.smithy.utils.ToSmithyBuilder;

import java.util.List;

public class DotnetGenerationContext implements CodegenContext<DotnetSettings, CSharpWriter, DotnetIntegration>, ToSmithyBuilder<DotnetGenerationContext> {
    private final Model model;
    private final DotnetSettings settings;
    private final SymbolProvider symbolProvider;
    private final FileManifest fileManifest;
    private final CSharpDelegator delegator;
    private final List<DotnetIntegration> integrations;

    private DotnetGenerationContext(Builder builder) {
        model = builder.model;
        settings = builder.settings;
        symbolProvider = builder.symbolProvider;
        fileManifest = builder.fileManifest;
        delegator = builder.delegator;
        integrations = builder.integrations;
    }

    @Override
    public Model model() {
        return model;
    }

    @Override
    public DotnetSettings settings() {
        return settings;
    }

    @Override
    public SymbolProvider symbolProvider() {
        return symbolProvider;
    }

    @Override
    public FileManifest fileManifest() {
        return fileManifest;
    }

    @Override
    public WriterDelegator<CSharpWriter> writerDelegator() {
        return delegator;
    }

    @Override
    public List<DotnetIntegration> integrations() {
        return integrations;
    }

    public static Builder builder() {
        return new Builder();
    }

    @Override
    public SmithyBuilder<DotnetGenerationContext> toBuilder() {
        return builder()
                .model(model)
                .settings(settings)
                .symbolProvider(symbolProvider)
                .fileManifest(fileManifest)
                .delegator(delegator)
                .integrations(integrations);
    }

    public static final class Builder implements SmithyBuilder<DotnetGenerationContext> {
        private SymbolProvider symbolProvider;
        private FileManifest fileManifest;
        private CSharpDelegator delegator;
        private List<DotnetIntegration> integrations;
        private DotnetSettings settings;
        private Model model;

        /**
         * @param symbolProvider The symbol provider for the generator
         * @return Returns the Builder
         */
        public Builder symbolProvider(SymbolProvider symbolProvider) {
            this.symbolProvider = symbolProvider;
            return this;
        }

        /**
         * @param fileManifest The file manifest for the generator
         * @return Returns the builder
         */
        public Builder fileManifest(FileManifest fileManifest) {
            this.fileManifest = fileManifest;
            return this;
        }

        public Builder delegator(CSharpDelegator delegator) {
            this.delegator = delegator;
            return this;
        }

        public Builder integrations(List<DotnetIntegration> integrations) {
            this.integrations = integrations;
            return this;
        }

        public Builder settings(DotnetSettings settings) {
            this.settings = settings;
            return this;
        }

        public Builder model(Model model) {
            this.model = model;
            return this;
        }

        @Override
        public DotnetGenerationContext build() {
            return new DotnetGenerationContext(this);
        }
    }

}

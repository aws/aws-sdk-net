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
import software.amazon.smithy.codegen.core.SymbolProvider;
import software.amazon.smithy.codegen.core.WriterDelegator;

/**
 * Manages writers for C# Files
 */
public class CSharpDelegator extends WriterDelegator<CSharpWriter> {

    public CSharpDelegator(FileManifest fileManifest, SymbolProvider symbolProvider, DotnetSettings settings) {
        super(fileManifest, symbolProvider, new CSharpWriter.CSharpWriterFactory(settings));
    }
}

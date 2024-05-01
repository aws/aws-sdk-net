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

import software.amazon.smithy.codegen.core.SymbolWriter;
import software.amazon.smithy.utils.StringUtils;

import java.util.List;
import java.util.logging.Logger;


public final class CSharpWriter extends SymbolWriter<CSharpWriter, DotnetImportContainer> {

    private static final Logger LOGGER = Logger.getLogger(CSharpWriter.class.getName());
    private final String fullyQualifiedNamespace;

    private boolean isCodeGen = true;


    /**
     * @param fullyQualifiedNamespace The fully qualified namespace that this writer belongs to
     * @param settings                The DotnetSettings associated with this writer
     */
    public CSharpWriter(String fullyQualifiedNamespace, DotnetSettings settings) {
        super(new DotnetImportContainer(fullyQualifiedNamespace));
        this.fullyQualifiedNamespace = fullyQualifiedNamespace;
        trimBlankLines();
        trimTrailingSpaces();

        //TODO: Custom Formatter
        setRelativizeSymbols(fullyQualifiedNamespace);
    }

    /**
     * @param namespace The namespace to add the import to
     * @param name      The name of the package
     * @return Returns the CSharpWriter
     */
    public CSharpWriter addImport(String namespace, String name) {
        getImportContainer().addImport(namespace, name);
        return this;
    }

    public CSharpWriter addImport(String namespace, String name, String alias) {
        getImportContainer().addImport(namespace, name, alias);
        return this;
    }

    /**
     * This function adds the packages in the systemImports list from DotnetImportContainer
     *
     * @param namespace The namespace to add the package to.
     * @return Returns the CSharpWriter
     * @see DotnetImportContainer
     */
    public CSharpWriter addSystemImport(String namespace) {
        getImportContainer().addSystemImport(namespace);
        return this;
    }

    public CSharpWriter writeMultiLineComment(String comment) {
        pushState();
        write("/* ");
        setNewlinePrefix("* ");
        write(formatDocs(comment));
        write("*/");
        popState();
        return this;
    }

    public CSharpWriter writeSingleLineComment(String comment) {
        write("// " + comment);
        return this;
    }

    public CSharpWriter writeXmlDocs(String comment) {
        pushState();
        setNewlinePrefix("/// ");
        write("<summary>");
        write(formatDocs(comment));
        write("</summary>");
        popState();
        return this;
    }

    /**
     * Refer to the following link to see why 65 was used as the line break.
     * <a href = https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions#style-guidelines>C# Style Guidelines</a>
     */
    public String formatDocs(String docs) {
        return StringUtils.wrap(docs.replace("\n", " "), 65);
    }

    @Override
    public String toString() {
        String content = getImportContainer().toString() + super.toString();
        String license = Templates.getCopyrightHeader();
        if (isCodeGen) {
            license = license + Templates.getGeneratedWarning();
        }
        content = license + content;
        return content;
    }

    /**
     * This function adds the packages in the coreImports list from DotnetImportContainer
     *
     * @param namespace The namespace to add the package to
     * @return The CSharpWriter
     * @see DotnetImportContainer
     */
    public CSharpWriter addCoreImport(String namespace) {
        getImportContainer().addCoreImport(namespace);
        return this;
    }

    public CSharpWriter addMarshallImports(String namespace, String service) {
        getImportContainer().addMarshallImports(namespace, service);
        return this;
    }

    public CSharpWriter addProtocolTestImports(String namespace) {
        getImportContainer().addProtocolTestImports(namespace);
        return this;
    }

    /**
     * The Factory class for creating CSharpWriters
     */
    public static final class CSharpWriterFactory implements SymbolWriter.Factory<CSharpWriter> {

        private final DotnetSettings settings;

        /**
         * Constructs a CSharpWriterFactory
         *
         * @param settings The dotnet settings associated with this factory
         */

        public CSharpWriterFactory(DotnetSettings settings) {
            this.settings = settings;
        }

        @Override
        public CSharpWriter apply(String filename, String namespace) {
            return new CSharpWriter(namespace, settings);
        }
    }
}
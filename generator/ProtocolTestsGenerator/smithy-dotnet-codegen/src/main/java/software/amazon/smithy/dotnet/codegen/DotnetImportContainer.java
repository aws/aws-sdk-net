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

import software.amazon.smithy.codegen.core.ImportContainer;
import software.amazon.smithy.codegen.core.Symbol;

import java.util.List;
import java.util.Arrays;
import java.util.TreeMap;
import java.util.Map;

public final class DotnetImportContainer implements ImportContainer {
    private static final List<String> systemImports = Arrays.asList(
            "System",
            "System.Text",
            "System.Linq",
            "System.IO",
            "System.Collections.Generic"
    );
    private static final List<String> coreImports = Arrays.asList(
            "Amazon.Runtime",
            "Amazon.Runtime.Internal",
            "Amazon.Runtime.Internal.Transform"
    );
    private static final List<String> protocolTestImports = Arrays.asList(
            "AWSSDK.ProtocolTests",
            "Microsoft.VisualStudio.TestTools.UnitTesting",
            "Amazon.Runtime.Internal.Transform",
            "AWSSDK_DotNet.UnitTests.TestTools"
    );
    private final Map<String, Map<String, String>> imports = new TreeMap<>();
    private final String localNamespace;

    public DotnetImportContainer(String namespace) {
        this.localNamespace = namespace;

    }

    @Override
    public void importSymbol(Symbol symbol, String alias) {
        var symbolNamespace = symbol.getNamespace();

        // Only import symbols in other namespaces.
        if (!symbolNamespace.equals(localNamespace)) {
            var namespaceImports = imports.computeIfAbsent(symbolNamespace, ns -> new TreeMap<>());
            namespaceImports.put(symbol.getName(), alias);
        }
    }

    public ImportContainer addImport(String namespace, String name) {
        return addImport(namespace, name, name);
    }

    public ImportContainer addImport(String namespace, String name, String alias) {
        Map<String, String> namespaceImports = imports.computeIfAbsent(namespace, ns -> new TreeMap<>());
        namespaceImports.put(name, alias);
        return this;
    }

    @Override
    public String toString() {
        if (imports.isEmpty()) {
            return "";
        }
        var builder = new StringBuilder();
        for (var entry : imports.entrySet()) {
            String formattedUsingStatements = formatNamespaceEntries(entry.getKey(), entry.getValue());
            builder.append(formattedUsingStatements);
        }
        builder.append("\n");
        return builder.toString();
    }

    public String formatNamespaceEntries(String namespace, Map<String, String> namespaceImports) {
        var builder = new StringBuilder();
        for (var entry : namespaceImports.entrySet()) {
            builder.append("using ").append(entry.getKey()).append(";\n");
        }
        return builder.toString();
    }

    public void addSystemImport(String namespace) {
        for (String systemImport : systemImports) {
            addImport(namespace, systemImport);
        }
    }

    public void addCoreImport(String namespace) {
        for (String coreImport : coreImports) {
            addImport(namespace, coreImport);
        }
    }

    public void addMarshallImports(String namespace, String service) {
        addImport(namespace, service);
        addImport(namespace, service + ".Model");
        addImport(namespace, service + ".Model.Internal.MarshallTransformations");
    }

    public void addProtocolTestImports(String namespace) {
        for (String protocolTestImport : protocolTestImports) {
            addImport(namespace, protocolTestImport);
        }
    }
}

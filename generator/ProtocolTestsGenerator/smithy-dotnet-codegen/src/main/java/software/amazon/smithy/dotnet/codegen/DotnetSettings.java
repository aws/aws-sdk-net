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


import software.amazon.smithy.model.Model;
import software.amazon.smithy.model.shapes.ServiceShape;
import software.amazon.smithy.model.shapes.ShapeId;
import software.amazon.smithy.utils.SmithyUnstableApi;
import software.amazon.smithy.model.node.ObjectNode;
import software.amazon.smithy.codegen.core.CodegenException;

import java.util.Objects;

/**
 * The DotnetSettings class maps to keys and values of the smithy-build.json file
 */
@SmithyUnstableApi
public final class DotnetSettings {
    private static final String SERVICE = "service";
    private static final String PACKAGE_NAME = "package";
    private static final String PACKAGE_VERSION = "packageVersion";
    private static final String PACKAGE_NAMESPACE = "packageNamespace";
    private ShapeId service;
    /*
    The packageName is the name of the nuget package. For example S3 is AWSSDK.S3
     */
    private String packageName;

    /*
    The packageNamespace is the base namespace of a service. For example, S3 would be
    AmazonS3. It is essentially replacing the prefix for the packageName with Amazon.
     */
    private String packageNamespace;
    private String packageVersion;

    public static DotnetSettings from(ObjectNode config) {
        DotnetSettings settings = new DotnetSettings();
        settings.setService(config.expectStringMember(SERVICE).expectShapeId());
        settings.setPackageName(config.expectStringMember(PACKAGE_NAME).getValue());
        settings.setPackageVersion(config.expectStringMember(PACKAGE_VERSION).getValue());
        settings.setPackageNamespace(config.expectStringMember(PACKAGE_NAMESPACE).getValue());
        return settings;
    }

    /**
     * @return Returns the version of the package.
     */
    public String getPackageVersion() {
        return packageVersion;
    }

    private void setPackageVersion(String packageVersion) {
        this.packageVersion = Objects.requireNonNull(packageVersion);
    }

    /**
     * @return Returns the name of the package, which is the equivalent of the nuget package name.
     * For example S3 would be AWSSDK.S3
     */
    public String getPackageName() {
        return packageName;
    }

    private void setPackageName(String packageName) {
        this.packageName = Objects.requireNonNull(packageName);
    }

    /**
     * @return Returns the namespace of the package. This is the namespace that is used within the package.
     * For example for S3, if the packageName is AWSSDK.S3 then the packageNamespace is Amazon.S3
     */
    public String getPackageNamespace() {
        return packageNamespace;
    }

    private void setPackageNamespace(String packageNamespace) {
        this.packageNamespace = Objects.requireNonNull(packageNamespace);
    }

    private void setService(ShapeId service) {
        this.service = Objects.requireNonNull(service);
    }

    /**
     * Gets the id of the service that is being generated.
     *
     * @return Returns the service id.
     * @throws NullPointerException if the service has not been set.
     */
    public ShapeId getService() {
        return Objects.requireNonNull(service, SERVICE + " not set");
    }

    /**
     * Gets the corresponding {@link ServiceShape} from a model.
     *
     * @param model Model to search for the service shape by ID.
     * @return Returns the found {@code Service}.
     * @throws NullPointerException if the service has not been set.
     * @throws CodegenException     if the service is invalid or not found.
     */
    public ServiceShape getService(Model model) {
        return model
                .getShape(getService())
                .orElseThrow(() -> new CodegenException("Service shape not found: " + getService()))
                .asServiceShape()
                .orElseThrow(() -> new CodegenException("Shape is not a Service: " + getService()));
    }
}

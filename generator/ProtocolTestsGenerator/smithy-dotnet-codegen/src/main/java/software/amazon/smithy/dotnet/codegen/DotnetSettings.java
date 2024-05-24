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
    private static final String PACKAGE_VERSION = "packageVersion";
    private ShapeId service;
    private String packageVersion;

    public static DotnetSettings from(ObjectNode config) {
        DotnetSettings settings = new DotnetSettings();
        settings.setService(config.expectStringMember(SERVICE).expectShapeId());
        settings.setPackageVersion(config.expectStringMember(PACKAGE_VERSION).getValue());
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
     * Gets the id of the service that is being generated.
     *
     * @return Returns the service id.
     * @throws NullPointerException if the service has not been set.
     */
    public ShapeId getService() {
        return Objects.requireNonNull(service, SERVICE + " not set");
    }

    private void setService(ShapeId service) {
        this.service = Objects.requireNonNull(service);
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

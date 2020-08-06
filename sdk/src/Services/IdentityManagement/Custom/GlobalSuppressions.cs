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

using System.Diagnostics.CodeAnalysis;
// Don't reference RegionEndpoints in the SDK unless absolutely necessary.
[module: SuppressMessage("AwsSdkRules", "CR1004:PreventRegionEndpointUseRule", Scope = "member", Target = "Amazon.IdentityManagement.AmazonIdentityManagementServiceConfig.#.ctor()")]
// Types names matching namespaces
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.IdentityManagement.Model.Policy")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.IdentityManagement.Model.GetOpenIDConnectProviderResult.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.IdentityManagement.Model.CreateOpenIDConnectProviderRequest.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.IdentityManagement.Model.GetOpenIDConnectProviderResponse.#Url")]
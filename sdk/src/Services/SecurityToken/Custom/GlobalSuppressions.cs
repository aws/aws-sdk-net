/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
[module: SuppressMessage("AwsSdkRules", "CR1004:PreventRegionEndpointUseRule", Scope = "member", Target = "Amazon.SecurityToken.AmazonSecurityTokenServiceConfig.#.ctor()")]
[module: SuppressMessage("AwsSdkRules", "CR1004:PreventRegionEndpointUseRule", Scope = "member", Target = "Amazon.SecurityToken.SAML.StoredProfileSAMLCredentials.#.ctor(System.String,System.String)")]

[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient.#Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS.CredentialsFromSAMLAuthentication(System.String,System.String,System.String,System.TimeSpan,System.Net.ICredentials)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient.#Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication(System.String,System.String,Amazon.Runtime.AssumeRoleAWSCredentialsOptions)")]


[module: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "Amazon.SecurityToken.SAML.ImpersonationState.#Impersonate(System.Net.NetworkCredential)")]

[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient.#Amazon.Runtime.SharedInterfaces.ICoreAmazonSTS.CredentialsFromSAMLAuthentication(System.String,System.String,System.String,System.TimeSpan,System.Net.ICredentials)")]

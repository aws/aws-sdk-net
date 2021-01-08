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

// Unused parameters
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.CloudSearchDomain.Internal.ProcessExceptionHandler.#HandleException(Amazon.Runtime.IExecutionContext,System.Exception)", MessageId = "exception")]
// Suppressions for various *url* params being strings.
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudSearchDomain.AmazonCloudSearchDomainClient.#.ctor(System.String,Amazon.Runtime.AWSCredentials)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudSearchDomain.AmazonCloudSearchDomainClient.#.ctor(System.String,System.String,System.String,System.String)", MessageId = "3#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudSearchDomain.AmazonCloudSearchDomainClient.#.ctor(System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudSearchDomain.AmazonCloudSearchDomainClient.#.ctor(System.String,System.String,System.String)", MessageId = "2#")]
// Suppressions for Nested Generic types
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.CloudSearchDomain.Model.Hit.#Fields")]

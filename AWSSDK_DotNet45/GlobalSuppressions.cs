/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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


[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.FileInfo,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCustomSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime,System.DateTime,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.FileInfo,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCannedSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory.#NewCannedACLCondition(Amazon.S3.S3CannedACL)")]

// Suppressions for DynamoDBContext generic methods
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#DeleteAsync`1(System.Object,System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#DeleteAsync`1(System.Object,System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig,System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#DeleteAsync`1(System.Object,System.Object,System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#DeleteAsync`1(System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig,System.Threading.CancellationToken)")]

// Uri objects instead of strings
[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceClient.#ConfigureHttpClient()")]

// Link demands
[module: SuppressMessage("Microsoft.Security", "CA2141:TransparentMethodsMustNotSatisfyLinkDemandsFxCopRule", Scope = "member", Target = "Amazon.Runtime.Internal.Util.TraceSourceUtil.#GetTraceSourceWithListeners_Locked(System.String,System.Diagnostics.SourceLevels)")]
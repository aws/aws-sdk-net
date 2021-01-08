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

// General suppressions for marshallers
[module: SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.CreateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.CreateDistributionRequest)")]
[module: SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.UpdateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.UpdateDistributionRequest)")]
[module: SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.CreateDistributionWithTagsRequestMarshaller.#Marshall(Amazon.CloudFront.Model.CreateDistributionWithTagsRequest)")]
// Passing base types
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.FileInfo,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCustomSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime,System.DateTime,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.FileInfo,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCannedSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime)")]
// Nested types, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol")]
// Normalize strings to uppercase, breaking change
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.CreateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.CreateDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.CreateStreamingDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.CreateStreamingDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.UpdateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.UpdateDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.UpdateStreamingDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.UpdateStreamingDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope="member", Target="Amazon.CloudFront.AmazonCloudFrontCookieSigner.#GenerateResourcePath(Amazon.CloudFront.AmazonCloudFrontCookieSigner+Protocols,System.String,System.String)")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.FileInfo,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.StreamReader,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.FileInfo,System.DateTime)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.StreamReader,System.DateTime)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#BuildPolicyForSignedUrl(System.String,System.DateTime,System.String,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCannedSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCannedSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.StreamReader,System.String,System.String,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCustomSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime,System.DateTime,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCustomSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.StreamReader,System.String,System.String,System.DateTime,System.DateTime,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.FileInfo,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.StreamReader,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.FileInfo,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.StreamReader,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.Util.AmazonCloudFrontUtil.#UrlEncode(System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#BuildPolicyForSignedUrl(System.String,System.DateTime,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCustomSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.StreamReader,System.String,System.String,System.DateTime,System.String)")]
// Flag enums should have a Zero Value
[module: SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Amazon.CloudFront.AmazonCloudFrontCookieSigner+Protocols")]
// Should not have next public types
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CloudFront.AmazonCloudFrontCookieSigner+Protocols")]
// Amazon.CloudFront.Model.Signer type conflicts with Amazon.Signer service namespace.
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.CloudFront.Model.Signer")]
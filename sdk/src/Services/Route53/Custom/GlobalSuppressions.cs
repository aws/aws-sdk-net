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

// Suppressions for empty response types
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.Route53.Model.Internal.MarshallTransformations.DeleteHealthCheckResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.Route53.Model.DeleteHealthCheckResponse)", MessageId = "response")]
// Normalize strings to uppercase, breaking change
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Route53.Model.Internal.MarshallTransformations.ChangeResourceRecordSetsRequestMarshaller.#Marshall(Amazon.Route53.Model.ChangeResourceRecordSetsRequest)")]
// Suppressions for various *url* params being strings.
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.Route53Domains.Model.GetDomainDetailResult.#RegistrarUrl")]

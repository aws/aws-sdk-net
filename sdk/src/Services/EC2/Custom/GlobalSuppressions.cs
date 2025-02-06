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

// General exception types
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.VPCUtilities.#WaitTillTrue(System.Func`1<System.Boolean>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#LoadDefinitionsFromWeb()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#ParseAMIDefinitions(System.IO.StreamReader)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.AmazonEC2Client+DryRunInfo.#DryRun(Amazon.EC2.AmazonEC2Client,Amazon.EC2.AmazonEC2Request,Amazon.EC2.Model.DryRunResponse&)")]
// Nested types, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.EC2.Util.VPCUtilities+Progress")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.EC2.Util.ImageUtilities+ImageDescriptor")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.DiskImageDescription.#ImportManifestUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.DiskImageDetail.#ImportManifestUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.ImageDiskContainer.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.SnapshotDetail.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.SnapshotDiskContainer.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.SnapshotTaskDetail.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.CopySnapshotRequest.#PresignedUrl")]
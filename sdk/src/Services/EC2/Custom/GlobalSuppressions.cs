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

// Suppressions for exceptions in setters
[module: SuppressMessage("Microsoft.Usage", "CA2219:DoNotRaiseExceptionsInExceptionClauses", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.EC2.IAmazonEC2,Amazon.S3.IAmazonS3,System.String,System.Boolean,Amazon.EC2.Import.CleanupProgressCallback)")]
[module: SuppressMessage("Microsoft.Usage", "CA2219:DoNotRaiseExceptionsInExceptionClauses", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.EC2.IAmazonEC2,Amazon.Runtime.SharedInterfaces.ICoreAmazonS3,System.String,System.Boolean,Amazon.EC2.Import.CleanupProgressCallback)")]
// General exception types
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.VPCUtilities.#WaitTillTrue(System.Func`1<System.Boolean>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.EC2Metadata.#FetchData(System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.EC2Metadata.#get_IAMSecurityCredentials()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.EC2Metadata.#get_IAMInstanceProfileInfo()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#LoadDefinitionsFromWeb()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#ParseAMIDefinitions(System.IO.StreamReader)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.AmazonEC2Client+DryRunInfo.#DryRun(Amazon.EC2.AmazonEC2Client,Amazon.EC2.AmazonEC2Request,Amazon.EC2.Model.DryRunResponse&)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.DiskImageImporter.#UploadImageFilePart(System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.DiskImageImporter.#DetermineRemainingUploads()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.DiskImageImporter.#RemoveUploadedArtifacts(System.String,System.Collections.Generic.IEnumerable`1<Amazon.EC2.Util.ImageFilePart>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.ImageFileParts.#FetchNextPartForUpload(System.IO.Stream,System.Byte[]&)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.DiskImageImporter.#RemoveUploadedArtifacts(System.String,System.Collections.Generic.IEnumerable`1<Amazon.EC2.Import.ImageFilePart>)")]
// Nested types, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.EC2.Util.VPCUtilities+Progress")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.EC2.Util.ImageUtilities+ImageDescriptor")]
// Types names matching namespaces
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.EC2.Import.Import")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.DiskImageDescription.#ImportManifestUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.DiskImageDetail.#ImportManifestUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportManifestRoot.#SelfDestructUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImageFilePart.#HeadUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImageFilePart.#DeleteUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImageFilePart.#GetUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.ImageDiskContainer.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.SnapshotDetail.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.SnapshotDiskContainer.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.SnapshotTaskDetail.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.CopySnapshotRequest.#PresignedUrl")]
// Initialize reference type static fields inline
[module: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#.cctor()")]
// ISerializable attribute
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.EC2.Import.DiskImageImporterException")]
// Suppressions for various *url* params being strings.
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.RegionEndpoint,System.String,Amazon.EC2.Import.CleanupProgressCallback)", MessageId = "1#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.Runtime.AWSCredentials,Amazon.RegionEndpoint,System.String,Amazon.EC2.Import.CleanupProgressCallback)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.S3.IAmazonS3,System.String,Amazon.EC2.Import.CleanupProgressCallback)", MessageId = "1#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.Runtime.SharedInterfaces.ICoreAmazonS3,System.String,Amazon.EC2.Import.CleanupProgressCallback)", MessageId = "1#")]
// Passing Uri instead of string (in these cases, the uri overload is called by the string overload)
[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.S3.IAmazonS3,System.String,Amazon.EC2.Import.CleanupProgressCallback)")]
[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.Runtime.SharedInterfaces.ICoreAmazonS3,System.String,Amazon.EC2.Import.CleanupProgressCallback)")]

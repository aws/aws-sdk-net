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

// Suppressions for empty response types
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.PutBucketResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.S3.Model.PutBucketResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.PutBucketResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.S3.Model.PutBucketResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3Transforms.#ToURLEncodedValue(System.Int32,System.Boolean)", MessageId = "path")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3Transforms.#ToURLEncodedValue(System.DateTime,System.Boolean)", MessageId = "path")]
// Array properties/fields
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.S3.Util.S3PostUploadError.#elements")]
// Suppressions for exceptions in setters
[module: SuppressMessage("Microsoft.Usage", "CA2219:DoNotRaiseExceptionsInExceptionClauses", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.EC2.IAmazonEC2,Amazon.S3.IAmazonS3,System.String,System.Boolean,Amazon.EC2.Import.CleanupProgressCallback)")]
// Passing base types
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.S3.Model.S3AccessControlList.#RemoveGrant(Amazon.S3.Model.S3Grantee,Amazon.S3.S3Permission)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.S3.Model.S3BucketLoggingConfig.#RemoveGrant(Amazon.S3.Model.S3Grantee,Amazon.S3.S3Permission)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory.#NewCannedACLCondition(Amazon.S3.S3CannedACL)")]
// Identifier suffix
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Model.TransferProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Model.WriteObjectProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.DownloadDirectoryProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadDirectoryProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadDirectoryFileRequestArgs")]
// General exception types
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Internal.MultipartUploadCommand.#AbortMultipartUpload(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Internal.MultipartUploadCommand.#shutdown(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Internal.MultipartUploadCommand+UploadPartInvoker.#Execute()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller.#Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Util.AmazonS3Util.#InvokeDeleteS3BucketWithObjects(System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Util.S3PostUploadException.#FromResponse(System.Net.HttpWebResponse)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Executer.#Execute()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Internal.MultipartUploadCommand.#Cleanup(System.String,System.Collections.Generic.List`1<System.Threading.Tasks.Task`1<Amazon.S3.Model.UploadPartResponse>>)")]
// Nested types, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.S3.Util.S3EventNotification+RequestParametersEntity")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.S3.Util.S3EventNotification+ResponseElementsEntity")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.S3.Util.S3EventNotification+S3BucketEntity")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.S3.Util.S3EventNotification+S3Entity")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.S3.Util.S3EventNotification+S3EventNotificationRecord")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.S3.Util.S3EventNotification+S3ObjectEntity")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.S3.Util.S3EventNotification+UserIdentityEntity")]
// Normalize strings to uppercase, breaking change
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS3Signer.#GetCanonicalizedHeadersForStringToSign(Amazon.Runtime.Internal.IRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS3Signer.#GetHeadersForStringToSign(Amazon.Runtime.Internal.IRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#buildCanonicalizedHeaders(System.Collections.Generic.IDictionary`2<System.String,System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsRequestMarshaller.#Marshall(Amazon.S3.Model.DeleteObjectsRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope="member", Target="Amazon.S3.Model.Internal.MarshallTransformations.PutLifecycleConfigurationRequestMarshaller.#Marshall(Amazon.S3.Model.PutLifecycleConfigurationRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#BuildCanonicalizedHeaders(System.Collections.Generic.IDictionary`2<System.String,System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.S3.Internal.S3Signer.#BuildCanonicalizedHeaders(System.Collections.Generic.IDictionary`2<System.String,System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1307:SpecifyStringComparison", Scope = "member", Target = "Amazon.S3.Internal.S3Signer.#BuildCanonicalizedResource(Amazon.Runtime.Internal.IRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope="member", Target="Amazon.S3.Model.Internal.MarshallTransformations.ListObjectsV2RequestMarshaller.#Marshall(Amazon.S3.Model.ListObjectsV2Request)")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope="member", Target="Amazon.SQS.IAmazonSQS.#AuthorizeS3ToSendMessage(System.String,System.String)", MessageId="0#")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.S3.Model.S3Grantee.#URI")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.S3.IAmazonS3.#GetPreSignedURL(Amazon.S3.Model.GetPreSignedUrlRequest)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.S3.Util.AmazonS3Util.#UrlEncode(System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.S3Link.#GetPreSignedURL(System.DateTime)")]
// Use properties, breaking changes
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.S3.Util.S3PostUploadSignedPolicy.#GetReadablePolicy()")]
// Use properties, huge change
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller.#GetInstance()")]
// Unused parameters
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Internal.AmazonS3ExceptionHandler.#HandleException(Amazon.Runtime.IExecutionContext,System.Exception)", MessageId = "exception")]
// Mark members as static, breaking changes
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#EndHeadBucket(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndUploadDirectory(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndDownload(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndUpload(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndOpenStream(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndDownloadDirectory(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndAbortMultipartUploads(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#SignRequest(Amazon.Runtime.Internal.IRequest,Amazon.Runtime.ClientConfig,Amazon.Runtime.Internal.Util.RequestMetrics,System.String,System.String)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#SignRequest(Amazon.Runtime.Internal.IRequest,Amazon.Runtime.Internal.Util.RequestMetrics,System.String,System.String)")]
// ISerializable attribute
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.S3.Util.S3PostUploadException")]
// Override methods on comparable types
[module: SuppressMessage("Microsoft.Design", "CA1036:OverrideMethodsOnComparableTypes", Scope = "type", Target = "Amazon.S3.Model.PartETag")]
// Suppressions for various *url* params being strings.
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.S3.IAmazonS3,System.String,Amazon.EC2.Import.CleanupProgressCallback)", MessageId = "1#")]
// Passing Uri instead of string (in these cases, the uri overload is called by the string overload)
[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Amazon.S3.Internal.AmazonS3RedirectHandler.#FinalizeForRedirect(Amazon.Runtime.IExecutionContext,System.String)")]
[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportCleanup.#DeleteImageArtifacts(Amazon.S3.IAmazonS3,System.String,Amazon.EC2.Import.CleanupProgressCallback)")]
// Explicit interface implementations
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.BeginDelete(System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.BeginDownloadToFilePath(System.String,System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.BeginGetObjectStream(System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.BeginUploadObjectFromFilePath(System.String,System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.BeginUploadObjectFromStream(System.String,System.String,System.IO.Stream,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.Delete(System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.Deletes(System.String,System.Collections.Generic.IEnumerable`1<System.String>,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DoesS3BucketExist(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DownloadToFilePath(System.String,System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.EndDelete(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.EndDownloadToFilePath(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.EndGetObjectStream(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.EndUploadObjectFromFilePath(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.EndUploadObjectFromStream(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.EnsureBucketExists(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GeneratePreSignedURL(System.String,System.String,System.DateTime,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GetAllObjectKeys(System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GetObjectStream(System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.MakeObjectPublic(System.String,System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.UploadObjectFromFilePath(System.String,System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.UploadObjectFromStream(System.String,System.String,System.IO.Stream,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DeleteAsync(System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.DownloadToFilePathAsync(System.String,System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.GetObjectStreamAsync(System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.UploadObjectFromFilePathAsync(System.String,System.String,System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#Amazon.Runtime.SharedInterfaces.ICoreAmazonS3.UploadObjectFromStreamAsync(System.String,System.String,System.IO.Stream,System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.CancellationToken)")]
// Calling overridable methods in constructors
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.V4ClientSection.#.ctor(System.Xml.Linq.XElement)")]
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.V4ClientSectionRoot.#.ctor(System.Xml.Linq.XElement)")]
// Unused private field
[module: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Scope = "member", Target = "Amazon.S3.Transfer.Internal.SimpleUploadCommand.#_config")]

// Exceptions being thrown from Expires property getter for GetObjectResponse and GetObjectMetadataResponse classes.
[module: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "Amazon.S3.Model.GetObjectResponse.#get_Expires()")]
[module: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "Amazon.S3.Model.GetObjectMetadataResponse.#get_Expires()")]

[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.GetObjectTorrentRequestMarshaller.#Marshall(Amazon.S3.Model.GetObjectTorrentRequest)")]
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.GetObjectRequestMarshaller.#Marshall(Amazon.S3.Model.GetObjectRequest)")]
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.GetObjectMetadataRequestMarshaller.#Marshall(Amazon.S3.Model.GetObjectMetadataRequest)")]
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
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.DeleteIdentityResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.DeleteIdentityResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.SetIdentityFeedbackForwardingEnabledResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.SetIdentityNotificationTopicResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.SetIdentityNotificationTopicResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.VerifyEmailIdentityResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.VerifyEmailIdentityResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.SetIdentityDkimEnabledResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.SetIdentityDkimEnabledResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePresetResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePresetResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePresetResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePresetResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePipelineResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePipelineResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePipelineResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePipelineResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.CancelJobResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.CancelJobResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.CancelJobResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.CancelJobResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.PutBucketResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.S3.Model.PutBucketResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.PutBucketResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.S3.Model.PutBucketResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3Transforms.#ToURLEncodedValue(System.Int32,System.Boolean)", MessageId = "path")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3Transforms.#ToURLEncodedValue(System.DateTime,System.Boolean)", MessageId = "path")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.Route53.Model.Internal.MarshallTransformations.DeleteHealthCheckResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.Route53.Model.DeleteHealthCheckResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.DeleteLoadBalancerListenersResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerListenersResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.DeleteLoadBalancerPolicyResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerPolicyResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.DeleteLoadBalancerResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.SetLoadBalancerPoliciesForBackendServerResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.SetLoadBalancerListenerSSLCertificateResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.SetLoadBalancerPoliciesOfListenerResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.CreateLoadBalancerListenersResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerListenersResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.CreateAppCookieStickinessPolicyResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.CreateAppCookieStickinessPolicyResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.CreateLoadBalancerPolicyResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerPolicyResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.CreateLBCookieStickinessPolicyResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.CreateLBCookieStickinessPolicyResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.DataPipeline.Model.Internal.MarshallTransformations.SetTaskStatusResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.DataPipeline.Model.SetTaskStatusResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.DataPipeline.Model.Internal.MarshallTransformations.SetTaskStatusResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.DataPipeline.Model.SetTaskStatusResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.DataPipeline.Model.Internal.MarshallTransformations.ActivatePipelineResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.DataPipeline.Model.ActivatePipelineResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.DataPipeline.Model.Internal.MarshallTransformations.ActivatePipelineResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.DataPipeline.Model.ActivatePipelineResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations.ModifyLoadBalancerAttributesResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.ElasticLoadBalancing.Model.ModifyLoadBalancerAttributesResponse)", MessageId = "response")]

// Suppressions for identifiers in base classes
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.DataPipeline.Model.Operator", MessageId = "Operator")]
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.DynamoDBv2.Select", MessageId = "Select")]
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.ElastiCache.Model.Event", MessageId = "Event")]
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.RDS.Model.Event", MessageId = "Event")]
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.RDS.Model.Option", MessageId = "Option")]
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.Redshift.Model.Event", MessageId = "Event")]
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "member", Target = "Amazon.SimpleDB.IAmazonSimpleDB.#Select(Amazon.SimpleDB.Model.SelectRequest)", MessageId = "Select")]
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.Step", MessageId = "Step")]

// Identifiers should have correct prefix
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.ResizeAction", MessageId = "I")]

// Identifiers should not contain type names
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry.#AsInt()", MessageId = "int")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry.#AsLong()", MessageId = "long")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry.#AsShort()", MessageId = "short")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry.#AsUInt()", MessageId = "uint")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry.#AsULong()", MessageId = "ulong")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry.#AsUShort()", MessageId = "ushort")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeRealNumberRangeFloat(System.String,System.Int32,System.Int32)", MessageId = "float")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeRealNumberRangeInt(System.String,System.Int32)", MessageId = "int")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeZeroPaddingFloat(System.String)", MessageId = "float")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeZeroPaddingInt(System.String)", MessageId = "int")]

// General suppressions for marshallers
[module: SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.CreateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.CreateDistributionRequest)")]
[module: SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.UpdateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.UpdateDistributionRequest)")]

// Array properties/fields
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.Runtime.Internal.Util.HashStream.#CalculatedHash")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.Runtime.Internal.Util.HashStream.#ExpectedHash")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.Auth.AccessControlPolicy.Condition.#Values")]
[module: SuppressMessage("Microsoft.Security", "CA2105:ArrayFieldsShouldNotBeReadOnly", Scope = "member", Target = "Amazon.Util.TypeFactory.#EmptyTypes")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBLocalSecondaryIndexRangeKeyAttribute.#IndexNames")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.QueryCondition.#Values")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.ScanCondition.#Values")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.Runtime.Internal.IRequest.#Content")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.S3.Util.S3PostUploadError.#elements")]

// Nested generic types
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.BatchGetItemResult.#Responses")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.BatchWriteItemRequest.#RequestItems")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.BatchWriteItemResult.#ItemCollectionMetrics")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.BatchWriteItemResult.#UnprocessedItems")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.KeysAndAttributes.#Keys")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.QueryResult.#Items")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.ScanResult.#Items")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.OpsWorks.Model.DeploymentCommand.#Args")]

// Suppressions for exceptions in setters
[module: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.AddInstanceGroup.#get_Args()")]
[module: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.ModifyInstanceGroup.#get_Args()")]

// Suppressions for DynamoDBContext generic methods
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginDelete`1(System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginDelete`1(System.Object,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginDelete`1(System.Object,System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginDelete`1(System.Object,System.Object,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginLoad`1(System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginLoad`1(System.Object,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginLoad`1(System.Object,System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#BeginLoad`1(System.Object,System.Object,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#Delete`1(System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#Delete`1(System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#Delete`1(System.Object,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#Delete`1(System.Object,System.Object,Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#GetTargetTable`1()")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#GetTargetTable`1(Amazon.DynamoDBv2.DataModel.DynamoDBOperationConfig)")]

// Serialization-only classes
[module: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Amazon.Runtime.InstanceProfileAWSCredentials+SecurityCredentials")]
[module: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Amazon.Runtime.InstanceProfileAWSCredentials+SecurityInfo")]

// Sealing attributes
[module: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBPropertyAttribute")]

// Passing base types
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.S3.Model.S3AccessControlList.#RemoveGrant(Amazon.S3.Model.S3Grantee,Amazon.S3.S3Permission)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.S3.Model.S3BucketLoggingConfig.#RemoveGrant(Amazon.S3.Model.S3Grantee,Amazon.S3.S3Permission)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.FileInfo,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCustomSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime,System.DateTime,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.FileInfo,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#GetCannedSignedURL(Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol,System.String,System.IO.FileInfo,System.String,System.String,System.DateTime)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory.#NewCannedACLCondition(Amazon.S3.S3CannedACL)")]

// Casting
[module: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "Amazon.Runtime.Internal.Util.WrapperStream.#SearchWrappedStream(System.Func`2<System.IO.Stream,System.Boolean>)")]

// Identifier suffix
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Model.TransferProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Model.WriteObjectProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.Runtime.StreamTransferProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.DownloadDirectoryProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadDirectoryProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.DynamoDBv2.DocumentModel.Document")]

// Interface methods not callable by child types
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceRequest.#Amazon.Runtime.Internal.IRequestEvents.FireBeforeRequestEvent(System.Object,Amazon.Runtime.RequestEventArgs)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceRequest.#Amazon.Runtime.Internal.IRequestEvents.AddBeforeRequestHandler(Amazon.Runtime.RequestEventHandler)")]

// General exception types
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.Util.InternalLog4netLogger.#loadStatics()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.Util.BackgroundDispatcher`1.#HandleInvoked()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.FallbackCredentialsFactory.#GetCredentials()")]

// Overflow operations
[module: SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", Scope = "member", Target = "Amazon.DynamoDBv2.AmazonDynamoDBClient.#pauseExponentially(System.Int32)", MessageId = "retries-1")]
[module: SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", Scope = "member", Target = "Amazon.Runtime.Internal.Util.EncryptStream.#Read(System.Byte[],System.Int32,System.Int32)", MessageId = "offset+16")]
[module: SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", Scope = "member", Target = "Amazon.Runtime.Internal.Util.EncryptUploadPartStream.#Read(System.Byte[],System.Int32,System.Int32)", MessageId = "offset+16")]

// Atrribute arguments, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBRenamableAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBLocalSecondaryIndexRangeKeyAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBPropertyAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBTableAttribute")]

// Nested types, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory+ArnComparisonType")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory+DateComparisonType")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory+IpAddressComparisonType")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory+NumericComparisonType")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory+StringComparisonType")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.Statement+StatementEffect")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner+Protocol")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.EC2.Util.VPCUtilities+Progress")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.EC2.Util.ImageUtilities+ImageDescriptor")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.StepFactory+HiveVersion")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.RegionEndpoint+Endpoint")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.Runtime.Internal.AsyncResult+AsyncRequestState")]

// Normalize strings to uppercase, breaking change
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Auth.AccessControlPolicy.ConditionFactory.#NewCondition(System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.CreateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.CreateDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.CreateStreamingDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.CreateStreamingDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.UpdateDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.UpdateDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.CloudFront.Model.Internal.MarshallTransformations.UpdateStreamingDistributionRequestMarshaller.#Marshall(Amazon.CloudFront.Model.UpdateStreamingDistributionRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.ConfigureDaemons.#AddHeapSize(Amazon.ElasticMapReduce.Model.Daemon,System.Int32)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.ConfigureDaemons.#AddOpts(Amazon.ElasticMapReduce.Model.Daemon,System.String)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Glacier.TreeHashGenerator.#CalculateTreeHash(System.Collections.Generic.IEnumerable`1<System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Glacier.TreeHashGenerator.#CalculateTreeHash(System.IO.Stream)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.RegionEndpoint.#GetBySystemName(System.String)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Route53.Model.Internal.MarshallTransformations.ChangeResourceRecordSetsRequestMarshaller.#Marshall(Amazon.Route53.Model.ChangeResourceRecordSetsRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS3Signer.#GetCanonicalizedHeadersForStringToSign(Amazon.Runtime.Internal.IRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS3Signer.#GetHeadersForStringToSign(Amazon.Runtime.Internal.IRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#CalculateSignature(System.Collections.Generic.IDictionary`2<System.String,System.String>,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.String,System.String,System.String,System.String,Amazon.Runtime.ImmutableCredentials)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#DetermineRegion(Amazon.Runtime.ClientConfig)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#DetermineService(Amazon.Runtime.ClientConfig)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#GetCanonicalizedHeaders(System.Collections.Generic.List`1<System.String>,System.Collections.Generic.IDictionary`2<System.String,System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#GetSignedHeaders(System.Collections.Generic.List`1<System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#buildCanonicalizedHeaders(System.Collections.Generic.IDictionary`2<System.String,System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Util.StringUtils.#FromBool(System.Boolean)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.DeleteObjectsRequestMarshaller.#Marshall(Amazon.S3.Model.DeleteObjectsRequest)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#CalculateMD5(System.String)")]

// Types names matching namespaces
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.Policy")]
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.Auth.AccessControlPolicy.Principal")]
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.OpsWorks.Model.Deployment")]

// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Util.AmazonCloudFormationUtil.#SignalWaitCondition(System.String,System.String,System.String,System.String,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.FileInfo,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrl(System.String,System.String,System.IO.StreamReader,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.FileInfo,System.DateTime)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFront.AmazonCloudFrontUrlSigner.#SignUrlCanned(System.String,System.String,System.IO.StreamReader,System.DateTime)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.#SubscribeQueue(System.String,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#DetermineRegion(System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#DetermineService(System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.CreateStackRequest.#TemplateURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.EstimateTemplateCostRequest.#TemplateURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.EstimateTemplateCostResult.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.UpdateStackRequest.#TemplateURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.ValidateTemplateRequest.#TemplateURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.DiskImageDescription.#ImportManifestUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.DiskImageDetail.#ImportManifestUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticBeanstalk.Model.CreateEnvironmentResult.#EndpointURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticBeanstalk.Model.EnvironmentDescription.#EndpointURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticBeanstalk.Model.TerminateEnvironmentResult.#EndpointURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticBeanstalk.Model.UpdateEnvironmentResult.#EndpointURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Cluster.#LogUri")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.JobFlowDetail.#LogUri")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.RunJobFlowRequest.#LogUri")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ImportExport.Model.Artifact.#URL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.OpsWorks.Model.Command.#LogUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.OpsWorks.Model.Source.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.Runtime.ClientConfig.#ServiceURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.S3.Model.S3Grantee.#URI")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.AddPermissionRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ChangeMessageVisibilityBatchRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ChangeMessageVisibilityRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.CreateQueueResult.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.DeleteMessageBatchRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.DeleteMessageRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.DeleteQueueRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.GetQueueAttributesRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.GetQueueUrlResult.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ReceiveMessageRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.RemovePermissionRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.SendMessageBatchRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.SendMessageRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.SetQueueAttributesRequest.#QueueUrl")]
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
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.S3.IAmazonS3.#GetPreSignedURL(Amazon.S3.Model.GetPreSignedUrlRequest)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.S3.Util.AmazonS3Util.#UrlEncode(System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#UrlEncode(System.String,System.Boolean)")]

// Use properties, breaking changes
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Document.#GetAttributeNames()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Search.#GetNextSet()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Search.#GetRemaining()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.AWSCredentials.#GetCredentials()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.InstanceProfileAWSCredentials.#GetAvailableRoles()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.RequestMetrics.#GetErrors()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.S3.Util.S3PostUploadSignedPolicy.#GetReadablePolicy()")]

// Flag enums should have plural names, breaking changes
[module: SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Scope = "type", Target = "Amazon.DynamoDBv2.DocumentModel.ReturnValues")]
[module: SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Scope = "type", Target = "Amazon.DynamoDBv2.DocumentModel.SelectValues")]

// Unused parameters
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#UserAgentRequestEventHandler(System.Object,Amazon.Runtime.RequestEventArgs,System.Boolean)", MessageId = "sender")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceClient.#LogResponse(Amazon.Runtime.Internal.Util.RequestMetrics,Amazon.Runtime.Internal.IRequest,System.Net.HttpStatusCode)", MessageId = "request")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.Runtime.ConstantClass.#ToString(System.IFormatProvider)", MessageId = "provider")]

// Mark members as static, breaking changes
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.MultiTableBatchWrite.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.BatchWrite.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.MultiTableBatchGet.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.BatchGet.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.MultiTableDocumentBatchGet.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Search.#EndGetRemaining(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Search.#EndGetNextSet(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DocumentBatchWrite.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#EndGetItem(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#EndUpdateItem(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#EndDeleteItem(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#EndPutItem(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.MultiTableDocumentBatchWrite.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DocumentBatchGet.#EndExecute(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.AmazonS3Client.#EndHeadBucket(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndUploadDirectory(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndDownload(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndUpload(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndOpenStream(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndDownloadDirectory(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.S3.Transfer.TransferUtility.#EndAbortMultipartUploads(System.IAsyncResult)")]

// Link demand
[module: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "Amazon.Runtime.Internal.Util.TraceSourceUtil.#GetTraceSourceWithListeners_Locked(System.String,System.Diagnostics.SourceLevels)")]

// Initialize reference type static fields inline
[module: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#.cctor()")]

// Initialize reference type static fields inline
[module: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#.cctor()")]
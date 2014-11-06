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
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "member", Target = "Amazon.Runtime.Internal.Util.ILogger.#Error(System.Exception,System.String,System.Object[])", MessageId = "Error")]

// Identifiers should have correct prefix
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.ResizeAction", MessageId = "I")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceClient.#Invoke`2(!!1,System.AsyncCallback,System.Object,System.Boolean,Amazon.Runtime.Internal.Transform.IMarshaller`2<!!0,!!1>,Amazon.Runtime.Internal.Transform.ResponseUnmarshaller,Amazon.Runtime.Internal.Auth.AbstractAWSSigner)", MessageId = "T")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.IResponseUnmarshaller`2", MessageId = "T")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.IUnmarshaller`2", MessageId = "T")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.DictionaryUnmarshaller`4", MessageId = "T")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.IMarshaller`2", MessageId = "T")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.ListUnmarshaller`2", MessageId = "T")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.KeyValueUnmarshaller`4", MessageId = "T")]
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.IRequestMarshaller`2", MessageId = "T")]

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
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.DynamoDBv2.Model.AttributeValue.#BOOL", MessageId = "bool")]

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
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.Runtime.Internal.Util.LogMessage.#Args")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4SigningResult.#SignatureBytes")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4SigningResult.#SigningKey")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBGlobalSecondaryIndexHashKeyAttribute.#IndexNames")]
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBGlobalSecondaryIndexRangeKeyAttribute.#IndexNames")]

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

[module: SuppressMessage("Microsoft.Usage", "CA2219:DoNotRaiseExceptionsInExceptionClauses", Scope = "member", Target = "Amazon.Runtime.Internal.HttpRequest.#WriteToRequestBody(System.IO.Stream,System.IO.Stream,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.Int32)")]

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

// Sealing attributes, attributes are extended elsewhere
[module: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBPropertyAttribute")]
[module: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBRangeKeyAttribute")]
[module: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBGlobalSecondaryIndexHashKeyAttribute")]
[module: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBGlobalSecondaryIndexRangeKeyAttribute")]
[module: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBHashKeyAttribute")]

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
[module: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext.#ReadText()")]

// Identifier suffix
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Model.TransferProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Model.WriteObjectProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.Runtime.StreamTransferProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.DownloadDirectoryProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadDirectoryProgressArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.S3.Transfer.UploadDirectoryFileRequestArgs")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.DynamoDBv2.DocumentModel.Document")]

// Interface methods not callable by child types
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceRequest.#Amazon.Runtime.Internal.IRequestEvents.FireBeforeRequestEvent(System.Object,Amazon.Runtime.RequestEventArgs)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceRequest.#Amazon.Runtime.Internal.IRequestEvents.AddBeforeRequestHandler(Amazon.Runtime.RequestEventHandler)")]

// General exception types

[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Internal.MultipartUploadCommand.#AbortMultipartUpload(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.Util.InternalLog4netLogger.#loadStatics()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.Util.BackgroundDispatcher`1.#HandleInvoked()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.FallbackCredentialsFactory.#GetCredentials(System.Boolean)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.VPCUtilities.#WaitTillTrue(System.Func`1<System.Boolean>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.EC2Metadata.#FetchData(System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.EC2Metadata.#get_IAMSecurityCredentials()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.EC2Metadata.#get_IAMInstanceProfileInfo()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#LoadDefinitionsFromWeb()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#ParseAMIDefinitions(System.IO.StreamReader)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.Util.MetricError.#.ctor(Amazon.Runtime.Internal.Util.Metric,System.Exception,System.String,System.Object[])")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Internal.MultipartUploadCommand.#shutdown(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Internal.MultipartUploadCommand+UploadPartInvoker.#Execute()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller.#Unmarshall(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceClient.#getRequestStreamCallback(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceClient.#getResponseCallback(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.InstanceProfileAWSCredentials.#GenerateNewCredentials()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.AmazonEC2Client+DryRunInfo.#DryRun(Amazon.EC2.AmazonEC2Client,Amazon.EC2.AmazonEC2Request,Amazon.EC2.Model.DryRunResponse&)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.DynamoDBv2.DynamoDBAsyncExecutor.#Execute(Amazon.DynamoDBv2.AsyncCall,Amazon.DynamoDBv2.DynamoDBAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Glacier.Transfer.Internal.DownloadJobCommand.#Execute()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Util.CryptoUtilFactory+CryptoUtil.#get_SHA256HashAlgorithmInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#PreserveStackTrace(System.Exception)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#ForceCanonicalPathAndQuery(System.Uri)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#DetermineFramework()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Util.AmazonS3Util.#InvokeDeleteS3BucketWithObjects(System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Util.S3PostUploadException.#FromResponse(System.Net.HttpWebResponse)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.Util.EventStream.#BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.S3.Transfer.Executer.#Execute()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#TryLoadTable(Amazon.DynamoDBv2.IAmazonDynamoDB,System.String,Amazon.DynamoDBv2.DocumentModel.Table&)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#TryLoadTable(Amazon.DynamoDBv2.IAmazonDynamoDB,System.String,Amazon.DynamoDBv2.DocumentModel.Table+DynamoDBConsumer,Amazon.DynamoDBv2.DynamoDBEntryConversion,Amazon.DynamoDBv2.DocumentModel.Table&)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#TryLoadTable(Amazon.DynamoDBv2.IAmazonDynamoDB,System.String,Amazon.DynamoDBv2.DynamoDBEntryConversion,Amazon.DynamoDBv2.DocumentModel.Table&)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.AWSSection.#Serialize(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.AbstractWebServiceClient.#DontUnescapePathDotsAndSlashes(System.Uri)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.DiskImageImporter.#UploadImageFilePart(System.Object)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.DiskImageImporter.#DetermineRemainingUploads()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.DiskImageImporter.#RemoveUploadedArtifacts(System.String,System.Collections.Generic.IEnumerable`1<Amazon.EC2.Util.ImageFilePart>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.EC2.Import.ImageFileParts.#FetchNextPartForUpload(System.IO.Stream,System.Byte[]&)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.RegionEndpoint.#TryLoadEndpointDefinitionsFromAssemblyDir()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.HttpHandler`1.#DontUnescapePathDotsAndSlashes(System.Uri)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.HttpHandler`1.#GetResponseCallback(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.HttpHandler`1.#GetRequestStreamCallback(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.PipelineHandler.#AsyncCallback(Amazon.Runtime.IAsyncExecutionContext)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.HttpErrorResponseExceptionHandler.#HandleSuppressed404(Amazon.Runtime.IExecutionContext,Amazon.Runtime.Internal.Transform.IWebResponseData)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.Internal.ErrorHandler.#InvokeAsyncCallback(Amazon.Runtime.IAsyncExecutionContext)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.Runtime.AmazonServiceClient.#DontUnescapePathDotsAndSlashes(System.Uri)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBContext.#TryToScalar(System.Object,System.Type,Amazon.DynamoDBv2.DataModel.DynamoDBFlatConfig,Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry&)")]

// Overflow operations
[module: SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", Scope = "member", Target = "Amazon.DynamoDBv2.AmazonDynamoDBClient.#pauseExponentially(System.Int32)", MessageId = "retries-1")]
[module: SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", Scope = "member", Target = "Amazon.Runtime.Internal.Util.EncryptStream.#Read(System.Byte[],System.Int32,System.Int32)", MessageId = "offset+16")]
[module: SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", Scope = "member", Target = "Amazon.Runtime.Internal.Util.EncryptUploadPartStream.#Read(System.Byte[],System.Int32,System.Int32)", MessageId = "offset+16")]

// Atrribute arguments, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBRenamableAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBLocalSecondaryIndexRangeKeyAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBPropertyAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBTableAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBGlobalSecondaryIndexHashKeyAttribute")]
[module: SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Scope = "type", Target = "Amazon.DynamoDBv2.DataModel.DynamoDBGlobalSecondaryIndexRangeKeyAttribute")]

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
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#CanonicalizeHeaderNames(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#CanonicalizeHeaders(System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#DetermineSigningRegion(Amazon.Runtime.ClientConfig,System.String,Amazon.RegionEndpoint)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#CalculateMD5(System.Byte[])")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#BuildCanonicalizedHeaders(System.Collections.Generic.IDictionary`2<System.String,System.String>)")]

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
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.#SubscribeQueue(System.String,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticBeanstalk.Model.Queue.#URL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ListDeadLetterSourceQueuesRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.UpdateStackRequest.#StackPolicyDuringUpdateURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.UpdateStackRequest.#StackPolicyURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.CreateStackRequest.#StackPolicyURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.CloudFormation.Model.SetStackPolicyRequest.#StackPolicyURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImportManifestRoot.#SelfDestructUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImageFilePart.#HeadUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImageFilePart.#DeleteUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Import.ImageFilePart.#GetUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.EC2.Model.CopySnapshotRequest.#PresignedUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.IdentityManagement.Model.GetOpenIDConnectProviderResult.#Url")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.IdentityManagement.Model.CreateOpenIDConnectProviderRequest.#Url")]

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
[module: SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Amazon.DynamoDBv2.DataModel.S3Link.#GetPreSignedURL(System.DateTime)")]

// Use properties, breaking changes
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Document.#GetAttributeNames()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Search.#GetNextSet()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Search.#GetRemaining()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.AWSCredentials.#GetCredentials()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.InstanceProfileAWSCredentials.#GetAvailableRoles()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.RequestMetrics.#GetErrors()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.S3.Util.S3PostUploadSignedPolicy.#GetReadablePolicy()")]

// Use properties, huge change
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.ResponseMetadataUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.MemoryStreamUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.StringUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.LongUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.IntUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.ErrorResponseUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.FloatUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.JsonErrorResponseUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.ByteUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.DoubleUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.BoolUnmarshaller.#GetInstance()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.Transform.DateTimeEpochLongMillisecondsUnmarshaller.#GetInstance()")]

// Flag enums should have plural names, breaking changes
[module: SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Scope = "type", Target = "Amazon.DynamoDBv2.DocumentModel.ReturnValues")]
[module: SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Scope = "type", Target = "Amazon.DynamoDBv2.DocumentModel.SelectValues")]
[module: SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Scope = "type", Target = "Amazon.DynamoDBv2.DocumentModel.ConditionalOperatorValues")]

// Unused parameters
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.Table.#UserAgentRequestEventHandler(System.Object,Amazon.Runtime.RequestEventArgs,System.Boolean)", MessageId = "sender")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.Runtime.AmazonWebServiceClient.#LogResponse(Amazon.Runtime.Internal.Util.RequestMetrics,Amazon.Runtime.Internal.IRequest,System.Net.HttpStatusCode)", MessageId = "request")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.Runtime.ConstantClass.#ToString(System.IFormatProvider)", MessageId = "provider")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.AddTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.AddTagsResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.AddTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.AddTagsResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.RemoveTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.RemoveTagsResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.RemoveTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.RemoveTagsResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.AddPermissionResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.AddPermissionResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.ChangeMessageVisibilityResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.ChangeMessageVisibilityResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.DeleteMessageResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.DeleteMessageResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.DeleteQueueResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.DeleteQueueResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.RemovePermissionResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.RemovePermissionResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.SetQueueAttributesResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.SetQueueAttributesResponse)", MessageId = "response")]

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
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4Signer.#SignRequest(Amazon.Runtime.Internal.IRequest,Amazon.Runtime.ClientConfig,Amazon.Runtime.Internal.Util.RequestMetrics,System.String,System.String)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.AWS4PreSignedUrlSigner.#SignRequest(Amazon.Runtime.Internal.IRequest,Amazon.Runtime.ClientConfig,Amazon.Runtime.Internal.Util.RequestMetrics,System.String,System.String)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#SignRequest(Amazon.Runtime.Internal.IRequest,Amazon.Runtime.ClientConfig,Amazon.Runtime.Internal.Util.RequestMetrics,System.String,System.String)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Amazon.Runtime.Internal.Auth.S3Signer.#SignRequest(Amazon.Runtime.Internal.IRequest,Amazon.Runtime.Internal.Util.RequestMetrics,System.String,System.String)")]

// Link demand
[module: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "Amazon.Runtime.Internal.Util.TraceSourceUtil.#GetTraceSourceWithListeners(System.String,System.Diagnostics.SourceLevels)")]

// Initialize reference type static fields inline
[module: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "Amazon.EC2.Util.ImageUtilities.#.cctor()")]

// Initialize reference type static fields inline
[module: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "Amazon.Util.AWSSDKUtils.#.cctor()")]

// Abstract types should not have constructors
[module: SuppressMessage("Microsoft.Design", "CA1012:AbstractTypesShouldNotHaveConstructors", Scope = "type", Target = "Amazon.Runtime.ClientConfig")]

// Avoid uncalled private code, properties used in serialization
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Amazon.Runtime.InstanceProfileAWSCredentials+SecurityBase.#set_Code(System.String)")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Amazon.Runtime.InstanceProfileAWSCredentials+SecurityBase.#get_LastUpdated()")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Amazon.Runtime.InstanceProfileAWSCredentials+SecurityBase.#set_LastUpdated(System.DateTime)")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Amazon.Runtime.InstanceProfileAWSCredentials+SecurityBase.#set_Message(System.String)")]

// Do not call overridable methods in constructors
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.Runtime.AbstractWebServiceClient.#.ctor(Amazon.Runtime.AWSCredentials,Amazon.Runtime.ClientConfig,Amazon.Runtime.AbstractWebServiceClient+AuthenticationTypes)")]
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.Runtime.ClientConfig.#.ctor()")]
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.Runtime.AmazonServiceClient.#.ctor(Amazon.Runtime.AWSCredentials,Amazon.Runtime.ClientConfig)")]
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.Runtime.Internal.ErrorHandler.#.ctor(Amazon.Runtime.Internal.Util.ILogger)")]

// Events should have before or after prefix
[module: SuppressMessage("Microsoft.Naming", "CA1713:EventsShouldNotHaveBeforeOrAfterPrefix", Scope = "member", Target = "Amazon.Runtime.AbstractWebServiceClient.#BeforeRequestEvent")]
[module: SuppressMessage("Microsoft.Naming", "CA1713:EventsShouldNotHaveBeforeOrAfterPrefix", Scope = "member", Target = "Amazon.Runtime.AbstractWebServiceClient.#AfterResponseEvent")]
[module: SuppressMessage("Microsoft.Naming", "CA1713:EventsShouldNotHaveBeforeOrAfterPrefix", Scope = "member", Target = "Amazon.Runtime.AmazonServiceClient.#BeforeRequestEvent")]
[module: SuppressMessage("Microsoft.Naming", "CA1713:EventsShouldNotHaveBeforeOrAfterPrefix", Scope = "member", Target = "Amazon.Runtime.AmazonServiceClient.#AfterResponseEvent")]

// ISerializable attribute
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.Runtime.AmazonServiceException")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.Runtime.SignatureException")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.Runtime.AmazonClientException")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.Runtime.Internal.Auth.SignatureException")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.S3.Util.S3PostUploadException")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.EC2.Import.DiskImageImporterException")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Amazon.Runtime.Internal.HttpErrorResponseException")]

// Use generic event handler instances, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "Amazon.Runtime.RequestEventHandler")]
[module: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "Amazon.Runtime.ExceptionEventHandler")]
[module: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "Amazon.Runtime.ResponseEventHandler")]
[module: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "Amazon.Runtime.PreRequestEventHandler")]

// Declare event handlers correctly, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly", Scope = "member", Target = "Amazon.Runtime.AbstractWebServiceClient.#BeforeRequestEvent")]
[module: SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly", Scope = "member", Target = "Amazon.Runtime.AbstractWebServiceClient.#ExceptionEvent")]
[module: SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly", Scope = "member", Target = "Amazon.Runtime.AbstractWebServiceClient.#AfterResponseEvent")]

// Use events where appropriate
[module: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.Internal.IRequestEvents.#FireBeforeRequestEvent(System.Object,Amazon.Runtime.RequestEventArgs)")]

// Override methods on comparable types
[module: SuppressMessage("Microsoft.Design", "CA1036:OverrideMethodsOnComparableTypes", Scope = "type", Target = "Amazon.S3.Model.PartETag")]

// Do not call overridable methods in constructors
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.Runtime.Internal.Util.EncryptionWrapper.#.ctor()")]
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.Runtime.Internal.Util.DecryptionWrapper.#.ctor()")]


// Suppressions for Runtime generic methods
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.Runtime.Internal.RuntimePipeline.#RemoveHandler`1()")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.Runtime.Internal.RuntimePipeline.#AddHandlerAfter`1(Amazon.Runtime.IPipelineHandler)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.Runtime.Internal.RuntimePipeline.#ReplaceHandler`1(Amazon.Runtime.IPipelineHandler)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.Runtime.Internal.RuntimePipeline.#AddHandlerBefore`1(Amazon.Runtime.IPipelineHandler)")]
[module: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Amazon.Runtime.Internal.DefaultRetryPolicy.#IsInnerException`1(System.Exception)")]

[module: SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", Scope = "member", Target = "Amazon.Runtime.Internal.DefaultRetryPolicy.#IsInnerException`1(System.Exception,!!0&)", MessageId = "1#")]

// Suppression for methods on IHttpRequest
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.IHttpRequest`1.#GetRequestContent()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.Runtime.IHttpRequest`1.#GetResponse()")]

// Suppression for HttpWebRequestResponseData, HttpWebRequestResponseData.ResponseBody is disposed on it's own.
[module: SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Scope = "type", Target = "Amazon.Runtime.Internal.Transform.HttpWebRequestResponseData")]

// Suppressions for SQS QueueUrl param being string.

[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ChangeMessageVisibilityRequest.#.ctor(System.String,System.String,System.Int32)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.SendMessageBatchRequest.#.ctor(System.String,System.Collections.Generic.List`1<Amazon.SQS.Model.SendMessageBatchRequestEntry>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.SendMessageRequest.#.ctor(System.String,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ChangeMessageVisibilityBatchRequest.#.ctor(System.String,System.Collections.Generic.List`1<Amazon.SQS.Model.ChangeMessageVisibilityBatchRequestEntry>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.SetQueueAttributesRequest.#.ctor(System.String,System.Collections.Generic.Dictionary`2<System.String,System.String>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ReceiveMessageRequest.#.ctor(System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.GetQueueAttributesRequest.#.ctor(System.String,System.Collections.Generic.List`1<System.String>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.AddPermissionRequest.#.ctor(System.String,System.String,System.Collections.Generic.List`1<System.String>,System.Collections.Generic.List`1<System.String>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.DeleteQueueRequest.#.ctor(System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.DeleteMessageRequest.#.ctor(System.String,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.RemovePermissionRequest.#.ctor(System.String,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.DeleteMessageBatchRequest.#.ctor(System.String,System.Collections.Generic.List`1<Amazon.SQS.Model.DeleteMessageBatchRequestEntry>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#SendMessage(System.String,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#AddPermission(System.String,System.String,System.Collections.Generic.List`1<System.String>,System.Collections.Generic.List`1<System.String>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#SendMessageBatch(System.String,System.Collections.Generic.List`1<Amazon.SQS.Model.SendMessageBatchRequestEntry>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#DeleteMessageBatch(System.String,System.Collections.Generic.List`1<Amazon.SQS.Model.DeleteMessageBatchRequestEntry>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#RemovePermission(System.String,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#ChangeMessageVisibility(System.String,System.String,System.Int32)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#DeleteQueue(System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#ReceiveMessage(System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#GetQueueAttributes(System.String,System.Collections.Generic.List`1<System.String>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#DeleteMessage(System.String,System.String)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#ChangeMessageVisibilityBatch(System.String,System.Collections.Generic.List`1<Amazon.SQS.Model.ChangeMessageVisibilityBatchRequestEntry>)", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.IAmazonSQS.#SetQueueAttributes(System.String,System.Collections.Generic.Dictionary`2<System.String,System.String>)", MessageId = "0#")]

// Suppressions for DynamoDB Nested Generic types

[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.IAmazonDynamoDB.#BatchWriteItem(System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<Amazon.DynamoDBv2.Model.WriteRequest>>)")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.DynamoDBv2.Model.BatchWriteItemRequest.#.ctor(System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<Amazon.DynamoDBv2.Model.WriteRequest>>)")]

// Suppression for base and subclass conversions
[module: SuppressMessage("Microsoft.Design", "CA1061:DoNotHideBaseClassMethods", Scope = "member", Target = "Amazon.DynamoDBv2.DocumentModel.DynamoDBList.#op_Implicit(Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry[]):Amazon.DynamoDBv2.DocumentModel.DynamoDBList")]
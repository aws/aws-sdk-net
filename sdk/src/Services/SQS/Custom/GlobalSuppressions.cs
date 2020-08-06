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

// Identifiers should not contain type names
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SQS.Internal.ValidationResponseHandler.#CalculateMD5(System.Byte[])", MessageId = "bytes")]
// Normalize strings to uppercase, breaking change
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#CalculateMD5(System.String)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#CalculateMD5(System.Byte[])")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.SQS.Internal.ValidationResponseHandler.#CalculateMD5(System.Byte[])")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.#SubscribeQueue(System.String,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.#SubscribeQueueToTopics(System.Collections.Generic.IList`1<System.String>,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope="member", Target="Amazon.SQS.IAmazonSQS.#AuthorizeS3ToSendMessage(System.String,System.String)", MessageId="0#")]
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
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope="member", Target="Amazon.SQS.Model.PurgeQueueRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope="member", Target="Amazon.SQS.IAmazonSQS.#PurgeQueue(System.String)", MessageId="0#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.#SubscribeQueue(System.String,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.ListDeadLetterSourceQueuesRequest.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.CreateQueueResponse.#QueueUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SQS.Model.GetQueueUrlResponse.#QueueUrl")]
// Unused parameters
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.AddPermissionResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.AddPermissionResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.ChangeMessageVisibilityResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.ChangeMessageVisibilityResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.DeleteMessageResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.DeleteMessageResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.DeleteQueueResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.DeleteQueueResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.RemovePermissionResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.RemovePermissionResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SQS.Model.Internal.MarshallTransformations.SetQueueAttributesResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SQS.Model.SetQueueAttributesResponse)", MessageId = "response")]
// Suppressions for various *url* params being strings.
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
// Explicit interface implementations
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS.GetAttributes(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS.GetAttributesAsync(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS.SetAttributes(System.String,System.Collections.Generic.Dictionary`2<System.String,System.String>)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Amazon.SQS.AmazonSQSClient.#Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS.SetAttributesAsync(System.String,System.Collections.Generic.Dictionary`2<System.String,System.String>)")]

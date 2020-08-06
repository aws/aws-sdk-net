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

// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.#SubscribeQueue(System.String,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.#SubscribeQueueToTopics(System.Collections.Generic.IList`1<System.String>,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.#SubscribeQueue(System.String,Amazon.SQS.IAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.#SubscribeQueueToTopics(System.Collections.Generic.IList`1<System.String>,Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS,System.String)", MessageId = "2#")]
[module: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.#SubscribeQueue(System.String,Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS,System.String)", MessageId = "2#")]
// Suppressions for various *url* params being strings.
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.Util.Message.#UnsubscribeURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.Util.Message.#SigningCertURL")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.SimpleNotificationService.Util.Message.#SubscribeURL")]
// Nested generic types
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.#SubscribeQueueToTopicsAsync(System.Collections.Generic.IList`1<System.String>,Amazon.Runtime.SharedInterfaces.ICoreAmazonSQS,System.String)")]
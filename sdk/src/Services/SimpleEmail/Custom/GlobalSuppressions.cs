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
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.DeleteIdentityResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.DeleteIdentityResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.SetIdentityFeedbackForwardingEnabledResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.SetIdentityNotificationTopicResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.SetIdentityNotificationTopicResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.VerifyEmailIdentityResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.VerifyEmailIdentityResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.SimpleEmail.Model.Internal.MarshallTransformations.SetIdentityDkimEnabledResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.XmlUnmarshallerContext,Amazon.SimpleEmail.Model.SetIdentityDkimEnabledResponse)", MessageId = "response")]

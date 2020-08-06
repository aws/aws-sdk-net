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
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePresetResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePresetResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePresetResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePresetResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePipelineResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePipelineResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.DeletePipelineResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.DeletePipelineResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.CancelJobResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.CancelJobResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations.CancelJobResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticTranscoder.Model.CancelJobResponse)", MessageId = "response")]
// Types names matching namespaces
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.ElasticTranscoder.Model.Encryption")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.HlsContentProtection.#LicenseAcquisitionUrl")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticTranscoder.Model.PlayReadyDrm.#LicenseAcquisitionUrl")]

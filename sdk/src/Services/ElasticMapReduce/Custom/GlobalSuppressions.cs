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

// Suppressions for identifiers in base classes
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.Step", MessageId = "Step")]
// Identifiers should have correct prefix
[module: SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.ResizeAction", MessageId = "I")]
// Type names should not match namespaces
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.Configuration")]
// Suppressions for exceptions in setters
[module: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.AddInstanceGroup.#get_Args()")]
[module: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.ModifyInstanceGroup.#get_Args()")]
// Nested types, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.ElasticMapReduce.Model.StepFactory+HiveVersion")]
// Normalize strings to uppercase, breaking change
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.ConfigureDaemons.#AddHeapSize(Amazon.ElasticMapReduce.Model.Daemon,System.Int32)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.ConfigureDaemons.#AddOpts(Amazon.ElasticMapReduce.Model.Daemon,System.String)")]
// Uri properties should not be strings
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Cluster.#LogUri")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.JobFlowDetail.#LogUri")]
[module: SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.RunJobFlowRequest.#LogUri")]
// Unused parameters
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.AddTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.AddTagsResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.AddTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.AddTagsResponse)", MessageId = "response")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.RemoveTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.RemoveTagsResponse)", MessageId = "context")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations.RemoveTagsResponseUnmarshaller.#UnmarshallResult(Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext,Amazon.ElasticMapReduce.Model.RemoveTagsResponse)", MessageId = "response")]

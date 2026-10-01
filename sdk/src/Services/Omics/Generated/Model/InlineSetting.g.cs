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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Omics.Model
{
    /// <summary>
    /// A per-run configuration that overrides or merges with fields from <c>DefaultRunSetting</c>
    /// for a specific run.
    /// </summary>
    public partial class InlineSetting
    {
        /// <summary>
        /// Gets and sets the property EngineSettings. 
        /// <para>
        /// Per-run engine-specific settings. Use this field to specify configuration options
        /// that are specific to the workflow engine (for example, Nextflow profiles). Overrides
        /// <c>defaultRunSetting.engineSettings</c> for this run.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document EngineSettings { get; set; }

        /// <summary>
        /// Checks to see if the EngineSettings property is set.
        /// </summary>
        internal bool IsSetEngineSettings() => !this.EngineSettings.IsNull();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional user-friendly name for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputBucketOwnerId. 
        /// <para>
        /// The expected Amazon Web Services account ID of the owner of the output S3 bucket for
        /// this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OutputBucketOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OutputBucketOwnerId property is set.
        /// </summary>
        internal bool IsSetOutputBucketOwnerId() => this.OutputBucketOwnerId != null;

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// Override the destination S3 URI for this run's outputs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 750)]
        public string OutputUri { get; set; }

        /// <summary>
        /// Checks to see if the OutputUri property is set.
        /// </summary>
        internal bool IsSetOutputUri() => this.OutputUri != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Per-run workflow parameters. Merged with <c>defaultRunSetting.parameters</c>; values
        /// in this object take precedence when keys overlap.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => !this.Parameters.IsNull();

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Override the priority for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property RunSettingId. 
        /// <para>
        /// A customer-provided unique identifier for this run configuration within the batch.
        /// After submission, use <c>ListRunsInBatch</c> to map each <c>runSettingId</c> to the
        /// HealthOmics-generated <c>runId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RunSettingId { get; set; }

        /// <summary>
        /// Checks to see if the RunSettingId property is set.
        /// </summary>
        internal bool IsSetRunSettingId() => this.RunSettingId != null;

        /// <summary>
        /// Gets and sets the property RunTags. 
        /// <para>
        /// Per-run Amazon Web Services tags. Merged with <c>defaultRunSetting.runTags</c>; values
        /// in this object take precedence when keys overlap.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RunTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RunTags property is set.
        /// </summary>
        internal bool IsSetRunTags() => this.RunTags != null && (this.RunTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

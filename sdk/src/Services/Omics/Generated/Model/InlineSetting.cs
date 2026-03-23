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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
        private string _name;
        private string _outputBucketOwnerId;
        private string _outputUri;
        private Amazon.Runtime.Documents.Document _parameters;
        private int? _priority;
        private string _runSettingId;
        private Dictionary<string, string> _runTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional user-friendly name for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputBucketOwnerId. 
        /// <para>
        /// The expected AWS account ID of the owner of the output S3 bucket for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OutputBucketOwnerId
        {
            get { return this._outputBucketOwnerId; }
            set { this._outputBucketOwnerId = value; }
        }

        // Check to see if OutputBucketOwnerId property is set
        internal bool IsSetOutputBucketOwnerId()
        {
            return this._outputBucketOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// Override the destination S3 URI for this run's outputs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public string OutputUri
        {
            get { return this._outputUri; }
            set { this._outputUri = value; }
        }

        // Check to see if OutputUri property is set
        internal bool IsSetOutputUri()
        {
            return this._outputUri != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Per-run workflow parameters. Merged with <c>defaultRunSetting.parameters</c>; values
        /// in this object take precedence when keys overlap.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return !this._parameters.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Override the priority for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunSettingId. 
        /// <para>
        /// A customer-provided unique identifier for this run configuration within the batch.
        /// After submission, use <c>ListRunsInBatch</c> to map each <c>runSettingId</c> to the
        /// HealthOmics-generated <c>runId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RunSettingId
        {
            get { return this._runSettingId; }
            set { this._runSettingId = value; }
        }

        // Check to see if RunSettingId property is set
        internal bool IsSetRunSettingId()
        {
            return this._runSettingId != null;
        }

        /// <summary>
        /// Gets and sets the property RunTags. 
        /// <para>
        /// Per-run AWS tags. Merged with <c>defaultRunSetting.runTags</c>; values in this object
        /// take precedence when keys overlap.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RunTags
        {
            get { return this._runTags; }
            set { this._runTags = value; }
        }

        // Check to see if RunTags property is set
        internal bool IsSetRunTags()
        {
            return this._runTags != null && (this._runTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
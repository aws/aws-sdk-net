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
    /// Container for the parameters to the StartRunBatch operation.
    /// Starts a batch of workflow runs. You can group up to 100,000 runs into a single batch
    /// that share a common configuration defined in <c>defaultRunSetting</c>. Per-run overrides
    /// can be provided either inline via <c>inlineSettings</c> (up to 100 runs) or via a
    /// JSON file stored in Amazon S3 via <c>s3UriSettings</c> (up to 100,000 runs).
    /// 
    ///  
    /// <para>
    ///  <c>StartRunBatch</c> validates common fields synchronously and returns immediately
    /// with a batch ID and status <c>PENDING</c>. Runs are submitted gradually and asynchronously
    /// at a rate governed by your <c>StartRun</c> throughput quota.
    /// </para>
    /// </summary>
    public partial class StartRunBatchRequest : AmazonOmicsRequest
    {
        private string _batchName;
        private BatchRunSettings _batchRunSettings;
        private DefaultRunSetting _defaultRunSetting;
        private string _requestId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property BatchName. 
        /// <para>
        /// An optional user-friendly name for the run batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string BatchName
        {
            get { return this._batchName; }
            set { this._batchName = value; }
        }

        // Check to see if BatchName property is set
        internal bool IsSetBatchName()
        {
            return this._batchName != null;
        }

        /// <summary>
        /// Gets and sets the property BatchRunSettings. 
        /// <para>
        /// The individual run configurations. Specify exactly one of <c>inlineSettings</c> or
        /// <c>s3UriSettings</c>. See <c>BatchRunSettings</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchRunSettings BatchRunSettings
        {
            get { return this._batchRunSettings; }
            set { this._batchRunSettings = value; }
        }

        // Check to see if BatchRunSettings property is set
        internal bool IsSetBatchRunSettings()
        {
            return this._batchRunSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRunSetting. 
        /// <para>
        /// Shared configuration applied to all runs in the batch. See <c>DefaultRunSetting</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DefaultRunSetting DefaultRunSetting
        {
            get { return this._defaultRunSetting; }
            set { this._defaultRunSetting = value; }
        }

        // Check to see if DefaultRunSetting property is set
        internal bool IsSetDefaultRunSetting()
        {
            return this._defaultRunSetting != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// A client token used to deduplicate retry requests and prevent duplicate batches from
        /// being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// AWS tags to associate with the batch resource. These tags are not inherited by individual
        /// runs. To tag individual runs, use <c>defaultRunSetting.runTags</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
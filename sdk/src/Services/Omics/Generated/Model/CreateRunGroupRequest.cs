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
    /// Container for the parameters to the CreateRunGroup operation.
    /// Creates a run group to limit the compute resources for the runs that are added to
    /// the group. Returns an ARN, ID, and tags for the run group.
    /// </summary>
    public partial class CreateRunGroupRequest : AmazonOmicsRequest
    {
        private int? _maxCpus;
        private int? _maxDuration;
        private int? _maxGpus;
        private int? _maxRuns;
        private string _name;
        private string _requestId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property MaxCpus. 
        /// <para>
        /// The maximum number of CPUs that can run concurrently across all active runs in the
        /// run group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public int? MaxCpus
        {
            get { return this._maxCpus; }
            set { this._maxCpus = value; }
        }

        // Check to see if MaxCpus property is set
        internal bool IsSetMaxCpus()
        {
            return this._maxCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDuration. 
        /// <para>
        /// The maximum time for each run (in minutes). If a run exceeds the maximum run time,
        /// the run fails automatically.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public int? MaxDuration
        {
            get { return this._maxDuration; }
            set { this._maxDuration = value; }
        }

        // Check to see if MaxDuration property is set
        internal bool IsSetMaxDuration()
        {
            return this._maxDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxGpus. 
        /// <para>
        /// The maximum number of GPUs that can run concurrently across all active runs in the
        /// run group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public int? MaxGpus
        {
            get { return this._maxGpus; }
            set { this._maxGpus = value; }
        }

        // Check to see if MaxGpus property is set
        internal bool IsSetMaxGpus()
        {
            return this._maxGpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRuns. 
        /// <para>
        /// The maximum number of runs that can be running at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public int? MaxRuns
        {
            get { return this._maxRuns; }
            set { this._maxRuns = value; }
        }

        // Check to see if MaxRuns property is set
        internal bool IsSetMaxRuns()
        {
            return this._maxRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the group.
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
        /// Gets and sets the property RequestId. 
        /// <para>
        /// To ensure that requests don't run multiple times, specify a unique ID for each request.
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
        /// Tags for the group.
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
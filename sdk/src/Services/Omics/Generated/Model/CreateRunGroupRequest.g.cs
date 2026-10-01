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
    /// Container for the parameters to the CreateRunGroup operation. Creates a run group
    /// to limit the compute resources for the runs that are added to the group. Returns an
    /// ARN, ID, and tags for the run group.
    /// </summary>
    public partial class CreateRunGroupRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxCpus. 
        /// <para>
        /// The maximum number of CPUs that can run concurrently across all active runs in the
        /// run group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxCpus { get; set; }

        /// <summary>
        /// Checks to see if the MaxCpus property is set.
        /// </summary>
        internal bool IsSetMaxCpus() => this.MaxCpus.HasValue;

        /// <summary>
        /// Gets and sets the property MaxDuration. 
        /// <para>
        /// The maximum time for each run (in minutes). If a run exceeds the maximum run time,
        /// the run fails automatically.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxDuration property is set.
        /// </summary>
        internal bool IsSetMaxDuration() => this.MaxDuration.HasValue;

        /// <summary>
        /// Gets and sets the property MaxGpus. 
        /// <para>
        /// The maximum number of GPUs that can run concurrently across all active runs in the
        /// run group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxGpus { get; set; }

        /// <summary>
        /// Checks to see if the MaxGpus property is set.
        /// </summary>
        internal bool IsSetMaxGpus() => this.MaxGpus.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRuns. 
        /// <para>
        /// The maximum number of runs that can be running at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxRuns { get; set; }

        /// <summary>
        /// Checks to see if the MaxRuns property is set.
        /// </summary>
        internal bool IsSetMaxRuns() => this.MaxRuns.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// To ensure that requests don't run multiple times, specify a unique ID for each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

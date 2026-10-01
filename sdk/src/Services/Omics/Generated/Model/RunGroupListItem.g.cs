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
    /// A run group.
    /// </summary>
    public partial class RunGroupListItem
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The group's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the group was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The group's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MaxCpus. 
        /// <para>
        /// The group's maximum CPU count setting.
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
        /// The group's maximum duration setting in minutes.
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
        ///  The maximum GPUs that can be used by a run group. 
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
        /// The group's maximum concurrent run setting.
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
        /// The group's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}

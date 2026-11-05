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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details about the task or pod in the cluster.
    /// </summary>
    public partial class ClusterDetails
    {
        /// <summary>
        /// Gets and sets the property ClusterMetadata.
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterMetadata ClusterMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ClusterMetadata property is set.
        /// </summary>
        internal bool IsSetClusterMetadata() => this.ClusterMetadata != null;

        /// <summary>
        /// Gets and sets the property LastInUse. 
        /// <para>
        /// The last timestamp when Amazon Inspector recorded the image in use in the task or
        /// pod in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastInUse { get; set; }

        /// <summary>
        /// Checks to see if the LastInUse property is set.
        /// </summary>
        internal bool IsSetLastInUse() => this.LastInUse.HasValue;

        /// <summary>
        /// Gets and sets the property RunningUnitCount. 
        /// <para>
        /// The number of tasks or pods where an image was running on the cluster.
        /// </para>
        /// </summary>
        public long? RunningUnitCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningUnitCount property is set.
        /// </summary>
        internal bool IsSetRunningUnitCount() => this.RunningUnitCount.HasValue;

        /// <summary>
        /// Gets and sets the property StoppedUnitCount. 
        /// <para>
        /// The number of tasks or pods where an image was stopped on the cluster in the last
        /// 24 hours.
        /// </para>
        /// </summary>
        public long? StoppedUnitCount { get; set; }

        /// <summary>
        /// Checks to see if the StoppedUnitCount property is set.
        /// </summary>
        internal bool IsSetStoppedUnitCount() => this.StoppedUnitCount.HasValue;
    }
}

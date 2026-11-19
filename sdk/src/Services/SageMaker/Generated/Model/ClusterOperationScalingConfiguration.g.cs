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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A point-in-time snapshot of an instance group's scaling configuration. This structure
    /// represents both the original configuration before the operation and the desired configuration
    /// requested by the operation.
    /// </summary>
    public partial class ClusterOperationScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property CurrentCount. 
        /// <para>
        /// The number of instances that were in the instance group at the time of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// Checks to see if the CurrentCount property is set.
        /// </summary>
        internal bool IsSetCurrentCount() => this.CurrentCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinCount. 
        /// <para>
        /// The minimum number of instances that must be available in the instance group of a
        /// HyperPod cluster before it transitions to <c>InService</c> status. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MinCount { get; set; }

        /// <summary>
        /// Checks to see if the MinCount property is set.
        /// </summary>
        internal bool IsSetMinCount() => this.MinCount.HasValue;

        /// <summary>
        /// Gets and sets the property TargetCount. 
        /// <para>
        /// The target number of instances for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetCount property is set.
        /// </summary>
        internal bool IsSetTargetCount() => this.TargetCount.HasValue;
    }
}

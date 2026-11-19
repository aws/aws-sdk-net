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
    /// The scaling details for a single instance group that is affected by a cluster operation.
    /// </summary>
    public partial class ClusterOperationScalingDetails
    {
        /// <summary>
        /// Gets and sets the property Desired. 
        /// <para>
        /// The desired scaling configuration of the instance group for the scaling operation,
        /// including its target and minimum instance counts.
        /// </para>
        /// </summary>
        public ClusterOperationScalingConfiguration Desired { get; set; }

        /// <summary>
        /// Checks to see if the Desired property is set.
        /// </summary>
        internal bool IsSetDesired() => this.Desired != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group being scaled.
        /// </para>
        /// </summary>
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property Original. 
        /// <para>
        /// The scaling configuration of the instance group before the scaling operation was applied,
        /// including its current, target, and minimum instance counts.
        /// </para>
        /// </summary>
        public ClusterOperationScalingConfiguration Original { get; set; }

        /// <summary>
        /// Checks to see if the Original property is set.
        /// </summary>
        internal bool IsSetOriginal() => this.Original != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the scaling operation for this instance group. Valid values are <c>InProgress</c>,
        /// <c>Superseded</c>, or <c>Done</c>.
        /// </para>
        /// </summary>
        public ClusterOperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

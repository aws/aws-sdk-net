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

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Specifies whether the scaling activities for a scalable target are in a suspended
    /// state.
    /// </summary>
    public partial class SuspendedState
    {
        /// <summary>
        /// Gets and sets the property DynamicScalingInSuspended. 
        /// <para>
        /// Whether scale in by a target tracking scaling policy or a step scaling policy is suspended.
        /// Set the value to <c>true</c> if you don't want Application Auto Scaling to remove
        /// capacity when a scaling policy is triggered. The default is <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? DynamicScalingInSuspended { get; set; }

        /// <summary>
        /// Checks to see if the DynamicScalingInSuspended property is set.
        /// </summary>
        internal bool IsSetDynamicScalingInSuspended() => this.DynamicScalingInSuspended.HasValue;

        /// <summary>
        /// Gets and sets the property DynamicScalingOutSuspended. 
        /// <para>
        /// Whether scale out by a target tracking scaling policy or a step scaling policy is
        /// suspended. Set the value to <c>true</c> if you don't want Application Auto Scaling
        /// to add capacity when a scaling policy is triggered. The default is <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? DynamicScalingOutSuspended { get; set; }

        /// <summary>
        /// Checks to see if the DynamicScalingOutSuspended property is set.
        /// </summary>
        internal bool IsSetDynamicScalingOutSuspended() => this.DynamicScalingOutSuspended.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduledScalingSuspended. 
        /// <para>
        /// Whether scheduled scaling is suspended. Set the value to <c>true</c> if you don't
        /// want Application Auto Scaling to add or remove capacity by initiating scheduled actions.
        /// The default is <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? ScheduledScalingSuspended { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledScalingSuspended property is set.
        /// </summary>
        internal bool IsSetScheduledScalingSuspended() => this.ScheduledScalingSuspended.HasValue;
    }
}

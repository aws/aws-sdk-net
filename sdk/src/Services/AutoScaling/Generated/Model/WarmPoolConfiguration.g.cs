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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a warm pool configuration.
    /// </summary>
    public partial class WarmPoolConfiguration
    {
        /// <summary>
        /// Gets and sets the property InstanceReusePolicy. 
        /// <para>
        /// The instance reuse policy.
        /// </para>
        /// </summary>
        public InstanceReusePolicy InstanceReusePolicy { get; set; }

        /// <summary>
        /// Checks to see if the InstanceReusePolicy property is set.
        /// </summary>
        internal bool IsSetInstanceReusePolicy() => this.InstanceReusePolicy != null;

        /// <summary>
        /// Gets and sets the property MaxGroupPreparedCapacity. 
        /// <para>
        /// The maximum number of instances that are allowed to be in the warm pool or in any
        /// state except <c>Terminated</c> for the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1)]
        public int? MaxGroupPreparedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxGroupPreparedCapacity property is set.
        /// </summary>
        internal bool IsSetMaxGroupPreparedCapacity() => this.MaxGroupPreparedCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of instances to maintain in the warm pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MinSize { get; set; }

        /// <summary>
        /// Checks to see if the MinSize property is set.
        /// </summary>
        internal bool IsSetMinSize() => this.MinSize.HasValue;

        /// <summary>
        /// Gets and sets the property PoolState. 
        /// <para>
        /// The instance state to transition to after the lifecycle actions are complete.
        /// </para>
        /// </summary>
        public WarmPoolState PoolState { get; set; }

        /// <summary>
        /// Checks to see if the PoolState property is set.
        /// </summary>
        internal bool IsSetPoolState() => this.PoolState != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a warm pool that is marked for deletion.
        /// </para>
        /// </summary>
        public WarmPoolStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
        private InstanceReusePolicy _instanceReusePolicy;
        private int? _maxGroupPreparedCapacity;
        private int? _minSize;
        private WarmPoolState _poolState;
        private WarmPoolStatus _status;

        /// <summary>
        /// Gets and sets the property InstanceReusePolicy. 
        /// <para>
        /// The instance reuse policy.
        /// </para>
        /// </summary>
        public InstanceReusePolicy InstanceReusePolicy
        {
            get { return this._instanceReusePolicy; }
            set { this._instanceReusePolicy = value; }
        }

        // Check to see if InstanceReusePolicy property is set
        internal bool IsSetInstanceReusePolicy()
        {
            return this._instanceReusePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property MaxGroupPreparedCapacity. 
        /// <para>
        /// The maximum number of instances that are allowed to be in the warm pool or in any
        /// state except <c>Terminated</c> for the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1)]
        public int? MaxGroupPreparedCapacity
        {
            get { return this._maxGroupPreparedCapacity; }
            set { this._maxGroupPreparedCapacity = value; }
        }

        // Check to see if MaxGroupPreparedCapacity property is set
        internal bool IsSetMaxGroupPreparedCapacity()
        {
            return this._maxGroupPreparedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of instances to maintain in the warm pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MinSize
        {
            get { return this._minSize; }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolState. 
        /// <para>
        /// The instance state to transition to after the lifecycle actions are complete.
        /// </para>
        /// </summary>
        public WarmPoolState PoolState
        {
            get { return this._poolState; }
            set { this._poolState = value; }
        }

        // Check to see if PoolState property is set
        internal bool IsSetPoolState()
        {
            return this._poolState != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a warm pool that is marked for deletion.
        /// </para>
        /// </summary>
        public WarmPoolStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
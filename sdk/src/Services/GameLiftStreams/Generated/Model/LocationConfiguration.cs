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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Configuration settings that define a stream group's stream capacity for a location.
    /// When configuring a location for the first time, you must specify a numeric value for
    /// at least one of the two capacity types. To update the capacity for an existing stream
    /// group, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html">UpdateStreamGroup</a>.
    /// To add a new location and specify its capacity, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_AddStreamGroupLocations.html">AddStreamGroupLocations</a>.
    /// </summary>
    public partial class LocationConfiguration
    {
        private int? _alwaysOnCapacity;
        private string _locationName;
        private int? _maximumCapacity;
        private int? _onDemandCapacity;
        private int? _targetIdleCapacity;

        /// <summary>
        /// Gets and sets the property AlwaysOnCapacity. 
        /// <para>
        /// This setting, if non-zero, indicates minimum streaming capacity which is allocated
        /// to you and is never released back to the service. You pay for this base level of capacity
        /// at all times, whether used or idle.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int AlwaysOnCapacity
        {
            get { return this._alwaysOnCapacity.GetValueOrDefault(); }
            set { this._alwaysOnCapacity = value; }
        }

        // Check to see if AlwaysOnCapacity property is set
        internal bool IsSetAlwaysOnCapacity()
        {
            return this._alwaysOnCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        ///  A location's name. For example, <c>us-east-1</c>. For a complete list of locations
        /// that Amazon GameLift Streams supports, refer to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string LocationName
        {
            get { return this._locationName; }
            set { this._locationName = value; }
        }

        // Check to see if LocationName property is set
        internal bool IsSetLocationName()
        {
            return this._locationName != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumCapacity. 
        /// <para>
        /// This indicates the maximum capacity that the service can allocate for you. Newly created
        /// streams may take a few minutes to start. Capacity is released back to the service
        /// when idle. You pay for capacity that is allocated to you until it is released.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaximumCapacity
        {
            get { return this._maximumCapacity.GetValueOrDefault(); }
            set { this._maximumCapacity = value; }
        }

        // Check to see if MaximumCapacity property is set
        internal bool IsSetMaximumCapacity()
        {
            return this._maximumCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnDemandCapacity. 
        /// <para>
        /// This field is deprecated. Use <c>MaximumCapacity</c> instead. This parameter cannot
        /// be used with <c>MaximumCapacity</c> or <c>TargetIdleCapacity</c> in the same location
        /// configuration.
        /// </para>
        ///  
        /// <para>
        /// The streaming capacity that Amazon GameLift Streams can allocate in response to stream
        /// requests, and then de-allocate when the session has terminated. This offers a cost
        /// control measure at the expense of a greater startup time (typically under 5 minutes).
        /// Default is 0 when creating a stream group or adding a location.
        /// </para>
        /// </summary>
        [Obsolete("This input field is deprecated in favor of explicit MaximumCapacity values.")]
        [AWSProperty(Min=0)]
        public int OnDemandCapacity
        {
            get { return this._onDemandCapacity.GetValueOrDefault(); }
            set { this._onDemandCapacity = value; }
        }

        // Check to see if OnDemandCapacity property is set
        internal bool IsSetOnDemandCapacity()
        {
            return this._onDemandCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetIdleCapacity. 
        /// <para>
        /// This indicates idle capacity which the service pre-allocates and holds for you in
        /// anticipation of future activity. This helps to insulate your users from capacity-allocation
        /// delays. You pay for capacity which is held in this intentional idle state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int TargetIdleCapacity
        {
            get { return this._targetIdleCapacity.GetValueOrDefault(); }
            set { this._targetIdleCapacity = value; }
        }

        // Check to see if TargetIdleCapacity property is set
        internal bool IsSetTargetIdleCapacity()
        {
            return this._targetIdleCapacity.HasValue; 
        }

    }
}
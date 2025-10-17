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
    /// Represents a location and its corresponding stream capacity and status.
    /// </summary>
    public partial class LocationState
    {
        private int? _allocatedCapacity;
        private int? _alwaysOnCapacity;
        private int? _idleCapacity;
        private string _locationName;
        private int? _onDemandCapacity;
        private int? _requestedCapacity;
        private StreamGroupLocationStatus _status;

        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This value is the stream capacity that Amazon GameLift Streams has provisioned in
        /// a stream group that can respond immediately to stream requests. It includes resources
        /// that are currently streaming and resources that are idle and ready to respond to stream
        /// requests. You pay for this capacity whether it's in use or not. After making changes
        /// to capacity, it can take a few minutes for the allocated capacity count to reflect
        /// the change while compute resources are allocated or deallocated. Similarly, when allocated
        /// on-demand capacity is no longer needed, it can take a few minutes for Amazon GameLift
        /// Streams to spin down the allocated capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int AllocatedCapacity
        {
            get { return this._allocatedCapacity.GetValueOrDefault(); }
            set { this._allocatedCapacity = value; }
        }

        // Check to see if AllocatedCapacity property is set
        internal bool IsSetAllocatedCapacity()
        {
            return this._allocatedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlwaysOnCapacity. 
        /// <para>
        /// The streaming capacity that is allocated and ready to handle stream requests without
        /// delay. You pay for this capacity whether it's in use or not. Best for quickest time
        /// from streaming request to streaming session. Default is 1 (2 for high stream classes)
        /// when creating a stream group or adding a location.
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
        /// Gets and sets the property IdleCapacity. 
        /// <para>
        /// This value is the amount of allocated capacity that is not currently streaming. It
        /// represents the stream group's ability to respond immediately to new stream requests
        /// with near-instant startup time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int IdleCapacity
        {
            get { return this._idleCapacity.GetValueOrDefault(); }
            set { this._idleCapacity = value; }
        }

        // Check to see if IdleCapacity property is set
        internal bool IsSetIdleCapacity()
        {
            return this._idleCapacity.HasValue; 
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
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property OnDemandCapacity. 
        /// <para>
        /// The streaming capacity that Amazon GameLift Streams can allocate in response to stream
        /// requests, and then de-allocate when the session has terminated. This offers a cost
        /// control measure at the expense of a greater startup time (typically under 5 minutes).
        /// Default is 0 when creating a stream group or adding a location.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RequestedCapacity. 
        /// <para>
        /// This value is the always-on capacity that you most recently requested for a stream
        /// group. You request capacity separately for each location in a stream group. In response
        /// to an increase in requested capacity, Amazon GameLift Streams attempts to provision
        /// compute resources to make the stream group's allocated capacity meet requested capacity.
        /// When always-on capacity is decreased, it can take a few minutes to deprovision allocated
        /// capacity to match the requested capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int RequestedCapacity
        {
            get { return this._requestedCapacity.GetValueOrDefault(); }
            set { this._requestedCapacity = value; }
        }

        // Check to see if RequestedCapacity property is set
        internal bool IsSetRequestedCapacity()
        {
            return this._requestedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This value is set of locations, including their name, current status, and capacities.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A location can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVATING</c>: Amazon GameLift Streams is preparing the location. You cannot
        /// stream from, scale the capacity of, or remove this location yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The location is provisioned with initial capacity. You can now stream
        /// from, scale the capacity of, or remove this location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: Amazon GameLift Streams failed to set up this location. The <c>StatusReason</c>
        /// field describes the error. You can remove this location and try to add it again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVING</c>: Amazon GameLift Streams is working to remove this location. This
        /// will release all provisioned capacity for this location in this stream group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamGroupLocationStatus Status
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
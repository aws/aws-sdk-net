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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFleetCapacity operation.
    /// Updates capacity settings for a fleet. For fleets with multiple locations, use this
    /// operation to manage capacity settings in each location individually. Fleet capacity
    /// determines the number of game sessions and players that can be hosted based on the
    /// fleet configuration. Use this operation to set the following fleet capacity properties:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Minimum/maximum size: Set hard limits on fleet capacity. GameLift cannot set the fleet's
    /// capacity to a value outside of this range, whether the capacity is changed manually
    /// or through automatic scaling. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Desired capacity: Manually set the number of Amazon EC2 instances to be maintained
    /// in a fleet location. Before changing a fleet's desired capacity, you may want to call
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeEC2InstanceLimits.html">DescribeEC2InstanceLimits</a>
    /// to get the maximum capacity of the fleet's Amazon EC2 instance type. Alternatively,
    /// consider using automatic scaling to adjust capacity based on player demand.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To update capacity for a fleet's home Region, or if the fleet has no remote locations,
    /// omit the <code>Location</code> parameter. The fleet must be in <code>ACTIVE</code>
    /// status. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To update capacity for a fleet's remote location, include the <code>Location</code>
    /// parameter set to the location to be updated. The location must be in <code>ACTIVE</code>
    /// status.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, capacity settings are updated immediately. In response a change in
    /// desired capacity, GameLift initiates steps to start new instances or terminate existing
    /// instances in the requested fleet location. This continues until the location's active
    /// instance count matches the new desired instance count. You can track a fleet's current
    /// capacity by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetCapacity.html">DescribeFleetCapacity</a>
    /// or <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html">DescribeFleetLocationCapacity</a>.
    /// If the requested desired instance count is higher than the instance type's limit,
    /// the <code>LimitExceeded</code> exception occurs.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-manage-capacity.html">Scaling
    /// fleet capacity</a> 
    /// </para>
    /// </summary>
    public partial class UpdateFleetCapacityRequest : AmazonGameLiftRequest
    {
        private int? _desiredInstances;
        private string _fleetId;
        private string _location;
        private int? _maxSize;
        private int? _minSize;

        /// <summary>
        /// Gets and sets the property DesiredInstances. 
        /// <para>
        /// The number of Amazon EC2 instances you want to maintain in the specified fleet location.
        /// This value must fall between the minimum and maximum size limits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int DesiredInstances
        {
            get { return this._desiredInstances.GetValueOrDefault(); }
            set { this._desiredInstances = value; }
        }

        // Check to see if DesiredInstances property is set
        internal bool IsSetDesiredInstances()
        {
            return this._desiredInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to update capacity settings for. You can use either
        /// the fleet ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The name of a remote location to update fleet capacity settings for, in the form of
        /// an Amazon Web Services Region code such as <code>us-west-2</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum number of instances that are allowed in the specified fleet location.
        /// If this parameter is not set, the default is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of instances that are allowed in the specified fleet location.
        /// If this parameter is not set, the default is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

    }
}
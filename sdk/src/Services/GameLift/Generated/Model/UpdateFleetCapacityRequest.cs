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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFleetCapacity operation.
    /// Updates capacity settings for a managed EC2 fleet or managed container fleet. For
    /// these fleets, you adjust capacity by changing the number of instances in the fleet.
    /// Fleet capacity determines the number of game sessions and players that the fleet can
    /// host based on its configuration. For fleets with multiple locations, use this operation
    /// to manage capacity settings in each location individually.
    /// 
    ///  
    /// <para>
    /// Use this operation to set these fleet capacity properties: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Minimum/maximum size: Set hard limits on the number of Amazon EC2 instances allowed.
    /// If Amazon GameLift Servers receives a request--either through manual update or automatic
    /// scaling--it won't change the capacity to a value outside of this range.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Desired capacity: As an alternative to automatic scaling, manually set the number
    /// of Amazon EC2 instances to be maintained. Before changing a fleet's desired capacity,
    /// check the maximum capacity of the fleet's Amazon EC2 instance type by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeEC2InstanceLimits.html">DescribeEC2InstanceLimits</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To update capacity for a fleet's home Region, or if the fleet has no remote locations,
    /// omit the <c>Location</c> parameter. The fleet must be in <c>ACTIVE</c> status. 
    /// </para>
    ///  
    /// <para>
    /// To update capacity for a fleet's remote location, set the <c>Location</c> parameter
    /// to the location to update. The location must be in <c>ACTIVE</c> status.
    /// </para>
    ///  
    /// <para>
    /// If successful, Amazon GameLift Servers updates the capacity settings and returns the
    /// identifiers for the updated fleet and/or location. If a requested change to desired
    /// capacity exceeds the instance type's limit, the <c>LimitExceeded</c> exception occurs.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Updates often prompt an immediate change in fleet capacity, such as when current capacity
    /// is different than the new desired capacity or outside the new limits. In this scenario,
    /// Amazon GameLift Servers automatically initiates steps to add or remove instances in
    /// the fleet location. You can track a fleet's current capacity by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetCapacity.html">DescribeFleetCapacity</a>
    /// or <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html">DescribeFleetLocationCapacity</a>.
    /// 
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
        /// This value must fall between the minimum and maximum size limits. Changes in desired
        /// instance value can take up to 1 minute to be reflected when viewing the fleet's capacity
        /// settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DesiredInstances
        {
            get { return this._desiredInstances; }
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
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// an Amazon Web Services Region code such as <c>us-west-2</c>.
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
        public int? MaxSize
        {
            get { return this._maxSize; }
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

    }
}
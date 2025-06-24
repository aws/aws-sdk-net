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
    /// Current resource capacity settings for managed EC2 fleets and managed container fleets.
    /// For multi-location fleets, location values might refer to a fleet's remote location
    /// or its home Region. 
    /// 
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetCapacity.html">DescribeFleetCapacity</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html">DescribeFleetLocationCapacity</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateFleetCapacity.html">UpdateFleetCapacity</a>
    /// 
    /// </para>
    /// </summary>
    public partial class FleetCapacity
    {
        private string _fleetArn;
        private string _fleetId;
        private GameServerContainerGroupCounts _gameServerContainerGroupCounts;
        private EC2InstanceCounts _instanceCounts;
        private EC2InstanceType _instanceType;
        private string _location;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet associated with the location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property GameServerContainerGroupCounts. 
        /// <para>
        /// The number and status of game server container groups deployed in a container fleet.
        /// 
        /// </para>
        /// </summary>
        public GameServerContainerGroupCounts GameServerContainerGroupCounts
        {
            get { return this._gameServerContainerGroupCounts; }
            set { this._gameServerContainerGroupCounts = value; }
        }

        // Check to see if GameServerContainerGroupCounts property is set
        internal bool IsSetGameServerContainerGroupCounts()
        {
            return this._gameServerContainerGroupCounts != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCounts. 
        /// <para>
        /// The current number of instances in the fleet, listed by instance status. Counts for
        /// pending and terminating instances might be non-zero if the fleet is adjusting to a
        /// scaling event or if access to resources is temporarily affected.
        /// </para>
        /// </summary>
        public EC2InstanceCounts InstanceCounts
        {
            get { return this._instanceCounts; }
            set { this._instanceCounts = value; }
        }

        // Check to see if InstanceCounts property is set
        internal bool IsSetInstanceCounts()
        {
            return this._instanceCounts != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type that is used for instances in a fleet. Instance type
        /// determines the computing resources in use, including CPU, memory, storage, and networking
        /// capacity. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon Elastic Compute
        /// Cloud Instance Types</a> for detailed descriptions.
        /// </para>
        /// </summary>
        public EC2InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The fleet location for the instance count information, expressed as an Amazon Web
        /// Services Region code, such as <c>us-west-2</c>. 
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

    }
}
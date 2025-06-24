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
    /// Container for the parameters to the DescribeInstances operation.
    /// Retrieves information about the EC2 instances in an Amazon GameLift Servers managed
    /// fleet, including instance ID, connection data, and status. You can use this operation
    /// with a multi-location fleet to get location-specific instance information. As an alternative,
    /// use the operations <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute">https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute</a>
    /// and <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeCompute">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeCompute</a>
    /// to retrieve information for compute resources, including EC2 and Anywhere fleets.
    /// 
    ///  
    /// <para>
    /// You can call this operation in the following ways:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To get information on all instances in a fleet's home Region, specify the fleet ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get information on all instances in a fleet's remote location, specify the fleet
    /// ID and location name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get information on a specific instance in a fleet, specify the fleet ID and instance
    /// ID.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use the pagination parameters to retrieve results as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns <c>Instance</c> objects for each requested instance,
    /// listed in no particular order. If you call this operation for an Anywhere fleet, you
    /// receive an InvalidRequestException.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
    /// connect to fleet instances</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
    /// fleet issues</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class DescribeInstancesRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _instanceId;
        private int? _limit;
        private string _location;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to retrieve instance information for. You can use
        /// either the fleet ID or ARN value.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// A unique identifier for an instance to retrieve. Specify an instance ID or leave blank
        /// to retrieve all instances in the fleet.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The name of a location to retrieve instance information for, in the form of an Amazon
        /// Web Services Region code such as <c>us-west-2</c>. 
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}
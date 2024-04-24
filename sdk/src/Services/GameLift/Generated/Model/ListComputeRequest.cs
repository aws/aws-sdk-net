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
    /// Container for the parameters to the ListCompute operation.
    /// <b>This operation has been expanded to use with the Amazon GameLift containers feature,
    /// which is currently in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// Retrieves information on the compute resources in an Amazon GameLift fleet. 
    /// </para>
    ///  
    /// <para>
    /// To request a list of computes, specify the fleet ID. Use the pagination parameters
    /// to retrieve results in a set of sequential pages.
    /// </para>
    ///  
    /// <para>
    /// You can filter the result set by location. 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns information on all computes in the requested
    /// fleet. Depending on the fleet's compute type, the result includes the following information:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <c>EC2</c> fleets, this operation returns information about the EC2 instance.
    /// Compute names are instance IDs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <c>ANYWHERE</c> fleets, this operation returns the compute names and details provided
    /// when the compute was registered with <c>RegisterCompute</c>. The <c>GameLiftServiceSdkEndpoint</c>
    /// or <c>GameLiftAgentEndpoint</c> is included.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <c>CONTAINER</c> fleets, this operation returns information about containers that
    /// are registered as computes, and the instances they're running on. Compute names are
    /// container names.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListComputeRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private int? _limit;
        private string _location;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to retrieve compute resources for.
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
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
        /// The name of a location to retrieve compute resources for. For an Amazon GameLift Anywhere
        /// fleet, use a custom location. For a multi-location EC2 or container fleet, provide
        /// a Amazon Web Services Region or Local Zone code (for example: <c>us-west-2</c> or
        /// <c>us-west-2-lax-1</c>).
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
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
    /// Container for the parameters to the DescribeFleetCapacity operation.
    /// Retrieves the resource capacity settings for one or more fleets. The data returned
    /// includes the current fleet capacity (number of EC2 instances), and settings that can
    /// control how capacity scaling. For fleets with remote locations, this operation retrieves
    /// data for the fleet's home Region only.
    /// 
    ///  
    /// <para>
    /// This operation can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To get capacity data for one or more specific fleets, provide a list of fleet IDs
    /// or fleet ARNs. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get capacity data for all fleets, do not provide a fleet identifier. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When requesting multiple fleets, use the pagination parameters to retrieve results
    /// as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// If successful, a <code>FleetCapacity</code> object is returned for each requested
    /// fleet ID. Each FleetCapacity object includes a <code>Location</code> property, which
    /// is set to the fleet's home Region. When a list of fleet IDs is provided, attribute
    /// objects are returned only for fleets that currently exist.
    /// </para>
    ///  <note> 
    /// <para>
    /// Some API operations may limit the number of fleet IDs that are allowed in one request.
    /// If a request exceeds this limit, the request fails and the error message includes
    /// the maximum allowed.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up GameLift fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
    /// metrics for fleets</a> 
    /// </para>
    /// </summary>
    public partial class DescribeFleetCapacityRequest : AmazonGameLiftRequest
    {
        private List<string> _fleetIds = new List<string>();
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// A unique identifier for the fleet to retrieve capacity information for. You can use
        /// either the fleet ID or ARN value. Leave this parameter empty to retrieve capacity
        /// information for all fleets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> FleetIds
        {
            get { return this._fleetIds; }
            set { this._fleetIds = value; }
        }

        // Check to see if FleetIds property is set
        internal bool IsSetFleetIds()
        {
            return this._fleetIds != null && this._fleetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages. This parameter is ignored when the request
        /// specifies one or a list of fleet IDs.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value. This parameter is ignored when the request
        /// specifies one or a list of fleet IDs.
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
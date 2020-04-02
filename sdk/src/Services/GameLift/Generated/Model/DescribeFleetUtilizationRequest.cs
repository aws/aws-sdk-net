/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFleetUtilization operation.
    /// Retrieves utilization statistics for one or more fleets. These statistics provide
    /// insight into how available hosting resources are currently being used. To get statistics
    /// on available hosting resources, see <a>DescribeFleetCapacity</a>.
    /// 
    ///  
    /// <para>
    /// You can request utilization data for all fleets, or specify a list of one or more
    /// fleet IDs. When requesting multiple fleets, use the pagination parameters to retrieve
    /// results as a set of sequential pages. If successful, a <a>FleetUtilization</a> object
    /// is returned for each requested fleet ID, unless the fleet identifier is not found.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
    /// exceeds this limit, the request fails and the error message includes the maximum allowed.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up GameLift Fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/monitoring-cloudwatch.html#gamelift-metrics-fleet">GameLift
    /// Metrics for Fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Describe fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetUtilization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeRuntimeConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetEvents</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeFleetUtilizationRequest : AmazonGameLiftRequest
    {
        private List<string> _fleetIds = new List<string>();
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// A unique identifier for a fleet(s) to retrieve utilization data for. You can use either
        /// the fleet ID or ARN value. To retrieve attributes for all current fleets, do not include
        /// this parameter. If the list of fleet identifiers includes fleets that don't currently
        /// exist, the request succeeds but no attributes for that fleet are returned.
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
        /// Token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this action. To start at the beginning of
        /// the result set, do not specify a value. This parameter is ignored when the request
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
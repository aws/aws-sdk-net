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
    /// Container for the parameters to the DescribeFleetAttributes operation.
    /// Retrieves fleet properties, including metadata, status, and configuration, for one
    /// or more fleets. You can request attributes for all fleets, or specify a list of one
    /// or more fleet IDs. When requesting multiple fleets, use the pagination parameters
    /// to retrieve results as a set of sequential pages. If successful, a <a>FleetAttributes</a>
    /// object is returned for each requested fleet ID. When specifying a list of fleet IDs,
    /// attribute objects are returned only for fleets that currently exist. 
    /// 
    ///  <note> 
    /// <para>
    /// Some API actions may limit the number of fleet IDs allowed in one request. If a request
    /// exceeds this limit, the request fails and the error message includes the maximum allowed.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeFleetAttributesRequest : AmazonGameLiftRequest
    {
        private List<string> _fleetIds = new List<string>();
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// Unique identifiers for the fleet(s) that you want to retrieve attributes for. To request
        /// attributes for all fleets, leave this parameter empty.
        /// </para>
        /// </summary>
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
        /// Maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages. This parameter is ignored when the request
        /// specifies one or a list of fleet IDs.
        /// </para>
        /// </summary>
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
        /// Token indicating the start of the next sequential page of results. Use the token that
        /// is returned with a previous call to this action. To specify the start of the result
        /// set, do not specify a value. This parameter is ignored when the request specifies
        /// one or a list of fleet IDs.
        /// </para>
        /// </summary>
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
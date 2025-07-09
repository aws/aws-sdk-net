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
    /// Container for the parameters to the DescribeFleetAttributes operation.
    /// Retrieves core fleet-wide properties for fleets in an Amazon Web Services Region.
    /// Properties include the computing hardware and deployment configuration for instances
    /// in the fleet.
    /// 
    ///  
    /// <para>
    /// You can use this operation in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To get attributes for specific fleets, provide a list of fleet IDs or fleet ARNs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get attributes for all fleets, do not provide a fleet identifier.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When requesting attributes for multiple fleets, use the pagination parameters to retrieve
    /// results as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// If successful, a <c>FleetAttributes</c> object is returned for each fleet requested,
    /// unless the fleet identifier is not found. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Some API operations limit the number of fleet IDs that allowed in one request. If
    /// a request exceeds this limit, the request fails and the error message contains the
    /// maximum allowed number.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up Amazon GameLift Servers fleets</a> 
    /// </para>
    /// </summary>
    public partial class DescribeFleetAttributesRequest : AmazonGameLiftRequest
    {
        private List<string> _fleetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// A list of unique fleet identifiers to retrieve attributes for. You can use either
        /// the fleet ID or ARN value. To retrieve attributes for all current fleets, do not include
        /// this parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._fleetIds != null && (this._fleetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages. This parameter is ignored when the request
        /// specifies one or a list of fleet IDs.
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
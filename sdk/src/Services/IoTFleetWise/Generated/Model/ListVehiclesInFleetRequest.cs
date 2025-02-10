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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListVehiclesInFleet operation.
    /// Retrieves a list of summaries of all vehicles associated with a fleet. 
    /// 
    ///  <note> 
    /// <para>
    /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
    /// request to return more results.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListVehiclesInFleetRequest : AmazonIoTFleetWiseRequest
    {
        private string _fleetId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        ///  The ID of a fleet. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return, between 1 and 100, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for the next set of results.
        /// </para>
        ///  
        /// <para>
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <c>nextToken</c> pagination token is returned in the response. To retrieve the
        /// next set of results, reissue the search request and include the returned token. When
        /// all results have been returned, the response does not contain a pagination token value.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
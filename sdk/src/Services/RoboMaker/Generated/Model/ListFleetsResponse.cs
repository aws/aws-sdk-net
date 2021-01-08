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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the ListFleets operation.
    /// </summary>
    public partial class ListFleetsResponse : AmazonWebServiceResponse
    {
        private List<Fleet> _fleetDetails = new List<Fleet>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetDetails. 
        /// <para>
        /// A list of fleet details meeting the request criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Fleet> FleetDetails
        {
            get { return this._fleetDetails; }
            set { this._fleetDetails = value; }
        }

        // Check to see if FleetDetails property is set
        internal bool IsSetFleetDetails()
        {
            return this._fleetDetails != null && this._fleetDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous paginated request did not return all of the remaining results, the
        /// response object's <code>nextToken</code> parameter value is set to a token. To retrieve
        /// the next set of results, call <code>ListFleets</code> again and assign that token
        /// to the request object's <code>nextToken</code> parameter. If there are no remaining
        /// results, the previous response object's NextToken parameter is set to null. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
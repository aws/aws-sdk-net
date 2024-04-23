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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the SearchRoutingProfiles operation.
    /// </summary>
    public partial class SearchRoutingProfilesResponse : AmazonWebServiceResponse
    {
        private long? _approximateTotalCount;
        private string _nextToken;
        private List<RoutingProfile> _routingProfiles = AWSConfigs.InitializeCollections ? new List<RoutingProfile>() : null;

        /// <summary>
        /// Gets and sets the property ApproximateTotalCount. 
        /// <para>
        /// The total number of routing profiles which matched your search query.
        /// </para>
        /// </summary>
        public long ApproximateTotalCount
        {
            get { return this._approximateTotalCount.GetValueOrDefault(); }
            set { this._approximateTotalCount = value; }
        }

        // Check to see if ApproximateTotalCount property is set
        internal bool IsSetApproximateTotalCount()
        {
            return this._approximateTotalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2500)]
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

        /// <summary>
        /// Gets and sets the property RoutingProfiles. 
        /// <para>
        /// Information about the routing profiles.
        /// </para>
        /// </summary>
        public List<RoutingProfile> RoutingProfiles
        {
            get { return this._routingProfiles; }
            set { this._routingProfiles = value; }
        }

        // Check to see if RoutingProfiles property is set
        internal bool IsSetRoutingProfiles()
        {
            return this._routingProfiles != null && (this._routingProfiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
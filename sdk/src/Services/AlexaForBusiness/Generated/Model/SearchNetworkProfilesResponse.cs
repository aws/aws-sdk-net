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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// This is the response object from the SearchNetworkProfiles operation.
    /// </summary>
    public partial class SearchNetworkProfilesResponse : AmazonWebServiceResponse
    {
        private List<NetworkProfileData> _networkProfiles = new List<NetworkProfileData>();
        private string _nextToken;
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property NetworkProfiles. 
        /// <para>
        /// The network profiles that meet the specified set of filter criteria, in sort order.
        /// It is a list of NetworkProfileData objects. 
        /// </para>
        /// </summary>
        public List<NetworkProfileData> NetworkProfiles
        {
            get { return this._networkProfiles; }
            set { this._networkProfiles = value; }
        }

        // Check to see if NetworkProfiles property is set
        internal bool IsSetNetworkProfiles()
        {
            return this._networkProfiles != null && this._networkProfiles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by MaxResults.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1100)]
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
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of network profiles returned.
        /// </para>
        /// </summary>
        public int TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}
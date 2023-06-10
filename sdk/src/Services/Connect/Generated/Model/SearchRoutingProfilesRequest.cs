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
    /// Container for the parameters to the SearchRoutingProfiles operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Searches routing profiles in an Amazon Connect instance, with optional filtering.
    /// </para>
    /// </summary>
    public partial class SearchRoutingProfilesRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private RoutingProfileSearchCriteria _searchCriteria;
        private RoutingProfileSearchFilter _searchFilter;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
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
        /// Gets and sets the property SearchCriteria. 
        /// <para>
        /// The search criteria to be used to return routing profiles.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>name</code> and <code>description</code> fields support "contains" queries
        /// with a minimum of 2 characters and a maximum of 25 characters. Any queries with character
        /// lengths outside of this range will throw invalid results. 
        /// </para>
        ///  </note>
        /// </summary>
        public RoutingProfileSearchCriteria SearchCriteria
        {
            get { return this._searchCriteria; }
            set { this._searchCriteria = value; }
        }

        // Check to see if SearchCriteria property is set
        internal bool IsSetSearchCriteria()
        {
            return this._searchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property SearchFilter. 
        /// <para>
        /// Filters to be applied to search results.
        /// </para>
        /// </summary>
        public RoutingProfileSearchFilter SearchFilter
        {
            get { return this._searchFilter; }
            set { this._searchFilter = value; }
        }

        // Check to see if SearchFilter property is set
        internal bool IsSetSearchFilter()
        {
            return this._searchFilter != null;
        }

    }
}
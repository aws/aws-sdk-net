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
    /// Container for the parameters to the GetCurrentUserData operation.
    /// Gets the real-time active user data from the specified Amazon Connect instance.
    /// </summary>
    public partial class GetCurrentUserDataRequest : AmazonConnectRequest
    {
        private UserDataFilters _filters;
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to returned user data. You can filter up to the following limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Queues: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Routing profiles: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agents: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contact states: 9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User hierarchy groups: 1
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  The user data is retrieved for only the specified values/resources in the filter.
        /// A maximum of one filter can be passed from queues, routing profiles, agents, and user
        /// hierarchy groups. 
        /// </para>
        ///  
        /// <para>
        /// Currently tagging is only supported on the resources that are passed in the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserDataFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
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
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrafficMirrorSessions operation.
    /// Describes one or more Traffic Mirror sessions. By default, all Traffic Mirror sessions
    /// are described. Alternatively, you can filter the results.
    /// </summary>
    public partial class DescribeTrafficMirrorSessionsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _trafficMirrorSessionIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>description</code>: The Traffic Mirror session description.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-id</code>: The ID of the Traffic Mirror session network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code>: The ID of the account that owns the Traffic Mirror session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>packet-length</code>: The assigned number of packets to mirror. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>session-number</code>: The assigned session number. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>traffic-mirror-filter-id</code>: The ID of the Traffic Mirror filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>traffic-mirror-session-id</code>: The ID of the Traffic Mirror session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>traffic-mirror-target-id</code>: The ID of the Traffic Mirror target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>virtual-network-id</code>: The virtual network ID of the Traffic Mirror session.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// The token for the next page of results.
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

        /// <summary>
        /// Gets and sets the property TrafficMirrorSessionIds. 
        /// <para>
        /// The ID of the Traffic Mirror session.
        /// </para>
        /// </summary>
        public List<string> TrafficMirrorSessionIds
        {
            get { return this._trafficMirrorSessionIds; }
            set { this._trafficMirrorSessionIds = value; }
        }

        // Check to see if TrafficMirrorSessionIds property is set
        internal bool IsSetTrafficMirrorSessionIds()
        {
            return this._trafficMirrorSessionIds != null && this._trafficMirrorSessionIds.Count > 0; 
        }

    }
}
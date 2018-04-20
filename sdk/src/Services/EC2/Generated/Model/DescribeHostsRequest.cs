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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeHosts operation.
    /// Describes one or more of your Dedicated Hosts.
    /// 
    ///  
    /// <para>
    /// The results describe only the Dedicated Hosts in the region you're currently using.
    /// All listed instances consume capacity on your Dedicated Host. Dedicated Hosts that
    /// have recently been released will be listed with the state <code>released</code>.
    /// </para>
    /// </summary>
    public partial class DescribeHostsRequest : AmazonEC2Request
    {
        private List<Filter> _filter = new List<Filter>();
        private List<string> _hostIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>auto-placement</code> - Whether auto-placement is enabled or disabled (<code>on</code>
        /// | <code>off</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone of the host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>client-token</code> - The idempotency token you provided when you allocated
        /// the host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>host-reservation-id</code> - The ID of the reservation assigned to this host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-type</code> - The instance type size that the Dedicated Host is configured
        /// to support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The allocation state of the Dedicated Host (<code>available</code>
        /// | <code>under-assessment</code> | <code>permanent-failure</code> | <code>released</code>
        /// | <code>released-permanent-failure</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HostIds. 
        /// <para>
        /// The IDs of the Dedicated Hosts. The IDs are used for targeted instance launches.
        /// </para>
        /// </summary>
        public List<string> HostIds
        {
            get { return this._hostIds; }
            set { this._hostIds = value; }
        }

        // Check to see if HostIds property is set
        internal bool IsSetHostIds()
        {
            return this._hostIds != null && this._hostIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <code>nextToken</code>
        /// value. This value can be between 5 and 500; if <code>maxResults</code> is given a
        /// larger value than 500, you will receive an error. You cannot specify this parameter
        /// and the host IDs parameter in the same request.
        /// </para>
        /// </summary>
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
        /// The token to retrieve the next page of results.
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
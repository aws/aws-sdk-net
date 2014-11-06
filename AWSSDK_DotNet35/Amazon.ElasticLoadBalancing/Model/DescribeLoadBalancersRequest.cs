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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLoadBalancers operation.
    /// Returns detailed configuration information for all the load balancers created for
    /// the account. If you specify load balancer names, the action returns configuration
    /// information of the specified load balancers. 
    /// 
    ///  <note> In order to retrieve this information, you must provide the same account credentials
    /// that was used to create the load balancer.</note>
    /// </summary>
    public partial class DescribeLoadBalancersRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> _loadBalancerNames = new List<string>();
        private string _marker;
        private int? _pageSize;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeLoadBalancersRequest() { }

        /// <summary>
        /// Instantiates DescribeLoadBalancersRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerNames"> A list of load balancer names associated with the account. </param>
        public DescribeLoadBalancersRequest(List<string> loadBalancerNames)
        {
            _loadBalancerNames = loadBalancerNames;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        ///  A list of load balancer names associated with the account. 
        /// </para>
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this._loadBalancerNames; }
            set { this._loadBalancerNames = value; }
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this._loadBalancerNames != null && this._loadBalancerNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional parameter used for pagination of results from this call. If specified,
        /// the response includes only records beyond the marker. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        ///  The number of results returned in each page. The default is 400. You cannot specify
        /// a page size greater than 400 or less than 1. 
        /// </para>
        /// </summary>
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}
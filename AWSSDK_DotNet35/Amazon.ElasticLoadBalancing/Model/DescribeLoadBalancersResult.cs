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
    /// The output for the <a>DescribeLoadBalancers</a> action.
    /// </summary>
    public partial class DescribeLoadBalancersResult : AmazonWebServiceResponse
    {
        private List<LoadBalancerDescription> _loadBalancerDescriptions = new List<LoadBalancerDescription>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property LoadBalancerDescriptions. 
        /// <para>
        ///  A list of load balancer description structures. 
        /// </para>
        /// </summary>
        public List<LoadBalancerDescription> LoadBalancerDescriptions
        {
            get { return this._loadBalancerDescriptions; }
            set { this._loadBalancerDescriptions = value; }
        }

        // Check to see if LoadBalancerDescriptions property is set
        internal bool IsSetLoadBalancerDescriptions()
        {
            return this._loadBalancerDescriptions != null && this._loadBalancerDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        ///  Specifies the value of next marker if the request returned more than one page of
        /// results. 
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTags operation.
    /// Describes the tags associated with the specified load balancers.
    /// </summary>
    public partial class DescribeTagsRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> _loadBalancerNames = new List<string>();

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// The names of the load balancers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
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

    }
}
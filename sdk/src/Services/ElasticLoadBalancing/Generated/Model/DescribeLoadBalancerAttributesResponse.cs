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
    /// Contains the output of DescribeLoadBalancerAttributes.
    /// </summary>
    public partial class DescribeLoadBalancerAttributesResponse : AmazonWebServiceResponse
    {
        private LoadBalancerAttributes _loadBalancerAttributes;

        /// <summary>
        /// Gets and sets the property LoadBalancerAttributes. 
        /// <para>
        /// Information about the load balancer attributes.
        /// </para>
        /// </summary>
        public LoadBalancerAttributes LoadBalancerAttributes
        {
            get { return this._loadBalancerAttributes; }
            set { this._loadBalancerAttributes = value; }
        }

        // Check to see if LoadBalancerAttributes property is set
        internal bool IsSetLoadBalancerAttributes()
        {
            return this._loadBalancerAttributes != null;
        }

    }
}
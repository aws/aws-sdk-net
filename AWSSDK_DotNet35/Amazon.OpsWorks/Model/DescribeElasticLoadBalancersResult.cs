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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeElasticLoadBalancers</code> request.
    /// </summary>
    public partial class DescribeElasticLoadBalancersResult : AmazonWebServiceResponse
    {
        private List<ElasticLoadBalancer> _elasticLoadBalancers = new List<ElasticLoadBalancer>();

        /// <summary>
        /// Gets and sets the property ElasticLoadBalancers. 
        /// <para>
        /// A list of <code>ElasticLoadBalancer</code> objects that describe the specified Elastic
        /// Load Balancing instances.
        /// </para>
        /// </summary>
        public List<ElasticLoadBalancer> ElasticLoadBalancers
        {
            get { return this._elasticLoadBalancers; }
            set { this._elasticLoadBalancers = value; }
        }

        // Check to see if ElasticLoadBalancers property is set
        internal bool IsSetElasticLoadBalancers()
        {
            return this._elasticLoadBalancers != null && this._elasticLoadBalancers.Count > 0; 
        }

    }
}
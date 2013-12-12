/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeElasticLoadBalancers</c> request.</para>
    /// </summary>
    public partial class DescribeElasticLoadBalancersResult : AmazonWebServiceResponse
    {
        
        private List<ElasticLoadBalancer> elasticLoadBalancers = new List<ElasticLoadBalancer>();


        /// <summary>
        /// A list of <c>ElasticLoadBalancer</c> objects that describe the specified Elastic Load Balancing instances.
        ///  
        /// </summary>
        public List<ElasticLoadBalancer> ElasticLoadBalancers
        {
            get { return this.elasticLoadBalancers; }
            set { this.elasticLoadBalancers = value; }
        }

        // Check to see if ElasticLoadBalancers property is set
        internal bool IsSetElasticLoadBalancers()
        {
            return this.elasticLoadBalancers.Count > 0;
        }
    }
}

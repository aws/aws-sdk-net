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

using System;
using Amazon.Runtime;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Returns information about the DescribeElasticLoadBalancersResult response and response metadata.
    /// </summary>
    public class DescribeElasticLoadBalancersResponse : AmazonWebServiceResponse
    {
        private DescribeElasticLoadBalancersResult _describeElasticLoadBalancersResult;

        /// <summary>
        /// Gets and sets the DescribeElasticLoadBalancersResult property.
        /// Represents the output of a DescribeElasticLoadBalancers operation.
        /// </summary>
        public DescribeElasticLoadBalancersResult DescribeElasticLoadBalancersResult
        {
            get
            {
                if(this._describeElasticLoadBalancersResult == null)
                {
                    this._describeElasticLoadBalancersResult = new DescribeElasticLoadBalancersResult();
                }
                return this._describeElasticLoadBalancersResult;
            }
            set { this._describeElasticLoadBalancersResult = value; }
        }
    }
}
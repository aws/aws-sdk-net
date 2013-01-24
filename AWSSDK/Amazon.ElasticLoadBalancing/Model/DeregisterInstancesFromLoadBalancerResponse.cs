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

using Amazon.Runtime;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Returns information about the  DeregisterInstancesFromLoadBalancerResult response and response metadata.
    /// </summary>
    public class DeregisterInstancesFromLoadBalancerResponse : AmazonWebServiceResponse
    {
        private DeregisterInstancesFromLoadBalancerResult deregisterInstancesFromLoadBalancerResult;

        /// <summary>
        /// Gets and sets the DeregisterInstancesFromLoadBalancerResult property.
        /// The output for the DeregisterInstancesFromLoadBalancer action.
        /// </summary>
        public DeregisterInstancesFromLoadBalancerResult DeregisterInstancesFromLoadBalancerResult
        {
            get 
            {
                if(this.deregisterInstancesFromLoadBalancerResult == null)
                {
                    this.deregisterInstancesFromLoadBalancerResult = new DeregisterInstancesFromLoadBalancerResult();
                }

                return this.deregisterInstancesFromLoadBalancerResult; 
            }
            set { this.deregisterInstancesFromLoadBalancerResult = value; }
        }
    }
}
    

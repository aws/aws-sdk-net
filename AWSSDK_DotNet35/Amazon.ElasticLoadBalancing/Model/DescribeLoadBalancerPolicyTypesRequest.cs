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
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLoadBalancerPolicyTypes operation.
    /// <para> Returns meta-information on the specified load balancer policies defined by the Elastic Load Balancing service. The policy types
    /// that are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will
    /// be applied to a load balancer. </para>
    /// </summary>
    public partial class DescribeLoadBalancerPolicyTypesRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> policyTypeNames = new List<string>();


        /// <summary>
        /// Specifies the name of the policy types. If no names are specified, returns the description of all the policy types defined by Elastic Load
        /// Balancing service.
        ///  
        /// </summary>
        public List<string> PolicyTypeNames
        {
            get { return this.policyTypeNames; }
            set { this.policyTypeNames = value; }
        }

        // Check to see if PolicyTypeNames property is set
        internal bool IsSetPolicyTypeNames()
        {
            return this.policyTypeNames.Count > 0;
        }

    }
}
    

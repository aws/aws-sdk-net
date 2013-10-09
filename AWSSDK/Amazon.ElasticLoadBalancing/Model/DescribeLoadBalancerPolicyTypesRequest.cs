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
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicyTypes"/>
    public class DescribeLoadBalancerPolicyTypesRequest : AmazonWebServiceRequest
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
        /// <summary>
        /// Adds elements to the PolicyTypeNames collection
        /// </summary>
        /// <param name="policyTypeNames">The values to add to the PolicyTypeNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBalancerPolicyTypesRequest WithPolicyTypeNames(params string[] policyTypeNames)
        {
            foreach (string element in policyTypeNames)
            {
                this.policyTypeNames.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the PolicyTypeNames collection
        /// </summary>
        /// <param name="policyTypeNames">The values to add to the PolicyTypeNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBalancerPolicyTypesRequest WithPolicyTypeNames(IEnumerable<string> policyTypeNames)
        {
            foreach (string element in policyTypeNames)
            {
                this.policyTypeNames.Add(element);
            }

            return this;
        }

        // Check to see if PolicyTypeNames property is set
        internal bool IsSetPolicyTypeNames()
        {
            return this.policyTypeNames.Count > 0;
        }
    }
}
    

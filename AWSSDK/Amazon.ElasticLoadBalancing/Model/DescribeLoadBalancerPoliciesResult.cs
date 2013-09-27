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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para>The output for the DescribeLoadBalancerPolicies action. </para>
    /// </summary>
    public class DescribeLoadBalancerPoliciesResult  
    {
        
        private List<PolicyDescription> policyDescriptions = new List<PolicyDescription>();

        /// <summary>
        /// A list of policy description structures.
        ///  
        /// </summary>
        public List<PolicyDescription> PolicyDescriptions
        {
            get { return this.policyDescriptions; }
            set { this.policyDescriptions = value; }
        }
        /// <summary>
        /// Adds elements to the PolicyDescriptions collection
        /// </summary>
        /// <param name="policyDescriptions">The values to add to the PolicyDescriptions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBalancerPoliciesResult WithPolicyDescriptions(params PolicyDescription[] policyDescriptions)
        {
            foreach (PolicyDescription element in policyDescriptions)
            {
                this.policyDescriptions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the PolicyDescriptions collection
        /// </summary>
        /// <param name="policyDescriptions">The values to add to the PolicyDescriptions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBalancerPoliciesResult WithPolicyDescriptions(IEnumerable<PolicyDescription> policyDescriptions)
        {
            foreach (PolicyDescription element in policyDescriptions)
            {
                this.policyDescriptions.Add(element);
            }

            return this;
        }

        // Check to see if PolicyDescriptions property is set
        internal bool IsSetPolicyDescriptions()
        {
            return this.policyDescriptions.Count > 0;       
        }
    }
}

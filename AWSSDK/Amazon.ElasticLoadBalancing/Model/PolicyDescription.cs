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
    /// <para> The <c>PolicyDescription</c> data type. </para>
    /// </summary>
    public class PolicyDescription  
    {
        
        private string policyName;
        private string policyTypeName;
        private List<PolicyAttributeDescription> policyAttributeDescriptions = new List<PolicyAttributeDescription>();

        /// <summary>
        /// The name mof the policy associated with the LoadBalancer.
        ///  
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        /// <summary>
        /// Sets the PolicyName property
        /// </summary>
        /// <param name="policyName">The value to set for the PolicyName property </param>
        /// <returns>this instance</returns>
        public PolicyDescription WithPolicyName(string policyName)
        {
            this.policyName = policyName;
            return this;
        }
            

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;       
        }

        /// <summary>
        /// The name of the policy type associated with the LoadBalancer.
        ///  
        /// </summary>
        public string PolicyTypeName
        {
            get { return this.policyTypeName; }
            set { this.policyTypeName = value; }
        }

        /// <summary>
        /// Sets the PolicyTypeName property
        /// </summary>
        /// <param name="policyTypeName">The value to set for the PolicyTypeName property </param>
        /// <returns>this instance</returns>
        public PolicyDescription WithPolicyTypeName(string policyTypeName)
        {
            this.policyTypeName = policyTypeName;
            return this;
        }
            

        // Check to see if PolicyTypeName property is set
        internal bool IsSetPolicyTypeName()
        {
            return this.policyTypeName != null;       
        }

        /// <summary>
        /// A list of policy attribute description structures.
        ///  
        /// </summary>
        public List<PolicyAttributeDescription> PolicyAttributeDescriptions
        {
            get { return this.policyAttributeDescriptions; }
            set { this.policyAttributeDescriptions = value; }
        }
        /// <summary>
        /// Adds elements to the PolicyAttributeDescriptions collection
        /// </summary>
        /// <param name="policyAttributeDescriptions">The values to add to the PolicyAttributeDescriptions collection </param>
        /// <returns>this instance</returns>
        public PolicyDescription WithPolicyAttributeDescriptions(params PolicyAttributeDescription[] policyAttributeDescriptions)
        {
            foreach (PolicyAttributeDescription element in policyAttributeDescriptions)
            {
                this.policyAttributeDescriptions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the PolicyAttributeDescriptions collection
        /// </summary>
        /// <param name="policyAttributeDescriptions">The values to add to the PolicyAttributeDescriptions collection </param>
        /// <returns>this instance</returns>
        public PolicyDescription WithPolicyAttributeDescriptions(IEnumerable<PolicyAttributeDescription> policyAttributeDescriptions)
        {
            foreach (PolicyAttributeDescription element in policyAttributeDescriptions)
            {
                this.policyAttributeDescriptions.Add(element);
            }

            return this;
        }

        // Check to see if PolicyAttributeDescriptions property is set
        internal bool IsSetPolicyAttributeDescriptions()
        {
            return this.policyAttributeDescriptions.Count > 0;       
        }
    }
}

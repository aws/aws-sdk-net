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
        /// The name of the policy associated with the load balancer.
        ///  
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;
        }

        /// <summary>
        /// The name of the policy type associated with the load balancer.
        ///  
        /// </summary>
        public string PolicyTypeName
        {
            get { return this.policyTypeName; }
            set { this.policyTypeName = value; }
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

        // Check to see if PolicyAttributeDescriptions property is set
        internal bool IsSetPolicyAttributeDescriptions()
        {
            return this.policyAttributeDescriptions.Count > 0;
        }
    }
}

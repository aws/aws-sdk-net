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
    /// <para> The PolicyTypeDescription data type. </para>
    /// </summary>
    public class PolicyTypeDescription
    {
        
        private string policyTypeName;
        private string description;
        private List<PolicyAttributeTypeDescription> policyAttributeTypeDescriptions = new List<PolicyAttributeTypeDescription>();

        /// <summary>
        /// The name of the policy type.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PolicyTypeDescription WithPolicyTypeName(string policyTypeName)
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
        /// A human-readable description of the policy type.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PolicyTypeDescription WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The description of the policy attributes associated with the load balancer policies defined by the Elastic Load Balancing service.
        ///  
        /// </summary>
        public List<PolicyAttributeTypeDescription> PolicyAttributeTypeDescriptions
        {
            get { return this.policyAttributeTypeDescriptions; }
            set { this.policyAttributeTypeDescriptions = value; }
        }
        /// <summary>
        /// Adds elements to the PolicyAttributeTypeDescriptions collection
        /// </summary>
        /// <param name="policyAttributeTypeDescriptions">The values to add to the PolicyAttributeTypeDescriptions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PolicyTypeDescription WithPolicyAttributeTypeDescriptions(params PolicyAttributeTypeDescription[] policyAttributeTypeDescriptions)
        {
            foreach (PolicyAttributeTypeDescription element in policyAttributeTypeDescriptions)
            {
                this.policyAttributeTypeDescriptions.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the PolicyAttributeTypeDescriptions collection
        /// </summary>
        /// <param name="policyAttributeTypeDescriptions">The values to add to the PolicyAttributeTypeDescriptions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PolicyTypeDescription WithPolicyAttributeTypeDescriptions(IEnumerable<PolicyAttributeTypeDescription> policyAttributeTypeDescriptions)
        {
            foreach (PolicyAttributeTypeDescription element in policyAttributeTypeDescriptions)
            {
                this.policyAttributeTypeDescriptions.Add(element);
            }

            return this;
        }

        // Check to see if PolicyAttributeTypeDescriptions property is set
        internal bool IsSetPolicyAttributeTypeDescriptions()
        {
            return this.policyAttributeTypeDescriptions.Count > 0;
        }
    }
}

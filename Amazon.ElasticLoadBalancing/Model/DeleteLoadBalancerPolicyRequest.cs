/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-25
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Defines the properties needed to delete a Load Balancer Policy.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class DeleteLoadBalancerPolicyRequest
    {
        private string loadBalancerNameField;
        private string policyNameField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The name of the Load Balancer whose policy is to be deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerName")]
        public string LoadBalancerName
        {
            get { return this.loadBalancerNameField; }
            set { this.loadBalancerNameField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The name of the Load Balancer whose policy is to be deleted.</param>
        /// <returns>this instance</returns>
        public DeleteLoadBalancerPolicyRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerNameField = loadBalancerName;
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerName property is set
        /// </summary>
        /// <returns>true if LoadBalancerName property is set</returns>
        public bool IsSetLoadBalancerName()
        {
            return this.loadBalancerNameField != null;
        }

        /// <summary>
        /// Gets and sets the PolicyName property.
        /// The name of the policy to be deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "PolicyName")]
        public string PolicyName
        {
            get { return this.policyNameField; }
            set { this.policyNameField = value; }
        }

        /// <summary>
        /// Sets the PolicyName property
        /// </summary>
        /// <param name="policyName">The name of the policy to be deleted.</param>
        /// <returns>this instance</returns>
        public DeleteLoadBalancerPolicyRequest WithPolicyName(string policyName)
        {
            this.policyNameField = policyName;
            return this;
        }

        /// <summary>
        /// Checks if PolicyName property is set
        /// </summary>
        /// <returns>true if PolicyName property is set</returns>
        public bool IsSetPolicyName()
        {
            return this.policyNameField != null;
        }

    }
}

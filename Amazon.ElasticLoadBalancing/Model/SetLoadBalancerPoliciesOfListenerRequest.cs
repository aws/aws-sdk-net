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
    /// Associates, updates, or disables a policy with a listener on the load balancer.
    /// Only 0 or 1 policy can be associated with a listener.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class SetLoadBalancerPoliciesOfListenerRequest
    {
        private string loadBalancerNameField;
        private Decimal? loadBalancerPortField;
        private List<string> policyNamesField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The mnemonic name associated with the LoadBalancer.
        /// The name must be unique within your AWS account.
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
        /// <param name="loadBalancerName">The mnemonic name associated with the LoadBalancer.
        /// The name must be unique within your AWS account.</param>
        /// <returns>this instance</returns>
        public SetLoadBalancerPoliciesOfListenerRequest WithLoadBalancerName(string loadBalancerName)
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
        /// Gets and sets the LoadBalancerPort property.
        /// The external port of the LoadBalancer with which this policy has to be associated.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerPort")]
        public Decimal LoadBalancerPort
        {
            get { return this.loadBalancerPortField.GetValueOrDefault(); }
            set { this.loadBalancerPortField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerPort property
        /// </summary>
        /// <param name="loadBalancerPort">The external port of the LoadBalancer with which this policy has to be associated.</param>
        /// <returns>this instance</returns>
        public SetLoadBalancerPoliciesOfListenerRequest WithLoadBalancerPort(Decimal loadBalancerPort)
        {
            this.loadBalancerPortField = loadBalancerPort;
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerPort property is set
        /// </summary>
        /// <returns>true if LoadBalancerPort property is set</returns>
        public bool IsSetLoadBalancerPort()
        {
            return this.loadBalancerPortField.HasValue;
        }

        /// <summary>
        /// Gets and sets the PolicyNames property.
        /// List of policies to be associated with the listener.
        /// This list can have at most one policy. If the list is empty,
        /// the current policy is removed from the listener.
        /// </summary>
        [XmlElementAttribute(ElementName = "PolicyNames")]
        public List<string> PolicyNames
        {
            get
            {
                if (this.policyNamesField == null)
                {
                    this.policyNamesField = new List<string>();
                }
                return this.policyNamesField;
            }
            set { this.policyNamesField = value; }
        }

        /// <summary>
        /// Sets the PolicyNames property
        /// </summary>
        /// <param name="list">List of policies to be associated with the listener.
        /// This list can have at most one policy. If the list is empty,
        /// the current policy is removed from the listener.</param>
        /// <returns>this instance</returns>
        public SetLoadBalancerPoliciesOfListenerRequest WithPolicyNames(params string[] list)
        {
            foreach (string item in list)
            {
                PolicyNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if PolicyNames property is set
        /// </summary>
        /// <returns>true if PolicyNames property is set</returns>
        public bool IsSetPolicyNames()
        {
            return (PolicyNames.Count > 0);
        }

    }
}

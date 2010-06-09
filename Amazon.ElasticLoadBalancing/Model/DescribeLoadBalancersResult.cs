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
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Returns detailed configuration information for the specified LoadBalancers, or if no LoadBalancers are specified, then the
    /// API returns configuration information for all LoadBalancers created by the caller.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DescribeLoadBalancersResult
    {
        private List<LoadBalancerDescription> loadBalancerDescriptionsField;
        /// <summary>
        /// Gets and sets the LoadBalancerDescriptions property.
        /// List of LoadBalancer description structures.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerDescriptions")]
        public List<LoadBalancerDescription> LoadBalancerDescriptions
        {
            get
            {
                if (this.loadBalancerDescriptionsField == null)
                {
                    this.loadBalancerDescriptionsField = new List<LoadBalancerDescription>();
                }
                return this.loadBalancerDescriptionsField;
            }
            set { this.loadBalancerDescriptionsField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerDescriptions property
        /// </summary>
        /// <param name="list">List of LoadBalancer description structures.</param>
        /// <returns>this instance</returns>
        public DescribeLoadBalancersResult WithLoadBalancerDescriptions(params LoadBalancerDescription[] list)
        {
            foreach (LoadBalancerDescription item in list)
            {
                LoadBalancerDescriptions.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerDescriptions property is set
        /// </summary>
        /// <returns>true if LoadBalancerDescriptions property is set</returns>
        public bool IsSetLoadBalancerDescriptions()
        {
            return (LoadBalancerDescriptions.Count > 0);
        }

    }
}

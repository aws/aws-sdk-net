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
    ///
    /// You must have created the specified input LoadBalancers in order to retrieve this information. In other words, in order to
    /// successfully call this API, you must provide the same account credentials as those that were used to create the LoadBalancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DescribeLoadBalancersRequest
    {
        private List<string> loadBalancerNamesField;

        /// <summary>
        /// Gets and sets the LoadBalancerNames property.
        /// A list of LoadBalancerNames, the mnemonic name that was associated with the LoadBalancer at creation time.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerNames")]
        public List<string> LoadBalancerNames
        {
            get
            {
                if (this.loadBalancerNamesField == null)
                {
                    this.loadBalancerNamesField = new List<string>();
                }
                return this.loadBalancerNamesField;
            }
            set { this.loadBalancerNamesField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerNames property
        /// </summary>
        /// <param name="list">A list of LoadBalancerNames, the mnemonic name that was associated with the LoadBalancer at creation time.</param>
        /// <returns>this instance</returns>
        public DescribeLoadBalancersRequest WithLoadBalancerNames(params string[] list)
        {
            foreach (string item in list)
            {
                LoadBalancerNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerNames property is set
        /// </summary>
        /// <returns>true if LoadBalancerNames property is set</returns>
        public bool IsSetLoadBalancerNames()
        {
            return (LoadBalancerNames.Count > 0);
        }

    }
}

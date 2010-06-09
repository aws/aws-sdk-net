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
    /// Returns the DNS name for the new load balancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class CreateLoadBalancerResult
    {
        private string DNSNameField;

        /// <summary>
        /// Gets and sets the DNSName property.
        /// DNS name for the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "DNSName")]
        public string DNSName
        {
            get { return this.DNSNameField ; }
            set { this.DNSNameField= value; }
        }

        /// <summary>
        /// Sets the DNSName property
        /// </summary>
        /// <param name="DNSName">DNS name for the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerResult WithDNSName(string DNSName)
        {
            this.DNSNameField = DNSName;
            return this;
        }

        /// <summary>
        /// Checks if DNSName property is set
        /// </summary>
        /// <returns>true if DNSName property is set</returns>
        public bool IsSetDNSName()
        {
            return  this.DNSNameField != null;
        }

    }
}

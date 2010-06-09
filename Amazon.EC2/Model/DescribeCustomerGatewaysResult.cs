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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Customer Gateways Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeCustomerGatewaysResult
    {
        private List<CustomerGateway> customerGatewayField;
        /// <summary>
        /// Gets and sets the CustomerGateway property.
        /// List of customer gateways
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGateway")]
        public List<CustomerGateway> CustomerGateway
        {
            get
            {
                if (this.customerGatewayField == null)
                {
                    this.customerGatewayField = new List<CustomerGateway>();
                }
                return this.customerGatewayField;
            }
            set { this.customerGatewayField = value; }
        }

        /// <summary>
        /// Sets the CustomerGateway property
        /// </summary>
        /// <param name="list">List of customer gateways</param>
        /// <returns>this instance</returns>
        public DescribeCustomerGatewaysResult WithCustomerGateway(params CustomerGateway[] list)
        {
            foreach (CustomerGateway item in list)
            {
                CustomerGateway.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if CustomerGateway property is set
        /// </summary>
        /// <returns>true if CustomerGateway property is set</returns>
        public bool IsSetCustomerGateway()
        {
            return (CustomerGateway.Count > 0);
        }

    }
}

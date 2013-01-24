/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Returns information about your customer gateways.
    /// </summary>
    /// <remarks>
    /// You can filter the results to return information only about customer gateways
    /// that match criteria you specify.
    /// 
    /// For example, you could ask to get information about a particular
    /// customer gateway (or all) only if the gateway's state is pending or
    /// available. You can specify multiple filters (e.g., the customer
    /// gateway has a particular IP address for the Internet-routable
    /// external interface, and the gateway's state is pending or
    /// available). The result includes information for a particular
    /// customer gateway only if the gateway matches all your
    /// filters. If there's no match, no special message is returned;
    /// the response is simply empty
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeCustomerGatewaysRequest
    {    
        private List<string> customerGatewayIdField;
        private List<Filter> filterField;

        /// <summary>
        /// One ore more customer gateway IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayId")]
        public List<string> CustomerGatewayId
        {
            get
            {
                if (this.customerGatewayIdField == null)
                {
                    this.customerGatewayIdField = new List<string>();
                }
                return this.customerGatewayIdField;
            }
            set { this.customerGatewayIdField = value; }
        }

        /// <summary>
        /// Sets customer gateway IDs.
        /// </summary>
        /// <param name="list">A customer gateway ID. You can specify more
        /// than one in the
        /// request</param>
        /// <returns>this instance</returns>
        public DescribeCustomerGatewaysRequest WithCustomerGatewayId(params string[] list)
        {
            foreach (string item in list)
            {
                CustomerGatewayId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if CustomerGatewayId property is set
        /// </summary>
        /// <returns>true if CustomerGatewayId property is set</returns>
        public bool IsSetCustomerGatewayId()
        {
            return (CustomerGatewayId.Count > 0);
        }

        /// <summary>
        /// The filter to apply on the results of DescribeCustomerGateways.
        /// </summary>
        /// <remarks>
        /// Filters can be:
        /// a. state - The state of the Customer Gateway. (pending,
        /// available, deleting, deleted).
        /// b. type - The type of Customer Gateway. Currently the only
        /// supported type is ipsec.1.
        /// c. ipAddress - The IP address of the customer gateway's
        /// Internet-routable external interface (e.g., 12.1.2.3).
        /// </remarks>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets the filter to apply on the results of DescribeCustomerGateways.
        /// </summary>
        /// <param name="list">The filter to apply on the results of DescribeCustomerGateways.
        /// Filters can be:
        /// a. state - The state of the Customer Gateway. (pending,
        /// available, deleting, deleted).
        /// b. type - The type of Customer Gateway. Currently the only
        /// supported type is ipsec.1.
        /// c. ipAddress - The IP address of the customer gateway's
        /// Internet-routable external interface (e.g., 12.1.2.3).</param>
        /// <returns>this instance</returns>
        public DescribeCustomerGatewaysRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}

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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCustomerGateways operation.
    /// <para> Gives you information about your customer gateways. You can filter the results to return information only about customer gateways
    /// that match criteria you specify. For example, you could ask to get information about a particular customer gateway (or all) only if the
    /// gateway's state is pending or available. You can specify multiple filters (e.g., the customer gateway has a particular IP address for the
    /// Internet-routable external interface, and the gateway's state is pending or available). The result includes information for a particular
    /// customer gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
    /// empty. The following table shows the available filters. </para>
    /// </summary>
    public partial class DescribeCustomerGatewaysRequest : AmazonEC2Request
    {
        private List<string> customerGatewayIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// A set of one or more customer gateway IDs.
        ///  
        /// </summary>
        public List<string> CustomerGatewayIds
        {
            get { return this.customerGatewayIds; }
            set { this.customerGatewayIds = value; }
        }

        // Check to see if CustomerGatewayIds property is set
        internal bool IsSetCustomerGatewayIds()
        {
            return this.customerGatewayIds.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for Customer Gateways. For a complete reference to the available filter keys for this operation,
        /// see the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    

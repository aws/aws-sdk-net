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
    /// Container for the parameters to the DescribeInternetGateways operation.
    /// <para> Gives you information about your Internet gateways. You can filter the results to return information only about Internet gateways
    /// that match criteria you specify. For example, you could get information only about gateways with particular tags. The Internet gateway must
    /// match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the
    /// Internet gateway is attached to a particular VPC and is tagged with a particular value). The result includes information for a particular
    /// Internet gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
    /// empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
    /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
    /// searches for the literal string <c>*amazon?\</c> .
    /// </para>
    /// </summary>
    public partial class DescribeInternetGatewaysRequest : AmazonEC2Request
    {
        private List<string> internetGatewayIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more Internet gateway IDs.
        ///  
        /// </summary>
        public List<string> InternetGatewayIds
        {
            get { return this.internetGatewayIds; }
            set { this.internetGatewayIds = value; }
        }

        // Check to see if InternetGatewayIds property is set
        internal bool IsSetInternetGatewayIds()
        {
            return this.internetGatewayIds.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for Internet Gateways. For a complete reference to the available filter keys for this operation,
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
    

/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Gives you information about your Internet gateways.You can filter the results to return information only
    /// about Internet gateways that match criteria you specify. For example, you could get information only
    /// about gateways with particular tags. The Internet gateway must match at least one of the specified values
    /// for it to be included in the results.
    /// 
    /// You can specify multiple filters (e.g., the Internet gateway is attached to a particular VPC and is tagged
    /// with a particular value). The result includes information for a particular Internet gateway only if the gateway
    /// matches all your filters. If there's no match, no special message is returned; the response is simply empty.
    /// 
    /// You can use wildcards with the filter values: * matches zero or more characters, and ? matches exactly
    /// one character.You can escape special characters using a backslash before the character. For example,
    /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeInternetGatewaysRequest
    {    
        private List<string> internetGatewayIdField;
        private List<Filter> filterField;

        /// <summary>
        /// Gets and sets the InternetGatewayId property.
        /// IDs of the Internet gateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "InternetGatewayId")]
        public List<string> InternetGatewayId
        {
            get
            {
                if (this.internetGatewayIdField == null)
                {
                    this.internetGatewayIdField = new List<string>();
                }
                return this.internetGatewayIdField;
            }
            set { this.internetGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the InternetGatewayId property
        /// </summary>
        /// <param name="list">IDs of the Internet gateway.</param>
        /// <returns>this instance</returns>
        public DescribeInternetGatewaysRequest WithInternetGatewayId(params string[] list)
        {
            foreach (string item in list)
            {
                InternetGatewayId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if InternetGatewayId property is set
        /// </summary>
        /// <returns>true if InternetGatewayId property is set</returns>
        public bool IsSetInternetGatewayId()
        {
            return (InternetGatewayId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Filter property.
        /// A list of filters used to match system-defined properties associated with the specified
        /// Tags.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
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
        /// Sets the Filter property
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties associated with the specified
        /// Tags.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeInternetGatewaysRequest WithFilter(params Filter[] list)
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

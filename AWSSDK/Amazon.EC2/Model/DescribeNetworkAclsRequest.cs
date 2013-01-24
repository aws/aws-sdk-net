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
    /// Gives you information about the network ACLs in your VPC.
    /// </summary>
    /// <remarks>
    /// You can filter the results to return information only about ACLs
    /// that match criteria you specify. For example, you could get information
    /// for only the ACL associated with a particular subnet.
    /// The ACL must match at least one of the specified values for it to be
    /// included in the results.
    /// 
    /// You can specify multiple filters (e.g., the ACL is associated with
    /// a particular subnet and has an egress entry that denies traffic to
    /// a particular port). The result includes information for a particular
    /// ACL only if it matches all your filters. If there's no match, no
    /// special message is returned; the response is simply empty.
    /// 
    /// You can use wildcards with the filter values: * matches zero or more
    /// characters, and ? matches exactly one character.You can escape special
    /// characters using a backslash before the character. For example,
    /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeNetworkAclsRequest
    {    
        private List<string> networkAclIdField;
        private List<Filter> filterField;

        /// <summary>
        /// IDs of the route tables.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclId")]
        public List<string> NetworkAclId
        {
            get
            {
                if (this.networkAclIdField == null)
                {
                    this.networkAclIdField = new List<string>();
                }
                return this.networkAclIdField;
            }
            set { this.networkAclIdField = value; }
        }

        /// <summary>
        /// Sets the IDs of the route tables.
        /// </summary>
        /// <param name="list">IDs of the route tables.</param>
        /// <returns>this instance</returns>
        public DescribeNetworkAclsRequest WithNetworkAclId(params string[] list)
        {
            foreach (string item in list)
            {
                NetworkAclId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if NetworkAclId property is set
        /// </summary>
        /// <returns>true if NetworkAclId property is set</returns>
        public bool IsSetNetworkAclId()
        {
            return (NetworkAclId.Count > 0);
        }

        /// <summary>
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
        /// Sets the filters used to match system-defined properties associated with the specified
        /// Tags.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties associated with the specified
        /// Tags.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeNetworkAclsRequest WithFilter(params Filter[] list)
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

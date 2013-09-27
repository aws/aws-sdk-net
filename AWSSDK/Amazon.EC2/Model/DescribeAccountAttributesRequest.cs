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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Gives you information about the attributes of the account.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeAccountAttributesRequest : EC2Request
    {
        private List<AccountAttributeName> accountAttributeNamesField;
                private List<Filter> filterField;

        /// <summary>
        /// One or more account attribute names.
        /// </summary>
        [XmlElementAttribute(ElementName = "AccountAttributeNames")]
        public List<AccountAttributeName> AccountAttributeNames
        {
            get
            {
                if (this.accountAttributeNamesField == null)
                {
                    this.accountAttributeNamesField = new List<AccountAttributeName>();
                }
                return this.accountAttributeNamesField;
            }
            set { this.accountAttributeNamesField = value; }
        }

        /// <summary>
        /// Sets account attribute names.
        /// </summary>
        /// <param name="list">Account attribute names.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAccountAttributesRequest WithAccountAttributeNames(params AccountAttributeName[] list)
        {
            foreach (AccountAttributeName item in list)
            {
                AccountAttributeNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AccountAttributeNames property is set
        /// </summary>
        /// <returns>true if AccountAttributeNames property is set</returns>
        public bool IsSetAccountAttributeNames()
        {
            return (AccountAttributeNames.Count > 0);
        }

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Attributes.
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
        /// Sets the filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Attributes.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Attributes.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAccountAttributesRequest WithFilter(params Filter[] list)
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

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
    public class DescribeAccountAttributesRequest
    {
        private List<AccountAttributeName> accountAttributeNamesField;

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
    }
}

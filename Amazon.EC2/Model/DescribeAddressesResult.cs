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
    /// Describe Addresses Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeAddressesResult
    {
        private List<Address> addressField;
        /// <summary>
        /// Gets and sets the Address property.
        /// The list of IP addresses.
        /// </summary>
        [XmlElementAttribute(ElementName = "Address")]
        public List<Address> Address
        {
            get
            {
                if (this.addressField == null)
                {
                    this.addressField = new List<Address>();
                }
                return this.addressField;
            }
            set { this.addressField = value; }
        }

        /// <summary>
        /// Sets the Address property
        /// </summary>
        /// <param name="list">The list of IP addresses.</param>
        /// <returns>this instance</returns>
        public DescribeAddressesResult WithAddress(params Address[] list)
        {
            foreach (Address item in list)
            {
                Address.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Address property is set
        /// </summary>
        /// <returns>true if Address property is set</returns>
        public bool IsSetAddress()
        {
            return (Address.Count > 0);
        }

    }
}

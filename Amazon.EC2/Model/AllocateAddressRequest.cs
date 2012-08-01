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
    /// Acquires an elastic IP address for use with your account.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AllocateAddressRequest
    {    
        private string domainField;

        /// <summary>
        /// Gets and sets the Domain property.
        /// Set to vpc to allocate the address to your VPC.
        ///
        /// Default: Address is standard (allocated to EC2)
        /// Valid Values: vpc | standard
        /// Condition: Required when allocating an address to a VPC
        /// </summary>
        [XmlElementAttribute(ElementName = "Domain")]
        public string Domain
        {
            get { return this.domainField; }
            set { this.domainField = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">Set to vpc to allocate the address to your VPC.
        ///
        /// Default: Address is standard (allocated to EC2)
        /// Valid Values: vpc | standard
        /// Condition: Required when allocating an address to a VPC</param>
        /// <returns>this instance</returns>
        public AllocateAddressRequest WithDomain(string domain)
        {
            this.domainField = domain;
            return this;
        }

        /// <summary>
        /// Checks if Domain property is set
        /// </summary>
        /// <returns>true if Domain property is set</returns>
        public bool IsSetDomain()
        {
            return this.domainField != null;
        }

    }
}

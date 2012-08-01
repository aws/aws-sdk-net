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
    /// Deletes a customer gateway. You must delete the
    /// VPN connection before deleting the customer gateway.
    ///
    /// AWS might delete any customer gateway if you leave it inactive for an
    /// extended period of time (inactive means that there's no VPN connection in
    /// use with the customer gateway).
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteCustomerGatewayRequest
    {    
        private string customerGatewayIdField;

        /// <summary>
        /// Gets and sets the CustomerGatewayId property.
        /// The ID of the customer gateway you want to
        /// delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayId")]
        public string CustomerGatewayId
        {
            get { return this.customerGatewayIdField; }
            set { this.customerGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the CustomerGatewayId property
        /// </summary>
        /// <param name="customerGatewayId">The ID of the customer gateway you want to
        /// delete.</param>
        /// <returns>this instance</returns>
        public DeleteCustomerGatewayRequest WithCustomerGatewayId(string customerGatewayId)
        {
            this.customerGatewayIdField = customerGatewayId;
            return this;
        }

        /// <summary>
        /// Checks if CustomerGatewayId property is set
        /// </summary>
        /// <returns>true if CustomerGatewayId property is set</returns>
        public bool IsSetCustomerGatewayId()
        {
            return this.customerGatewayIdField != null;
        }

    }
}

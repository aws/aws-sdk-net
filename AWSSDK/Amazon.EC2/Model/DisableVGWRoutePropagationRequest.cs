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
    /// Disables a virtual private gateway (VGW) from propagating routes to
    /// the routing tables of an Amazon VPC.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DisableVGWRoutePropagationRequest : EC2Request
    {
        private string routeTableIdField;
        private string gatewayIdField;

        /// <summary>
        /// The ID of the routing table.
        /// </summary>
        [XmlElementAttribute(ElementName = "RouteTableId")]
        public string RouteTableId
        {
            get { return this.routeTableIdField; }
            set { this.routeTableIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the routing table.
        /// </summary>
        /// <param name="routeTableId">Routing table id</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisableVGWRoutePropagationRequest WithRouteTableId(string routeTableId)
        {
            this.routeTableIdField = routeTableId;
            return this;
        }

        /// <summary>
        /// Checks is the RouteTableId property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetRouteTableId()
        {
            return !string.IsNullOrEmpty(this.routeTableIdField);
        }

        /// <summary>
        /// The ID of the Virtual Private Gateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "GatewayId")]
        public string GatewayId
        {
            get { return this.gatewayIdField; }
            set { this.gatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Virtual Private Gateway.
        /// </summary>
        /// <param name="gatewayId">Gateway Id</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisableVGWRoutePropagationRequest WithGatewayId(string gatewayId)
        {
            this.gatewayIdField = gatewayId;
            return this;
        }

        /// <summary>
        /// Checks if the GatewayId property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetGatewayId()
        {
            return !string.IsNullOrEmpty(this.gatewayIdField);
        }
    }
}

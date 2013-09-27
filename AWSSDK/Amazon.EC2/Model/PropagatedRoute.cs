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
    /// Propagated Route
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class PropagatedRoute
    {
        private string destinationCidrBlockField;
        private string gatewayIdField;
        private string statusField;
        private string sourceIdField;

        /// <summary>
        /// The CIDR block associated with local subnet of the customer data center.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationCidrBlock")]
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlockField; }
            set { this.destinationCidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CIDR block associated with local subnet of the customer data center.
        /// </summary>
        /// <param name="destinationCidrBlock">CIDR</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PropagatedRoute WithDestinationCidrBlock(string destinationCidrBlock)
        {
            this.destinationCidrBlockField = destinationCidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if the DestinationCidrBlock property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetDestinationCidrBlock()
        {
            return !string.IsNullOrEmpty(this.destinationCidrBlockField);
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
        public PropagatedRoute WithGatewayId(string gatewayId)
        {
            this.gatewayIdField = gatewayId;
            return this;
        }

        /// <summary>
        /// Checks if the GatewayId property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetGatewayId()
        {
            return !string.IsNullOrEmpty(this.gatewayIdField);
        }

        /// <summary>
        /// The status of the propagated route.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status of the propagated route.
        /// </summary>
        /// <param name="status">Route status</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PropagatedRoute WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if the Status property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetStatus()
        {
            return !string.IsNullOrEmpty(this.statusField);
        }

        /// <summary>
        /// DOCS_TODO
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceId")]
        public string SourceId
        {
            get { return this.sourceIdField; }
            set { this.sourceIdField = value; }
        }

        /// <summary>
        /// Sets the SourceId property.
        /// </summary>
        /// <param name="sourceId">DOCS_TODO</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PropagatedRoute WithSourceId(string sourceId)
        {
            this.sourceIdField = sourceId;
            return this;
        }

        /// <summary>
        /// Checks if the SourceId property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetSourceId()
        {
            return !string.IsNullOrEmpty(this.sourceIdField);
        }
    }
}

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
    /// Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AttachInternetGatewayRequest
    {    
        private string internetGatewayIdField;
        private string vpcIdField;

        /// <summary>
        /// The ID of the Internet gateway to attach.
        /// </summary>
        [XmlElementAttribute(ElementName = "InternetGatewayId")]
        public string InternetGatewayId
        {
            get { return this.internetGatewayIdField; }
            set { this.internetGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Internet gateway to attach.
        /// </summary>
        /// <param name="internetGatewayId">The ID of the Internet gateway to attach.</param>
        /// <returns>this instance</returns>
        public AttachInternetGatewayRequest WithInternetGatewayId(string internetGatewayId)
        {
            this.internetGatewayIdField = internetGatewayId;
            return this;
        }

        /// <summary>
        /// Checks if InternetGatewayId property is set
        /// </summary>
        /// <returns>true if InternetGatewayId property is set</returns>
        public bool IsSetInternetGatewayId()
        {
            return this.internetGatewayIdField != null;
        }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC.
        /// </summary>
        /// <param name="vpcId">The ID of the VPC.</param>
        /// <returns>this instance</returns>
        public AttachInternetGatewayRequest WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

    }
}

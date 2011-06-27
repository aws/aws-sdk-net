/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///VPC Attachment
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class VpcAttachment
    {    
        private string vpcIdField;
        private string vpcAttachmentStateField;

        /// <summary>
        /// Gets and sets the VpcId property.
        /// The ID of the VPC the VPN gateway is attached to
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The ID of the VPC the VPN gateway is attached to</param>
        /// <returns>this instance</returns>
        public VpcAttachment WithVpcId(string vpcId)
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

        /// <summary>
        /// Gets and sets the VpcAttachmentState property.
        /// The current state of the attachment (attaching,
        /// attached,
        /// detaching, detached)
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcAttachmentState")]
        public string VpcAttachmentState
        {
            get { return this.vpcAttachmentStateField; }
            set { this.vpcAttachmentStateField = value; }
        }

        /// <summary>
        /// Sets the VpcAttachmentState property
        /// </summary>
        /// <param name="vpcAttachmentState">The current state of the attachment (attaching,
        /// attached,
        /// detaching, detached)</param>
        /// <returns>this instance</returns>
        public VpcAttachment WithVpcAttachmentState(string vpcAttachmentState)
        {
            this.vpcAttachmentStateField = vpcAttachmentState;
            return this;
        }

        /// <summary>
        /// Checks if VpcAttachmentState property is set
        /// </summary>
        /// <returns>true if VpcAttachmentState property is set</returns>
        public bool IsSetVpcAttachmentState()
        {
            return this.vpcAttachmentStateField != null;
        }

    }
}

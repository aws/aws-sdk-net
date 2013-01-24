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
    /// Internet gateway description.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InternetGateway
    {    
        private string internetGatewayIdField;
        private List<InternetGatewayAttachment> attachmentsField;
        private List<Tag> tagField;

        /// <summary>
        /// The ID of the Internet gateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "InternetGatewayId")]
        public string InternetGatewayId
        {
            get { return this.internetGatewayIdField; }
            set { this.internetGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Internet gateway.
        /// </summary>
        /// <param name="internetGatewayId">The ID of the Internet gateway.</param>
        /// <returns>this instance</returns>
        public InternetGateway WithInternetGatewayId(string internetGatewayId)
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
        /// A list of VPCs attached to the Internet gateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attachments")]
        public List<InternetGatewayAttachment> Attachments
        {
            get
            {
                if (this.attachmentsField == null)
                {
                    this.attachmentsField = new List<InternetGatewayAttachment>();
                }
                return this.attachmentsField;
            }
            set { this.attachmentsField = value; }
        }

        /// <summary>
        /// Sets the list of VPCs attached to the Internet gateway.
        /// </summary>
        /// <param name="list">A list of VPCs attached to the Internet gateway.</param>
        /// <returns>this instance</returns>
        public InternetGateway WithAttachments(params InternetGatewayAttachment[] list)
        {
            foreach (InternetGatewayAttachment item in list)
            {
                Attachments.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attachments property is set
        /// </summary>
        /// <returns>true if Attachments property is set</returns>
        public bool IsSetAttachments()
        {
            return (Attachments.Count > 0);
        }

        /// <summary>
        /// A list of tags for the License.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the list of tags for the License.
        /// </summary>
        /// <param name="list">A list of tags for the License.</param>
        /// <returns>this instance</returns>
        public InternetGateway WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

    }
}

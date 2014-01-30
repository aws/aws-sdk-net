/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an Internet gateway.</para>
    /// </summary>
    public class InternetGateway
    {
        
        private string internetGatewayId;
        private List<InternetGatewayAttachment> attachments = new List<InternetGatewayAttachment>();
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The ID of the Internet gateway.
        ///  
        /// </summary>
        public string InternetGatewayId
        {
            get { return this.internetGatewayId; }
            set { this.internetGatewayId = value; }
        }

        // Check to see if InternetGatewayId property is set
        internal bool IsSetInternetGatewayId()
        {
            return this.internetGatewayId != null;
        }

        /// <summary>
        /// Any VPCs attached to the Internet gateway.
        ///  
        /// </summary>
        public List<InternetGatewayAttachment> Attachments
        {
            get { return this.attachments; }
            set { this.attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this.attachments.Count > 0;
        }

        /// <summary>
        /// Any tags assigned to the Internet gateway.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}

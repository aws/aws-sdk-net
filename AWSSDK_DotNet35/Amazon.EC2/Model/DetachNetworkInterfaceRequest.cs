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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DetachNetworkInterface operation.
    /// <para>Detaches a network interface from an instance.</para>
    /// </summary>
    public partial class DetachNetworkInterfaceRequest : AmazonEC2Request
    {
        private string attachmentId;
        private bool? force;


        /// <summary>
        /// The ID of the attachment.
        ///  
        /// </summary>
        public string AttachmentId
        {
            get { return this.attachmentId; }
            set { this.attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this.attachmentId != null;
        }

        /// <summary>
        /// Specifies whether to force a detachment.
        ///  
        /// </summary>
        public bool Force
        {
            get { return this.force ?? default(bool); }
            set { this.force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this.force.HasValue;
        }

    }
}
    

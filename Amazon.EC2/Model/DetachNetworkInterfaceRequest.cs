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
 *  API Version: 2012-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Detach Network Interface request
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-06-15/", IsNullable = false)]
    public class DetachNetworkInterfaceRequest
    {
        private string attachmentIdField;
        private bool? forceField;

        /// <summary>
        /// Gets and sets the ID of the attachment to detach
        /// </summary>
        public string AttachmentId
        {
            get { return this.attachmentIdField; }
            set { this.attachmentIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the attachment to detach
        /// </summary>
        /// <param name="attachmentId">ID of the attachment</param>
        /// <returns>this instance</returns>
        public DetachNetworkInterfaceRequest WithAttachmentId(string attachmentId)
        {
            this.attachmentIdField = attachmentId;
            return this;
        }

        /// <summary>
        /// Checks if the AttachmentId property is set
        /// </summary>
        /// <returns>true if the AttachmentId property is set</returns>
        public bool IsSetAttachmentId()
        {
            return !string.IsNullOrEmpty(this.attachmentIdField);
        }

        /// <summary>
        /// Gets and sets whether to force the detachment
        /// </summary>
        public bool Force
        {
            get { return this.forceField.GetValueOrDefault(); }
            set { this.forceField = value; }
        }

        /// <summary>
        /// Sets whether to force the detachment
        /// </summary>
        /// <param name="force">Set to true to force a detachment.</param>
        /// <returns>this instance</returns>
        public DetachNetworkInterfaceRequest WithForce(bool force)
        {
            this.forceField = force;
            return this;
        }

        /// <summary>
        /// Checks if the Force property is set
        /// </summary>
        /// <returns>true if the Force property is set</returns>
        public bool IsSetForce()
        {
            return this.forceField != null;
        }
    }
}

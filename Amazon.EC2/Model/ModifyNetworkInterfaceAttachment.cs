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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Modify Network Interface Attachment
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ModifyNetworkInterfaceAttachment
    {
        private string attachmentIdField;
        private bool? deleteOnTerminationField;

        /// <summary>
        /// Gets and sets the AttachmentId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttachmentId")]
        public string AttachmentId
        {
            get { return this.attachmentIdField; }
            set { this.attachmentIdField = value; }
        }

        /// <summary>
        /// Sets the AttachmentId property.
        /// </summary>
        /// <param name="attachmentId">Attachment Id</param>
        /// <returns>this instance</returns>
        public ModifyNetworkInterfaceAttachment WithAttachmentId(string attachmentId)
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
        /// Gets and sets the DeleteOnTermination property
        /// </summary>
        [XmlElementAttribute(ElementName = "DeleteOnTermination")]
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTerminationField.GetValueOrDefault(); }
            set { this.deleteOnTerminationField = value; }
        }

        /// <summary>
        /// Sets the DeleteOnTermination property
        /// </summary>
        /// <param name="deleteOnTermination">true to delete on termination</param>
        /// <returns>this instance</returns>
        public ModifyNetworkInterfaceAttachment WithDeleteOnTermination(bool deleteOnTermination)
        {
            this.deleteOnTerminationField = deleteOnTermination;
            return this;
        }

        /// <summary>
        /// Checks if the DeleteOnTermination property is set
        /// </summary>
        /// <returns>true if the DeleteOnTermination property is set</returns>
        public bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTerminationField != null;
        }
    }
}

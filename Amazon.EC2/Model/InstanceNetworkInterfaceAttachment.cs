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
    /// Instance Network Interface Attachment
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-06-15/", IsNullable = false)]
    public class InstanceNetworkInterfaceAttachment
    {
        private string attachmentIdField;
        private int? deviceIndexField;
        private string statusField;
        private string attachTimeField;
        private bool? deleteOnTerminationField;

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
        public InstanceNetworkInterfaceAttachment WithAttachmentId(string attachmentId)
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
        /// Gets and sets the index of the device for the network interface attachment on the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeviceIndex")]
        public int DeviceIndex
        {
            get { return this.deviceIndexField.GetValueOrDefault(); }
            set { this.deviceIndexField = value; }
        }

        /// <summary>
        /// Sets the index of the device for the network interface attachment on the instance.
        /// </summary>
        /// <param name="deviceIndex">The device index</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceAttachment WithDeviceIndex(int deviceIndex)
        {
            this.deviceIndexField = deviceIndex;
            return this;
        }

        /// <summary>
        /// Checks if the DeviceIndex property is set
        /// </summary>
        /// <returns>true if the DeviceIndex property is set</returns>
        public bool IsSetDeviceIndex()
        {
            return this.deviceIndexField != null;
        }

        /// <summary>
        /// Gets and sets the Status property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">Attachment status</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceAttachment WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if the Status property is set
        /// </summary>
        /// <returns>true if the Status property is set</returns>
        public bool IsSetStatus()
        {
            return !string.IsNullOrEmpty(this.statusField);
        }

        /// <summary>
        /// Gets and sets the AttachTime property
        /// </summary>
        [XmlElementAttribute(ElementName = "AttachTime")]
        public string AttachTime
        {
            get { return this.attachTimeField; }
            set { this.attachTimeField = value; }
        }

        /// <summary>
        /// Sets the AttachTime property
        /// </summary>
        /// <param name="attachTime">Attach Time</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceAttachment WithAttachTime(string attachTime)
        {
            this.attachTimeField = attachTime;
            return this;
        }

        /// <summary>
        /// Checks if the AttachTime property is set
        /// </summary>
        /// <returns>true if the AttachTime property is set</returns>
        public bool IsSetAttachTime()
        {
            return !string.IsNullOrEmpty(this.attachTimeField);
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
        /// <param name="deleteOnTermination">True if the attachment should be deleted on termination</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceAttachment WithDeleteOnTermination(bool deleteOnTermination)
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

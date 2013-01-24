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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Network Interface Attachment
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class NetworkInterfaceAttachment
    {
        private string attachmentIdField;
        private string instanceIdField;
        private string instanceOwnerIdField;
        private int? deviceIndexField;
        private string statusField;
        private string attachTimeField;
        private bool? deleteOnTerminationField;

        /// <summary>
        /// The ID of the network interface attachment.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttachmentId")]
        public string AttachmentId
        {
            get { return this.attachmentIdField; }
            set { this.attachmentIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the network interface attachment.
        /// </summary>
        /// <param name="attachmentId">Attachment Id</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttachment WithAttachmentId(string attachmentId)
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
        /// The ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the instance.
        /// </summary>
        /// <param name="instanceId">Instance ID</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttachment WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceId property is set
        /// </summary>
        /// <returns>true if the InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return !string.IsNullOrEmpty(this.instanceIdField);
        }

        /// <summary>
        /// The owner of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceOwnerId")]
        public string InstanceOwnerId
        {
            get { return this.instanceOwnerIdField; }
            set { this.instanceOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the owner of the instance.
        /// </summary>
        /// <param name="instanceOwnerId">Instance Owner ID</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttachment WithInstanceOwnerId(string instanceOwnerId)
        {
            this.instanceOwnerIdField = instanceOwnerId;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceOwnerId property is set
        /// </summary>
        /// <returns>true if the InstanceOwnerId property is set</returns>
        public bool IsSetInstanceOwnerId()
        {
            return !string.IsNullOrEmpty(this.instanceOwnerIdField);
        }

        /// <summary>
        /// The index of the device for the network interface attachment on the instance.
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
        /// <param name="deviceIndex">Device Index</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttachment WithDeviceIndex(int deviceIndex)
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
        /// The status of the network interface attachment.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status of the network interface attachment.
        /// </summary>
        /// <param name="status">Status</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttachment WithStatus(string status)
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
        /// The time stamp when the attachment initiated.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttachTime")]
        public string AttachTime
        {
            get { return this.attachTimeField; }
            set { this.attachTimeField = value; }
        }

        /// <summary>
        /// Sets the time stamp when the attachment initiated.
        /// </summary>
        /// <param name="attachTime">Attach Time</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttachment WithAttachTime(string attachTime)
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
        /// Whether the attachment is deleted on instance termination.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeleteOnTermination")]
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTerminationField.GetValueOrDefault(); }
            set { this.deleteOnTerminationField = value; }
        }

        /// <summary>
        /// Sets whether the attachment is deleted on instance termination.
        /// </summary>
        /// <param name="deleteOnTermination">True if the attachment should be deleted on termination</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttachment WithDeleteOnTermination(bool deleteOnTermination)
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

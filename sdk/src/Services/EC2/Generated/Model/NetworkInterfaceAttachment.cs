/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a network interface attachment.
    /// </summary>
    public partial class NetworkInterfaceAttachment
    {
        private string _attachmentId;
        private DateTime? _attachTime;
        private bool? _deleteOnTermination;
        private int? _deviceIndex;
        private AttachmentEnaSrdSpecification _enaSrdSpecification;
        private string _instanceId;
        private string _instanceOwnerId;
        private int? _networkCardIndex;
        private AttachmentStatus _status;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the network interface attachment.
        /// </para>
        /// </summary>
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AttachTime. 
        /// <para>
        /// The timestamp indicating when the attachment initiated.
        /// </para>
        /// </summary>
        public DateTime AttachTime
        {
            get { return this._attachTime.GetValueOrDefault(); }
            set { this._attachTime = value; }
        }

        // Check to see if AttachTime property is set
        internal bool IsSetAttachTime()
        {
            return this._attachTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the network interface is deleted when the instance is terminated.
        /// </para>
        /// </summary>
        public bool DeleteOnTermination
        {
            get { return this._deleteOnTermination.GetValueOrDefault(); }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The device index of the network interface attachment on the instance.
        /// </para>
        /// </summary>
        public int DeviceIndex
        {
            get { return this._deviceIndex.GetValueOrDefault(); }
            set { this._deviceIndex = value; }
        }

        // Check to see if DeviceIndex property is set
        internal bool IsSetDeviceIndex()
        {
            return this._deviceIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSrdSpecification. 
        /// <para>
        /// Configures ENA Express for the network interface that this action attaches to the
        /// instance.
        /// </para>
        /// </summary>
        public AttachmentEnaSrdSpecification EnaSrdSpecification
        {
            get { return this._enaSrdSpecification; }
            set { this._enaSrdSpecification = value; }
        }

        // Check to see if EnaSrdSpecification property is set
        internal bool IsSetEnaSrdSpecification()
        {
            return this._enaSrdSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the instance.
        /// </para>
        /// </summary>
        public string InstanceOwnerId
        {
            get { return this._instanceOwnerId; }
            set { this._instanceOwnerId = value; }
        }

        // Check to see if InstanceOwnerId property is set
        internal bool IsSetInstanceOwnerId()
        {
            return this._instanceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card.
        /// </para>
        /// </summary>
        public int NetworkCardIndex
        {
            get { return this._networkCardIndex.GetValueOrDefault(); }
            set { this._networkCardIndex = value; }
        }

        // Check to see if NetworkCardIndex property is set
        internal bool IsSetNetworkCardIndex()
        {
            return this._networkCardIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The attachment state.
        /// </para>
        /// </summary>
        public AttachmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
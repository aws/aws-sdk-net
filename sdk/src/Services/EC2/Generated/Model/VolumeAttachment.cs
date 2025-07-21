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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes volume attachment details.
    /// </summary>
    public partial class VolumeAttachment
    {
        private string _associatedResource;
        private DateTime? _attachTime;
        private bool? _deleteOnTermination;
        private string _device;
        private string _instanceId;
        private string _instanceOwningService;
        private VolumeAttachmentState _state;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property AssociatedResource. 
        /// <para>
        /// The ARN of the Amazon Web Services-managed resource to which the volume is attached.
        /// </para>
        /// </summary>
        public string AssociatedResource
        {
            get { return this._associatedResource; }
            set { this._associatedResource = value; }
        }

        // Check to see if AssociatedResource property is set
        internal bool IsSetAssociatedResource()
        {
            return this._associatedResource != null;
        }

        /// <summary>
        /// Gets and sets the property AttachTime. 
        /// <para>
        /// The time stamp when the attachment initiated.
        /// </para>
        /// </summary>
        public DateTime? AttachTime
        {
            get { return this._attachTime; }
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
        /// Indicates whether the EBS volume is deleted on instance termination.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination
        {
            get { return this._deleteOnTermination; }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device name.
        /// </para>
        ///  
        /// <para>
        /// If the volume is attached to an Amazon Web Services-managed resource, this parameter
        /// returns <c>null</c>.
        /// </para>
        /// </summary>
        public string Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        ///  
        /// <para>
        /// If the volume is attached to an Amazon Web Services-managed resource, this parameter
        /// returns <c>null</c>.
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
        /// Gets and sets the property InstanceOwningService. 
        /// <para>
        /// The service principal of the Amazon Web Services service that owns the underlying
        /// resource to which the volume is attached.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only for volumes that are attached to Amazon Web Services-managed
        /// resources.
        /// </para>
        /// </summary>
        public string InstanceOwningService
        {
            get { return this._instanceOwningService; }
            set { this._instanceOwningService = value; }
        }

        // Check to see if InstanceOwningService property is set
        internal bool IsSetInstanceOwningService()
        {
            return this._instanceOwningService != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The attachment state of the volume.
        /// </para>
        /// </summary>
        public VolumeAttachmentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}
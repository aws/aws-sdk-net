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
    /// Describes a parameter used to set up an EBS volume in a block device mapping.
    /// </summary>
    public partial class EbsInstanceBlockDevice
    {
        private string _associatedResource;
        private DateTime? _attachTime;
        private bool? _deleteOnTermination;
        private OperatorResponse _operator;
        private AttachmentStatus _status;
        private string _volumeId;
        private string _volumeOwnerId;

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
        /// Indicates whether the volume is deleted on instance termination.
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
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the EBS volume.
        /// </para>
        /// </summary>
        public OperatorResponse Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
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

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the EBS volume.
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

        /// <summary>
        /// Gets and sets the property VolumeOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the volume.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only for volumes that are attached to Amazon Web Services-managed
        /// resources.
        /// </para>
        /// </summary>
        public string VolumeOwnerId
        {
            get { return this._volumeOwnerId; }
            set { this._volumeOwnerId = value; }
        }

        // Check to see if VolumeOwnerId property is set
        internal bool IsSetVolumeOwnerId()
        {
            return this._volumeOwnerId != null;
        }

    }
}
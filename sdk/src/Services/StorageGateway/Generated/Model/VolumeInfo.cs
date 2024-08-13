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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a storage volume object.
    /// </summary>
    public partial class VolumeInfo
    {
        private string _gatewayARN;
        private string _gatewayId;
        private string _volumeARN;
        private string _volumeAttachmentStatus;
        private string _volumeId;
        private long? _volumeSizeInBytes;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier assigned to your gateway during activation. This ID becomes
        /// part of the gateway Amazon Resource Name (ARN), which you use as input for other operations.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 50 to 500 lowercase letters, numbers, periods (.), and hyphens (-).
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=30)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the storage volume. For example, the following
        /// is a valid ARN:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:storagegateway:us-east-2:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 50 to 500 lowercase letters, numbers, periods (.), and hyphens (-).
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string VolumeARN
        {
            get { return this._volumeARN; }
            set { this._volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this._volumeARN != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeAttachmentStatus. 
        /// <para>
        /// One of the VolumeStatus values that indicates the state of the storage volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=50)]
        public string VolumeAttachmentStatus
        {
            get { return this._volumeAttachmentStatus; }
            set { this._volumeAttachmentStatus = value; }
        }

        // Check to see if VolumeAttachmentStatus property is set
        internal bool IsSetVolumeAttachmentStatus()
        {
            return this._volumeAttachmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The unique identifier assigned to the volume. This ID becomes part of the volume Amazon
        /// Resource Name (ARN), which you use as input for other operations.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 50 to 500 lowercase letters, numbers, periods (.), and hyphens (-).
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=30)]
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
        /// Gets and sets the property VolumeSizeInBytes. 
        /// <para>
        /// The size of the volume in bytes.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 50 to 500 lowercase letters, numbers, periods (.), and hyphens (-).
        /// </para>
        /// </summary>
        public long? VolumeSizeInBytes
        {
            get { return this._volumeSizeInBytes; }
            set { this._volumeSizeInBytes = value; }
        }

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this._volumeSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// One of the VolumeType enumeration values describing the type of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}
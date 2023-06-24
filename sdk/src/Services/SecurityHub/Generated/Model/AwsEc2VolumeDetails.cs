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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an EC2 volume.
    /// </summary>
    public partial class AwsEc2VolumeDetails
    {
        private List<AwsEc2VolumeAttachment> _attachments = new List<AwsEc2VolumeAttachment>();
        private string _createTime;
        private string _deviceName;
        private bool? _encrypted;
        private string _kmsKeyId;
        private int? _size;
        private string _snapshotId;
        private string _status;
        private string _volumeId;
        private string _volumeScanStatus;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The volume attachments.
        /// </para>
        /// </summary>
        public List<AwsEc2VolumeAttachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Indicates when the volume was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name for the volume that is attached to the instance. 
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the volume is encrypted.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key that was used to protect the volume encryption key for the
        /// volume.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the volume, in GiBs.
        /// </para>
        /// </summary>
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot from which the volume was created.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The volume state. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>available</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>creating</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleted</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleting</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>error</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>in-use</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
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

        /// <summary>
        /// Gets and sets the property VolumeScanStatus. 
        /// <para>
        /// Indicates whether the volume was scanned or skipped. 
        /// </para>
        /// </summary>
        public string VolumeScanStatus
        {
            get { return this._volumeScanStatus; }
            set { this._volumeScanStatus = value; }
        }

        // Check to see if VolumeScanStatus property is set
        internal bool IsSetVolumeScanStatus()
        {
            return this._volumeScanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. 
        /// </para>
        /// </summary>
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
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an EC2 volume.
    /// </summary>
    public partial class AwsEc2VolumeDetails
    {
        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The volume attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2VolumeAttachment> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2VolumeAttachment>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Indicates when the volume was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name for the volume that is attached to the instance. 
        /// </para>
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the volume is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key that was used to protect the volume encryption key for the
        /// volume.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the volume, in GiBs.
        /// </para>
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot from which the volume was created.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The volume state. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>available</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>creating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>in-use</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume. 
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeScanStatus. 
        /// <para>
        /// Indicates whether the volume was scanned or skipped. 
        /// </para>
        /// </summary>
        public string VolumeScanStatus { get; set; }

        /// <summary>
        /// Checks to see if the VolumeScanStatus property is set.
        /// </summary>
        internal bool IsSetVolumeScanStatus() => this.VolumeScanStatus != null;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. 
        /// </para>
        /// </summary>
        public string VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}

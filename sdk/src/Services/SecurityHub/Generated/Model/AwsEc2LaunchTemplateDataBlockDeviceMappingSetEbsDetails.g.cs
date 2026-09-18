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
    /// Parameters for a block device for an Amazon Elastic Block Store (Amazon EBS) volume
    /// in an Amazon EC2 launch template.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataBlockDeviceMappingSetEbsDetails
    {
        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        ///  Indicates whether the EBS volume is deleted on instance termination. 
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        ///  Indicates whether the EBS volume is encrypted. Encrypted volumes can only be attached
        /// to instances that support Amazon EBS encryption. If you're creating a volume from
        /// a snapshot, you can't specify an encryption value. 
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        ///  The number of I/O operations per second (IOPS). 
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the symmetric Key Management Service (KMS) customer
        /// managed key used for encryption. 
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        ///  The ID of the EBS snapshot. 
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        ///  The throughput to provision for a gp3 volume, with a maximum of 1,000 MiB/s. 
        /// </para>
        /// </summary>
        public int? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        ///  The size of the volume, in GiBs. You must specify either a snapshot ID or a volume
        /// size. 
        /// </para>
        /// </summary>
        public int? VolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSize property is set.
        /// </summary>
        internal bool IsSetVolumeSize() => this.VolumeSize.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        ///  The volume type. 
        /// </para>
        /// </summary>
        public string VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}

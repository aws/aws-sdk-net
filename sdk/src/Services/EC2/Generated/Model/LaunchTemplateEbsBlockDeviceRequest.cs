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
    /// The parameters for a block device for an EBS volume.
    /// </summary>
    public partial class LaunchTemplateEbsBlockDeviceRequest
    {
        private bool? _deleteOnTermination;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private string _snapshotId;
        private int? _throughput;
        private int? _volumeInitializationRate;
        private int? _volumeSize;
        private VolumeType _volumeType;

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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the EBS volume is encrypted. Encrypted volumes can only be attached
        /// to instances that support Amazon EBS encryption. If you are creating a volume from
        /// a snapshot, you can't specify an encryption value.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS). For <c>gp3</c>, <c>io1</c>, and <c>io2</c>
        /// volumes, this represents the number of IOPS that are provisioned for the volume. For
        /// <c>gp2</c> volumes, this represents the baseline performance of the volume and the
        /// rate at which the volume accumulates I/O credits for bursting.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported values for each volume type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp3</c>: 3,000 - 80,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c>: 100 - 64,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io2</c>: 100 - 256,000 IOPS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For <c>io2</c> volumes, you can achieve up to 256,000 IOPS on <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html">instances
        /// built on the Nitro System</a>. On other instances, you can achieve performance up
        /// to 32,000 IOPS.
        /// </para>
        ///  
        /// <para>
        /// This parameter is supported for <c>io1</c>, <c>io2</c>, and <c>gp3</c> volumes only.
        /// </para>
        /// </summary>
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Identifier (key ID, key alias, key ARN, or alias ARN) of the customer managed KMS
        /// key to use for EBS encryption.
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
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
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
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to provision for a <c>gp3</c> volume, with a maximum of 2,000 MiB/s.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 125. Maximum value of 2,000.
        /// </para>
        /// </summary>
        public int? Throughput
        {
            get { return this._throughput; }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeInitializationRate. 
        /// <para>
        /// Specifies the Amazon EBS Provisioned Rate for Volume Initialization (volume initialization
        /// rate), in MiB/s, at which to download the snapshot blocks from Amazon S3 to the volume.
        /// This is also known as <i>volume initialization</i>. Specifying a volume initialization
        /// rate ensures that the volume is initialized at a predictable and consistent rate after
        /// creation.
        /// </para>
        ///  
        /// <para>
        /// This parameter is supported only for volumes created from snapshots. Omit this parameter
        /// if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You want to create the volume using fast snapshot restore. You must specify a snapshot
        /// that is enabled for fast snapshot restore. In this case, the volume is fully initialized
        /// at creation.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify a snapshot that is enabled for fast snapshot restore and a volume initialization
        /// rate, the volume will be initialized at the specified rate instead of fast snapshot
        /// restore.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// You want to create a volume that is initialized at the default rate.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/initalize-volume.html">
        /// Initialize Amazon EBS volumes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid range: 100 - 300 MiB/s
        /// </para>
        /// </summary>
        public int? VolumeInitializationRate
        {
            get { return this._volumeInitializationRate; }
            set { this._volumeInitializationRate = value; }
        }

        // Check to see if VolumeInitializationRate property is set
        internal bool IsSetVolumeInitializationRate()
        {
            return this._volumeInitializationRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiBs. You must specify either a snapshot ID or a volume
        /// size. The following are the supported volumes sizes for each volume type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp2</c>: 1 - 16,384 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>gp3</c>: 1 - 65,536 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c>: 4 - 16,384 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io2</c>: 4 - 65,536 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>st1</c> and <c>sc1</c>: 125 - 16,384 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>standard</c>: 1 - 1024 GiB
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? VolumeSize
        {
            get { return this._volumeSize; }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volume-types.html">Amazon
        /// EBS volume types</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public VolumeType VolumeType
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
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
    /// Describes a block device for an EBS volume.
    /// </summary>
    public partial class FleetEbsBlockDeviceRequest
    {
        private bool? _deleteOnTermination;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private string _snapshotId;
        private int? _throughput;
        private int? _volumeSize;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the EBS volume is deleted on instance termination. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/preserving-volumes-on-termination.html">Preserve
        /// data when an instance is terminated</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Indicates whether the encryption state of an EBS volume is changed while being restored
        /// from a backing snapshot. The effect of setting the encryption state to <c>true</c>
        /// depends on the volume origin (new or from a snapshot), starting encryption state,
        /// ownership, and whether encryption by default is enabled. For more information, see
        /// <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-encryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// In no case can you remove encryption from an encrypted volume.
        /// </para>
        ///  
        /// <para>
        /// Encrypted volumes can only be attached to instances that support Amazon EBS encryption.
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-encryption-requirements.html#ebs-encryption_supported_instances">Supported
        /// instance types</a>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not returned by <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeImageAttribute">DescribeImageAttribute</a>.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateImage">CreateImage</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RegisterImage">RegisterImage</a>,
        /// whether you can include this parameter, and the allowed values differ depending on
        /// the type of block device mapping you are creating.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are creating a block device mapping for a <b>new (empty) volume</b>, you can
        /// include this parameter, and specify either <c>true</c> for an encrypted volume, or
        /// <c>false</c> for an unencrypted volume. If you omit this parameter, it defaults to
        /// <c>false</c> (unencrypted).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are creating a block device mapping from an <b>existing encrypted or unencrypted
        /// snapshot</b>, you must omit this parameter. If you include this parameter, the request
        /// will fail, regardless of the value that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are creating a block device mapping from an <b>existing unencrypted volume</b>,
        /// you can include this parameter, but you must specify <c>false</c>. If you specify
        /// <c>true</c>, the request will fail. In this case, we recommend that you omit the parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are creating a block device mapping from an <b>existing encrypted volume</b>,
        /// you can include this parameter, and specify either <c>true</c> or <c>false</c>. However,
        /// if you specify <c>false</c>, the parameter is ignored and the block device mapping
        /// is always encrypted. In this case, we recommend that you omit the parameter.
        /// </para>
        ///  </li> </ul>
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
        /// For <c>io2</c> volumes, you can achieve up to 256,000 IOPS on <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">instances
        /// built on the Nitro System</a>. On other instances, you can achieve performance up
        /// to 32,000 IOPS.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for <c>io1</c> and <c>io2</c> volumes. The default for
        /// <c>gp3</c> volumes is 3,000 IOPS.
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
        ///  
        /// <para>
        /// This parameter is only supported on <c>BlockDeviceMapping</c> objects called by <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet.html">CreateFleet</a>,
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotInstances.html">RequestSpotInstances</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>.
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
        /// The throughput that the volume supports, in MiB/s.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only for <c>gp3</c> volumes.
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
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiBs. You must specify either a snapshot ID or a volume
        /// size. If you specify a snapshot, the default is the snapshot size. You can specify
        /// a volume size that is equal to or larger than the snapshot size.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported sizes for each volume type:
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
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
    /// Describes a block device for an EBS volume.
    /// </summary>
    public partial class EbsBlockDevice
    {
        private bool? _deleteOnTermination;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private string _outpostArn;
        private string _snapshotId;
        private int? _throughput;
        private int? _volumeSize;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the EBS volume is deleted on instance termination. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/terminating-instances.html#preserving-volumes-on-termination">Preserving
        /// Amazon EBS volumes on instance termination</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the encryption state of an EBS volume is changed while being restored
        /// from a backing snapshot. The effect of setting the encryption state to <code>true</code>
        /// depends on the volume origin (new or from a snapshot), starting encryption state,
        /// ownership, and whether encryption by default is enabled. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#encryption-parameters">Amazon
        /// EBS encryption</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// In no case can you remove encryption from an encrypted volume.
        /// </para>
        ///  
        /// <para>
        /// Encrypted volumes can only be attached to instances that support Amazon EBS encryption.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
        /// instance types</a>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not returned by <a>DescribeImageAttribute</a>.
        /// </para>
        ///  
        /// <para>
        /// For <a>CreateImage</a> and <a>RegisterImage</a>, whether you can include this parameter,
        /// and the allowed values differ depending on the type of block device mapping you are
        /// creating.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are creating a block device mapping for a <b>new (empty) volume</b>, you can
        /// include this parameter, and specify either <code>true</code> for an encrypted volume,
        /// or <code>false</code> for an unencrypted volume. If you omit this parameter, it defaults
        /// to <code>false</code> (unencrypted).
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
        /// you can include this parameter, but you must specify <code>false</code>. If you specify
        /// <code>true</code>, the request will fail. In this case, we recommend that you omit
        /// the parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are creating a block device mapping from an <b>existing encrypted volume</b>,
        /// you can include this parameter, and specify either <code>true</code> or <code>false</code>.
        /// However, if you specify <code>false</code>, the parameter is ignored and the block
        /// device mapping is always encrypted. In this case, we recommend that you omit the parameter.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS). For <code>gp3</code>, <code>io1</code>,
        /// and <code>io2</code> volumes, this represents the number of IOPS that are provisioned
        /// for the volume. For <code>gp2</code> volumes, this represents the baseline performance
        /// of the volume and the rate at which the volume accumulates I/O credits for bursting.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported values for each volume type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>gp3</code>: 3,000-16,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io1</code>: 100-64,000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io2</code>: 100-64,000 IOPS
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For <code>io1</code> and <code>io2</code> volumes, we guarantee 64,000 IOPS only for
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Instances
        /// built on the Nitro System</a>. Other instance families guarantee performance up to
        /// 32,000 IOPS.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for <code>io1</code> and <code>io2</code> volumes. The
        /// default for <code>gp3</code> volumes is 3,000 IOPS. This parameter is not supported
        /// for <code>gp2</code>, <code>st1</code>, <code>sc1</code>, or <code>standard</code>
        /// volumes.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
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
        /// Identifier (key ID, key alias, ID ARN, or alias ARN) for a customer managed CMK under
        /// which the EBS volume is encrypted.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only supported on <code>BlockDeviceMapping</code> objects called
        /// by <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>,
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotFleet.html">RequestSpotFleet</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotInstances.html">RequestSpotInstances</a>.
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN of the Outpost on which the snapshot is stored.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only supported on <code>BlockDeviceMapping</code> objects called
        /// by <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateImage.html">
        /// CreateImage</a>.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
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
        /// This parameter is valid only for <code>gp3</code> volumes.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 125. Maximum value of 1000.
        /// </para>
        /// </summary>
        public int Throughput
        {
            get { return this._throughput.GetValueOrDefault(); }
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
        /// The following are the supported volumes sizes for each volume type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>gp2</code> and <code>gp3</code>:1-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io1</code> and <code>io2</code>: 4-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>st1</code> and <code>sc1</code>: 125-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>standard</code>: 1-1,024
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int VolumeSize
        {
            get { return this._volumeSize.GetValueOrDefault(); }
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
        /// The volume type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS volume types</a> in the <i>Amazon EC2 User Guide</i>. If the volume type is <code>io1</code>
        /// or <code>io2</code>, you must specify the IOPS that the volume supports.
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
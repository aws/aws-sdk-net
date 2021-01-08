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
        private int? _volumeSize;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the EBS volume is deleted on instance termination.
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
        /// Indicates whether the EBS volume is encrypted. Encrypted volumes can only be attached
        /// to instances that support Amazon EBS encryption. If you are creating a volume from
        /// a snapshot, you can't specify an encryption value.
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
        /// The ARN of the symmetric AWS Key Management Service (AWS KMS) CMK used for encryption.
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
        /// The throughput to provision for a <code>gp3</code> volume, with a maximum of 1,000
        /// MiB/s.
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
        ///  <code>gp2</code> and <code>gp3</code>: 1-16,384
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
        /// The volume type. The default is <code>gp2</code>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS volume types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
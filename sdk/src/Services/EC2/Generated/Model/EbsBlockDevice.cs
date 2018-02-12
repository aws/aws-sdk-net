/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private string _snapshotId;
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
        /// a snapshot, you can't specify an encryption value. This is because only blank volumes
        /// can be encrypted on creation.
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
        /// The number of I/O operations per second (IOPS) that the volume supports. For <code>io1</code>,
        /// this represents the number of IOPS that are provisioned for the volume. For <code>gp2</code>,
        /// this represents the baseline performance of the volume and the rate at which the volume
        /// accumulates I/O credits for bursting. For more information about General Purpose SSD
        /// baseline performance, I/O credits, and bursting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS Volume Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Range is 100-20000 IOPS for <code>io1</code> volumes and 100-10000 IOPS
        /// for <code>gp2</code> volumes.
        /// </para>
        ///  
        /// <para>
        /// Condition: This parameter is required for requests to create <code>io1</code> volumes;
        /// it is not used in requests to create <code>gp2</code>, <code>st1</code>, <code>sc1</code>,
        /// or <code>standard</code> volumes.
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
        /// Identifier (key ID, key alias, ID ARN, or alias ARN) for a user-managed CMK under
        /// which the EBS volume is encrypted.
        /// </para>
        ///  
        /// <para>
        /// Note: This parameter is only supported on <code>BlockDeviceMapping</code> objects
        /// called by <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>,
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotFleet.html">RequestSpotFleet</a>,
        /// and <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotInstances.html">RequestSpotInstances</a>.
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
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        ///  
        /// <para>
        /// Constraints: 1-16384 for General Purpose SSD (<code>gp2</code>), 4-16384 for Provisioned
        /// IOPS SSD (<code>io1</code>), 500-16384 for Throughput Optimized HDD (<code>st1</code>),
        /// 500-16384 for Cold HDD (<code>sc1</code>), and 1-1024 for Magnetic (<code>standard</code>)
        /// volumes. If you specify a snapshot, the volume size must be equal to or larger than
        /// the snapshot size.
        /// </para>
        ///  
        /// <para>
        /// Default: If you're creating the volume from a snapshot and don't specify a volume
        /// size, the default is the snapshot size.
        /// </para>
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
        /// The volume type: <code>gp2</code>, <code>io1</code>, <code>st1</code>, <code>sc1</code>,
        /// or <code>standard</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>standard</code> 
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
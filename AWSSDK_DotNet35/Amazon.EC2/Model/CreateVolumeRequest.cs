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
 * Do not modify this file. This file is generated from the ec2-2014-06-15.normal.json service model.
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
    /// Container for the parameters to the CreateVolume operation.
    /// Creates an Amazon EBS volume that can be attached to an instance in the same Availability
    /// Zone. The volume is created in the specified region.
    /// 
    ///  
    /// <para>
    /// You can create a new empty volume or restore a volume from an Amazon EBS snapshot.
    /// Any AWS Marketplace product codes from the snapshot are propagated to the volume.
    /// </para>
    ///  
    /// <para>
    /// You can create encrypted volumes with the <code>Encrypted</code> parameter. Encrypted
    /// volumes may only be attached to instances that support Amazon EBS encryption. Volumes
    /// that are created from encrypted snapshots are also automatically encrypted. For more
    /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
    /// or Restoring an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVolumeRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private bool? _encrypted;
        private int? _iops;
        private int? _size;
        private string _snapshotId;
        private VolumeType _volumeType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVolumeRequest() { }

        /// <summary>
        /// Instantiates CreateVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which to create the volume. Use <a>DescribeAvailabilityZones</a> to list the Availability Zones that are currently available to you.</param>
        /// <param name="size">The size of the volume, in GiBs. Constraints: If the volume type is <code>io1</code>, the minimum size of the volume is 10 GiB. Default: If you're creating the volume from a snapshot and don't specify a volume size, the default is the snapshot size.</param>
        public CreateVolumeRequest(string availabilityZone, int size)
        {
            _availabilityZone = availabilityZone;
            _size = size;
        }

        /// <summary>
        /// Instantiates CreateVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which to create the volume. Use <a>DescribeAvailabilityZones</a> to list the Availability Zones that are currently available to you.</param>
        /// <param name="snapshotId">The snapshot from which to create the volume.</param>
        public CreateVolumeRequest(string availabilityZone, string snapshotId)
        {
            _availabilityZone = availabilityZone;
            _snapshotId = snapshotId;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create the volume. Use <a>DescribeAvailabilityZones</a>
        /// to list the Availability Zones that are currently available to you.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the volume should be encrypted.
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
        /// The number of I/O operations per second (IOPS) that the volume supports. This parameter
        /// is not used with Magnetic or General Purpose (SSD) volumes, but is required when the
        /// volume type is <code>io1</code>.
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
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the volume, in GiBs.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If the volume type is <code>io1</code>, the minimum size of the volume
        /// is 10 GiB.
        /// </para>
        ///  
        /// <para>
        /// Default: If you're creating the volume from a snapshot and don't specify a volume
        /// size, the default is the snapshot size.
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
        /// The snapshot from which to create the volume.
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
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. This can be <code>gp2</code> for General Purpose (SSD) volumes, <code>io1</code>
        /// for Provisioned IOPS (SSD) volumes, or <code>standard</code> for Magnetic volumes.
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
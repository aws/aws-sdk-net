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
    /// <para>Creates an Amazon EBS volume that can be attached to an instance in the same Availability Zone. The volume is created in the specified
    /// region.</para> <para>You can create a new empty volume or restore a volume from an Amazon EBS snapshot. Any AWS Marketplace product codes
    /// from the snapshot are propagated to the volume.</para> <para>You can create encrypted volumes with the <c>Encrypted</c> parameter. Encrypted
    /// volumes may only be attached to instances that support Amazon EBS encryption. Volumes that are created from encrypted snapshots are also
    /// automatically encrypted. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html" >Amazon
    /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html" >Creating or Restoring an Amazon EBS Volume</a> in the
    /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateVolumeRequest : AmazonEC2Request
    {
        private int? size;
        private string snapshotId;
        private string availabilityZone;
        private VolumeType volumeType;
        private int? iops;
        private bool? encrypted;


        /// <summary>
        /// The size of the volume, in GiBs. Constraints: If the volume type is <c>io1</c>, the minimum size of the volume is 10 GiB. Default: If you're
        /// creating the volume from a snapshot and don't specify a volume size, the default is the snapshot size.
        ///  
        /// </summary>
        public int Size
        {
            get { return this.size ?? default(int); }
            set { this.size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this.size.HasValue;
        }

        /// <summary>
        /// The snapshot from which to create the volume.
        ///  
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// The Availability Zone in which to create the volume. Use <a>DescribeAvailabilityZones</a> to list the Availability Zones that are currently
        /// available to you.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The volume type. This can be <c>gp2</c> for General Purpose (SSD) volumes, <c>io1</c> for Provisioned IOPS (SSD) volumes, or <c>standard</c>
        /// for Magnetic volumes. Default: <c>standard</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>standard, io1, gp2</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VolumeType VolumeType
        {
            get { return this.volumeType; }
            set { this.volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this.volumeType != null;
        }

        /// <summary>
        /// The number of I/O operations per second (IOPS) that the volume supports. This parameter is not used with Magnetic or General Purpose (SSD)
        /// volumes, but is required when the volume type is <c>io1</c>.
        ///  
        /// </summary>
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }

        /// <summary>
        /// Specifies whether the volume should be encrypted.
        ///  
        /// </summary>
        public bool Encrypted
        {
            get { return this.encrypted ?? default(bool); }
            set { this.encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this.encrypted.HasValue;
        }

    }
}
    

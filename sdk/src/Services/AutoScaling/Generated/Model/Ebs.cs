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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes information used to set up an Amazon EBS volume specified in a block device
    /// mapping.
    /// </summary>
    public partial class Ebs
    {
        private bool? _deleteOnTermination;
        private bool? _encrypted;
        private int? _iops;
        private string _snapshotId;
        private int? _volumeSize;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the volume is deleted on instance termination. For Amazon EC2 Auto
        /// Scaling, the default value is <code>true</code>.
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
        /// Specifies whether the volume should be encrypted. Encrypted EBS volumes can only be
        /// attached to instances that support Amazon EBS encryption. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
        /// Instance Types</a>. If your AMI uses encrypted volumes, you can also only launch it
        /// on supported instance types.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are creating a volume from a snapshot, you cannot specify an encryption value.
        /// Volumes that are created from encrypted snapshots are automatically encrypted, and
        /// volumes that are created from unencrypted snapshots are automatically unencrypted.
        /// By default, encrypted snapshots use the AWS managed CMK that is used for EBS encryption,
        /// but you can specify a custom CMK when you create the snapshot. The ability to encrypt
        /// a snapshot during copying also allows you to apply a new CMK to an already-encrypted
        /// snapshot. Volumes restored from the resulting copy are only accessible using the new
        /// CMK.
        /// </para>
        ///  
        /// <para>
        /// Enabling <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#encryption-by-default">encryption
        /// by default</a> results in all EBS volumes being encrypted with the AWS managed CMK
        /// or a customer managed CMK, whether or not the snapshot was encrypted.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AMIEncryption.html">Using
        /// Encryption with EBS-Backed AMIs</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>
        /// and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/key-policy-requirements-EBS-encryption.html">Required
        /// CMK key policy for use with encrypted volumes</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
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
        /// The number of I/O operations per second (IOPS) to provision for the volume. The maximum
        /// ratio of IOPS to volume size (in GiB) is 50:1. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS Volume Types</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  
        /// <para>
        /// Required when the volume type is <code>io1</code>. (Not used with <code>standard</code>,
        /// <code>gp2</code>, <code>st1</code>, or <code>sc1</code> volumes.) 
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=20000)]
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
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot ID of the volume to use.
        /// </para>
        ///  
        /// <para>
        /// You must specify either a <code>VolumeSize</code> or a <code>SnapshotId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The volume size, in Gibibytes (GiB).
        /// </para>
        ///  
        /// <para>
        /// This can be a number from 1-1,024 for <code>standard</code>, 4-16,384 for <code>io1</code>,
        /// 1-16,384 for <code>gp2</code>, and 500-16,384 for <code>st1</code> and <code>sc1</code>.
        /// If you specify a snapshot, the volume size must be equal to or larger than the snapshot
        /// size.
        /// </para>
        ///  
        /// <para>
        /// Default: If you create a volume from a snapshot and you don't specify a volume size,
        /// the default is the snapshot size.
        /// </para>
        ///  
        /// <para>
        /// You must specify either a <code>VolumeSize</code> or a <code>SnapshotId</code>. If
        /// you specify both <code>SnapshotId</code> and <code>VolumeSize</code>, the volume size
        /// must be equal or greater than the size of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
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
        /// The volume type, which can be <code>standard</code> for Magnetic, <code>io1</code>
        /// for Provisioned IOPS SSD, <code>gp2</code> for General Purpose SSD, <code>st1</code>
        /// for Throughput Optimized HDD, or <code>sc1</code> for Cold HDD. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS Volume Types</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>standard</code> | <code>io1</code> | <code>gp2</code> | <code>st1</code>
        /// | <code>sc1</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
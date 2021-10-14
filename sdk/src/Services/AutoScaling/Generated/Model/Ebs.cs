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
        private int? _throughput;
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
        /// instance types</a>. If your AMI uses encrypted volumes, you can also only launch it
        /// on supported instance types.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are creating a volume from a snapshot, you cannot create an unencrypted volume
        /// from an encrypted snapshot. Also, you cannot specify a KMS key ID when using a launch
        /// configuration.
        /// </para>
        ///  
        /// <para>
        /// If you enable encryption by default, the EBS volumes that you create are always encrypted,
        /// either using the Amazon Web Services managed KMS key or a customer-managed KMS key,
        /// regardless of whether the snapshot was encrypted. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-data-protection.html#encryption">Using
        /// Amazon Web Services KMS keys to encrypt Amazon EBS volumes</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
        ///  </note>
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
        /// The number of input/output (I/O) operations per second (IOPS) to provision for the
        /// volume. For <code>gp3</code> and <code>io1</code> volumes, this represents the number
        /// of IOPS that are provisioned for the volume. For <code>gp2</code> volumes, this represents
        /// the baseline performance of the volume and the rate at which the volume accumulates
        /// I/O credits for bursting. 
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
        ///  </li> </ul> 
        /// <para>
        /// For <code>io1</code> volumes, we guarantee 64,000 IOPS only for <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Instances
        /// built on the Nitro System</a>. Other instance families guarantee performance up to
        /// 32,000 IOPS. 
        /// </para>
        ///  
        /// <para>
        ///  <code>Iops</code> is supported when the volume type is <code>gp3</code> or <code>io1</code>
        /// and required only when the volume type is <code>io1</code>. (Not used with <code>standard</code>,
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
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput (MiBps) to provision for a <code>gp3</code> volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=125, Max=1000)]
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
        /// The volume size, in GiBs. The following are the supported volumes sizes for each volume
        /// type: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>gp2</code> and <code>gp3</code>: 1-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>io1</code>: 4-16,384
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
        /// <para>
        /// You must specify either a <code>SnapshotId</code> or a <code>VolumeSize</code>. If
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
        /// The volume type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS volume types</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>standard</code> | <code>io1</code> | <code>gp2</code> | <code>st1</code>
        /// | <code>sc1</code> | <code>gp3</code> 
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
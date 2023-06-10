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
    /// Container for the parameters to the CreateVolume operation.
    /// Creates an EBS volume that can be attached to an instance in the same Availability
    /// Zone.
    /// 
    ///  
    /// <para>
    /// You can create a new empty volume or restore a volume from an EBS snapshot. Any Amazon
    /// Web Services Marketplace product codes from the snapshot are propagated to the volume.
    /// </para>
    ///  
    /// <para>
    /// You can create encrypted volumes. Encrypted volumes must be attached to instances
    /// that support Amazon EBS encryption. Volumes that are created from encrypted snapshots
    /// are also automatically encrypted. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can tag your volumes during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
    /// your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Create
    /// an Amazon EBS volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVolumeRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _clientToken;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private bool? _multiAttachEnabled;
        private string _outpostArn;
        private int? _size;
        private string _snapshotId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private int? _throughput;
        private VolumeType _volumeType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVolumeRequest() { }

        /// <summary>
        /// Instantiates CreateVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which to create the volume.</param>
        /// <param name="size">The size of the volume, in GiBs. You must specify either a snapshot ID or a volume size. If you specify a snapshot, the default is the snapshot size. You can specify a volume size that is equal to or larger than the snapshot size. The following are the supported volumes sizes for each volume type: <ul> <li>  <code>gp2</code> and <code>gp3</code>: 1-16,384 </li> <li>  <code>io1</code> and <code>io2</code>: 4-16,384 </li> <li>  <code>st1</code> and <code>sc1</code>: 125-16,384 </li> <li>  <code>standard</code>: 1-1,024 </li> </ul></param>
        public CreateVolumeRequest(string availabilityZone, int size)
        {
            _availabilityZone = availabilityZone;
            _size = size;
        }

        /// <summary>
        /// Instantiates CreateVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which to create the volume.</param>
        /// <param name="snapshotId">The snapshot from which to create the volume. You must specify either a snapshot ID or a volume size.</param>
        public CreateVolumeRequest(string availabilityZone, string snapshotId)
        {
            _availabilityZone = availabilityZone;
            _snapshotId = snapshotId;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensure
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the volume should be encrypted. The effect of setting the encryption
        /// state to <code>true</code> depends on the volume origin (new or from a snapshot),
        /// starting encryption state, ownership, and whether encryption by default is enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#encryption-by-default">Encryption
        /// by default</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Encrypted Amazon EBS volumes must be attached to instances that support Amazon EBS
        /// encryption. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
        /// instance types</a>.
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
        ///  <code>io1</code> and <code>io2</code> volumes support up to 64,000 IOPS only on <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Instances
        /// built on the Nitro System</a>. Other instance families support performance up to 32,000
        /// IOPS.
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
        /// The identifier of the Key Management Service (KMS) KMS key to use for Amazon EBS encryption.
        /// If this parameter is not specified, your KMS key for Amazon EBS is used. If <code>KmsKeyId</code>
        /// is specified, the encrypted state must be <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the KMS key using any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID. For example, 1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias. For example, alias/ExampleAlias.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN. For example, arn:aws:kms:us-east-1:012345678910:key/1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN. For example, arn:aws:kms:us-east-1:012345678910:alias/ExampleAlias.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services authenticates the KMS key asynchronously. Therefore, if you specify
        /// an ID, alias, or ARN that is not valid, the action can appear to complete, but eventually
        /// fails.
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
        /// Gets and sets the property MultiAttachEnabled. 
        /// <para>
        /// Indicates whether to enable Amazon EBS Multi-Attach. If you enable Multi-Attach, you
        /// can attach the volume to up to 16 <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Instances
        /// built on the Nitro System</a> in the same Availability Zone. This parameter is supported
        /// with <code>io1</code> and <code>io2</code> volumes only. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-volumes-multi.html">
        /// Amazon EBS Multi-Attach</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public bool MultiAttachEnabled
        {
            get { return this._multiAttachEnabled.GetValueOrDefault(); }
            set { this._multiAttachEnabled = value; }
        }

        // Check to see if MultiAttachEnabled property is set
        internal bool IsSetMultiAttachEnabled()
        {
            return this._multiAttachEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
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
        /// Gets and sets the property Size. 
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
        /// The snapshot from which to create the volume. You must specify either a snapshot ID
        /// or a volume size.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the volume during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to provision for a volume, with a maximum of 1,000 MiB/s.
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
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. This parameter can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose SSD: <code>gp2</code> | <code>gp3</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS SSD: <code>io1</code> | <code>io2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Throughput Optimized HDD: <code>st1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cold HDD: <code>sc1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic: <code>standard</code> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Throughput Optimized HDD (<code>st1</code>) and Cold HDD (<code>sc1</code>) volumes
        /// can't be used as boot volumes.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS volume types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>gp2</code> 
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
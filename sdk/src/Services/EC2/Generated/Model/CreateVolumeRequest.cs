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
    /// are also automatically encrypted. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-encryption.html">Amazon
    /// EBS encryption</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can tag your volumes during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
    /// your Amazon EC2 resources</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-creating-volume.html">Create
    /// an Amazon EBS volume</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVolumeRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _clientToken;
        private bool? _dryRun;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private bool? _multiAttachEnabled;
        private OperatorRequest _operator;
        private string _outpostArn;
        private int? _size;
        private string _snapshotId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private int? _throughput;
        private int? _volumeInitializationRate;
        private VolumeType _volumeType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVolumeRequest() { }

        /// <summary>
        /// Instantiates CreateVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The ID of the Availability Zone in which to create the volume. For example, <c>us-east-1a</c>. Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified, but not both.</param>
        /// <param name="size">The size of the volume, in GiBs. You must specify either a snapshot ID or a volume size. If you specify a snapshot, the default is the snapshot size. You can specify a volume size that is equal to or larger than the snapshot size. The following are the supported volumes sizes for each volume type: <ul> <li>  <c>gp2</c>: 1 - 16,384 GiB </li> <li>  <c>gp3</c>: 1 - 65,536 GiB </li> <li>  <c>io1</c>: 4 - 16,384 GiB </li> <li>  <c>io2</c>: 4 - 65,536 GiB </li> <li>  <c>st1</c> and <c>sc1</c>: 125 - 16,384 GiB </li> <li>  <c>standard</c>: 1 - 1024 GiB </li> </ul></param>
        public CreateVolumeRequest(string availabilityZone, int? size)
        {
            _availabilityZone = availabilityZone;
            _size = size;
        }

        /// <summary>
        /// Instantiates CreateVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The ID of the Availability Zone in which to create the volume. For example, <c>us-east-1a</c>. Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified, but not both.</param>
        /// <param name="snapshotId">The snapshot from which to create the volume. You must specify either a snapshot ID or a volume size.</param>
        public CreateVolumeRequest(string availabilityZone, string snapshotId)
        {
            _availabilityZone = availabilityZone;
            _snapshotId = snapshotId;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The ID of the Availability Zone in which to create the volume. For example, <c>us-east-1a</c>.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified, but
        /// not both.
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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone in which to create the volume. For example, <c>use1-az1</c>.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified, but
        /// not both.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensure
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the volume should be encrypted. The effect of setting the encryption
        /// state to <c>true</c> depends on the volume origin (new or from a snapshot), starting
        /// encryption state, ownership, and whether encryption by default is enabled. For more
        /// information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/work-with-ebs-encr.html#encryption-by-default">Encryption
        /// by default</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Encrypted Amazon EBS volumes must be attached to instances that support Amazon EBS
        /// encryption. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-encryption-requirements.html#ebs-encryption_supported_instances">Supported
        /// instance types</a>.
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
        /// This parameter is required for <c>io1</c> and <c>io2</c> volumes. The default for
        /// <c>gp3</c> volumes is 3,000 IOPS. This parameter is not supported for <c>gp2</c>,
        /// <c>st1</c>, <c>sc1</c>, or <c>standard</c> volumes.
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
        /// The identifier of the KMS key to use for Amazon EBS encryption. If this parameter
        /// is not specified, your KMS key for Amazon EBS is used. If <c>KmsKeyId</c> is specified,
        /// the encrypted state must be <c>true</c>.
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
        /// can attach the volume to up to 16 <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html">Instances
        /// built on the Nitro System</a> in the same Availability Zone. This parameter is supported
        /// with <c>io1</c> and <c>io2</c> volumes only. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volumes-multi.html">
        /// Amazon EBS Multi-Attach</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public bool? MultiAttachEnabled
        {
            get { return this._multiAttachEnabled; }
            set { this._multiAttachEnabled = value; }
        }

        // Check to see if MultiAttachEnabled property is set
        internal bool IsSetMultiAttachEnabled()
        {
            return this._multiAttachEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public OperatorRequest Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost on which to create the volume.
        /// </para>
        ///  
        /// <para>
        /// If you intend to use a volume with an instance running on an outpost, then you must
        /// create the volume on the same outpost as the instance. You can't use a volume created
        /// in an Amazon Web Services Region with an instance on an Amazon Web Services outpost,
        /// or the other way around.
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
        public int? Size
        {
            get { return this._size; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to provision for a volume, with a maximum of 2,000 MiB/s.
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
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. This parameter can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose SSD: <c>gp2</c> | <c>gp3</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS SSD: <c>io1</c> | <c>io2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Throughput Optimized HDD: <c>st1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cold HDD: <c>sc1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Magnetic: <c>standard</c> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Throughput Optimized HDD (<c>st1</c>) and Cold HDD (<c>sc1</c>) volumes can't be used
        /// as boot volumes.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volume-types.html">Amazon
        /// EBS volume types</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>gp2</c> 
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
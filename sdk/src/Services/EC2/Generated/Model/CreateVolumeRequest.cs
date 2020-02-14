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
    /// Container for the parameters to the CreateVolume operation.
    /// Creates an EBS volume that can be attached to an instance in the same Availability
    /// Zone. The volume is created in the regional endpoint that you send the HTTP request
    /// to. For more information see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
    /// and Endpoints</a>.
    /// 
    ///  
    /// <para>
    /// You can create a new empty volume or restore a volume from an EBS snapshot. Any AWS
    /// Marketplace product codes from the snapshot are propagated to the volume.
    /// </para>
    ///  
    /// <para>
    /// You can create encrypted volumes. Encrypted volumes must be attached to instances
    /// that support Amazon EBS encryption. Volumes that are created from encrypted snapshots
    /// are also automatically encrypted. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can tag your volumes during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// Your Amazon EC2 Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
    /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVolumeRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private bool? _multiAttachEnabled;
        private string _outpostArn;
        private int? _size;
        private string _snapshotId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private VolumeType _volumeType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVolumeRequest() { }

        /// <summary>
        /// Instantiates CreateVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which to create the volume.</param>
        /// <param name="size">The size of the volume, in GiBs. You must specify either a snapshot ID or a volume size. Constraints: 1-16,384 for <code>gp2</code>, 4-16,384 for <code>io1</code>, 500-16,384 for <code>st1</code>, 500-16,384 for <code>sc1</code>, and 1-1,024 for <code>standard</code>. If you specify a snapshot, the volume size must be equal to or larger than the snapshot size. Default: If you're creating the volume from a snapshot and don't specify a volume size, the default is the snapshot size.</param>
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the volume should be encrypted. The effect of setting the encryption
        /// state to <code>true</code> depends on the volume origin (new or from a snapshot),
        /// starting encryption state, ownership, and whether encryption by default is enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#encryption-by-default">Encryption
        /// by Default</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Encrypted Amazon EBS volumes must be attached to instances that support Amazon EBS
        /// encryption. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
        /// Instance Types</a>.
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
        /// The number of I/O operations per second (IOPS) to provision for the volume, with a
        /// maximum ratio of 50 IOPS/GiB. Range is 100 to 64,000 IOPS for volumes in most Regions.
        /// Maximum IOPS of 64,000 is guaranteed only on <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Nitro-based
        /// instances</a>. Other instance families guarantee performance up to 32,000 IOPS. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS Volume Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only for Provisioned IOPS SSD (io1) volumes.
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
        /// The identifier of the AWS Key Management Service (AWS KMS) customer master key (CMK)
        /// to use for Amazon EBS encryption. If this parameter is not specified, your AWS managed
        /// CMK for EBS is used. If <code>KmsKeyId</code> is specified, the encrypted state must
        /// be <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the CMK using any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID. For example, key/1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias. For example, alias/ExampleAlias.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS authenticates the CMK asynchronously. Therefore, if you specify an ID, alias,
        /// or ARN that is not valid, the action can appear to complete, but eventually fails.
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
        /// Specifies whether to enable Amazon EBS Multi-Attach. If you enable Multi-Attach, you
        /// can attach the volume to up to 16 <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Nitro-based
        /// instances</a> in the same Availability Zone. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-volumes-multi.html">
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
        /// size.
        /// </para>
        ///  
        /// <para>
        /// Constraints: 1-16,384 for <code>gp2</code>, 4-16,384 for <code>io1</code>, 500-16,384
        /// for <code>st1</code>, 500-16,384 for <code>sc1</code>, and 1-1,024 for <code>standard</code>.
        /// If you specify a snapshot, the volume size must be equal to or larger than the snapshot
        /// size.
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
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. This can be <code>gp2</code> for General Purpose SSD, <code>io1</code>
        /// for Provisioned IOPS SSD, <code>st1</code> for Throughput Optimized HDD, <code>sc1</code>
        /// for Cold HDD, or <code>standard</code> for Magnetic volumes.
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
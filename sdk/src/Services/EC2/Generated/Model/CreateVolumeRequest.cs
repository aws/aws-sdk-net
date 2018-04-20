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
    /// to. For more information see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
    /// and Endpoints</a>.
    /// 
    ///  
    /// <para>
    /// You can create a new empty volume or restore a volume from an EBS snapshot. Any AWS
    /// Marketplace product codes from the snapshot are propagated to the volume.
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
    /// You can tag your volumes during creation. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// Your Amazon EC2 Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
    /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVolumeRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
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
        /// <param name="availabilityZone">The Availability Zone in which to create the volume. Use <a>DescribeAvailabilityZones</a> to list the Availability Zones that are currently available to you.</param>
        /// <param name="size">The size of the volume, in GiBs. Constraints: 1-16384 for <code>gp2</code>, 4-16384 for <code>io1</code>, 500-16384 for <code>st1</code>, 500-16384 for <code>sc1</code>, and 1-1024 for <code>standard</code>. If you specify a snapshot, the volume size must be equal to or larger than the snapshot size. Default: If you're creating the volume from a snapshot and don't specify a volume size, the default is the snapshot size.</param>
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
        /// Specifies whether the volume should be encrypted. Encrypted Amazon EBS volumes may
        /// only be attached to instances that support Amazon EBS encryption. Volumes that are
        /// created from encrypted snapshots are automatically encrypted. There is no way to create
        /// an encrypted volume from an unencrypted snapshot or vice versa. If your AMI uses encrypted
        /// volumes, you can only launch it on supported instance types. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// maximum ratio of 50 IOPS/GiB. Range is 100 to 32000 IOPS for volumes in most regions.
        /// For exceptions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS Volume Types</a>.
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
        /// An identifier for the AWS Key Management Service (AWS KMS) customer master key (CMK)
        /// to use when creating the encrypted volume. This parameter is only required if you
        /// want to use a non-default CMK; if this parameter is not specified, the default CMK
        /// for EBS is used. If a <code>KmsKeyId</code> is specified, the <code>Encrypted</code>
        /// flag must also be set. 
        /// </para>
        ///  
        /// <para>
        /// The CMK identifier may be provided in any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key ID. The ID ARN contains the <code>arn:aws:kms</code> namespace, followed
        /// by the region of the CMK, the AWS account ID of the CMK owner, the <code>key</code>
        /// namespace, and then the CMK ID. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key alias. The alias ARN contains the <code>arn:aws:kms</code> namespace,
        /// followed by the region of the CMK, the AWS account ID of the CMK owner, the <code>alias</code>
        /// namespace, and then the CMK alias. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS parses <code>KmsKeyId</code> asynchronously, meaning that the action you call
        /// may appear to complete even though you provided an invalid identifier. The action
        /// will eventually fail. 
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
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the volume, in GiBs.
        /// </para>
        ///  
        /// <para>
        /// Constraints: 1-16384 for <code>gp2</code>, 4-16384 for <code>io1</code>, 500-16384
        /// for <code>st1</code>, 500-16384 for <code>sc1</code>, and 1-1024 for <code>standard</code>.
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
        /// Defaults: If no volume type is specified, the default is <code>standard</code> in
        /// us-east-1, eu-west-1, eu-central-1, us-west-2, us-west-1, sa-east-1, ap-northeast-1,
        /// ap-northeast-2, ap-southeast-1, ap-southeast-2, ap-south-1, us-gov-west-1, and cn-north-1.
        /// In all other regions, EBS defaults to <code>gp2</code>.
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
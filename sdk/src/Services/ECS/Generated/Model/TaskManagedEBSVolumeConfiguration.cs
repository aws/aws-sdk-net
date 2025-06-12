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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The configuration for the Amazon EBS volume that Amazon ECS creates and manages on
    /// your behalf. These settings are used to create each Amazon EBS volume, with one volume
    /// created for each task.
    /// </summary>
    public partial class TaskManagedEBSVolumeConfiguration
    {
        private bool? _encrypted;
        private TaskFilesystemType _filesystemType;
        private int? _iops;
        private string _kmsKeyId;
        private string _roleArn;
        private int? _sizeInGiB;
        private string _snapshotId;
        private List<EBSTagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<EBSTagSpecification>() : null;
        private TaskManagedEBSVolumeTerminationPolicy _terminationPolicy;
        private int? _throughput;
        private int? _volumeInitializationRate;
        private string _volumeType;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the volume should be encrypted. If you turn on Region-level Amazon
        /// EBS encryption by default but set this value as <c>false</c>, the setting is overridden
        /// and the volume is encrypted with the KMS key specified for Amazon EBS encryption by
        /// default. This parameter maps 1:1 with the <c>Encrypted</c> parameter of the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>.
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
        /// Gets and sets the property FilesystemType. 
        /// <para>
        /// The Linux filesystem type for the volume. For volumes created from a snapshot, you
        /// must specify the same filesystem type that the volume was using when the snapshot
        /// was created. If there is a filesystem type mismatch, the task will fail to start.
        /// </para>
        ///  
        /// <para>
        /// The available filesystem types are&#x2028; <c>ext3</c>, <c>ext4</c>, and <c>xfs</c>.
        /// If no value is specified, the <c>xfs</c> filesystem type is used by default.
        /// </para>
        /// </summary>
        public TaskFilesystemType FilesystemType
        {
            get { return this._filesystemType; }
            set { this._filesystemType = value; }
        }

        // Check to see if FilesystemType property is set
        internal bool IsSetFilesystemType()
        {
            return this._filesystemType != null;
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
        /// The following are the supported values for each volume type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp3</c>: 3,000 - 16,000 IOPS
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
        /// This parameter is required for <c>io1</c> and <c>io2</c> volume types. The default
        /// for <c>gp3</c> volumes is <c>3,000 IOPS</c>. This parameter is not supported for <c>st1</c>,
        /// <c>sc1</c>, or <c>standard</c> volume types.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps 1:1 with the <c>Iops</c> parameter of the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>.
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
        /// The Amazon Resource Name (ARN) identifier of the Amazon Web Services Key Management
        /// Service key to use for Amazon EBS encryption. When a key is specified using this parameter,
        /// it overrides Amazon EBS default encryption or any KMS key that you specified for cluster-level
        /// managed storage encryption. This parameter maps 1:1 with the <c>KmsKeyId</c> parameter
        /// of the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>. For more information about encrypting
        /// Amazon EBS volumes attached to a task, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-kms-encryption.html">Encrypt
        /// data stored in Amazon EBS volumes attached to Amazon ECS tasks</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon Web Services authenticates the Amazon Web Services Key Management Service key
        /// asynchronously. Therefore, if you specify an ID, alias, or ARN that is invalid, the
        /// action can appear to complete, but eventually fails.
        /// </para>
        ///  </important>
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role to associate with this volume. This is the Amazon ECS infrastructure
        /// IAM role that is used to manage your Amazon Web Services infrastructure. We recommend
        /// using the Amazon ECS-managed <c>AmazonECSInfrastructureRolePolicyForVolumes</c> IAM
        /// policy with this role. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/infrastructure_IAM_role.html">Amazon
        /// ECS infrastructure IAM role</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInGiB. 
        /// <para>
        /// The size of the volume in GiB. You must specify either a volume size or a snapshot
        /// ID. If you specify a snapshot ID, the snapshot size is used for the volume size by
        /// default. You can optionally specify a volume size greater than or equal to the snapshot
        /// size. This parameter maps 1:1 with the <c>Size</c> parameter of the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported volume size values for each volume type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp2</c> and <c>gp3</c>: 1-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c> and <c>io2</c>: 4-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>st1</c> and <c>sc1</c>: 125-16,384
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>standard</c>: 1-1,024
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? SizeInGiB
        {
            get { return this._sizeInGiB; }
            set { this._sizeInGiB = value; }
        }

        // Check to see if SizeInGiB property is set
        internal bool IsSetSizeInGiB()
        {
            return this._sizeInGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot that Amazon ECS uses to create the volume. You must specify either a
        /// snapshot ID or a volume size. This parameter maps 1:1 with the <c>SnapshotId</c> parameter
        /// of the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>.
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
        /// The tags to apply to the volume. Amazon ECS applies service-managed tags by default.
        /// This parameter maps 1:1 with the <c>TagSpecifications.N</c> parameter of the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EBSTagSpecification> TagSpecifications
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
        /// Gets and sets the property TerminationPolicy. 
        /// <para>
        /// The termination policy for the volume when the task exits. This provides a way to
        /// control whether Amazon ECS terminates the Amazon EBS volume when the task stops.
        /// </para>
        /// </summary>
        public TaskManagedEBSVolumeTerminationPolicy TerminationPolicy
        {
            get { return this._terminationPolicy; }
            set { this._terminationPolicy = value; }
        }

        // Check to see if TerminationPolicy property is set
        internal bool IsSetTerminationPolicy()
        {
            return this._terminationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to provision for a volume, in MiB/s, with a maximum of 1,000 MiB/s.
        /// This parameter maps 1:1 with the <c>Throughput</c> parameter of the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter is only supported for the <c>gp3</c> volume type.
        /// </para>
        ///  </important>
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
        /// The rate, in MiB/s, at which data is fetched from a snapshot of an existing Amazon
        /// EBS volume to create a new volume for attachment to the task. This property can be
        /// specified only if you specify a <c>snapshotId</c>. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/initalize-volume.html">Initialize
        /// Amazon EBS volumes</a> in the <i>Amazon EBS User Guide</i>.
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
        /// The volume type. This parameter maps 1:1 with the <c>VolumeType</c> parameter of the
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVolume.html">CreateVolume
        /// API</a> in the <i>Amazon EC2 API Reference</i>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-volume-types.html">Amazon
        /// EBS volume types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported volume types.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose SSD: <c>gp2</c>|<c>gp3</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned IOPS SSD: <c>io1</c>|<c>io2</c> 
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
        ///  <note> 
        /// <para>
        /// The magnetic volume type is not supported on Fargate.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
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
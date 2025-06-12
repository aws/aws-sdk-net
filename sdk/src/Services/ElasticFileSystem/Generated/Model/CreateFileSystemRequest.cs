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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFileSystem operation.
    /// Creates a new, empty file system. The operation requires a creation token in the request
    /// that Amazon EFS uses to ensure idempotent creation (calling the operation with same
    /// creation token has no effect). If a file system does not currently exist that is owned
    /// by the caller's Amazon Web Services account with the specified creation token, this
    /// operation does the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Creates a new, empty file system. The file system will have an Amazon EFS assigned
    /// ID, and an initial lifecycle state <c>creating</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns with the description of the created file system.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Otherwise, this operation returns a <c>FileSystemAlreadyExists</c> error with the
    /// ID of the existing file system.
    /// </para>
    ///  <note> 
    /// <para>
    /// For basic use cases, you can use a randomly generated UUID for the creation token.
    /// </para>
    ///  </note> 
    /// <para>
    /// The idempotent operation allows you to retry a <c>CreateFileSystem</c> call without
    /// risk of creating an extra file system. This can happen when an initial call fails
    /// in a way that leaves it uncertain whether or not a file system was actually created.
    /// An example might be that a transport level timeout occurred or your connection was
    /// reset. As long as you use the same creation token, if the initial call had succeeded
    /// in creating a file system, the client can learn of its existence from the <c>FileSystemAlreadyExists</c>
    /// error.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/creating-using-create-fs.html#creating-using-create-fs-part1">Creating
    /// a file system</a> in the <i>Amazon EFS User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <c>CreateFileSystem</c> call returns while the file system's lifecycle state is
    /// still <c>creating</c>. You can check the file system creation status by calling the
    /// <a>DescribeFileSystems</a> operation, which among other things returns the file system
    /// state.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation accepts an optional <c>PerformanceMode</c> parameter that you choose
    /// for your file system. We recommend <c>generalPurpose</c> <c>PerformanceMode</c> for
    /// all file systems. The <c>maxIO</c> mode is a previous generation performance type
    /// that is designed for highly parallelized workloads that can tolerate higher latencies
    /// than the <c>generalPurpose</c> mode. <c>MaxIO</c> mode is not supported for One Zone
    /// file systems or file systems that use Elastic throughput.
    /// </para>
    ///  
    /// <para>
    /// The <c>PerformanceMode</c> can't be changed after the file system has been created.
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/performance.html#performancemodes.html">Amazon
    /// EFS performance modes</a>.
    /// </para>
    ///  
    /// <para>
    /// You can set the throughput mode for the file system using the <c>ThroughputMode</c>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// After the file system is fully created, Amazon EFS sets its lifecycle state to <c>available</c>,
    /// at which point you can create one or more mount targets for the file system in your
    /// VPC. For more information, see <a>CreateMountTarget</a>. You mount your Amazon EFS
    /// file system on an EC2 instances in your VPC by using the mount target. For more information,
    /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon EFS:
    /// How it Works</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <c>elasticfilesystem:CreateFileSystem</c>
    /// action. 
    /// </para>
    ///  
    /// <para>
    /// File systems can be tagged on creation. If tags are specified in the creation action,
    /// IAM performs additional authorization on the <c>elasticfilesystem:TagResource</c>
    /// action to verify if users have permissions to create tags. Therefore, you must grant
    /// explicit permissions to use the <c>elasticfilesystem:TagResource</c> action. For more
    /// information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/using-tags-efs.html#supported-iam-actions-tagging.html">Granting
    /// permissions to tag resources during creation</a>.
    /// </para>
    /// </summary>
    public partial class CreateFileSystemRequest : AmazonElasticFileSystemRequest
    {
        private string _availabilityZoneName;
        private bool? _backup;
        private string _creationToken;
        private bool? _encrypted;
        private string _kmsKeyId;
        private PerformanceMode _performanceMode;
        private double? _provisionedThroughputInMibps;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ThroughputMode _throughputMode;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateFileSystemRequest() { }

        /// <summary>
        /// Instantiates CreateFileSystemRequest with the parameterized properties
        /// </summary>
        /// <param name="creationToken">A string of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.</param>
        public CreateFileSystemRequest(string creationToken)
        {
            _creationToken = creationToken;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. 
        /// <para>
        /// For One Zone file systems, specify the Amazon Web Services Availability Zone in which
        /// to create the file system. Use the format <c>us-east-1a</c> to specify the Availability
        /// Zone. For more information about One Zone file systems, see <a href="https://docs.aws.amazon.com/efs/latest/ug/availability-durability.html#file-system-type">EFS
        /// file system types</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// One Zone file systems are not available in all Availability Zones in Amazon Web Services
        /// Regions where Amazon EFS is available.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AvailabilityZoneName
        {
            get { return this._availabilityZoneName; }
            set { this._availabilityZoneName = value; }
        }

        // Check to see if AvailabilityZoneName property is set
        internal bool IsSetAvailabilityZoneName()
        {
            return this._availabilityZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property Backup. 
        /// <para>
        /// Specifies whether automatic backups are enabled on the file system that you are creating.
        /// Set the value to <c>true</c> to enable automatic backups. If you are creating a One
        /// Zone file system, automatic backups are enabled by default. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/awsbackup.html#automatic-backups">Automatic
        /// backups</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default is <c>false</c>. However, if you specify an <c>AvailabilityZoneName</c>, the
        /// default is <c>true</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Backup is not available in all Amazon Web Services Regions where Amazon EFS is available.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Backup
        {
            get { return this._backup; }
            set { this._backup = value; }
        }

        // Check to see if Backup property is set
        internal bool IsSetBackup()
        {
            return this._backup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationToken. 
        /// <para>
        /// A string of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CreationToken
        {
            get { return this._creationToken; }
            set { this._creationToken = value; }
        }

        // Check to see if CreationToken property is set
        internal bool IsSetCreationToken()
        {
            return this._creationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// A Boolean value that, if true, creates an encrypted file system. When creating an
        /// encrypted file system, you have the option of specifying an existing Key Management
        /// Service key (KMS key). If you don't specify a KMS key, then the default KMS key for
        /// Amazon EFS, <c>/aws/elasticfilesystem</c>, is used to protect the encrypted file system.
        /// 
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key that you want to use to protect the encrypted file system. This
        /// parameter is required only if you want to use a non-default KMS key. If this parameter
        /// is not specified, the default KMS key for Amazon EFS is used. You can specify a KMS
        /// key ID using the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID - A unique identifier of the key, for example <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN - An Amazon Resource Name (ARN) for the key, for example <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias - A previously created display name for a key, for example <c>alias/projectKey1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias ARN - An ARN for a key alias, for example <c>arn:aws:kms:us-west-2:444455556666:alias/projectKey1</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you use <c>KmsKeyId</c>, you must set the <a>CreateFileSystemRequest$Encrypted</a>
        /// parameter to true.
        /// </para>
        ///  <important> 
        /// <para>
        /// EFS accepts only symmetric KMS keys. You cannot use asymmetric KMS keys with Amazon
        /// EFS file systems.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property PerformanceMode. 
        /// <para>
        /// The performance mode of the file system. We recommend <c>generalPurpose</c> performance
        /// mode for all file systems. File systems using the <c>maxIO</c> performance mode can
        /// scale to higher levels of aggregate throughput and operations per second with a tradeoff
        /// of slightly higher latencies for most file operations. The performance mode can't
        /// be changed after the file system has been created. The <c>maxIO</c> mode is not supported
        /// on One Zone file systems.
        /// </para>
        ///  <important> 
        /// <para>
        /// Due to the higher per-operation latencies with Max I/O, we recommend using General
        /// Purpose performance mode for all file systems.
        /// </para>
        ///  </important> 
        /// <para>
        /// Default is <c>generalPurpose</c>.
        /// </para>
        /// </summary>
        public PerformanceMode PerformanceMode
        {
            get { return this._performanceMode; }
            set { this._performanceMode = value; }
        }

        // Check to see if PerformanceMode property is set
        internal bool IsSetPerformanceMode()
        {
            return this._performanceMode != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughputInMibps. 
        /// <para>
        /// The throughput, measured in mebibytes per second (MiBps), that you want to provision
        /// for a file system that you're creating. Required if <c>ThroughputMode</c> is set to
        /// <c>provisioned</c>. Valid values are 1-3414 MiBps, with the upper limit depending
        /// on Region. To increase this limit, contact Amazon Web ServicesSupport. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/limits.html#soft-limits">Amazon
        /// EFS quotas that you can increase</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public double? ProvisionedThroughputInMibps
        {
            get { return this._provisionedThroughputInMibps; }
            set { this._provisionedThroughputInMibps = value; }
        }

        // Check to see if ProvisionedThroughputInMibps property is set
        internal bool IsSetProvisionedThroughputInMibps()
        {
            return this._provisionedThroughputInMibps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Use to create one or more tags associated with the file system. Each tag is a user-defined
        /// key-value pair. Name your file system on creation by including a <c>"Key":"Name","Value":"{value}"</c>
        /// key-value pair. Each key must be unique. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThroughputMode. 
        /// <para>
        /// Specifies the throughput mode for the file system. The mode can be <c>bursting</c>,
        /// <c>provisioned</c>, or <c>elastic</c>. If you set <c>ThroughputMode</c> to <c>provisioned</c>,
        /// you must also set a value for <c>ProvisionedThroughputInMibps</c>. After you create
        /// the file system, you can decrease your file system's Provisioned throughput or change
        /// between the throughput modes, with certain time restrictions. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/performance.html#provisioned-throughput">Specifying
        /// throughput with provisioned mode</a> in the <i>Amazon EFS User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Default is <c>bursting</c>.
        /// </para>
        /// </summary>
        public ThroughputMode ThroughputMode
        {
            get { return this._throughputMode; }
            set { this._throughputMode = value; }
        }

        // Check to see if ThroughputMode property is set
        internal bool IsSetThroughputMode()
        {
            return this._throughputMode != null;
        }

    }
}
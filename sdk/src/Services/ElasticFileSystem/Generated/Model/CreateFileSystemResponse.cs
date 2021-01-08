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

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// A description of the file system.
    /// </summary>
    public partial class CreateFileSystemResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _creationToken;
        private bool? _encrypted;
        private string _fileSystemArn;
        private string _fileSystemId;
        private string _kmsKeyId;
        private LifeCycleState _lifeCycleState;
        private string _name;
        private int? _numberOfMountTargets;
        private string _ownerId;
        private PerformanceMode _performanceMode;
        private double? _provisionedThroughputInMibps;
        private FileSystemSize _sizeInBytes;
        private List<Tag> _tags = new List<Tag>();
        private ThroughputMode _throughputMode;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the file system was created, in seconds (since 1970-01-01T00:00:00Z).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationToken. 
        /// <para>
        /// The opaque string specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// A Boolean value that, if true, indicates that the file system is encrypted.
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
        /// Gets and sets the property FileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the EFS file system, in the format <code>arn:aws:elasticfilesystem:<i>region</i>:<i>account-id</i>:file-system/<i>file-system-id</i>
        /// </code>. Example with sample data: <code>arn:aws:elasticfilesystem:us-west-2:1111333322228888:file-system/fs-01234567</code>
        /// 
        /// </para>
        /// </summary>
        public string FileSystemArn
        {
            get { return this._fileSystemArn; }
            set { this._fileSystemArn = value; }
        }

        // Check to see if FileSystemArn property is set
        internal bool IsSetFileSystemArn()
        {
            return this._fileSystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system, assigned by Amazon EFS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of an AWS Key Management Service (AWS KMS) customer master key (CMK) that was
        /// used to protect the encrypted file system.
        /// </para>
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
        /// Gets and sets the property LifeCycleState. 
        /// <para>
        /// The lifecycle phase of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifeCycleState LifeCycleState
        {
            get { return this._lifeCycleState; }
            set { this._lifeCycleState = value; }
        }

        // Check to see if LifeCycleState property is set
        internal bool IsSetLifeCycleState()
        {
            return this._lifeCycleState != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// You can add tags to a file system, including a <code>Name</code> tag. For more information,
        /// see <a>CreateFileSystem</a>. If the file system has a <code>Name</code> tag, Amazon
        /// EFS returns the value in this field. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfMountTargets. 
        /// <para>
        /// The current number of mount targets that the file system has. For more information,
        /// see <a>CreateMountTarget</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int NumberOfMountTargets
        {
            get { return this._numberOfMountTargets.GetValueOrDefault(); }
            set { this._numberOfMountTargets = value; }
        }

        // Check to see if NumberOfMountTargets property is set
        internal bool IsSetNumberOfMountTargets()
        {
            return this._numberOfMountTargets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The AWS account that created the file system. If the file system was created by an
        /// IAM user, the parent account to which the user belongs is the owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=14)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceMode. 
        /// <para>
        /// The performance mode of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The throughput, measured in MiB/s, that you want to provision for a file system. Valid
        /// values are 1-1024. Required if <code>ThroughputMode</code> is set to <code>provisioned</code>.
        /// The limit on throughput is 1024 MiB/s. You can get these limits increased by contacting
        /// AWS Support. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/limits.html#soft-limits">Amazon
        /// EFS Limits That You Can Increase</a> in the <i>Amazon EFS User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public double ProvisionedThroughputInMibps
        {
            get { return this._provisionedThroughputInMibps.GetValueOrDefault(); }
            set { this._provisionedThroughputInMibps = value; }
        }

        // Check to see if ProvisionedThroughputInMibps property is set
        internal bool IsSetProvisionedThroughputInMibps()
        {
            return this._provisionedThroughputInMibps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// The latest known metered size (in bytes) of data stored in the file system, in its
        /// <code>Value</code> field, and the time at which that size was determined in its <code>Timestamp</code>
        /// field. The <code>Timestamp</code> value is the integer number of seconds since 1970-01-01T00:00:00Z.
        /// The <code>SizeInBytes</code> value doesn't represent the size of a consistent snapshot
        /// of the file system, but it is eventually consistent when there are no writes to the
        /// file system. That is, <code>SizeInBytes</code> represents actual size only if the
        /// file system is not modified for a period longer than a couple of hours. Otherwise,
        /// the value is not the exact size that the file system was at any point in time. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileSystemSize SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this._sizeInBytes != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the file system, presented as an array of <code>Tag</code>
        /// objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputMode. 
        /// <para>
        /// The throughput mode for a file system. There are two throughput modes to choose from
        /// for your file system: <code>bursting</code> and <code>provisioned</code>. If you set
        /// <code>ThroughputMode</code> to <code>provisioned</code>, you must also set a value
        /// for <code>ProvisionedThroughPutInMibps</code>. You can decrease your file system's
        /// throughput in Provisioned Throughput mode or change between the throughput modes as
        /// long as it’s been more than 24 hours since the last decrease or throughput mode change.
        /// 
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
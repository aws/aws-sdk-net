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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A description of the file system.
    /// </summary>
    public partial class FileSystemDescription
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The unique and consistent identifier of the Availability Zone in which the file system
        /// is located, and is valid only for One Zone file systems. For example, <c>use1-az1</c>
        /// is an Availability Zone ID for the us-east-1 Amazon Web Services Region, and it has
        /// the same location in every Amazon Web Services account.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. 
        /// <para>
        /// Describes the Amazon Web Services Availability Zone in which the file system is located,
        /// and is valid only for One Zone file systems. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/storage-classes.html">Using
        /// EFS storage classes</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AvailabilityZoneName { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneName property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneName() => this.AvailabilityZoneName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the file system was created, in seconds (since 1970-01-01T00:00:00Z).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationToken. 
        /// <para>
        /// The opaque string specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CreationToken { get; set; }

        /// <summary>
        /// Checks to see if the CreationToken property is set.
        /// </summary>
        internal bool IsSetCreationToken() => this.CreationToken != null;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// A Boolean value that, if true, indicates that the file system is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property FileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the EFS file system, in the format <c>arn:aws:elasticfilesystem:<i>region</i>:<i>account-id</i>:file-system/<i>file-system-id</i>
        /// </c>. Example with sample data: <c>arn:aws:elasticfilesystem:us-west-2:1111333322228888:file-system/fs-01234567</c>
        /// 
        /// </para>
        /// </summary>
        public string FileSystemArn { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemArn property is set.
        /// </summary>
        internal bool IsSetFileSystemArn() => this.FileSystemArn != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system, assigned by Amazon EFS.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property FileSystemProtection. 
        /// <para>
        /// Describes the protection on the file system. 
        /// </para>
        /// </summary>
        public FileSystemProtectionDescription FileSystemProtection { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemProtection property is set.
        /// </summary>
        internal bool IsSetFileSystemProtection() => this.FileSystemProtection != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of an KMS key used to protect the encrypted file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LifeCycleState. 
        /// <para>
        /// The lifecycle phase of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifeCycleState LifeCycleState { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycleState property is set.
        /// </summary>
        internal bool IsSetLifeCycleState() => this.LifeCycleState != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// You can add tags to a file system, including a <c>Name</c> tag. For more information,
        /// see <a>CreateFileSystem</a>. If the file system has a <c>Name</c> tag, Amazon EFS
        /// returns the value in this field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfMountTargets. 
        /// <para>
        /// The current number of mount targets that the file system has. For more information,
        /// see <a>CreateMountTarget</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? NumberOfMountTargets { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfMountTargets property is set.
        /// </summary>
        internal bool IsSetNumberOfMountTargets() => this.NumberOfMountTargets.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account that created the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 14)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PerformanceMode. 
        /// <para>
        /// The performance mode of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PerformanceMode PerformanceMode { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceMode property is set.
        /// </summary>
        internal bool IsSetPerformanceMode() => this.PerformanceMode != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughputInMibps. 
        /// <para>
        /// The amount of provisioned throughput, measured in MiBps, for the file system. Valid
        /// for file systems using <c>ThroughputMode</c> set to <c>provisioned</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public double? ProvisionedThroughputInMibps { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughputInMibps property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughputInMibps() => this.ProvisionedThroughputInMibps.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// The latest known metered size (in bytes) of data stored in the file system, in its
        /// <c>Value</c> field, and the time at which that size was determined in its <c>Timestamp</c>
        /// field. The <c>Timestamp</c> value is the integer number of seconds since 1970-01-01T00:00:00Z.
        /// The <c>SizeInBytes</c> value doesn't represent the size of a consistent snapshot of
        /// the file system, but it is eventually consistent when there are no writes to the file
        /// system. That is, <c>SizeInBytes</c> represents actual size only if the file system
        /// is not modified for a period longer than a couple of hours. Otherwise, the value is
        /// not the exact size that the file system was at any point in time. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileSystemSize SizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytes property is set.
        /// </summary>
        internal bool IsSetSizeInBytes() => this.SizeInBytes != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the file system, presented as an array of <c>Tag</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThroughputMode. 
        /// <para>
        /// Displays the file system's throughput mode. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/performance.html#throughput-modes">Throughput
        /// modes</a> in the <i>Amazon EFS User Guide</i>. 
        /// </para>
        /// </summary>
        public ThroughputMode ThroughputMode { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputMode property is set.
        /// </summary>
        internal bool IsSetThroughputMode() => this.ThroughputMode != null;
    }
}

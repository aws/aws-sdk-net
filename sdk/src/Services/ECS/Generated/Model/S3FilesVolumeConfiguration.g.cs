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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This parameter is specified when you're using an Amazon S3 Files file system for task
    /// storage. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/s3files-volumes.html">Amazon
    /// S3 Files volumes</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// Your task definition must include a Task IAM Role. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-files-prereq-policies.html#s3-files-prereq-iam-compute-role">
    /// IAM role for attaching your file system to Amazon Web Services compute resources</a>
    /// for required permissions.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class S3FilesVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The full ARN of the S3 Files access point to use. If an access point is specified,
        /// the root directory value specified in the <c>S3FilesVolumeConfiguration</c> must either
        /// be omitted or set to <c>/</c> which will enforce the path set on the S3 Files access
        /// point. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-files-access-points-creating.html">Creating
        /// S3 Files access points</a>.
        /// </para>
        /// </summary>
        public string AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointArn property is set.
        /// </summary>
        internal bool IsSetAccessPointArn() => this.AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property FileSystemArn. 
        /// <para>
        /// The full ARN of the S3 Files file system to mount.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileSystemArn { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemArn property is set.
        /// </summary>
        internal bool IsSetFileSystemArn() => this.FileSystemArn != null;

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the Amazon S3 Files file system to mount as the root directory.
        /// If this parameter is omitted, the root of the Amazon S3 Files file system will be
        /// used. Specifying <c>/</c> will have the same effect as omitting this parameter.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a S3 Files access point is specified in the <c>accessPointArn</c>, the root directory
        /// parameter must either be omitted or set to <c>/</c> which will enforce the path set
        /// on the S3 Files access point.
        /// </para>
        ///  </important>
        /// </summary>
        public string RootDirectory { get; set; }

        /// <summary>
        /// Checks to see if the RootDirectory property is set.
        /// </summary>
        internal bool IsSetRootDirectory() => this.RootDirectory != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionPort. 
        /// <para>
        /// The port to use for sending encrypted data between the ECS host and the S3 Files file
        /// system. If you do not specify a transit encryption port, it will use the port selection
        /// strategy that the Amazon S3 Files mount helper uses. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-files-mounting.html">S3
        /// Files mount helper</a>.
        /// </para>
        /// </summary>
        public int? TransitEncryptionPort { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionPort property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionPort() => this.TransitEncryptionPort.HasValue;
    }
}

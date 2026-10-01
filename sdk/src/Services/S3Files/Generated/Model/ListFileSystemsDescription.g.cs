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

namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Contains information about an S3 File System returned in list operations.
    /// </summary>
    public partial class ListFileSystemsDescription
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the file system was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileSystemArn { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemArn property is set.
        /// </summary>
        internal bool IsSetFileSystemArn() => this.FileSystemArn != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the file system owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 12)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used for S3 access.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifeCycleState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional information about the file system status.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}

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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is used when you're using an S3Files file system for job storage.
    /// </summary>
    public partial class S3FilesVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3Files access point to use.
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
        /// The Amazon Resource Name (ARN) of the S3Files file system to use.
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
        /// The directory within the S3Files file system to mount as the root directory.
        /// </para>
        /// </summary>
        public string RootDirectory { get; set; }

        /// <summary>
        /// Checks to see if the RootDirectory property is set.
        /// </summary>
        internal bool IsSetRootDirectory() => this.RootDirectory != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionPort. 
        /// <para>
        /// The port to use when sending encrypted data between the Amazon ECS host and the S3Files
        /// file system server.
        /// </para>
        /// </summary>
        public int? TransitEncryptionPort { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionPort property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionPort() => this.TransitEncryptionPort.HasValue;
    }
}

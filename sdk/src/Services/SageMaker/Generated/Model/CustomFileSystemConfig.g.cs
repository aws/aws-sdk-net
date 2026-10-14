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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The settings for assigning a custom file system to a user profile or space for an
    /// Amazon SageMaker AI Domain. Permitted users can access this file system in Amazon
    /// SageMaker AI Studio.
    /// </summary>
    public partial class CustomFileSystemConfig
    {
        /// <summary>
        /// Gets and sets the property EFSFileSystemConfig. 
        /// <para>
        /// The settings for a custom Amazon EFS file system.
        /// </para>
        /// </summary>
        public EFSFileSystemConfig EFSFileSystemConfig { get; set; }

        /// <summary>
        /// Checks to see if the EFSFileSystemConfig property is set.
        /// </summary>
        internal bool IsSetEFSFileSystemConfig() => this.EFSFileSystemConfig != null;

        /// <summary>
        /// Gets and sets the property FSxLustreFileSystemConfig. 
        /// <para>
        /// The settings for a custom Amazon FSx for Lustre file system.
        /// </para>
        /// </summary>
        public FSxLustreFileSystemConfig FSxLustreFileSystemConfig { get; set; }

        /// <summary>
        /// Checks to see if the FSxLustreFileSystemConfig property is set.
        /// </summary>
        internal bool IsSetFSxLustreFileSystemConfig() => this.FSxLustreFileSystemConfig != null;

        /// <summary>
        /// Gets and sets the property S3FileSystemConfig. 
        /// <para>
        /// Configuration settings for a custom Amazon S3 file system.
        /// </para>
        /// </summary>
        public S3FileSystemConfig S3FileSystemConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3FileSystemConfig property is set.
        /// </summary>
        internal bool IsSetS3FileSystemConfig() => this.S3FileSystemConfig != null;
    }
}

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
    /// A file system, created by you, that you assign to a user profile or space for an Amazon
    /// SageMaker AI Domain. Permitted users can access this file system in Amazon SageMaker
    /// AI Studio.
    /// </summary>
    public partial class CustomFileSystem
    {
        /// <summary>
        /// Gets and sets the property EFSFileSystem. 
        /// <para>
        /// A custom file system in Amazon EFS.
        /// </para>
        /// </summary>
        public EFSFileSystem EFSFileSystem { get; set; }

        /// <summary>
        /// Checks to see if the EFSFileSystem property is set.
        /// </summary>
        internal bool IsSetEFSFileSystem() => this.EFSFileSystem != null;

        /// <summary>
        /// Gets and sets the property FSxLustreFileSystem. 
        /// <para>
        /// A custom file system in Amazon FSx for Lustre.
        /// </para>
        /// </summary>
        public FSxLustreFileSystem FSxLustreFileSystem { get; set; }

        /// <summary>
        /// Checks to see if the FSxLustreFileSystem property is set.
        /// </summary>
        internal bool IsSetFSxLustreFileSystem() => this.FSxLustreFileSystem != null;

        /// <summary>
        /// Gets and sets the property S3FileSystem. 
        /// <para>
        /// A custom file system in Amazon S3. This is only supported in Amazon SageMaker Unified
        /// Studio.
        /// </para>
        /// </summary>
        public S3FileSystem S3FileSystem { get; set; }

        /// <summary>
        /// Checks to see if the S3FileSystem property is set.
        /// </summary>
        internal bool IsSetS3FileSystem() => this.S3FileSystem != null;
    }
}

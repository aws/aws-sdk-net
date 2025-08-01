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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private EFSFileSystem _efsFileSystem;
        private FSxLustreFileSystem _fSxLustreFileSystem;
        private S3FileSystem _s3FileSystem;

        /// <summary>
        /// Gets and sets the property EFSFileSystem. 
        /// <para>
        /// A custom file system in Amazon EFS.
        /// </para>
        /// </summary>
        public EFSFileSystem EFSFileSystem
        {
            get { return this._efsFileSystem; }
            set { this._efsFileSystem = value; }
        }

        // Check to see if EFSFileSystem property is set
        internal bool IsSetEFSFileSystem()
        {
            return this._efsFileSystem != null;
        }

        /// <summary>
        /// Gets and sets the property FSxLustreFileSystem. 
        /// <para>
        /// A custom file system in Amazon FSx for Lustre.
        /// </para>
        /// </summary>
        public FSxLustreFileSystem FSxLustreFileSystem
        {
            get { return this._fSxLustreFileSystem; }
            set { this._fSxLustreFileSystem = value; }
        }

        // Check to see if FSxLustreFileSystem property is set
        internal bool IsSetFSxLustreFileSystem()
        {
            return this._fSxLustreFileSystem != null;
        }

        /// <summary>
        /// Gets and sets the property S3FileSystem. 
        /// <para>
        /// A custom file system in Amazon S3. This is only supported in Amazon SageMaker Unified
        /// Studio.
        /// </para>
        /// </summary>
        public S3FileSystem S3FileSystem
        {
            get { return this._s3FileSystem; }
            set { this._s3FileSystem = value; }
        }

        // Check to see if S3FileSystem property is set
        internal bool IsSetS3FileSystem()
        {
            return this._s3FileSystem != null;
        }

    }
}
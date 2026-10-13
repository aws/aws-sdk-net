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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// This is the response object from the DeleteFileSystem operation.
    /// </summary>
    public partial class DeleteFileSystemResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system that's being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The file system lifecycle for the deletion request. If the <c>DeleteFileSystem</c>
        /// operation is successful, this status is <c>DELETING</c>.
        /// </para>
        /// </summary>
        public FileSystemLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LustreResponse.
        /// </summary>
        public DeleteFileSystemLustreResponse LustreResponse { get; set; }

        /// <summary>
        /// Checks to see if the LustreResponse property is set.
        /// </summary>
        internal bool IsSetLustreResponse() => this.LustreResponse != null;

        /// <summary>
        /// Gets and sets the property OpenZFSResponse. 
        /// <para>
        /// The response object for the OpenZFS file system that's being deleted in the <c>DeleteFileSystem</c>
        /// operation.
        /// </para>
        /// </summary>
        public DeleteFileSystemOpenZFSResponse OpenZFSResponse { get; set; }

        /// <summary>
        /// Checks to see if the OpenZFSResponse property is set.
        /// </summary>
        internal bool IsSetOpenZFSResponse() => this.OpenZFSResponse != null;

        /// <summary>
        /// Gets and sets the property WindowsResponse.
        /// </summary>
        public DeleteFileSystemWindowsResponse WindowsResponse { get; set; }

        /// <summary>
        /// Checks to see if the WindowsResponse property is set.
        /// </summary>
        internal bool IsSetWindowsResponse() => this.WindowsResponse != null;
    }
}

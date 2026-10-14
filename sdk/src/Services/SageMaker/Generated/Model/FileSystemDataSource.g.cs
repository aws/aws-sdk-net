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
    /// Specifies a file system data source for a channel.
    /// </summary>
    public partial class FileSystemDataSource
    {
        /// <summary>
        /// Gets and sets the property DirectoryPath. 
        /// <para>
        /// The full path to the directory to associate with the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4096)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryPath property is set.
        /// </summary>
        internal bool IsSetDirectoryPath() => this.DirectoryPath != null;

        /// <summary>
        /// Gets and sets the property FileSystemAccessMode. 
        /// <para>
        /// The access mode of the mount of the directory associated with the channel. A directory
        /// can be mounted either in <c>ro</c> (read-only) or <c>rw</c> (read-write) mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileSystemAccessMode FileSystemAccessMode { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemAccessMode property is set.
        /// </summary>
        internal bool IsSetFileSystemAccessMode() => this.FileSystemAccessMode != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The file system id.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property FileSystemType. 
        /// <para>
        /// The file system type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileSystemType FileSystemType { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemType property is set.
        /// </summary>
        internal bool IsSetFileSystemType() => this.FileSystemType != null;
    }
}

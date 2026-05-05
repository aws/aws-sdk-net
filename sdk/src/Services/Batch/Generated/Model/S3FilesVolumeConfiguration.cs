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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
        private string _accessPointArn;
        private string _fileSystemArn;
        private string _rootDirectory;
        private int? _transitEncryptionPort;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3Files access point to use.
        /// </para>
        /// </summary>
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3Files file system to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the S3Files file system to mount as the root directory.
        /// </para>
        /// </summary>
        public string RootDirectory
        {
            get { return this._rootDirectory; }
            set { this._rootDirectory = value; }
        }

        // Check to see if RootDirectory property is set
        internal bool IsSetRootDirectory()
        {
            return this._rootDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property TransitEncryptionPort. 
        /// <para>
        /// The port to use when sending encrypted data between the Amazon ECS host and the S3Files
        /// file system server.
        /// </para>
        /// </summary>
        public int? TransitEncryptionPort
        {
            get { return this._transitEncryptionPort; }
            set { this._transitEncryptionPort = value; }
        }

        // Check to see if TransitEncryptionPort property is set
        internal bool IsSetTransitEncryptionPort()
        {
            return this._transitEncryptionPort.HasValue; 
        }

    }
}
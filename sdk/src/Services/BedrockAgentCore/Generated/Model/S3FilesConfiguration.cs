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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The configuration for mounting an Amazon Simple Storage Service (Amazon S3) Files
    /// access point that you own into a session.
    /// </summary>
    public partial class S3FilesConfiguration
    {
        private string _accessPointArn;
        private string _fileSystemArn;
        private string _mountPath;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Storage Service (Amazon S3) Files
        /// access point to mount.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// The Amazon Resource Name (ARN) of the Amazon Simple Storage Service (Amazon S3) Files
        /// file system that owns the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The absolute path within the session at which the access point is mounted, for example
        /// <c>/mnt/s3data</c>. Each mount path must be unique across all file system configurations
        /// in the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=200)]
        public string MountPath
        {
            get { return this._mountPath; }
            set { this._mountPath = value; }
        }

        // Check to see if MountPath property is set
        internal bool IsSetMountPath()
        {
            return this._mountPath != null;
        }

    }
}
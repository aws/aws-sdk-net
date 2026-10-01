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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The configuration for mounting an Amazon Elastic File System (Amazon EFS) access point
    /// that you own into a session.
    /// </summary>
    public partial class EfsConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Elastic File System (Amazon EFS) access
        /// point to mount.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointArn property is set.
        /// </summary>
        internal bool IsSetAccessPointArn() => this.AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property FileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Elastic File System (Amazon EFS) file
        /// system that owns the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string FileSystemArn { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemArn property is set.
        /// </summary>
        internal bool IsSetFileSystemArn() => this.FileSystemArn != null;

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The absolute path within the session at which the access point is mounted, for example
        /// <c>/mnt/efs</c>. Each mount path must be unique across all file system configurations
        /// in the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 200)]
        public string MountPath { get; set; }

        /// <summary>
        /// Checks to see if the MountPath property is set.
        /// </summary>
        internal bool IsSetMountPath() => this.MountPath != null;
    }
}

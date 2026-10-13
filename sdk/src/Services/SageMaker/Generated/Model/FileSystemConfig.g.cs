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
    /// The Amazon Elastic File System storage configuration for a SageMaker AI image.
    /// </summary>
    public partial class FileSystemConfig
    {
        /// <summary>
        /// Gets and sets the property DefaultGid. 
        /// <para>
        /// The default POSIX group ID (GID). If not specified, defaults to <c>100</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? DefaultGid { get; set; }

        /// <summary>
        /// Checks to see if the DefaultGid property is set.
        /// </summary>
        internal bool IsSetDefaultGid() => this.DefaultGid.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultUid. 
        /// <para>
        /// The default POSIX user ID (UID). If not specified, defaults to <c>1000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? DefaultUid { get; set; }

        /// <summary>
        /// Checks to see if the DefaultUid property is set.
        /// </summary>
        internal bool IsSetDefaultUid() => this.DefaultUid.HasValue;

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The path within the image to mount the user's EFS home directory. The directory should
        /// be empty. If not specified, defaults to <i>/home/sagemaker-user</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MountPath { get; set; }

        /// <summary>
        /// Checks to see if the MountPath property is set.
        /// </summary>
        internal bool IsSetMountPath() => this.MountPath != null;
    }
}

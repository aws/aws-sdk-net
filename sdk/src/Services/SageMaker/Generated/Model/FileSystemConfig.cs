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
    /// The Amazon Elastic File System storage configuration for a SageMaker AI image.
    /// </summary>
    public partial class FileSystemConfig
    {
        private int? _defaultGid;
        private int? _defaultUid;
        private string _mountPath;

        /// <summary>
        /// Gets and sets the property DefaultGid. 
        /// <para>
        /// The default POSIX group ID (GID). If not specified, defaults to <c>100</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? DefaultGid
        {
            get { return this._defaultGid; }
            set { this._defaultGid = value; }
        }

        // Check to see if DefaultGid property is set
        internal bool IsSetDefaultGid()
        {
            return this._defaultGid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultUid. 
        /// <para>
        /// The default POSIX user ID (UID). If not specified, defaults to <c>1000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? DefaultUid
        {
            get { return this._defaultUid; }
            set { this._defaultUid = value; }
        }

        // Check to see if DefaultUid property is set
        internal bool IsSetDefaultUid()
        {
            return this._defaultUid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The path within the image to mount the user's EFS home directory. The directory should
        /// be empty. If not specified, defaults to <i>/home/sagemaker-user</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
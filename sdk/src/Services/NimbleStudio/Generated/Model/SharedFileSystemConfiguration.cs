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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The configuration for a shared file storage system that is associated with a studio
    /// resource.
    /// </summary>
    public partial class SharedFileSystemConfiguration
    {
        private string _endpoint;
        private string _fileSystemId;
        private string _linuxMountPoint;
        private string _shareName;
        private string _windowsMountDrive;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint of the shared file system that is accessed by the studio component resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The unique identifier for a file system.
        /// </para>
        /// </summary>
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property LinuxMountPoint. 
        /// <para>
        /// The mount location for a shared file system on a Linux virtual workstation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=128)]
        public string LinuxMountPoint
        {
            get { return this._linuxMountPoint; }
            set { this._linuxMountPoint = value; }
        }

        // Check to see if LinuxMountPoint property is set
        internal bool IsSetLinuxMountPoint()
        {
            return this._linuxMountPoint != null;
        }

        /// <summary>
        /// Gets and sets the property ShareName. 
        /// <para>
        /// The name of the file share.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ShareName
        {
            get { return this._shareName; }
            set { this._shareName = value; }
        }

        // Check to see if ShareName property is set
        internal bool IsSetShareName()
        {
            return this._shareName != null;
        }

        /// <summary>
        /// Gets and sets the property WindowsMountDrive. 
        /// <para>
        /// The mount location for a shared file system on a Windows virtual workstation.
        /// </para>
        /// </summary>
        public string WindowsMountDrive
        {
            get { return this._windowsMountDrive; }
            set { this._windowsMountDrive = value; }
        }

        // Check to see if WindowsMountDrive property is set
        internal bool IsSetWindowsMountDrive()
        {
            return this._windowsMountDrive != null;
        }

    }
}
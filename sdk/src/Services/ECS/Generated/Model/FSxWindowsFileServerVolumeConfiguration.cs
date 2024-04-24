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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// This parameter is specified when you're using <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/what-is.html">Amazon
    /// FSx for Windows File Server</a> file system for task storage.
    /// 
    ///  
    /// <para>
    /// For more information and the input format, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/wfsx-volumes.html">Amazon
    /// FSx for Windows File Server volumes</a> in the <i>Amazon Elastic Container Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class FSxWindowsFileServerVolumeConfiguration
    {
        private FSxWindowsFileServerAuthorizationConfig _authorizationConfig;
        private string _fileSystemId;
        private string _rootDirectory;

        /// <summary>
        /// Gets and sets the property AuthorizationConfig. 
        /// <para>
        /// The authorization configuration details for the Amazon FSx for Windows File Server
        /// file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FSxWindowsFileServerAuthorizationConfig AuthorizationConfig
        {
            get { return this._authorizationConfig; }
            set { this._authorizationConfig = value; }
        }

        // Check to see if AuthorizationConfig property is set
        internal bool IsSetAuthorizationConfig()
        {
            return this._authorizationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The Amazon FSx for Windows File Server file system ID to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the Amazon FSx for Windows File Server file system to mount as
        /// the root directory inside the host.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}
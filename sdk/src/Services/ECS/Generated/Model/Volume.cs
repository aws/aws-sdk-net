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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// A data volume used in a task definition. For tasks that use the Amazon Elastic File
    /// System (Amazon EFS), specify an <code>efsVolumeConfiguration</code>. For Windows tasks
    /// that use Amazon FSx for Windows File Server file system, specify a <code>fsxWindowsFileServerVolumeConfiguration</code>.
    /// For tasks that use a Docker volume, specify a <code>DockerVolumeConfiguration</code>.
    /// For tasks that use a bind mount host volume, specify a <code>host</code> and optional
    /// <code>sourcePath</code>. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html">Using
    /// Data Volumes in Tasks</a>.
    /// </summary>
    public partial class Volume
    {
        private DockerVolumeConfiguration _dockerVolumeConfiguration;
        private EFSVolumeConfiguration _efsVolumeConfiguration;
        private FSxWindowsFileServerVolumeConfiguration _fsxWindowsFileServerVolumeConfiguration;
        private HostVolumeProperties _host;
        private string _name;

        /// <summary>
        /// Gets and sets the property DockerVolumeConfiguration. 
        /// <para>
        /// This parameter is specified when you are using Docker volumes. Docker volumes are
        /// only supported when you are using the EC2 launch type. Windows containers only support
        /// the use of the <code>local</code> driver. To use bind mounts, specify the <code>host</code>
        /// parameter instead.
        /// </para>
        /// </summary>
        public DockerVolumeConfiguration DockerVolumeConfiguration
        {
            get { return this._dockerVolumeConfiguration; }
            set { this._dockerVolumeConfiguration = value; }
        }

        // Check to see if DockerVolumeConfiguration property is set
        internal bool IsSetDockerVolumeConfiguration()
        {
            return this._dockerVolumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EfsVolumeConfiguration. 
        /// <para>
        /// This parameter is specified when you are using an Amazon Elastic File System file
        /// system for task storage.
        /// </para>
        /// </summary>
        public EFSVolumeConfiguration EfsVolumeConfiguration
        {
            get { return this._efsVolumeConfiguration; }
            set { this._efsVolumeConfiguration = value; }
        }

        // Check to see if EfsVolumeConfiguration property is set
        internal bool IsSetEfsVolumeConfiguration()
        {
            return this._efsVolumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FsxWindowsFileServerVolumeConfiguration. 
        /// <para>
        /// This parameter is specified when you are using Amazon FSx for Windows File Server
        /// file system for task storage.
        /// </para>
        /// </summary>
        public FSxWindowsFileServerVolumeConfiguration FsxWindowsFileServerVolumeConfiguration
        {
            get { return this._fsxWindowsFileServerVolumeConfiguration; }
            set { this._fsxWindowsFileServerVolumeConfiguration = value; }
        }

        // Check to see if FsxWindowsFileServerVolumeConfiguration property is set
        internal bool IsSetFsxWindowsFileServerVolumeConfiguration()
        {
            return this._fsxWindowsFileServerVolumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// This parameter is specified when you are using bind mount host volumes. The contents
        /// of the <code>host</code> parameter determine whether your bind mount host volume persists
        /// on the host container instance and where it is stored. If the <code>host</code> parameter
        /// is empty, then the Docker daemon assigns a host path for your data volume. However,
        /// the data is not guaranteed to persist after the containers associated with it stop
        /// running.
        /// </para>
        ///  
        /// <para>
        /// Windows containers can mount whole directories on the same drive as <code>$env:ProgramData</code>.
        /// Windows containers cannot mount directories on a different drive, and mount point
        /// cannot be across drives. For example, you can mount <code>C:\my\path:C:\my\path</code>
        /// and <code>D:\:D:\</code>, but not <code>D:\my\path:C:\my\path</code> or <code>D:\:C:\my\path</code>.
        /// </para>
        /// </summary>
        public HostVolumeProperties Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the volume. Up to 255 letters (uppercase and lowercase), numbers, and
        /// hyphens are allowed. This name is referenced in the <code>sourceVolume</code> parameter
        /// of container definition <code>mountPoints</code>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
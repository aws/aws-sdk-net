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
    /// The data volume configuration for tasks launched using this task definition. Specifying
    /// a volume configuration in a task definition is optional. The volume configuration
    /// may contain multiple volumes but only one volume configured at launch is supported.
    /// Each volume defined in the volume configuration may only specify a <c>name</c> and
    /// one of either <c>configuredAtLaunch</c>, <c>dockerVolumeConfiguration</c>, <c>efsVolumeConfiguration</c>,
    /// <c>fsxWindowsFileServerVolumeConfiguration</c>, or <c>host</c>. If an empty volume
    /// configuration is specified, by default Amazon ECS uses a host volume. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html">Using
    /// data volumes in tasks</a>.
    /// </summary>
    public partial class Volume
    {
        private bool? _configuredAtLaunch;
        private DockerVolumeConfiguration _dockerVolumeConfiguration;
        private EFSVolumeConfiguration _efsVolumeConfiguration;
        private FSxWindowsFileServerVolumeConfiguration _fsxWindowsFileServerVolumeConfiguration;
        private HostVolumeProperties _host;
        private string _name;

        /// <summary>
        /// Gets and sets the property ConfiguredAtLaunch. 
        /// <para>
        /// Indicates whether the volume should be configured at launch time. This is used to
        /// create Amazon EBS volumes for standalone tasks or tasks created as part of a service.
        /// Each task definition revision may only have one volume configured at launch in the
        /// volume configuration.
        /// </para>
        ///  
        /// <para>
        /// To configure a volume at launch time, use this task definition revision and specify
        /// a <c>volumeConfigurations</c> object when calling the <c>CreateService</c>, <c>UpdateService</c>,
        /// <c>RunTask</c> or <c>StartTask</c> APIs.
        /// </para>
        /// </summary>
        public bool? ConfiguredAtLaunch
        {
            get { return this._configuredAtLaunch; }
            set { this._configuredAtLaunch = value; }
        }

        // Check to see if ConfiguredAtLaunch property is set
        internal bool IsSetConfiguredAtLaunch()
        {
            return this._configuredAtLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DockerVolumeConfiguration. 
        /// <para>
        /// This parameter is specified when you use Docker volumes.
        /// </para>
        ///  
        /// <para>
        /// Windows containers only support the use of the <c>local</c> driver. To use bind mounts,
        /// specify the <c>host</c> parameter instead.
        /// </para>
        ///  <note> 
        /// <para>
        /// Docker volumes aren't supported by tasks run on Fargate.
        /// </para>
        ///  </note>
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
        /// This parameter is specified when you use an Amazon Elastic File System file system
        /// for task storage.
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
        /// This parameter is specified when you use Amazon FSx for Windows File Server file system
        /// for task storage.
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
        /// This parameter is specified when you use bind mount host volumes. The contents of
        /// the <c>host</c> parameter determine whether your bind mount host volume persists on
        /// the host container instance and where it's stored. If the <c>host</c> parameter is
        /// empty, then the Docker daemon assigns a host path for your data volume. However, the
        /// data isn't guaranteed to persist after the containers that are associated with it
        /// stop running.
        /// </para>
        ///  
        /// <para>
        /// Windows containers can mount whole directories on the same drive as <c>$env:ProgramData</c>.
        /// Windows containers can't mount directories on a different drive, and mount point can't
        /// be across drives. For example, you can mount <c>C:\my\path:C:\my\path</c> and <c>D:\:D:\</c>,
        /// but not <c>D:\my\path:C:\my\path</c> or <c>D:\:C:\my\path</c>.
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
        /// The name of the volume. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed.
        /// </para>
        ///  
        /// <para>
        /// When using a volume configured at launch, the <c>name</c> is required and must also
        /// be specified as the volume name in the <c>ServiceVolumeConfiguration</c> or <c>TaskVolumeConfiguration</c>
        /// parameter when creating your service or standalone task.
        /// </para>
        ///  
        /// <para>
        /// For all other types of volumes, this name is referenced in the <c>sourceVolume</c>
        /// parameter of the <c>mountPoints</c> object in the container definition.
        /// </para>
        ///  
        /// <para>
        /// When a volume is using the <c>efsVolumeConfiguration</c>, the name is required.
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
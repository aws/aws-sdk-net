/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Linux-specific options that are applied to the container, such as Linux <a>KernelCapabilities</a>.
    /// </summary>
    public partial class LinuxParameters
    {
        private KernelCapabilities _capabilities;
        private List<Device> _devices = new List<Device>();
        private bool? _initProcessEnabled;
        private int? _sharedMemorySize;
        private List<Tmpfs> _tmpfs = new List<Tmpfs>();

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The Linux capabilities for the container that are added to or dropped from the default
        /// configuration provided by Docker.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using tasks that use the Fargate launch type, <code>capabilities</code>
        /// is supported but the <code>add</code> parameter is not supported.
        /// </para>
        ///  </note>
        /// </summary>
        public KernelCapabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// Any host devices to expose to the container. This parameter maps to <code>Devices</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/">Docker
        /// Remote API</a> and the <code>--device</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using tasks that use the Fargate launch type, the <code>devices</code>
        /// parameter is not supported.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Device> Devices
        {
            get { return this._devices; }
            set { this._devices = value; }
        }

        // Check to see if Devices property is set
        internal bool IsSetDevices()
        {
            return this._devices != null && this._devices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InitProcessEnabled. 
        /// <para>
        /// Run an <code>init</code> process inside the container that forwards signals and reaps
        /// processes. This parameter maps to the <code>--init</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. This parameter requires version 1.25 of the Docker Remote API or greater
        /// on your container instance. To check the Docker Remote API version on your container
        /// instance, log in to your container instance and run the following command: <code>sudo
        /// docker version | grep "Server API version"</code> 
        /// </para>
        /// </summary>
        public bool InitProcessEnabled
        {
            get { return this._initProcessEnabled.GetValueOrDefault(); }
            set { this._initProcessEnabled = value; }
        }

        // Check to see if InitProcessEnabled property is set
        internal bool IsSetInitProcessEnabled()
        {
            return this._initProcessEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SharedMemorySize. 
        /// <para>
        /// The value for the size (in MiB) of the <code>/dev/shm</code> volume. This parameter
        /// maps to the <code>--shm-size</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using tasks that use the Fargate launch type, the <code>sharedMemorySize</code>
        /// parameter is not supported.
        /// </para>
        ///  </note>
        /// </summary>
        public int SharedMemorySize
        {
            get { return this._sharedMemorySize.GetValueOrDefault(); }
            set { this._sharedMemorySize = value; }
        }

        // Check to see if SharedMemorySize property is set
        internal bool IsSetSharedMemorySize()
        {
            return this._sharedMemorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tmpfs. 
        /// <para>
        /// The container path, mount options, and size (in MiB) of the tmpfs mount. This parameter
        /// maps to the <code>--tmpfs</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using tasks that use the Fargate launch type, the <code>tmpfs</code> parameter
        /// is not supported.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tmpfs> Tmpfs
        {
            get { return this._tmpfs; }
            set { this._tmpfs = value; }
        }

        // Check to see if Tmpfs property is set
        internal bool IsSetTmpfs()
        {
            return this._tmpfs != null && this._tmpfs.Count > 0; 
        }

    }
}
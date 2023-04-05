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
    /// The Linux-specific options that are applied to the container, such as Linux <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_KernelCapabilities.html">KernelCapabilities</a>.
    /// </summary>
    public partial class LinuxParameters
    {
        private KernelCapabilities _capabilities;
        private List<Device> _devices = new List<Device>();
        private bool? _initProcessEnabled;
        private int? _maxSwap;
        private int? _sharedMemorySize;
        private int? _swappiness;
        private List<Tmpfs> _tmpfs = new List<Tmpfs>();

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The Linux capabilities for the container that are added to or dropped from the default
        /// configuration provided by Docker.
        /// </para>
        ///  <note> 
        /// <para>
        /// For tasks that use the Fargate launch type, <code>capabilities</code> is supported
        /// for all platform versions but the <code>add</code> parameter is only supported if
        /// using platform version 1.4.0 or later.
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
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>--device</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <code>devices</code> parameter
        /// isn't supported.
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
        /// processes. This parameter maps to the <code>--init</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>. This parameter requires version 1.25 of the Docker Remote API or greater
        /// on your container instance. To check the Docker Remote API version on your container
        /// instance, log in to your container instance and run the following command: <code>sudo
        /// docker version --format '{{.Server.APIVersion}}'</code> 
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
        /// Gets and sets the property MaxSwap. 
        /// <para>
        /// The total amount of swap memory (in MiB) a container can use. This parameter will
        /// be translated to the <code>--memory-swap</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a> where the value would be the sum of the container memory plus the <code>maxSwap</code>
        /// value.
        /// </para>
        ///  
        /// <para>
        /// If a <code>maxSwap</code> value of <code>0</code> is specified, the container will
        /// not use swap. Accepted values are <code>0</code> or any positive integer. If the <code>maxSwap</code>
        /// parameter is omitted, the container will use the swap configuration for the container
        /// instance it is running on. A <code>maxSwap</code> value must be set for the <code>swappiness</code>
        /// parameter to be used.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <code>maxSwap</code> parameter
        /// isn't supported.
        /// </para>
        ///  </note>
        /// </summary>
        public int MaxSwap
        {
            get { return this._maxSwap.GetValueOrDefault(); }
            set { this._maxSwap = value; }
        }

        // Check to see if MaxSwap property is set
        internal bool IsSetMaxSwap()
        {
            return this._maxSwap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SharedMemorySize. 
        /// <para>
        /// The value for the size (in MiB) of the <code>/dev/shm</code> volume. This parameter
        /// maps to the <code>--shm-size</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
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
        /// Gets and sets the property Swappiness. 
        /// <para>
        /// This allows you to tune a container's memory swappiness behavior. A <code>swappiness</code>
        /// value of <code>0</code> will cause swapping to not happen unless absolutely necessary.
        /// A <code>swappiness</code> value of <code>100</code> will cause pages to be swapped
        /// very aggressively. Accepted values are whole numbers between <code>0</code> and <code>100</code>.
        /// If the <code>swappiness</code> parameter is not specified, a default value of <code>60</code>
        /// is used. If a value is not specified for <code>maxSwap</code> then this parameter
        /// is ignored. This parameter maps to the <code>--memory-swappiness</code> option to
        /// <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <code>swappiness</code>
        /// parameter isn't supported.
        /// </para>
        ///  </note>
        /// </summary>
        public int Swappiness
        {
            get { return this._swappiness.GetValueOrDefault(); }
            set { this._swappiness = value; }
        }

        // Check to see if Swappiness property is set
        internal bool IsSetSwappiness()
        {
            return this._swappiness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tmpfs. 
        /// <para>
        /// The container path, mount options, and size (in MiB) of the tmpfs mount. This parameter
        /// maps to the <code>--tmpfs</code> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <code>tmpfs</code> parameter
        /// isn't supported.
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
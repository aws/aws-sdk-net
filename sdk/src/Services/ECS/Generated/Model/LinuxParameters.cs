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
    /// The Linux-specific options that are applied to the container, such as Linux <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_KernelCapabilities.html">KernelCapabilities</a>.
    /// </summary>
    public partial class LinuxParameters
    {
        private KernelCapabilities _capabilities;
        private List<Device> _devices = AWSConfigs.InitializeCollections ? new List<Device>() : null;
        private bool? _initProcessEnabled;
        private int? _maxSwap;
        private int? _sharedMemorySize;
        private int? _swappiness;
        private List<Tmpfs> _tmpfs = AWSConfigs.InitializeCollections ? new List<Tmpfs>() : null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The Linux capabilities for the container that are added to or dropped from the default
        /// configuration provided by Docker.
        /// </para>
        ///  <note> 
        /// <para>
        /// For tasks that use the Fargate launch type, <c>capabilities</c> is supported for all
        /// platform versions but the <c>add</c> parameter is only supported if using platform
        /// version 1.4.0 or later.
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
        /// Any host devices to expose to the container. This parameter maps to <c>Devices</c>
        /// in the docker container create command and the <c>--device</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <c>devices</c> parameter
        /// isn't supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Device> Devices
        {
            get { return this._devices; }
            set { this._devices = value; }
        }

        // Check to see if Devices property is set
        internal bool IsSetDevices()
        {
            return this._devices != null && (this._devices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InitProcessEnabled. 
        /// <para>
        /// Run an <c>init</c> process inside the container that forwards signals and reaps processes.
        /// This parameter maps to the <c>--init</c> option to docker run. This parameter requires
        /// version 1.25 of the Docker Remote API or greater on your container instance. To check
        /// the Docker Remote API version on your container instance, log in to your container
        /// instance and run the following command: <c>sudo docker version --format '{{.Server.APIVersion}}'</c>
        /// 
        /// </para>
        /// </summary>
        public bool? InitProcessEnabled
        {
            get { return this._initProcessEnabled; }
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
        /// be translated to the <c>--memory-swap</c> option to docker run where the value would
        /// be the sum of the container memory plus the <c>maxSwap</c> value.
        /// </para>
        ///  
        /// <para>
        /// If a <c>maxSwap</c> value of <c>0</c> is specified, the container will not use swap.
        /// Accepted values are <c>0</c> or any positive integer. If the <c>maxSwap</c> parameter
        /// is omitted, the container will use the swap configuration for the container instance
        /// it is running on. A <c>maxSwap</c> value must be set for the <c>swappiness</c> parameter
        /// to be used.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <c>maxSwap</c> parameter
        /// isn't supported.
        /// </para>
        ///  
        /// <para>
        /// If you're using tasks on Amazon Linux 2023 the <c>swappiness</c> parameter isn't supported.
        /// </para>
        ///  </note>
        /// </summary>
        public int? MaxSwap
        {
            get { return this._maxSwap; }
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
        /// The value for the size (in MiB) of the <c>/dev/shm</c> volume. This parameter maps
        /// to the <c>--shm-size</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using tasks that use the Fargate launch type, the <c>sharedMemorySize</c>
        /// parameter is not supported.
        /// </para>
        ///  </note>
        /// </summary>
        public int? SharedMemorySize
        {
            get { return this._sharedMemorySize; }
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
        /// This allows you to tune a container's memory swappiness behavior. A <c>swappiness</c>
        /// value of <c>0</c> will cause swapping to not happen unless absolutely necessary. A
        /// <c>swappiness</c> value of <c>100</c> will cause pages to be swapped very aggressively.
        /// Accepted values are whole numbers between <c>0</c> and <c>100</c>. If the <c>swappiness</c>
        /// parameter is not specified, a default value of <c>60</c> is used. If a value is not
        /// specified for <c>maxSwap</c> then this parameter is ignored. This parameter maps to
        /// the <c>--memory-swappiness</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <c>swappiness</c> parameter
        /// isn't supported.
        /// </para>
        ///  
        /// <para>
        /// If you're using tasks on Amazon Linux 2023 the <c>swappiness</c> parameter isn't supported.
        /// </para>
        ///  </note>
        /// </summary>
        public int? Swappiness
        {
            get { return this._swappiness; }
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
        /// maps to the <c>--tmpfs</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using tasks that use the Fargate launch type, the <c>tmpfs</c> parameter
        /// isn't supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tmpfs> Tmpfs
        {
            get { return this._tmpfs; }
            set { this._tmpfs = value; }
        }

        // Check to see if Tmpfs property is set
        internal bool IsSetTmpfs()
        {
            return this._tmpfs != null && (this._tmpfs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
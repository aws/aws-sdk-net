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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Linux-specific modifications that are applied to the container, such as details for
    /// device mappings.
    /// </summary>
    public partial class LinuxParameters
    {
        private List<Device> _devices = new List<Device>();
        private bool? _initProcessEnabled;
        private int? _maxSwap;
        private int? _sharedMemorySize;
        private int? _swappiness;
        private List<Tmpfs> _tmpfs = new List<Tmpfs>();

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// Any host devices to expose to the container. This parameter maps to <code>Devices</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--device</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided.
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
        /// If true, run an <code>init</code> process inside the container that forwards signals
        /// and reaps processes. This parameter maps to the <code>--init</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. This parameter requires version 1.25 of the Docker Remote API or greater
        /// on your container instance. To check the Docker Remote API version on your container
        /// instance, log into your container instance and run the following command: <code>sudo
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
        /// Gets and sets the property MaxSwap. 
        /// <para>
        /// The total amount of swap memory (in MiB) a container can use. This parameter is translated
        /// to the <code>--memory-swap</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a> where the value is the sum of the container memory plus the <code>maxSwap</code>
        /// value. For more information, see <a href="https://docs.docker.com/config/containers/resource_constraints/#--memory-swap-details">
        /// <code>--memory-swap</code> details</a> in the Docker documentation.
        /// </para>
        ///  
        /// <para>
        /// If a <code>maxSwap</code> value of <code>0</code> is specified, the container doesn't
        /// use swap. Accepted values are <code>0</code> or any positive integer. If the <code>maxSwap</code>
        /// parameter is omitted, the container doesn't use the swap configuration for the container
        /// instance it is running on. A <code>maxSwap</code> value must be set for the <code>swappiness</code>
        /// parameter to be used.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided.
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
        /// maps to the <code>--shm-size</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided.
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
        /// value of <code>0</code> causes swapping not to happen unless absolutely necessary.
        /// A <code>swappiness</code> value of <code>100</code> causes pages to be swapped very
        /// aggressively. Accepted values are whole numbers between <code>0</code> and <code>100</code>.
        /// If the <code>swappiness</code> parameter isn't specified, a default value of <code>60</code>
        /// is used. If a value isn't specified for <code>maxSwap</code> then this parameter is
        /// ignored. If <code>maxSwap</code> is set to 0, the container doesn't use swap. This
        /// parameter maps to the <code>--memory-swappiness</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// Consider the following when you use a per-container swap configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Swap space must be enabled and allocated on the container instance for the containers
        /// to use.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS optimized AMIs don't have swap enabled by default. You must enable
        /// swap on the instance to use this feature. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-store-swap-volumes.html">Instance
        /// Store Swap Volumes</a> in the <i>Amazon EC2 User Guide for Linux Instances</i> or
        /// <a href="http://aws.amazon.com/premiumsupport/knowledge-center/ec2-memory-swap-file/">How
        /// do I allocate memory to work as swap space in an Amazon EC2 instance by using a swap
        /// file?</a> 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The swap space parameters are only supported for job definitions using EC2 resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <code>maxSwap</code> and <code>swappiness</code> parameters are omitted from
        /// a job definition, each container will have a default <code>swappiness</code> value
        /// of 60 and the total swap usage will be limited to two times the memory reservation
        /// of the container.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided.
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
        /// maps to the <code>--tmpfs</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided.
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
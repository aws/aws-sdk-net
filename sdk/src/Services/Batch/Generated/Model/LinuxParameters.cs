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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Linux-specific modifications that are applied to the container, such as details for
    /// device mappings.
    /// </summary>
    public partial class LinuxParameters
    {
        private List<Device> _devices = AWSConfigs.InitializeCollections ? new List<Device>() : null;
        private bool? _initProcessEnabled;
        private int? _maxSwap;
        private int? _sharedMemorySize;
        private int? _swappiness;
        private List<Tmpfs> _tmpfs = AWSConfigs.InitializeCollections ? new List<Tmpfs>() : null;

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// Any of the host devices to expose to the container. This parameter maps to <c>Devices</c>
        /// in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <c>--device</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// provide it for these jobs.
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
        /// If true, run an <c>init</c> process inside the container that forwards signals and
        /// reaps processes. This parameter maps to the <c>--init</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. This parameter requires version 1.25 of the Docker Remote API or greater
        /// on your container instance. To check the Docker Remote API version on your container
        /// instance, log in to your container instance and run the following command: <c>sudo
        /// docker version | grep "Server API version"</c> 
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
        /// The total amount of swap memory (in MiB) a container can use. This parameter is translated
        /// to the <c>--memory-swap</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a> where the value is the sum of the container memory plus the <c>maxSwap</c>
        /// value. For more information, see <a href="https://docs.docker.com/config/containers/resource_constraints/#--memory-swap-details">
        /// <c>--memory-swap</c> details</a> in the Docker documentation.
        /// </para>
        ///  
        /// <para>
        /// If a <c>maxSwap</c> value of <c>0</c> is specified, the container doesn't use swap.
        /// Accepted values are <c>0</c> or any positive integer. If the <c>maxSwap</c> parameter
        /// is omitted, the container doesn't use the swap configuration for the container instance
        /// on which it runs. A <c>maxSwap</c> value must be set for the <c>swappiness</c> parameter
        /// to be used.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// provide it for these jobs.
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
        /// to the <c>--shm-size</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// provide it for these jobs.
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
        /// You can use this parameter to tune a container's memory swappiness behavior. A <c>swappiness</c>
        /// value of <c>0</c> causes swapping to not occur unless absolutely necessary. A <c>swappiness</c>
        /// value of <c>100</c> causes pages to be swapped aggressively. Valid values are whole
        /// numbers between <c>0</c> and <c>100</c>. If the <c>swappiness</c> parameter isn't
        /// specified, a default value of <c>60</c> is used. If a value isn't specified for <c>maxSwap</c>,
        /// then this parameter is ignored. If <c>maxSwap</c> is set to 0, the container doesn't
        /// use swap. This parameter maps to the <c>--memory-swappiness</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
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
        /// By default, the Amazon ECS optimized AMIs don't have swap enabled. You must enable
        /// swap on the instance to use this feature. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-store-swap-volumes.html">Instance
        /// store swap volumes</a> in the <i>Amazon EC2 User Guide for Linux Instances</i> or
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
        /// If the <c>maxSwap</c> and <c>swappiness</c> parameters are omitted from a job definition,
        /// each container has a default <c>swappiness</c> value of 60. Moreover, the total swap
        /// usage is limited to two times the memory reservation of the container.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// provide it for these jobs.
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
        /// The container path, mount options, and size (in MiB) of the <c>tmpfs</c> mount. This
        /// parameter maps to the <c>--tmpfs</c> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// provide this parameter for this resource type.
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
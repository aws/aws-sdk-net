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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about system resource limits that the IoT Greengrass Core software
    /// applies to a component's processes. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-greengrass-core-v2.html#configure-component-system-resource-limits">Configure
    /// system resource limits for components</a>.
    /// </summary>
    public partial class SystemResourceLimits
    {
        private double? _cpus;
        private long? _memory;

        /// <summary>
        /// Gets and sets the property Cpus. 
        /// <para>
        /// The maximum amount of CPU time that a component's processes can use on the core device.
        /// A core device's total CPU time is equivalent to the device's number of CPU cores.
        /// For example, on a core device with 4 CPU cores, you can set this value to <c>2</c>
        /// to limit the component's processes to 50 percent usage of each CPU core. On a device
        /// with 1 CPU core, you can set this value to <c>0.25</c> to limit the component's processes
        /// to 25 percent usage of the CPU. If you set this value to a number greater than the
        /// number of CPU cores, the IoT Greengrass Core software doesn't limit the component's
        /// CPU usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? Cpus
        {
            get { return this._cpus; }
            set { this._cpus = value; }
        }

        // Check to see if Cpus property is set
        internal bool IsSetCpus()
        {
            return this._cpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The maximum amount of RAM, expressed in kilobytes, that a component's processes can
        /// use on the core device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9223372036854771712)]
        public long? Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

    }
}
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
    /// The Linux capabilities to add or remove from the default Docker configuration for
    /// a container defined in the task definition. For more detailed information about these
    /// Linux capabilities, see the <a href="http://man7.org/linux/man-pages/man7/capabilities.7.html">capabilities(7)</a>
    /// Linux manual page.
    /// 
    ///  
    /// <para>
    /// The following describes how Docker processes the Linux capabilities specified in the
    /// <c>add</c> and <c>drop</c> request parameters. For information about the latest behavior,
    /// see <a href="https://forums.docker.com/t/docker-compose-order-of-cap-drop-and-cap-add/97136/1">Docker
    /// Compose: order of cap_drop and cap_add</a> in the Docker Community Forum.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When the container is a privleged container, the container capabilities are all of
    /// the default Docker capabilities. The capabilities specified in the <c>add</c> request
    /// parameter, and the <c>drop</c> request parameter are ignored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the <c>add</c> request parameter is set to ALL, the container capabilities are
    /// all of the default Docker capabilities, excluding those specified in the <c>drop</c>
    /// request parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the <c>drop</c> request parameter is set to ALL, the container capabilities are
    /// the capabilities specified in the <c>add</c> request parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the <c>add</c> request parameter and the <c>drop</c> request parameter are both
    /// empty, the capabilities the container capabilities are all of the default Docker capabilities.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The default is to first drop the capabilities specified in the <c>drop</c> request
    /// parameter, and then add the capabilities specified in the <c>add</c> request parameter.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class KernelCapabilities
    {
        private List<string> _add = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _drop = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Add. 
        /// <para>
        /// The Linux capabilities for the container that have been added to the default configuration
        /// provided by Docker. This parameter maps to <c>CapAdd</c> in the docker container create
        /// command and the <c>--cap-add</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tasks launched on Fargate only support adding the <c>SYS_PTRACE</c> kernel capability.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values: <c>"ALL" | "AUDIT_CONTROL" | "AUDIT_WRITE" | "BLOCK_SUSPEND" | "CHOWN"
        /// | "DAC_OVERRIDE" | "DAC_READ_SEARCH" | "FOWNER" | "FSETID" | "IPC_LOCK" | "IPC_OWNER"
        /// | "KILL" | "LEASE" | "LINUX_IMMUTABLE" | "MAC_ADMIN" | "MAC_OVERRIDE" | "MKNOD" |
        /// "NET_ADMIN" | "NET_BIND_SERVICE" | "NET_BROADCAST" | "NET_RAW" | "SETFCAP" | "SETGID"
        /// | "SETPCAP" | "SETUID" | "SYS_ADMIN" | "SYS_BOOT" | "SYS_CHROOT" | "SYS_MODULE" |
        /// "SYS_NICE" | "SYS_PACCT" | "SYS_PTRACE" | "SYS_RAWIO" | "SYS_RESOURCE" | "SYS_TIME"
        /// | "SYS_TTY_CONFIG" | "SYSLOG" | "WAKE_ALARM"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Add
        {
            get { return this._add; }
            set { this._add = value; }
        }

        // Check to see if Add property is set
        internal bool IsSetAdd()
        {
            return this._add != null && (this._add.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Drop. 
        /// <para>
        /// The Linux capabilities for the container that have been removed from the default configuration
        /// provided by Docker. This parameter maps to <c>CapDrop</c> in the docker container
        /// create command and the <c>--cap-drop</c> option to docker run.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>"ALL" | "AUDIT_CONTROL" | "AUDIT_WRITE" | "BLOCK_SUSPEND" | "CHOWN"
        /// | "DAC_OVERRIDE" | "DAC_READ_SEARCH" | "FOWNER" | "FSETID" | "IPC_LOCK" | "IPC_OWNER"
        /// | "KILL" | "LEASE" | "LINUX_IMMUTABLE" | "MAC_ADMIN" | "MAC_OVERRIDE" | "MKNOD" |
        /// "NET_ADMIN" | "NET_BIND_SERVICE" | "NET_BROADCAST" | "NET_RAW" | "SETFCAP" | "SETGID"
        /// | "SETPCAP" | "SETUID" | "SYS_ADMIN" | "SYS_BOOT" | "SYS_CHROOT" | "SYS_MODULE" |
        /// "SYS_NICE" | "SYS_PACCT" | "SYS_PTRACE" | "SYS_RAWIO" | "SYS_RESOURCE" | "SYS_TIME"
        /// | "SYS_TTY_CONFIG" | "SYSLOG" | "WAKE_ALARM"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Drop
        {
            get { return this._drop; }
            set { this._drop = value; }
        }

        // Check to see if Drop property is set
        internal bool IsSetDrop()
        {
            return this._drop != null && (this._drop.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
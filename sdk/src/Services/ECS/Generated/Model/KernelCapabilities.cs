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
    /// The Linux capabilities for the container that are added to or dropped from the default
    /// configuration provided by Docker. For more information on the default capabilities
    /// and the non-default available capabilities, see <a href="https://docs.docker.com/engine/reference/run/#runtime-privilege-and-linux-capabilities">Runtime
    /// privilege and Linux capabilities</a> in the <i>Docker run reference</i>. For more
    /// detailed information on these Linux capabilities, see the <a href="http://man7.org/linux/man-pages/man7/capabilities.7.html">capabilities(7)</a>
    /// Linux manual page.
    /// </summary>
    public partial class KernelCapabilities
    {
        private List<string> _add = new List<string>();
        private List<string> _drop = new List<string>();

        /// <summary>
        /// Gets and sets the property Add. 
        /// <para>
        /// The Linux capabilities for the container that have been added to the default configuration
        /// provided by Docker. This parameter maps to <code>CapAdd</code> in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/">Docker
        /// Remote API</a> and the <code>--cap-add</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using tasks that use the Fargate launch type, the <code>add</code> parameter
        /// is not supported.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values: <code>"ALL" | "AUDIT_CONTROL" | "AUDIT_WRITE" | "BLOCK_SUSPEND" | "CHOWN"
        /// | "DAC_OVERRIDE" | "DAC_READ_SEARCH" | "FOWNER" | "FSETID" | "IPC_LOCK" | "IPC_OWNER"
        /// | "KILL" | "LEASE" | "LINUX_IMMUTABLE" | "MAC_ADMIN" | "MAC_OVERRIDE" | "MKNOD" |
        /// "NET_ADMIN" | "NET_BIND_SERVICE" | "NET_BROADCAST" | "NET_RAW" | "SETFCAP" | "SETGID"
        /// | "SETPCAP" | "SETUID" | "SYS_ADMIN" | "SYS_BOOT" | "SYS_CHROOT" | "SYS_MODULE" |
        /// "SYS_NICE" | "SYS_PACCT" | "SYS_PTRACE" | "SYS_RAWIO" | "SYS_RESOURCE" | "SYS_TIME"
        /// | "SYS_TTY_CONFIG" | "SYSLOG" | "WAKE_ALARM"</code> 
        /// </para>
        /// </summary>
        public List<string> Add
        {
            get { return this._add; }
            set { this._add = value; }
        }

        // Check to see if Add property is set
        internal bool IsSetAdd()
        {
            return this._add != null && this._add.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Drop. 
        /// <para>
        /// The Linux capabilities for the container that have been removed from the default configuration
        /// provided by Docker. This parameter maps to <code>CapDrop</code> in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/">Docker
        /// Remote API</a> and the <code>--cap-drop</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>"ALL" | "AUDIT_CONTROL" | "AUDIT_WRITE" | "BLOCK_SUSPEND" | "CHOWN"
        /// | "DAC_OVERRIDE" | "DAC_READ_SEARCH" | "FOWNER" | "FSETID" | "IPC_LOCK" | "IPC_OWNER"
        /// | "KILL" | "LEASE" | "LINUX_IMMUTABLE" | "MAC_ADMIN" | "MAC_OVERRIDE" | "MKNOD" |
        /// "NET_ADMIN" | "NET_BIND_SERVICE" | "NET_BROADCAST" | "NET_RAW" | "SETFCAP" | "SETGID"
        /// | "SETPCAP" | "SETUID" | "SYS_ADMIN" | "SYS_BOOT" | "SYS_CHROOT" | "SYS_MODULE" |
        /// "SYS_NICE" | "SYS_PACCT" | "SYS_PTRACE" | "SYS_RAWIO" | "SYS_RESOURCE" | "SYS_TIME"
        /// | "SYS_TTY_CONFIG" | "SYSLOG" | "WAKE_ALARM"</code> 
        /// </para>
        /// </summary>
        public List<string> Drop
        {
            get { return this._drop; }
            set { this._drop = value; }
        }

        // Check to see if Drop property is set
        internal bool IsSetDrop()
        {
            return this._drop != null && this._drop.Count > 0; 
        }

    }
}
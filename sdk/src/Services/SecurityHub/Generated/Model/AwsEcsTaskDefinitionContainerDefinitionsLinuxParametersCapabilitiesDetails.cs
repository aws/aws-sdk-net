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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The Linux capabilities for the container that are added to or dropped from the default
    /// configuration provided by Docker.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetails
    {
        private List<string> _add = new List<string>();
        private List<string> _drop = new List<string>();

        /// <summary>
        /// Gets and sets the property Add. 
        /// <para>
        /// The Linux capabilities for the container that are added to the default configuration
        /// provided by Docker. Valid values are as follows:
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>"ALL"</code> | <code>"AUDIT_CONTROL"</code> |<code> "AUDIT_WRITE"</code>
        /// | <code>"BLOCK_SUSPEND"</code> | <code>"CHOWN"</code> | <code>"DAC_OVERRIDE"</code>
        /// | <code>"DAC_READ_SEARCH"</code> | <code>"FOWNER"</code> | <code>"FSETID"</code> |
        /// <code>"IPC_LOCK"</code> | <code>"IPC_OWNER"</code> | <code>"KILL"</code> | <code>"LEASE"</code>
        /// | <code>"LINUX_IMMUTABLE"</code> | <code>"MAC_ADMIN"</code> |<code> "MAC_OVERRIDE"</code>
        /// | <code>"MKNOD"</code> | <code>"NET_ADMIN"</code> | <code>"NET_BIND_SERVICE"</code>
        /// | <code>"NET_BROADCAST"</code> | <code>"NET_RAW"</code> | <code>"SETFCAP"</code> |
        /// <code>"SETGID"</code> | <code>"SETPCAP"</code> | <code>"SETUID"</code> | <code>"SYS_ADMIN"</code>
        /// | <code>"SYS_BOOT"</code> | <code>"SYS_CHROOT"</code> | <code>"SYS_MODULE"</code>
        /// | <code>"SYS_NICE"</code> | <code>"SYS_PACCT"</code> | <code>"SYS_PTRACE"</code> |
        /// <code>"SYS_RAWIO"</code> | <code>"SYS_RESOURCE"</code> | <code>"SYS_TIME"</code> |
        /// <code>"SYS_TTY_CONFIG"</code> | <code>"SYSLOG"</code> | <code>"WAKE_ALARM"</code>
        /// 
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
        /// The Linux capabilities for the container that are dropped from the default configuration
        /// provided by Docker.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>"ALL"</code> | <code>"AUDIT_CONTROL"</code> |<code> "AUDIT_WRITE"</code>
        /// | <code>"BLOCK_SUSPEND"</code> | <code>"CHOWN"</code> | <code>"DAC_OVERRIDE"</code>
        /// | <code>"DAC_READ_SEARCH"</code> | <code>"FOWNER"</code> | <code>"FSETID"</code> |
        /// <code>"IPC_LOCK"</code> | <code>"IPC_OWNER"</code> | <code>"KILL"</code> | <code>"LEASE"</code>
        /// | <code>"LINUX_IMMUTABLE"</code> | <code>"MAC_ADMIN"</code> |<code> "MAC_OVERRIDE"</code>
        /// | <code>"MKNOD"</code> | <code>"NET_ADMIN"</code> | <code>"NET_BIND_SERVICE"</code>
        /// | <code>"NET_BROADCAST"</code> | <code>"NET_RAW"</code> | <code>"SETFCAP"</code> |
        /// <code>"SETGID"</code> | <code>"SETPCAP"</code> | <code>"SETUID"</code> | <code>"SYS_ADMIN"</code>
        /// | <code>"SYS_BOOT"</code> | <code>"SYS_CHROOT"</code> | <code>"SYS_MODULE"</code>
        /// | <code>"SYS_NICE"</code> | <code>"SYS_PACCT"</code> | <code>"SYS_PTRACE"</code> |
        /// <code>"SYS_RAWIO"</code> | <code>"SYS_RESOURCE"</code> | <code>"SYS_TIME"</code> |
        /// <code>"SYS_TTY_CONFIG"</code> | <code>"SYSLOG"</code> | <code>"WAKE_ALARM"</code>
        /// 
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
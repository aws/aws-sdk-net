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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The Linux capabilities for the container that are added to or dropped from the default
    /// configuration provided by Docker.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetails
    {
        private List<string> _add = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _drop = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Add. 
        /// <para>
        /// The Linux capabilities for the container that are added to the default configuration
        /// provided by Docker. Valid values are as follows:
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>"ALL"</c> | <c>"AUDIT_CONTROL"</c> |<c> "AUDIT_WRITE"</c> | <c>"BLOCK_SUSPEND"</c>
        /// | <c>"CHOWN"</c> | <c>"DAC_OVERRIDE"</c> | <c>"DAC_READ_SEARCH"</c> | <c>"FOWNER"</c>
        /// | <c>"FSETID"</c> | <c>"IPC_LOCK"</c> | <c>"IPC_OWNER"</c> | <c>"KILL"</c> | <c>"LEASE"</c>
        /// | <c>"LINUX_IMMUTABLE"</c> | <c>"MAC_ADMIN"</c> |<c> "MAC_OVERRIDE"</c> | <c>"MKNOD"</c>
        /// | <c>"NET_ADMIN"</c> | <c>"NET_BIND_SERVICE"</c> | <c>"NET_BROADCAST"</c> | <c>"NET_RAW"</c>
        /// | <c>"SETFCAP"</c> | <c>"SETGID"</c> | <c>"SETPCAP"</c> | <c>"SETUID"</c> | <c>"SYS_ADMIN"</c>
        /// | <c>"SYS_BOOT"</c> | <c>"SYS_CHROOT"</c> | <c>"SYS_MODULE"</c> | <c>"SYS_NICE"</c>
        /// | <c>"SYS_PACCT"</c> | <c>"SYS_PTRACE"</c> | <c>"SYS_RAWIO"</c> | <c>"SYS_RESOURCE"</c>
        /// | <c>"SYS_TIME"</c> | <c>"SYS_TTY_CONFIG"</c> | <c>"SYSLOG"</c> | <c>"WAKE_ALARM"</c>
        /// 
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
        /// The Linux capabilities for the container that are dropped from the default configuration
        /// provided by Docker.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>"ALL"</c> | <c>"AUDIT_CONTROL"</c> |<c> "AUDIT_WRITE"</c> | <c>"BLOCK_SUSPEND"</c>
        /// | <c>"CHOWN"</c> | <c>"DAC_OVERRIDE"</c> | <c>"DAC_READ_SEARCH"</c> | <c>"FOWNER"</c>
        /// | <c>"FSETID"</c> | <c>"IPC_LOCK"</c> | <c>"IPC_OWNER"</c> | <c>"KILL"</c> | <c>"LEASE"</c>
        /// | <c>"LINUX_IMMUTABLE"</c> | <c>"MAC_ADMIN"</c> |<c> "MAC_OVERRIDE"</c> | <c>"MKNOD"</c>
        /// | <c>"NET_ADMIN"</c> | <c>"NET_BIND_SERVICE"</c> | <c>"NET_BROADCAST"</c> | <c>"NET_RAW"</c>
        /// | <c>"SETFCAP"</c> | <c>"SETGID"</c> | <c>"SETPCAP"</c> | <c>"SETUID"</c> | <c>"SYS_ADMIN"</c>
        /// | <c>"SYS_BOOT"</c> | <c>"SYS_CHROOT"</c> | <c>"SYS_MODULE"</c> | <c>"SYS_NICE"</c>
        /// | <c>"SYS_PACCT"</c> | <c>"SYS_PTRACE"</c> | <c>"SYS_RAWIO"</c> | <c>"SYS_RESOURCE"</c>
        /// | <c>"SYS_TIME"</c> | <c>"SYS_TTY_CONFIG"</c> | <c>"SYSLOG"</c> | <c>"WAKE_ALARM"</c>
        /// 
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
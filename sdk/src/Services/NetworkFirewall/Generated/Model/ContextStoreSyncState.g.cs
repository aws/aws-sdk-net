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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The synchronization state of a firewall's context sets with its context store. This
    /// indicates whether the resource identifiers in the firewall's context sets resolve
    /// to resources that the context store records.
    /// </summary>
    public partial class ContextStoreSyncState
    {
        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that provides additional information about the synchronization status, particularly
        /// when the status is not <c>FULLY_RESOLVED</c>.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SyncStatus. 
        /// <para>
        /// The synchronization status of the firewall's context sets. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SYNCING</c> - The firewall is applying the latest context store data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FULLY_RESOLVED</c> - All resource identifiers in the firewall's context sets resolve
        /// to resources in the context store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIALLY_RESOLVED</c> - Some resource identifiers in the firewall's context sets
        /// don't resolve to resources in the context store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SYNC_FAILED</c> - The firewall couldn't sync with the context store. For details,
        /// see <c>StatusMessage</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContextStoreSyncStatus SyncStatus { get; set; }

        /// <summary>
        /// Checks to see if the SyncStatus property is set.
        /// </summary>
        internal bool IsSetSyncStatus() => this.SyncStatus != null;
    }
}

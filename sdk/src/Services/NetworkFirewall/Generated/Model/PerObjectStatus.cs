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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
    /// Provides configuration status for a single policy or rule group that is used for a
    /// firewall endpoint. Network Firewall provides each endpoint with the rules that are
    /// configured in the firewall policy. Each time you add a subnet or modify the associated
    /// firewall policy, Network Firewall synchronizes the rules in the endpoint, so it can
    /// properly filter network traffic. This is part of a <a>SyncState</a> for a firewall.
    /// </summary>
    public partial class PerObjectStatus
    {
        private PerObjectSyncStatus _syncStatus;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property SyncStatus. 
        /// <para>
        /// Indicates whether this object is in sync with the version indicated in the update
        /// token.
        /// </para>
        /// </summary>
        public PerObjectSyncStatus SyncStatus
        {
            get { return this._syncStatus; }
            set { this._syncStatus = value; }
        }

        // Check to see if SyncStatus property is set
        internal bool IsSetSyncStatus()
        {
            return this._syncStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// The current version of the object that is either in sync or pending synchronization.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}
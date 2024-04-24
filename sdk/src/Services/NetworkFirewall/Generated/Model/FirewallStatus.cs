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
    /// Detailed information about the current status of a <a>Firewall</a>. You can retrieve
    /// this for a firewall by calling <a>DescribeFirewall</a> and providing the firewall
    /// name and ARN.
    /// </summary>
    public partial class FirewallStatus
    {
        private CapacityUsageSummary _capacityUsageSummary;
        private ConfigurationSyncState _configurationSyncStateSummary;
        private FirewallStatusValue _status;
        private Dictionary<string, SyncState> _syncStates = AWSConfigs.InitializeCollections ? new Dictionary<string, SyncState>() : null;

        /// <summary>
        /// Gets and sets the property CapacityUsageSummary. 
        /// <para>
        /// Describes the capacity usage of the resources contained in a firewall's reference
        /// sets. Network Firewall calclulates the capacity usage by taking an aggregated count
        /// of all of the resources used by all of the reference sets in a firewall.
        /// </para>
        /// </summary>
        public CapacityUsageSummary CapacityUsageSummary
        {
            get { return this._capacityUsageSummary; }
            set { this._capacityUsageSummary = value; }
        }

        // Check to see if CapacityUsageSummary property is set
        internal bool IsSetCapacityUsageSummary()
        {
            return this._capacityUsageSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSyncStateSummary. 
        /// <para>
        /// The configuration sync state for the firewall. This summarizes the sync states reported
        /// in the <c>Config</c> settings for all of the Availability Zones where you have configured
        /// the firewall. 
        /// </para>
        ///  
        /// <para>
        /// When you create a firewall or update its configuration, for example by adding a rule
        /// group to its firewall policy, Network Firewall distributes the configuration changes
        /// to all zones where the firewall is in use. This summary indicates whether the configuration
        /// changes have been applied everywhere. 
        /// </para>
        ///  
        /// <para>
        /// This status must be <c>IN_SYNC</c> for the firewall to be ready for use, but it doesn't
        /// indicate that the firewall is ready. The <c>Status</c> setting indicates firewall
        /// readiness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationSyncState ConfigurationSyncStateSummary
        {
            get { return this._configurationSyncStateSummary; }
            set { this._configurationSyncStateSummary = value; }
        }

        // Check to see if ConfigurationSyncStateSummary property is set
        internal bool IsSetConfigurationSyncStateSummary()
        {
            return this._configurationSyncStateSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The readiness of the configured firewall to handle network traffic across all of the
        /// Availability Zones where you've configured it. This setting is <c>READY</c> only when
        /// the <c>ConfigurationSyncStateSummary</c> value is <c>IN_SYNC</c> and the <c>Attachment</c>
        /// <c>Status</c> values for all of the configured subnets are <c>READY</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirewallStatusValue Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SyncStates. 
        /// <para>
        /// The subnets that you've configured for use by the Network Firewall firewall. This
        /// contains one array element per Availability Zone where you've configured a subnet.
        /// These objects provide details of the information that is summarized in the <c>ConfigurationSyncStateSummary</c>
        /// and <c>Status</c>, broken down by zone and configuration object. 
        /// </para>
        /// </summary>
        public Dictionary<string, SyncState> SyncStates
        {
            get { return this._syncStates; }
            set { this._syncStates = value; }
        }

        // Check to see if SyncStates property is set
        internal bool IsSetSyncStates()
        {
            return this._syncStates != null && (this._syncStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
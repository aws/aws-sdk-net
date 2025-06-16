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
    /// 
    ///  
    /// <para>
    /// The firewall status indicates a combined status. It indicates whether all subnets
    /// are up-to-date with the latest firewall configurations, which is based on the sync
    /// states config values, and also whether all subnets have their endpoints fully enabled,
    /// based on their sync states attachment values. 
    /// </para>
    /// </summary>
    public partial class FirewallStatus
    {
        private CapacityUsageSummary _capacityUsageSummary;
        private ConfigurationSyncState _configurationSyncStateSummary;
        private FirewallStatusValue _status;
        private Dictionary<string, SyncState> _syncStates = AWSConfigs.InitializeCollections ? new Dictionary<string, SyncState>() : null;
        private TransitGatewayAttachmentSyncState _transitGatewayAttachmentSyncState;

        /// <summary>
        /// Gets and sets the property CapacityUsageSummary. 
        /// <para>
        /// Describes the capacity usage of the resources contained in a firewall's reference
        /// sets. Network Firewall calculates the capacity usage by taking an aggregated count
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
        /// The configuration sync state for the firewall. This summarizes the <c>Config</c> settings
        /// in the <c>SyncStates</c> for this firewall status object. 
        /// </para>
        ///  
        /// <para>
        /// When you create a firewall or update its configuration, for example by adding a rule
        /// group to its firewall policy, Network Firewall distributes the configuration changes
        /// to all Availability Zones that have subnets defined for the firewall. This summary
        /// indicates whether the configuration changes have been applied everywhere. 
        /// </para>
        ///  
        /// <para>
        /// This status must be <c>IN_SYNC</c> for the firewall to be ready for use, but it doesn't
        /// indicate that the firewall is ready. The <c>Status</c> setting indicates firewall
        /// readiness. It's based on this setting and the readiness of the firewall endpoints
        /// to take traffic. 
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
        /// Availability Zones where you have it configured. This setting is <c>READY</c> only
        /// when the <c>ConfigurationSyncStateSummary</c> value is <c>IN_SYNC</c> and the <c>Attachment</c>
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
        /// Status for the subnets that you've configured in the firewall. This contains one array
        /// element per Availability Zone where you've configured a subnet in the firewall. 
        /// </para>
        ///  
        /// <para>
        /// These objects provide detailed information for the settings <c>ConfigurationSyncStateSummary</c>
        /// and <c>Status</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentSyncState. 
        /// <para>
        /// The synchronization state of the transit gateway attachment. This indicates whether
        /// the firewall's transit gateway configuration is properly synchronized and operational.
        /// Use this to verify that your transit gateway configuration changes have been applied.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentSyncState TransitGatewayAttachmentSyncState
        {
            get { return this._transitGatewayAttachmentSyncState; }
            set { this._transitGatewayAttachmentSyncState = value; }
        }

        // Check to see if TransitGatewayAttachmentSyncState property is set
        internal bool IsSetTransitGatewayAttachmentSyncState()
        {
            return this._transitGatewayAttachmentSyncState != null;
        }

    }
}
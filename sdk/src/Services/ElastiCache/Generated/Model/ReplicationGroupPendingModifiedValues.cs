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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The settings to be applied to the Valkey or Redis OSS replication group, either immediately
    /// or during the next maintenance window.
    /// </summary>
    public partial class ReplicationGroupPendingModifiedValues
    {
        private AuthTokenUpdateStatus _authTokenStatus;
        private PendingAutomaticFailoverStatus _automaticFailoverStatus;
        private ClusterMode _clusterMode;
        private List<PendingLogDeliveryConfiguration> _logDeliveryConfigurations = AWSConfigs.InitializeCollections ? new List<PendingLogDeliveryConfiguration>() : null;
        private string _primaryClusterId;
        private ReshardingStatus _resharding;
        private bool? _transitEncryptionEnabled;
        private TransitEncryptionMode _transitEncryptionMode;
        private UserGroupsUpdateStatus _userGroups;

        /// <summary>
        /// Gets and sets the property AuthTokenStatus. 
        /// <para>
        /// The auth token status
        /// </para>
        /// </summary>
        public AuthTokenUpdateStatus AuthTokenStatus
        {
            get { return this._authTokenStatus; }
            set { this._authTokenStatus = value; }
        }

        // Check to see if AuthTokenStatus property is set
        internal bool IsSetAuthTokenStatus()
        {
            return this._authTokenStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AutomaticFailoverStatus. 
        /// <para>
        /// Indicates the status of automatic failover for this Valkey or Redis OSS replication
        /// group.
        /// </para>
        /// </summary>
        public PendingAutomaticFailoverStatus AutomaticFailoverStatus
        {
            get { return this._automaticFailoverStatus; }
            set { this._automaticFailoverStatus = value; }
        }

        // Check to see if AutomaticFailoverStatus property is set
        internal bool IsSetAutomaticFailoverStatus()
        {
            return this._automaticFailoverStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterMode. 
        /// <para>
        /// Enabled or Disabled. To modify cluster mode from Disabled to Enabled, you must first
        /// set the cluster mode to Compatible. Compatible mode allows your Valkey or Redis OSS
        /// clients to connect using both cluster mode enabled and cluster mode disabled. After
        /// you migrate all Valkey or Redis OSS clients to use cluster mode enabled, you can then
        /// complete cluster mode configuration and set the cluster mode to Enabled.
        /// </para>
        /// </summary>
        public ClusterMode ClusterMode
        {
            get { return this._clusterMode; }
            set { this._clusterMode = value; }
        }

        // Check to see if ClusterMode property is set
        internal bool IsSetClusterMode()
        {
            return this._clusterMode != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryConfigurations. 
        /// <para>
        /// The log delivery configurations being modified 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PendingLogDeliveryConfiguration> LogDeliveryConfigurations
        {
            get { return this._logDeliveryConfigurations; }
            set { this._logDeliveryConfigurations = value; }
        }

        // Check to see if LogDeliveryConfigurations property is set
        internal bool IsSetLogDeliveryConfigurations()
        {
            return this._logDeliveryConfigurations != null && (this._logDeliveryConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrimaryClusterId. 
        /// <para>
        /// The primary cluster ID that is applied immediately (if <c>--apply-immediately</c>
        /// was specified), or during the next maintenance window.
        /// </para>
        /// </summary>
        public string PrimaryClusterId
        {
            get { return this._primaryClusterId; }
            set { this._primaryClusterId = value; }
        }

        // Check to see if PrimaryClusterId property is set
        internal bool IsSetPrimaryClusterId()
        {
            return this._primaryClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property Resharding. 
        /// <para>
        /// The status of an online resharding operation.
        /// </para>
        /// </summary>
        public ReshardingStatus Resharding
        {
            get { return this._resharding; }
            set { this._resharding = value; }
        }

        // Check to see if Resharding property is set
        internal bool IsSetResharding()
        {
            return this._resharding != null;
        }

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to true.
        /// </para>
        /// </summary>
        public bool? TransitEncryptionEnabled
        {
            get { return this._transitEncryptionEnabled; }
            set { this._transitEncryptionEnabled = value; }
        }

        // Check to see if TransitEncryptionEnabled property is set
        internal bool IsSetTransitEncryptionEnabled()
        {
            return this._transitEncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransitEncryptionMode. 
        /// <para>
        /// A setting that allows you to migrate your clients to use in-transit encryption, with
        /// no downtime.
        /// </para>
        /// </summary>
        public TransitEncryptionMode TransitEncryptionMode
        {
            get { return this._transitEncryptionMode; }
            set { this._transitEncryptionMode = value; }
        }

        // Check to see if TransitEncryptionMode property is set
        internal bool IsSetTransitEncryptionMode()
        {
            return this._transitEncryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// The user group being modified.
        /// </para>
        /// </summary>
        public UserGroupsUpdateStatus UserGroups
        {
            get { return this._userGroups; }
            set { this._userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this._userGroups != null;
        }

    }
}
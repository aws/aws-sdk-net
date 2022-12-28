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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The settings to be applied to the Redis replication group, either immediately or during
    /// the next maintenance window.
    /// </summary>
    public partial class ReplicationGroupPendingModifiedValues
    {
        private AuthTokenUpdateStatus _authTokenStatus;
        private PendingAutomaticFailoverStatus _automaticFailoverStatus;
        private List<PendingLogDeliveryConfiguration> _logDeliveryConfigurations = new List<PendingLogDeliveryConfiguration>();
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
        /// Indicates the status of automatic failover for this Redis replication group.
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
        /// Gets and sets the property LogDeliveryConfigurations. 
        /// <para>
        /// The log delivery configurations being modified 
        /// </para>
        /// </summary>
        public List<PendingLogDeliveryConfiguration> LogDeliveryConfigurations
        {
            get { return this._logDeliveryConfigurations; }
            set { this._logDeliveryConfigurations = value; }
        }

        // Check to see if LogDeliveryConfigurations property is set
        internal bool IsSetLogDeliveryConfigurations()
        {
            return this._logDeliveryConfigurations != null && this._logDeliveryConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryClusterId. 
        /// <para>
        /// The primary cluster ID that is applied immediately (if <code>--apply-immediately</code>
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
        public bool TransitEncryptionEnabled
        {
            get { return this._transitEncryptionEnabled.GetValueOrDefault(); }
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
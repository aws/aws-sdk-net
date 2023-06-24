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
    /// A group of settings that are applied to the cluster in the future, or that are currently
    /// being applied.
    /// </summary>
    public partial class PendingModifiedValues
    {
        private AuthTokenUpdateStatus _authTokenStatus;
        private List<string> _cacheNodeIdsToRemove = new List<string>();
        private string _cacheNodeType;
        private string _engineVersion;
        private List<PendingLogDeliveryConfiguration> _logDeliveryConfigurations = new List<PendingLogDeliveryConfiguration>();
        private int? _numCacheNodes;
        private bool? _transitEncryptionEnabled;
        private TransitEncryptionMode _transitEncryptionMode;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PendingModifiedValues() { }

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
        /// Gets and sets the property CacheNodeIdsToRemove. 
        /// <para>
        /// A list of cache node IDs that are being removed (or will be removed) from the cluster.
        /// A node ID is a 4-digit numeric identifier (0001, 0002, etc.).
        /// </para>
        /// </summary>
        public List<string> CacheNodeIdsToRemove
        {
            get { return this._cacheNodeIdsToRemove; }
            set { this._cacheNodeIdsToRemove = value; }
        }

        // Check to see if CacheNodeIdsToRemove property is set
        internal bool IsSetCacheNodeIdsToRemove()
        {
            return this._cacheNodeIdsToRemove != null && this._cacheNodeIdsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The cache node type that this cluster or replication group is scaled to.
        /// </para>
        /// </summary>
        public string CacheNodeType
        {
            get { return this._cacheNodeType; }
            set { this._cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this._cacheNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The new cache engine version that the cluster runs.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
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
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The new number of cache nodes for the cluster.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Redis, this value must be 1. For clusters running Memcached,
        /// this value must be between 1 and 40.
        /// </para>
        /// </summary>
        public int NumCacheNodes
        {
            get { return this._numCacheNodes.GetValueOrDefault(); }
            set { this._numCacheNodes = value; }
        }

        // Check to see if NumCacheNodes property is set
        internal bool IsSetNumCacheNodes()
        {
            return this._numCacheNodes.HasValue; 
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

    }
}
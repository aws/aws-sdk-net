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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This object provides configuration information about a serverless replication.
    /// </summary>
    public partial class ReplicationConfig
    {
        private ComputeConfig _computeConfig;
        private string _replicationConfigArn;
        private DateTime? _replicationConfigCreateTime;
        private string _replicationConfigIdentifier;
        private DateTime? _replicationConfigUpdateTime;
        private string _replicationSettings;
        private MigrationTypeValue _replicationType;
        private string _sourceEndpointArn;
        private string _supplementalSettings;
        private string _tableMappings;
        private string _targetEndpointArn;

        /// <summary>
        /// Gets and sets the property ComputeConfig. 
        /// <para>
        /// Configuration parameters for provisioning an DMS serverless replication.
        /// </para>
        /// </summary>
        public ComputeConfig ComputeConfig
        {
            get { return this._computeConfig; }
            set { this._computeConfig = value; }
        }

        // Check to see if ComputeConfig property is set
        internal bool IsSetComputeConfig()
        {
            return this._computeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this DMS Serverless replication configuration.
        /// </para>
        /// </summary>
        public string ReplicationConfigArn
        {
            get { return this._replicationConfigArn; }
            set { this._replicationConfigArn = value; }
        }

        // Check to see if ReplicationConfigArn property is set
        internal bool IsSetReplicationConfigArn()
        {
            return this._replicationConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigCreateTime. 
        /// <para>
        /// The time the serverless replication config was created.
        /// </para>
        /// </summary>
        public DateTime? ReplicationConfigCreateTime
        {
            get { return this._replicationConfigCreateTime; }
            set { this._replicationConfigCreateTime = value; }
        }

        // Check to see if ReplicationConfigCreateTime property is set
        internal bool IsSetReplicationConfigCreateTime()
        {
            return this._replicationConfigCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigIdentifier. 
        /// <para>
        /// The identifier for the <c>ReplicationConfig</c> associated with the replication.
        /// </para>
        /// </summary>
        public string ReplicationConfigIdentifier
        {
            get { return this._replicationConfigIdentifier; }
            set { this._replicationConfigIdentifier = value; }
        }

        // Check to see if ReplicationConfigIdentifier property is set
        internal bool IsSetReplicationConfigIdentifier()
        {
            return this._replicationConfigIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigUpdateTime. 
        /// <para>
        /// The time the serverless replication config was updated.
        /// </para>
        /// </summary>
        public DateTime? ReplicationConfigUpdateTime
        {
            get { return this._replicationConfigUpdateTime; }
            set { this._replicationConfigUpdateTime = value; }
        }

        // Check to see if ReplicationConfigUpdateTime property is set
        internal bool IsSetReplicationConfigUpdateTime()
        {
            return this._replicationConfigUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationSettings. 
        /// <para>
        /// Configuration parameters for an DMS serverless replication.
        /// </para>
        /// </summary>
        public string ReplicationSettings
        {
            get { return this._replicationSettings; }
            set { this._replicationSettings = value; }
        }

        // Check to see if ReplicationSettings property is set
        internal bool IsSetReplicationSettings()
        {
            return this._replicationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// The type of the replication.
        /// </para>
        /// </summary>
        public MigrationTypeValue ReplicationType
        {
            get { return this._replicationType; }
            set { this._replicationType = value; }
        }

        // Check to see if ReplicationType property is set
        internal bool IsSetReplicationType()
        {
            return this._replicationType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source endpoint for this DMS serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        public string SourceEndpointArn
        {
            get { return this._sourceEndpointArn; }
            set { this._sourceEndpointArn = value; }
        }

        // Check to see if SourceEndpointArn property is set
        internal bool IsSetSourceEndpointArn()
        {
            return this._sourceEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementalSettings. 
        /// <para>
        /// Additional parameters for an DMS serverless replication.
        /// </para>
        /// </summary>
        public string SupplementalSettings
        {
            get { return this._supplementalSettings; }
            set { this._supplementalSettings = value; }
        }

        // Check to see if SupplementalSettings property is set
        internal bool IsSetSupplementalSettings()
        {
            return this._supplementalSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// Table mappings specified in the replication.
        /// </para>
        /// </summary>
        public string TableMappings
        {
            get { return this._tableMappings; }
            set { this._tableMappings = value; }
        }

        // Check to see if TableMappings property is set
        internal bool IsSetTableMappings()
        {
            return this._tableMappings != null;
        }

        /// <summary>
        /// Gets and sets the property TargetEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target endpoint for this DMS serverless replication
        /// configuration.
        /// </para>
        /// </summary>
        public string TargetEndpointArn
        {
            get { return this._targetEndpointArn; }
            set { this._targetEndpointArn = value; }
        }

        // Check to see if TargetEndpointArn property is set
        internal bool IsSetTargetEndpointArn()
        {
            return this._targetEndpointArn != null;
        }

    }
}
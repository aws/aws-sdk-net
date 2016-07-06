/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReplicationTask
    {
        private string _lastFailureMessage;
        private MigrationTypeValue _migrationType;
        private string _replicationInstanceArn;
        private string _replicationTaskArn;
        private DateTime? _replicationTaskCreationDate;
        private string _replicationTaskIdentifier;
        private string _replicationTaskSettings;
        private DateTime? _replicationTaskStartDate;
        private ReplicationTaskStats _replicationTaskStats;
        private string _sourceEndpointArn;
        private string _status;
        private string _tableMappings;
        private string _targetEndpointArn;

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The last error (failure) message generated for the replication instance.
        /// </para>
        /// </summary>
        public string LastFailureMessage
        {
            get { return this._lastFailureMessage; }
            set { this._lastFailureMessage = value; }
        }

        // Check to see if LastFailureMessage property is set
        internal bool IsSetLastFailureMessage()
        {
            return this._lastFailureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationType. 
        /// <para>
        /// The type of migration.
        /// </para>
        /// </summary>
        public MigrationTypeValue MigrationType
        {
            get { return this._migrationType; }
            set { this._migrationType = value; }
        }

        // Check to see if MigrationType property is set
        internal bool IsSetMigrationType()
        {
            return this._migrationType != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskCreationDate. 
        /// <para>
        /// The date the replication task was created.
        /// </para>
        /// </summary>
        public DateTime ReplicationTaskCreationDate
        {
            get { return this._replicationTaskCreationDate.GetValueOrDefault(); }
            set { this._replicationTaskCreationDate = value; }
        }

        // Check to see if ReplicationTaskCreationDate property is set
        internal bool IsSetReplicationTaskCreationDate()
        {
            return this._replicationTaskCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        /// The replication task identifier.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ReplicationTaskIdentifier
        {
            get { return this._replicationTaskIdentifier; }
            set { this._replicationTaskIdentifier = value; }
        }

        // Check to see if ReplicationTaskIdentifier property is set
        internal bool IsSetReplicationTaskIdentifier()
        {
            return this._replicationTaskIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskSettings. 
        /// <para>
        /// The settings for the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskSettings
        {
            get { return this._replicationTaskSettings; }
            set { this._replicationTaskSettings = value; }
        }

        // Check to see if ReplicationTaskSettings property is set
        internal bool IsSetReplicationTaskSettings()
        {
            return this._replicationTaskSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskStartDate. 
        /// <para>
        /// The date the replication task is scheduled to start.
        /// </para>
        /// </summary>
        public DateTime ReplicationTaskStartDate
        {
            get { return this._replicationTaskStartDate.GetValueOrDefault(); }
            set { this._replicationTaskStartDate = value; }
        }

        // Check to see if ReplicationTaskStartDate property is set
        internal bool IsSetReplicationTaskStartDate()
        {
            return this._replicationTaskStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskStats. 
        /// <para>
        /// The statistics for the task, including elapsed time, tables loaded, and table errors.
        /// </para>
        /// </summary>
        public ReplicationTaskStats ReplicationTaskStats
        {
            get { return this._replicationTaskStats; }
            set { this._replicationTaskStats = value; }
        }

        // Check to see if ReplicationTaskStats property is set
        internal bool IsSetReplicationTaskStats()
        {
            return this._replicationTaskStats != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the replication task.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TableMappings. 
        /// <para>
        /// Table mappings specified in the task.
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
        /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
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
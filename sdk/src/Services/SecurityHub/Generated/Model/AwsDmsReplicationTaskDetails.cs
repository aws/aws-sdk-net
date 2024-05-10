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
    /// Provides details about an Database Migration Service (DMS) replication task. A replication
    /// task moves a set of data from the source endpoint to the target endpoint.
    /// </summary>
    public partial class AwsDmsReplicationTaskDetails
    {
        private string _cdcStartPosition;
        private string _cdcStartTime;
        private string _cdcStopPosition;
        private string _id;
        private string _migrationType;
        private string _replicationInstanceArn;
        private string _replicationTaskIdentifier;
        private string _replicationTaskSettings;
        private string _resourceIdentifier;
        private string _sourceEndpointArn;
        private string _tableMappings;
        private string _targetEndpointArn;
        private string _taskData;

        /// <summary>
        /// Gets and sets the property CdcStartPosition. 
        /// <para>
        ///  Indicates when you want a change data capture (CDC) operation to start. <c>CCdcStartPosition</c>
        /// or <c>CCdcStartTime</c> specifies when you want a CDC operation to start. Only a value
        /// for one of these fields is included.
        /// </para>
        /// </summary>
        public string CdcStartPosition
        {
            get { return this._cdcStartPosition; }
            set { this._cdcStartPosition = value; }
        }

        // Check to see if CdcStartPosition property is set
        internal bool IsSetCdcStartPosition()
        {
            return this._cdcStartPosition != null;
        }

        /// <summary>
        /// Gets and sets the property CdcStartTime. 
        /// <para>
        ///  Indicates the start time for a CDC operation. <c>CdcStartPosition</c> or <c>CCdcStartTime</c>
        /// specifies when you want a CDC operation to start. Only a value for one of these fields
        /// is included.
        /// </para>
        /// </summary>
        public string CdcStartTime
        {
            get { return this._cdcStartTime; }
            set { this._cdcStartTime = value; }
        }

        // Check to see if CdcStartTime property is set
        internal bool IsSetCdcStartTime()
        {
            return this._cdcStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property CdcStopPosition. 
        /// <para>
        ///  Indicates when you want a CDC operation to stop. The value can be either server time
        /// or commit time.
        /// </para>
        /// </summary>
        public string CdcStopPosition
        {
            get { return this._cdcStopPosition; }
            set { this._cdcStopPosition = value; }
        }

        // Check to see if CdcStopPosition property is set
        internal bool IsSetCdcStopPosition()
        {
            return this._cdcStopPosition != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the replication task.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationType. 
        /// <para>
        ///  The migration type. 
        /// </para>
        /// </summary>
        public string MigrationType
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
        ///  The Amazon Resource Name (ARN) of a replication instance. 
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
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        ///  The user-defined replication task identifier or name.
        /// </para>
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
        ///  The settings for the replication task.
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
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        ///  A display name for the resource identifier at the end of the <c>EndpointArn</c> response
        /// parameter. If you don't specify a <c>ResourceIdentifier</c> value, DMS generates a
        /// default identifier value for the end of <c>EndpointArn</c>.
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEndpointArn. 
        /// <para>
        ///  The ARN of the source endpoint.
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
        /// Gets and sets the property TableMappings. 
        /// <para>
        ///  The table mappings for the replication task, in JSON format.
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
        ///  The ARN of the target endpoint.
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

        /// <summary>
        /// Gets and sets the property TaskData. 
        /// <para>
        ///  Supplemental information that the task requires to migrate the data for certain source
        /// and target endpoints.
        /// </para>
        /// </summary>
        public string TaskData
        {
            get { return this._taskData; }
            set { this._taskData = value; }
        }

        // Check to see if TaskData property is set
        internal bool IsSetTaskData()
        {
            return this._taskData != null;
        }

    }
}
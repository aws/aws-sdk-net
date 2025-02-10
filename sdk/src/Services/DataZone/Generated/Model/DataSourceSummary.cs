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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the data source.
    /// </summary>
    public partial class DataSourceSummary
    {
        private string _connectionId;
        private DateTime? _createdAt;
        private string _dataSourceId;
        private string _description;
        private string _domainId;
        private EnableSetting _enableSetting;
        private string _environmentId;
        private int? _lastRunAssetCount;
        private DateTime? _lastRunAt;
        private DataSourceErrorMessage _lastRunErrorMessage;
        private DataSourceRunStatus _lastRunStatus;
        private string _name;
        private ScheduleConfiguration _schedule;
        private DataSourceStatus _status;
        private string _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The connection ID that's part of the data source summary.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the data source was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The data source description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the data source exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EnableSetting. 
        /// <para>
        /// Specifies whether the data source is enabled.
        /// </para>
        /// </summary>
        public EnableSetting EnableSetting
        {
            get { return this._enableSetting; }
            set { this._enableSetting = value; }
        }

        // Check to see if EnableSetting property is set
        internal bool IsSetEnableSetting()
        {
            return this._enableSetting != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment in which the data source exists.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunAssetCount. 
        /// <para>
        /// The count of the assets created during the last data source run.
        /// </para>
        /// </summary>
        public int? LastRunAssetCount
        {
            get { return this._lastRunAssetCount; }
            set { this._lastRunAssetCount = value; }
        }

        // Check to see if LastRunAssetCount property is set
        internal bool IsSetLastRunAssetCount()
        {
            return this._lastRunAssetCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastRunAt. 
        /// <para>
        /// The timestamp of when the data source run was last performed.
        /// </para>
        /// </summary>
        public DateTime? LastRunAt
        {
            get { return this._lastRunAt; }
            set { this._lastRunAt = value; }
        }

        // Check to see if LastRunAt property is set
        internal bool IsSetLastRunAt()
        {
            return this._lastRunAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastRunErrorMessage.
        /// </summary>
        public DataSourceErrorMessage LastRunErrorMessage
        {
            get { return this._lastRunErrorMessage; }
            set { this._lastRunErrorMessage = value; }
        }

        // Check to see if LastRunErrorMessage property is set
        internal bool IsSetLastRunErrorMessage()
        {
            return this._lastRunErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// The status of the last data source run.
        /// </para>
        /// </summary>
        public DataSourceRunStatus LastRunStatus
        {
            get { return this._lastRunStatus; }
            set { this._lastRunStatus = value; }
        }

        // Check to see if LastRunStatus property is set
        internal bool IsSetLastRunStatus()
        {
            return this._lastRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ScheduleConfiguration Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the data source was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The progress details of a specific domain configuration change.
    /// </summary>
    public partial class ChangeProgressStatusDetails
    {
        private string _changeId;
        private List<ChangeProgressStage> _changeProgressStages = AWSConfigs.InitializeCollections ? new List<ChangeProgressStage>() : null;
        private List<string> _completedProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConfigChangeStatus _configChangeStatus;
        private InitiatedBy _initiatedBy;
        private DateTime? _lastUpdatedTime;
        private List<string> _pendingProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startTime;
        private OverallChangeStatus _status;
        private int? _totalNumberOfStages;

        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The unique change identifier associated with a specific domain configuration change.
        /// </para>
        /// </summary>
        public string ChangeId
        {
            get { return this._changeId; }
            set { this._changeId = value; }
        }

        // Check to see if ChangeId property is set
        internal bool IsSetChangeId()
        {
            return this._changeId != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeProgressStages. 
        /// <para>
        /// The specific stages that the domain is going through to perform the configuration
        /// change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChangeProgressStage> ChangeProgressStages
        {
            get { return this._changeProgressStages; }
            set { this._changeProgressStages = value; }
        }

        // Check to see if ChangeProgressStages property is set
        internal bool IsSetChangeProgressStages()
        {
            return this._changeProgressStages != null && (this._changeProgressStages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CompletedProperties. 
        /// <para>
        /// The list of properties involved in the domain configuration change that are completed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CompletedProperties
        {
            get { return this._completedProperties; }
            set { this._completedProperties = value; }
        }

        // Check to see if CompletedProperties property is set
        internal bool IsSetCompletedProperties()
        {
            return this._completedProperties != null && (this._completedProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConfigChangeStatus. 
        /// <para>
        /// The current status of the configuration change.
        /// </para>
        /// </summary>
        public ConfigChangeStatus ConfigChangeStatus
        {
            get { return this._configChangeStatus; }
            set { this._configChangeStatus = value; }
        }

        // Check to see if ConfigChangeStatus property is set
        internal bool IsSetConfigChangeStatus()
        {
            return this._configChangeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// The IAM principal who initiated the configuration change.
        /// </para>
        /// </summary>
        public InitiatedBy InitiatedBy
        {
            get { return this._initiatedBy; }
            set { this._initiatedBy = value; }
        }

        // Check to see if InitiatedBy property is set
        internal bool IsSetInitiatedBy()
        {
            return this._initiatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that the status of the configuration change was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingProperties. 
        /// <para>
        /// The list of properties involved in the domain configuration change that are still
        /// in pending.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PendingProperties
        {
            get { return this._pendingProperties; }
            set { this._pendingProperties = value; }
        }

        // Check to see if PendingProperties property is set
        internal bool IsSetPendingProperties()
        {
            return this._pendingProperties != null && (this._pendingProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the configuration change is made on the domain.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The overall status of the domain configuration change. This field can take the following
        /// values: <c>PENDING</c>, <c>PROCESSING</c>, <c>COMPLETED</c> and <c>FAILED</c>
        /// </para>
        /// </summary>
        public OverallChangeStatus Status
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
        /// Gets and sets the property TotalNumberOfStages. 
        /// <para>
        /// The total number of stages required for the configuration change.
        /// </para>
        /// </summary>
        public int? TotalNumberOfStages
        {
            get { return this._totalNumberOfStages; }
            set { this._totalNumberOfStages = value; }
        }

        // Check to see if TotalNumberOfStages property is set
        internal bool IsSetTotalNumberOfStages()
        {
            return this._totalNumberOfStages.HasValue; 
        }

    }
}
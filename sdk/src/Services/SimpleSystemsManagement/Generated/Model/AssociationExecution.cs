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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Includes information about the specified association.
    /// </summary>
    public partial class AssociationExecution
    {
        private AlarmConfiguration _alarmConfiguration;
        private string _associationId;
        private string _associationVersion;
        private DateTime? _createdTime;
        private string _detailedStatus;
        private string _executionId;
        private DateTime? _lastExecutionDate;
        private string _resourceCountByStatus;
        private string _status;
        private List<AlarmStateInformation> _triggeredAlarms = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration.
        /// </summary>
        public AlarmConfiguration AlarmConfiguration
        {
            get { return this._alarmConfiguration; }
            set { this._alarmConfiguration = value; }
        }

        // Check to see if AlarmConfiguration property is set
        internal bool IsSetAlarmConfiguration()
        {
            return this._alarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// The association version.
        /// </para>
        /// </summary>
        public string AssociationVersion
        {
            get { return this._associationVersion; }
            set { this._associationVersion = value; }
        }

        // Check to see if AssociationVersion property is set
        internal bool IsSetAssociationVersion()
        {
            return this._associationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the execution started.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetailedStatus. 
        /// <para>
        /// Detailed status information about the execution.
        /// </para>
        /// </summary>
        public string DetailedStatus
        {
            get { return this._detailedStatus; }
            set { this._detailedStatus = value; }
        }

        // Check to see if DetailedStatus property is set
        internal bool IsSetDetailedStatus()
        {
            return this._detailedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution ID for the association.
        /// </para>
        /// </summary>
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property LastExecutionDate. 
        /// <para>
        /// The date of the last execution.
        /// </para>
        /// </summary>
        public DateTime? LastExecutionDate
        {
            get { return this._lastExecutionDate; }
            set { this._lastExecutionDate = value; }
        }

        // Check to see if LastExecutionDate property is set
        internal bool IsSetLastExecutionDate()
        {
            return this._lastExecutionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceCountByStatus. 
        /// <para>
        /// An aggregate status of the resources in the execution based on the status type.
        /// </para>
        /// </summary>
        public string ResourceCountByStatus
        {
            get { return this._resourceCountByStatus; }
            set { this._resourceCountByStatus = value; }
        }

        // Check to see if ResourceCountByStatus property is set
        internal bool IsSetResourceCountByStatus()
        {
            return this._resourceCountByStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the association execution.
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
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarms that were invoked by the association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AlarmStateInformation> TriggeredAlarms
        {
            get { return this._triggeredAlarms; }
            set { this._triggeredAlarms = value; }
        }

        // Check to see if TriggeredAlarms property is set
        internal bool IsSetTriggeredAlarms()
        {
            return this._triggeredAlarms != null && (this._triggeredAlarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the UpdateWorkerSchedule operation.
    /// </summary>
    public partial class UpdateWorkerScheduleResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, AssignedSession> _assignedSessions = AWSConfigs.InitializeCollections ? new Dictionary<string, AssignedSession>() : null;
        private Dictionary<string, List<string>> _cancelSessionActions = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private DesiredWorkerStatus _desiredWorkerStatus;
        private int? _updateIntervalSeconds;

        /// <summary>
        /// Gets and sets the property AssignedSessions. 
        /// <para>
        /// The assigned sessions to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, AssignedSession> AssignedSessions
        {
            get { return this._assignedSessions; }
            set { this._assignedSessions = value; }
        }

        // Check to see if AssignedSessions property is set
        internal bool IsSetAssignedSessions()
        {
            return this._assignedSessions != null && (this._assignedSessions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CancelSessionActions. 
        /// <para>
        /// The session actions associated with the worker schedule to cancel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, List<string>> CancelSessionActions
        {
            get { return this._cancelSessionActions; }
            set { this._cancelSessionActions = value; }
        }

        // Check to see if CancelSessionActions property is set
        internal bool IsSetCancelSessionActions()
        {
            return this._cancelSessionActions != null && (this._cancelSessionActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DesiredWorkerStatus. 
        /// <para>
        /// The status to update the worker to.
        /// </para>
        /// </summary>
        public DesiredWorkerStatus DesiredWorkerStatus
        {
            get { return this._desiredWorkerStatus; }
            set { this._desiredWorkerStatus = value; }
        }

        // Check to see if DesiredWorkerStatus property is set
        internal bool IsSetDesiredWorkerStatus()
        {
            return this._desiredWorkerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateIntervalSeconds. 
        /// <para>
        /// Updates the time interval (in seconds) for the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? UpdateIntervalSeconds
        {
            get { return this._updateIntervalSeconds; }
            set { this._updateIntervalSeconds = value; }
        }

        // Check to see if UpdateIntervalSeconds property is set
        internal bool IsSetUpdateIntervalSeconds()
        {
            return this._updateIntervalSeconds.HasValue; 
        }

    }
}
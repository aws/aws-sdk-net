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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents the response structure returned when a prospecting task is successfully
    /// submitted. Contains the task identifier, ARN, and initial status. Uses <c>TaskId</c>
    /// with <c>GetProspectingFromEngagementTask</c> to poll for completion.
    /// </summary>
    public partial class StartProspectingFromEngagementTaskResponse : AmazonWebServiceResponse
    {
        private List<string> _identifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _message;
        private string _reasonCode;
        private DateTime? _startTime;
        private string _taskArn;
        private string _taskId;
        private string _taskName;
        private ProspectingTaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// The list of engagement identifiers that were accepted into the task queue for processing.
        /// This list matches the identifiers provided in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> Identifiers
        {
            get { return this._identifiers; }
            set { this._identifiers = value; }
        }

        // Check to see if Identifiers property is set
        internal bool IsSetIdentifiers()
        {
            return this._identifiers != null && (this._identifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message providing additional context about the task's current state. When the task
        /// fails, this field contains a detailed description of the failure and suggested recovery
        /// steps. This field is only populated for tasks in a failed state.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// An enumerated code identifying the reason for task failure. This field is only populated
        /// when the task has failed. Use the corresponding <c>Message</c> field for a human-readable
        /// description of the failure.
        /// </para>
        /// </summary>
        public string ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp indicating when the task was initiated. The format follows ISO 8601
        /// date-time notation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task. The ARN uniquely identifies the task across
        /// AWS and can be used for resource-level IAM policies.
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier assigned to this task. Use this identifier with <c>GetProspectingFromEngagementTask</c>
        /// to retrieve task details and check status.
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The task name from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The current status of the task. Possible values: <c>PENDING</c> (waiting to run),
        /// <c>IN_PROGRESS</c> (actively processing), <c>COMPLETED</c> (successfully processed),
        /// and <c>FAILED</c> (unrecoverable error).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProspectingTaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}
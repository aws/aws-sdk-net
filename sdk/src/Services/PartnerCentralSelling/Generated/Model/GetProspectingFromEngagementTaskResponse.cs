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
    /// Represents the response structure containing the full details of a prospecting task,
    /// including per-engagement processing results. Includes the <c>Status</c> field of each
    /// <c>EngagementProspectingResult</c> entry to determine individual outcomes.
    /// </summary>
    public partial class GetProspectingFromEngagementTaskResponse : AmazonWebServiceResponse
    {
        private DateTime? _endTime;
        private List<EngagementProspectingResult> _engagements = AWSConfigs.InitializeCollections ? new List<EngagementProspectingResult>() : null;
        private DateTime? _startTime;
        private string _taskArn;
        private string _taskId;
        private string _taskName;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp indicating when the task finished processing. This field is absent if
        /// the task is still in progress. The format follows ISO 8601 date-time notation.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engagements. 
        /// <para>
        /// An array of <c>EngagementProspectingResult</c> entries for each engagement in the
        /// task. Each entry contains the processing status. For successfully completed engagements,
        /// includes the prospecting context identifier. For failed engagements, includes an error
        /// code and message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EngagementProspectingResult> Engagements
        {
            get { return this._engagements; }
            set { this._engagements = value; }
        }

        // Check to see if Engagements property is set
        internal bool IsSetEngagements()
        {
            return this._engagements != null && (this._engagements.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The unique identifier of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The descriptive name of the task that you provided when you created it.
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

    }
}
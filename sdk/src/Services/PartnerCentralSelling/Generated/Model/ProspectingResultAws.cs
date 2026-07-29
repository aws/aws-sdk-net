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
    /// Contains the prospecting data that AWS sources. This includes task execution details,
    /// customer account information, and insights that AI generates from the prospecting
    /// analysis.
    /// </summary>
    public partial class ProspectingResultAws
    {
        private ProspectingResultCustomer _customer;
        private DateTime? _endTime;
        private ProspectingInsights _insights;
        private DateTime? _startTime;
        private string _taskArn;
        private string _taskId;
        private string _taskName;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Contains details about the prospected customer account, including geographic, industry,
        /// and segment classifications.
        /// </para>
        /// </summary>
        public ProspectingResultCustomer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        // Check to see if Customer property is set
        internal bool IsSetCustomer()
        {
            return this._customer != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the prospecting task completed processing. The format is ISO 8601
        /// (UTC).
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
        /// Gets and sets the property Insights. 
        /// <para>
        /// Insights that AI generates from the prospecting analysis. These insights include engagement
        /// scores and solution fit assessments for the prospected customer.
        /// </para>
        /// </summary>
        public ProspectingInsights Insights
        {
            get { return this._insights; }
            set { this._insights = value; }
        }

        // Check to see if Insights property is set
        internal bool IsSetInsights()
        {
            return this._insights != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the prospecting result context was created. The format is ISO 8601
        /// (UTC).
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the prospecting task. Use this ARN to track and
        /// manage the task within AWS.
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
        /// The unique identifier of the prospecting task that generates this result.
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
        /// The name that the user provides for the prospecting task that generates this result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
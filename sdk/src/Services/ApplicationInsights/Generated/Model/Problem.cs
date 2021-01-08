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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes a problem that is detected by correlating observations.
    /// </summary>
    public partial class Problem
    {
        private string _affectedResource;
        private DateTime? _endTime;
        private Dictionary<string, string> _feedback = new Dictionary<string, string>();
        private string _id;
        private string _insights;
        private string _resourceGroupName;
        private SeverityLevel _severityLevel;
        private DateTime? _startTime;
        private Status _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property AffectedResource. 
        /// <para>
        /// The resource affected by the problem.
        /// </para>
        /// </summary>
        public string AffectedResource
        {
            get { return this._affectedResource; }
            set { this._affectedResource = value; }
        }

        // Check to see if AffectedResource property is set
        internal bool IsSetAffectedResource()
        {
            return this._affectedResource != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the problem ended, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Feedback provided by the user about the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public Dictionary<string, string> Feedback
        {
            get { return this._feedback; }
            set { this._feedback = value; }
        }

        // Check to see if Feedback property is set
        internal bool IsSetFeedback()
        {
            return this._feedback != null && this._feedback.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Min=38, Max=38)]
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
        /// Gets and sets the property Insights. 
        /// <para>
        /// A detailed analysis of the problem using machine learning.
        /// </para>
        /// </summary>
        public string Insights
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
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group affected by the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityLevel. 
        /// <para>
        /// A measure of the level of impact of the problem.
        /// </para>
        /// </summary>
        public SeverityLevel SeverityLevel
        {
            get { return this._severityLevel; }
            set { this._severityLevel = value; }
        }

        // Check to see if SeverityLevel property is set
        internal bool IsSetSeverityLevel()
        {
            return this._severityLevel != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the problem started, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// The status of the problem.
        /// </para>
        /// </summary>
        public Status Status
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
        /// Gets and sets the property Title. 
        /// <para>
        /// The name of the problem.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}
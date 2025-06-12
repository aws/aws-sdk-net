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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes a problem that is detected by correlating observations.
    /// </summary>
    public partial class Problem
    {
        private string _accountId;
        private string _affectedResource;
        private DateTime? _endTime;
        private Dictionary<string, string> _feedback = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _id;
        private string _insights;
        private DateTime? _lastRecurrenceTime;
        private long? _recurringCount;
        private ResolutionMethod _resolutionMethod;
        private string _resourceGroupName;
        private SeverityLevel _severityLevel;
        private string _shortName;
        private DateTime? _startTime;
        private Status _status;
        private string _title;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the owner of the resource group affected by
        /// the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

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
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Feedback provided by the user about the problem.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._feedback != null && (this._feedback.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property LastRecurrenceTime. 
        /// <para>
        ///  The last time that the problem reoccurred after its last resolution. 
        /// </para>
        /// </summary>
        public DateTime? LastRecurrenceTime
        {
            get { return this._lastRecurrenceTime; }
            set { this._lastRecurrenceTime = value; }
        }

        // Check to see if LastRecurrenceTime property is set
        internal bool IsSetLastRecurrenceTime()
        {
            return this._lastRecurrenceTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecurringCount. 
        /// <para>
        ///  The number of times that the same problem reoccurred after the first time it was
        /// resolved. 
        /// </para>
        /// </summary>
        public long? RecurringCount
        {
            get { return this._recurringCount; }
            set { this._recurringCount = value; }
        }

        // Check to see if RecurringCount property is set
        internal bool IsSetRecurringCount()
        {
            return this._recurringCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResolutionMethod. 
        /// <para>
        /// Specifies how the problem was resolved. If the value is <c>AUTOMATIC</c>, the system
        /// resolved the problem. If the value is <c>MANUAL</c>, the user resolved the problem.
        /// If the value is <c>UNRESOLVED</c>, then the problem is not resolved.
        /// </para>
        /// </summary>
        public ResolutionMethod ResolutionMethod
        {
            get { return this._resolutionMethod; }
            set { this._resolutionMethod = value; }
        }

        // Check to see if ResolutionMethod property is set
        internal bool IsSetResolutionMethod()
        {
            return this._resolutionMethod != null;
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
        /// Gets and sets the property ShortName. 
        /// <para>
        ///  The short name of the problem associated with the SNS notification. 
        /// </para>
        /// </summary>
        public string ShortName
        {
            get { return this._shortName; }
            set { this._shortName = value; }
        }

        // Check to see if ShortName property is set
        internal bool IsSetShortName()
        {
            return this._shortName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the problem started, in epoch seconds.
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

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Specifies whether or not you can view the problem. Updates to ignored problems do
        /// not generate notifications.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Inspector assessment.
    /// 
    ///  
    /// <para>
    /// This data type is used as the response element in the <a>DescribeAssessment</a> action.
    /// </para>
    /// </summary>
    public partial class Assessment
    {
        private string _applicationArn;
        private string _assessmentArn;
        private string _assessmentName;
        private string _assessmentState;
        private bool? _dataCollected;
        private int? _durationInSeconds;
        private DateTime? _endTime;
        private string _failureMessage;
        private DateTime? _startTime;
        private List<Attribute> _userAttributesForFindings = new List<Attribute>();

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The ARN of the application that corresponds to this assessment.
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The ARN of the assessment.
        /// </para>
        /// </summary>
        public string AssessmentArn
        {
            get { return this._assessmentArn; }
            set { this._assessmentArn = value; }
        }

        // Check to see if AssessmentArn property is set
        internal bool IsSetAssessmentArn()
        {
            return this._assessmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentName. 
        /// <para>
        /// The name of the assessment.
        /// </para>
        /// </summary>
        public string AssessmentName
        {
            get { return this._assessmentName; }
            set { this._assessmentName = value; }
        }

        // Check to see if AssessmentName property is set
        internal bool IsSetAssessmentName()
        {
            return this._assessmentName != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentState. 
        /// <para>
        /// The state of the assessment. Values can be set to <i>Created</i>, <i>Collecting Data</i>,
        /// <i>Stopping</i>, and <i>Completed</i>.
        /// </para>
        /// </summary>
        public string AssessmentState
        {
            get { return this._assessmentState; }
            set { this._assessmentState = value; }
        }

        // Check to see if AssessmentState property is set
        internal bool IsSetAssessmentState()
        {
            return this._assessmentState != null;
        }

        /// <summary>
        /// Gets and sets the property DataCollected. 
        /// <para>
        /// Boolean value (true or false) specifying whether the data collection process is completed.
        /// </para>
        /// </summary>
        public bool DataCollected
        {
            get { return this._dataCollected.GetValueOrDefault(); }
            set { this._dataCollected = value; }
        }

        // Check to see if DataCollected property is set
        internal bool IsSetDataCollected()
        {
            return this._dataCollected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The assessment duration in seconds. The default value is 3600 seconds (one hour).
        /// The maximum value is 86400 seconds (one day).
        /// </para>
        /// </summary>
        public int DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The assessment end time.
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
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// This data type property is not currently used.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The assessment start time.
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
        /// Gets and sets the property UserAttributesForFindings. 
        /// <para>
        /// The user-defined attributes that are assigned to every generated finding.
        /// </para>
        /// </summary>
        public List<Attribute> UserAttributesForFindings
        {
            get { return this._userAttributesForFindings; }
            set { this._userAttributesForFindings = value; }
        }

        // Check to see if UserAttributesForFindings property is set
        internal bool IsSetUserAttributesForFindings()
        {
            return this._userAttributesForFindings != null && this._userAttributesForFindings.Count > 0; 
        }

    }
}
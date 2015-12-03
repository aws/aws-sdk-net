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
    /// This data type is used as the request parameter in the <a>ListAssessments</a> and
    /// <a>ListAttachedAssessments</a> actions.
    /// </summary>
    public partial class AssessmentsFilter
    {
        private List<string> _assessmentNamePatterns = new List<string>();
        private List<string> _assessmentStates = new List<string>();
        private bool? _dataCollected;
        private DurationRange _durationRange;
        private TimestampRange _endTimeRange;
        private TimestampRange _startTimeRange;

        /// <summary>
        /// Gets and sets the property AssessmentNamePatterns. 
        /// <para>
        /// For a record to match a filter, an explicit value or a string containing a wildcard
        /// specified for this data type property must match the value of the <b>assessmentName</b>
        /// property of the <a>Assessment</a> data type.
        /// </para>
        /// </summary>
        public List<string> AssessmentNamePatterns
        {
            get { return this._assessmentNamePatterns; }
            set { this._assessmentNamePatterns = value; }
        }

        // Check to see if AssessmentNamePatterns property is set
        internal bool IsSetAssessmentNamePatterns()
        {
            return this._assessmentNamePatterns != null && this._assessmentNamePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssessmentStates. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>assessmentState</b> property of the <a>Assessment</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<string> AssessmentStates
        {
            get { return this._assessmentStates; }
            set { this._assessmentStates = value; }
        }

        // Check to see if AssessmentStates property is set
        internal bool IsSetAssessmentStates()
        {
            return this._assessmentStates != null && this._assessmentStates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataCollected. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>dataCollected</b> property of the <a>Assessment</a>
        /// data type.
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
        /// Gets and sets the property DurationRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>durationInSeconds</b> property of the <a>Assessment</a> data type.
        /// </para>
        /// </summary>
        public DurationRange DurationRange
        {
            get { return this._durationRange; }
            set { this._durationRange = value; }
        }

        // Check to see if DurationRange property is set
        internal bool IsSetDurationRange()
        {
            return this._durationRange != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimeRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>endTime</b> property of the <a>Assessment</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange EndTimeRange
        {
            get { return this._endTimeRange; }
            set { this._endTimeRange = value; }
        }

        // Check to see if EndTimeRange property is set
        internal bool IsSetEndTimeRange()
        {
            return this._endTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>startTime</b> property of the <a>Assessment</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange StartTimeRange
        {
            get { return this._startTimeRange; }
            set { this._startTimeRange = value; }
        }

        // Check to see if StartTimeRange property is set
        internal bool IsSetStartTimeRange()
        {
            return this._startTimeRange != null;
        }

    }
}
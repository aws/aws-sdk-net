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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
    /// This data type is used as the request parameter in the <a>ListAssessmentRuns</a> action.
    /// </summary>
    public partial class AssessmentRunFilter
    {
        private TimestampRange _completionTimeRange;
        private DurationRange _durationRange;
        private string _namePattern;
        private List<string> _rulesPackageArns = new List<string>();
        private TimestampRange _startTimeRange;
        private TimestampRange _stateChangeTimeRange;
        private List<string> _states = new List<string>();

        /// <summary>
        /// Gets and sets the property CompletionTimeRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>completedAt</b> property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange CompletionTimeRange
        {
            get { return this._completionTimeRange; }
            set { this._completionTimeRange = value; }
        }

        // Check to see if CompletionTimeRange property is set
        internal bool IsSetCompletionTimeRange()
        {
            return this._completionTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property DurationRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>durationInSeconds</b> property of the <a>AssessmentRun</a> data type.
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
        /// Gets and sets the property NamePattern. 
        /// <para>
        /// For a record to match a filter, an explicit value or a string containing a wildcard
        /// specified for this data type property must match the value of the <b>assessmentRunName</b>
        /// property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public string NamePattern
        {
            get { return this._namePattern; }
            set { this._namePattern = value; }
        }

        // Check to see if NamePattern property is set
        internal bool IsSetNamePattern()
        {
            return this._namePattern != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be contained in the list of values of the <b>rulesPackages</b> property of the <a>AssessmentRun</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && this._rulesPackageArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>startTime</b> property of the <a>AssessmentRun</a> data type.
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

        /// <summary>
        /// Gets and sets the property StateChangeTimeRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// match the <b>stateChangedAt</b> property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange StateChangeTimeRange
        {
            get { return this._stateChangeTimeRange; }
            set { this._stateChangeTimeRange = value; }
        }

        // Check to see if StateChangeTimeRange property is set
        internal bool IsSetStateChangeTimeRange()
        {
            return this._stateChangeTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// For a record to match a filter, one of the values specified for this data type property
        /// must be the exact match of the value of the <b>assessmentRunState</b> property of
        /// the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public List<string> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && this._states.Count > 0; 
        }

    }
}
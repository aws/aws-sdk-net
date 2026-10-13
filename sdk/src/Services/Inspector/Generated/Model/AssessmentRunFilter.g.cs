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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Used as the request parameter in the <a>ListAssessmentRuns</a> action.
    /// </summary>
    public partial class AssessmentRunFilter
    {
        /// <summary>
        /// Gets and sets the property CompletionTimeRange. 
        /// <para>
        /// For a record to match a filter, the value that is specified for this data type property
        /// must inclusively match any value between the specified minimum and maximum values
        /// of the <b>completedAt</b> property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange CompletionTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTimeRange property is set.
        /// </summary>
        internal bool IsSetCompletionTimeRange() => this.CompletionTimeRange != null;

        /// <summary>
        /// Gets and sets the property DurationRange. 
        /// <para>
        /// For a record to match a filter, the value that is specified for this data type property
        /// must inclusively match any value between the specified minimum and maximum values
        /// of the <b>durationInSeconds</b> property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public DurationRange DurationRange { get; set; }

        /// <summary>
        /// Checks to see if the DurationRange property is set.
        /// </summary>
        internal bool IsSetDurationRange() => this.DurationRange != null;

        /// <summary>
        /// Gets and sets the property NamePattern. 
        /// <para>
        /// For a record to match a filter, an explicit value or a string containing a wildcard
        /// that is specified for this data type property must match the value of the <b>assessmentRunName</b>
        /// property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 140)]
        public string NamePattern { get; set; }

        /// <summary>
        /// Checks to see if the NamePattern property is set.
        /// </summary>
        internal bool IsSetNamePattern() => this.NamePattern != null;

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// For a record to match a filter, the value that is specified for this data type property
        /// must be contained in the list of values of the <b>rulesPackages</b> property of the
        /// <a>AssessmentRun</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RulesPackageArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RulesPackageArns property is set.
        /// </summary>
        internal bool IsSetRulesPackageArns() => this.RulesPackageArns != null && (this.RulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTimeRange. 
        /// <para>
        /// For a record to match a filter, the value that is specified for this data type property
        /// must inclusively match any value between the specified minimum and maximum values
        /// of the <b>startTime</b> property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange StartTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeRange property is set.
        /// </summary>
        internal bool IsSetStartTimeRange() => this.StartTimeRange != null;

        /// <summary>
        /// Gets and sets the property StateChangeTimeRange. 
        /// <para>
        /// For a record to match a filter, the value that is specified for this data type property
        /// must match the <b>stateChangedAt</b> property of the <a>AssessmentRun</a> data type.
        /// </para>
        /// </summary>
        public TimestampRange StateChangeTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeTimeRange property is set.
        /// </summary>
        internal bool IsSetStateChangeTimeRange() => this.StateChangeTimeRange != null;

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// For a record to match a filter, one of the values specified for this data type property
        /// must be the exact match of the value of the <b>assessmentRunState</b> property of
        /// the <a>AssessmentRun</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> States { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the States property is set.
        /// </summary>
        internal bool IsSetStates() => this.States != null && (this.States.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

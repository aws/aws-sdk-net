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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// A potential improvement that was found from analyzing the profiling data.
    /// </summary>
    public partial class Recommendation
    {
        /// <summary>
        /// Gets and sets the property AllMatchesCount. 
        /// <para>
        /// How many different places in the profile graph triggered a match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AllMatchesCount { get; set; }

        /// <summary>
        /// Checks to see if the AllMatchesCount property is set.
        /// </summary>
        internal bool IsSetAllMatchesCount() => this.AllMatchesCount.HasValue;

        /// <summary>
        /// Gets and sets the property AllMatchesSum. 
        /// <para>
        /// How much of the total sample count is potentially affected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? AllMatchesSum { get; set; }

        /// <summary>
        /// Checks to see if the AllMatchesSum property is set.
        /// </summary>
        internal bool IsSetAllMatchesSum() => this.AllMatchesSum.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of the profile that was used by this analysis. This is specified using the
        /// ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond past
        /// June 1, 2020 1:15:02 PM UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The pattern that analysis recognized in the profile to make this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Pattern Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the profile that was used by this analysis. This is specified using
        /// the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TopMatches. 
        /// <para>
        /// List of the matches with most impact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Match> TopMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<Match>() : null;

        /// <summary>
        /// Checks to see if the TopMatches property is set.
        /// </summary>
        internal bool IsSetTopMatches() => this.TopMatches != null && (this.TopMatches.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

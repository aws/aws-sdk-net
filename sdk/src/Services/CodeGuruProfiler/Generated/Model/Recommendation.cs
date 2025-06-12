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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
        private int? _allMatchesCount;
        private double? _allMatchesSum;
        private DateTime? _endTime;
        private Pattern _pattern;
        private DateTime? _startTime;
        private List<Match> _topMatches = AWSConfigs.InitializeCollections ? new List<Match>() : null;

        /// <summary>
        /// Gets and sets the property AllMatchesCount. 
        /// <para>
        /// How many different places in the profile graph triggered a match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? AllMatchesCount
        {
            get { return this._allMatchesCount; }
            set { this._allMatchesCount = value; }
        }

        // Check to see if AllMatchesCount property is set
        internal bool IsSetAllMatchesCount()
        {
            return this._allMatchesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllMatchesSum. 
        /// <para>
        /// How much of the total sample count is potentially affected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? AllMatchesSum
        {
            get { return this._allMatchesSum; }
            set { this._allMatchesSum = value; }
        }

        // Check to see if AllMatchesSum property is set
        internal bool IsSetAllMatchesSum()
        {
            return this._allMatchesSum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of the profile that was used by this analysis. This is specified using the
        /// ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond past
        /// June 1, 2020 1:15:02 PM UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The pattern that analysis recognized in the profile to make this recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Pattern Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the profile that was used by this analysis. This is specified using
        /// the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC.
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
        /// Gets and sets the property TopMatches. 
        /// <para>
        /// List of the matches with most impact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Match> TopMatches
        {
            get { return this._topMatches; }
            set { this._topMatches = value; }
        }

        // Check to see if TopMatches property is set
        internal bool IsSetTopMatches()
        {
            return this._topMatches != null && (this._topMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
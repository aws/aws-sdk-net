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
    /// Container for the parameters to the GetRecommendations operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Recommendation.html">
    /// <c>Recommendation</c> </a> objects that contain recommendations for a profiling group
    /// for a given time period. A list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Anomaly.html">
    /// <c>Anomaly</c> </a> objects that contains details about anomalies detected in the
    /// profiling group for the same time period is also returned.
    /// </summary>
    public partial class GetRecommendationsRequest : AmazonCodeGuruProfilerRequest
    {
        private DateTime? _endTime;
        private string _locale;
        private string _profilingGroupName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The start time of the profile to get analysis data about. You must specify <c>startTime</c>
        /// and <c>endTime</c>. This is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z
        /// represents 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
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
        /// Gets and sets the property Locale. 
        /// <para>
        ///  The language used to provide analysis. Specify using a string that is one of the
        /// following <c>BCP 47</c> language codes. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>de-DE</c> - German, Germany 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>en-GB</c> - English, United Kingdom 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>en-US</c> - English, United States 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>es-ES</c> - Spanish, Spain 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fr-FR</c> - French, France 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>it-IT</c> - Italian, Italy 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ja-JP</c> - Japanese, Japan 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ko-KR</c> - Korean, Republic of Korea 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pt-BR</c> - Portugese, Brazil 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh-CN</c> - Chinese, China 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh-TW</c> - Chinese, Taiwan 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        ///  The name of the profiling group to get analysis data about. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The end time of the profile to get analysis data about. You must specify <c>startTime</c>
        /// and <c>endTime</c>. This is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z
        /// represents 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
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

    }
}
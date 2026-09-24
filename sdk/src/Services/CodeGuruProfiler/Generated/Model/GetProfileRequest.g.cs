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
    /// Container for the parameters to the GetProfile operation. Gets the aggregated profile
    /// of a profiling group for a specified time range. Amazon CodeGuru Profiler collects
    /// posted agent profiles for a profiling group into aggregated profiles. <note> <para>
    /// Because aggregated profiles expire over time <c>GetProfile</c> is not idempotent.
    /// </para> </note> <para> Specify the time range for the requested aggregated profile
    /// using 1 or 2 of the following parameters: <c>startTime</c>, <c>endTime</c>, <c>period</c>.
    /// The maximum time range allowed is 7 days. If you specify all 3 parameters, an exception
    /// is thrown. If you specify only <c>period</c>, the latest aggregated profile is returned.
    /// </para> <para> Aggregated profiles are available with aggregation periods of 5 minutes,
    /// 1 hour, and 1 day, aligned to UTC. The aggregation period of an aggregated profile
    /// determines how long it is retained. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AggregatedProfileTime.html">
    /// <c>AggregatedProfileTime</c> </a>. The aggregated profile's aggregation period determines
    /// how long it is retained by CodeGuru Profiler. </para> <ul> <li> <para> If the aggregation
    /// period is 5 minutes, the aggregated profile is retained for 15 days. </para> </li>
    /// <li> <para> If the aggregation period is 1 hour, the aggregated profile is retained
    /// for 60 days. </para> </li> <li> <para> If the aggregation period is 1 day, the aggregated
    /// profile is retained for 3 years. </para> </li> </ul> <para> There are two use cases
    /// for calling <c>GetProfile</c>. </para> <ol> <li> <para> If you want to return an aggregated
    /// profile that already exists, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ListProfileTimes.html">
    /// <c>ListProfileTimes</c> </a> to view the time ranges of existing aggregated profiles.
    /// Use them in a <c>GetProfile</c> request to return a specific, existing aggregated
    /// profile. </para> </li> <li> <para> If you want to return an aggregated profile for
    /// a time range that doesn't align with an existing aggregated profile, then CodeGuru
    /// Profiler makes a best effort to combine existing aggregated profiles from the requested
    /// time range and return them as one aggregated profile. </para> <para> If aggregated
    /// profiles do not exist for the full time range requested, then aggregated profiles
    /// for a smaller time range are returned. For example, if the requested time range is
    /// from 00:00 to 00:20, and the existing aggregated profiles are from 00:15 and 00:25,
    /// then the aggregated profiles from 00:15 to 00:20 are returned. </para> </li> </ol>
    /// </summary>
    public partial class GetProfileRequest : AmazonCodeGuruProfilerRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        ///  The format of the returned profiling data. The format maps to the <c>Accept</c> and
        /// <c>Content-Type</c> headers of the HTTP request. You can specify one of the following:
        /// or the default . 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application/json</c> — standard JSON format 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/x-amzn-ion</c> — the Amazon Ion data format. For more information,
        /// see <a href="http://amzn.github.io/ion-docs/">Amazon Ion</a>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the requested profile. Specify using the ISO 8601 format. For example,
        /// 2020-06-01T13:15:02.001Z represents 1 millisecond past June 1, 2020 1:15:02 PM UTC.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If you specify <c>endTime</c>, then you must also specify <c>period</c> or <c>startTime</c>,
        /// but not both. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxDepth. 
        /// <para>
        ///  The maximum depth of the stacks in the code that is represented in the aggregated
        /// profile. For example, if CodeGuru Profiler finds a method <c>A</c>, which calls method
        /// <c>B</c>, which calls method <c>C</c>, which calls method <c>D</c>, then the depth
        /// is 4. If the <c>maxDepth</c> is set to 2, then the aggregated profile contains representations
        /// of methods <c>A</c> and <c>B</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaxDepth property is set.
        /// </summary>
        internal bool IsSetMaxDepth() => this.MaxDepth.HasValue;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        ///  Used with <c>startTime</c> or <c>endTime</c> to specify the time range for the returned
        /// aggregated profile. Specify using the ISO 8601 format. For example, <c>P1DT1H1M1S</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  To get the latest aggregated profile, specify only <c>period</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period != null;

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group to get.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the profile to get. Specify using the ISO 8601 format. For example,
        /// 2020-06-01T13:15:02.001Z represents 1 millisecond past June 1, 2020 1:15:02 PM UTC.
        /// </para>
        ///  
        /// <para>
        ///  If you specify <c>startTime</c>, then you must also specify <c>period</c> or <c>endTime</c>,
        /// but not both. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}

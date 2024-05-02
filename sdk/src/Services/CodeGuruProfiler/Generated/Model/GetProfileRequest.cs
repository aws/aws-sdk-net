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
    /// Container for the parameters to the GetProfile operation.
    /// Gets the aggregated profile of a profiling group for a specified time range. Amazon
    /// CodeGuru Profiler collects posted agent profiles for a profiling group into aggregated
    /// profiles. 
    /// 
    ///  <pre><c> &lt;note&gt; &lt;p&gt; Because aggregated profiles expire over time &lt;code&gt;GetProfile&lt;/code&gt;
    /// is not idempotent. &lt;/p&gt; &lt;/note&gt; &lt;p&gt; Specify the time range for the
    /// requested aggregated profile using 1 or 2 of the following parameters: &lt;code&gt;startTime&lt;/code&gt;,
    /// &lt;code&gt;endTime&lt;/code&gt;, &lt;code&gt;period&lt;/code&gt;. The maximum time
    /// range allowed is 7 days. If you specify all 3 parameters, an exception is thrown.
    /// If you specify only &lt;code&gt;period&lt;/code&gt;, the latest aggregated profile
    /// is returned. &lt;/p&gt; &lt;p&gt; Aggregated profiles are available with aggregation
    /// periods of 5 minutes, 1 hour, and 1 day, aligned to UTC. The aggregation period of
    /// an aggregated profile determines how long it is retained. For more information, see
    /// &lt;a href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AggregatedProfileTime.html&quot;&gt;
    /// &lt;code&gt;AggregatedProfileTime&lt;/code&gt; &lt;/a&gt;. The aggregated profile's
    /// aggregation period determines how long it is retained by CodeGuru Profiler. &lt;/p&gt;
    /// &lt;ul&gt; &lt;li&gt; &lt;p&gt; If the aggregation period is 5 minutes, the aggregated
    /// profile is retained for 15 days. &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; If the
    /// aggregation period is 1 hour, the aggregated profile is retained for 60 days. &lt;/p&gt;
    /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; If the aggregation period is 1 day, the aggregated
    /// profile is retained for 3 years. &lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;p&gt;There
    /// are two use cases for calling &lt;code&gt;GetProfile&lt;/code&gt;.&lt;/p&gt; &lt;ol&gt;
    /// &lt;li&gt; &lt;p&gt; If you want to return an aggregated profile that already exists,
    /// use &lt;a href=&quot;https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ListProfileTimes.html&quot;&gt;
    /// &lt;code&gt;ListProfileTimes&lt;/code&gt; &lt;/a&gt; to view the time ranges of existing
    /// aggregated profiles. Use them in a &lt;code&gt;GetProfile&lt;/code&gt; request to
    /// return a specific, existing aggregated profile. &lt;/p&gt; &lt;/li&gt; &lt;li&gt;
    /// &lt;p&gt; If you want to return an aggregated profile for a time range that doesn't
    /// align with an existing aggregated profile, then CodeGuru Profiler makes a best effort
    /// to combine existing aggregated profiles from the requested time range and return them
    /// as one aggregated profile. &lt;/p&gt; &lt;p&gt; If aggregated profiles do not exist
    /// for the full time range requested, then aggregated profiles for a smaller time range
    /// are returned. For example, if the requested time range is from 00:00 to 00:20, and
    /// the existing aggregated profiles are from 00:15 and 00:25, then the aggregated profiles
    /// from 00:15 to 00:20 are returned. &lt;/p&gt; &lt;/li&gt; &lt;/ol&gt; </c></pre>
    /// </summary>
    public partial class GetProfileRequest : AmazonCodeGuruProfilerRequest
    {
        private string _accept;
        private DateTime? _endTime;
        private int? _maxDepth;
        private string _period;
        private string _profilingGroupName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        ///  The format of the returned profiling data. The format maps to the <c>Accept</c> and
        /// <c>Content-Type</c> headers of the HTTP request. You can specify one of the following:
        /// or the default . 
        /// </para>
        ///  <pre><c> &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;application/json&lt;/code&gt;
        /// — standard JSON format &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;application/x-amzn-ion&lt;/code&gt;
        /// — the Amazon Ion data format. For more information, see &lt;a href=&quot;http://amzn.github.io/ion-docs/&quot;&gt;Amazon
        /// Ion&lt;/a&gt;. &lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; </c></pre>
        /// </summary>
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

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
        /// Gets and sets the property MaxDepth. 
        /// <para>
        ///  The maximum depth of the stacks in the code that is represented in the aggregated
        /// profile. For example, if CodeGuru Profiler finds a method <c>A</c>, which calls method
        /// <c>B</c>, which calls method <c>C</c>, which calls method <c>D</c>, then the depth
        /// is 4. If the <c>maxDepth</c> is set to 2, then the aggregated profile contains representations
        /// of methods <c>A</c> and <c>B</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MaxDepth
        {
            get { return this._maxDepth; }
            set { this._maxDepth = value; }
        }

        // Check to see if MaxDepth property is set
        internal bool IsSetMaxDepth()
        {
            return this._maxDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        ///  Used with <c>startTime</c> or <c>endTime</c> to specify the time range for the returned
        /// aggregated profile. Specify using the ISO 8601 format. For example, <c>P1DT1H1M1S</c>.
        /// 
        /// </para>
        ///  <pre><c> &lt;p&gt; To get the latest aggregated profile, specify only &lt;code&gt;period&lt;/code&gt;.
        /// &lt;/p&gt; </c></pre>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group to get.
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
        /// The start time of the profile to get. Specify using the ISO 8601 format. For example,
        /// 2020-06-01T13:15:02.001Z represents 1 millisecond past June 1, 2020 1:15:02 PM UTC.
        /// </para>
        ///  <pre><c> &lt;p&gt; If you specify &lt;code&gt;startTime&lt;/code&gt;, then you must
        /// also specify &lt;code&gt;period&lt;/code&gt; or &lt;code&gt;endTime&lt;/code&gt;,
        /// but not both. &lt;/p&gt; </c></pre>
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

    }
}
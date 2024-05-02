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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// In a <a>GetSampledRequests</a> request, the <c>StartTime</c> and <c>EndTime</c> objects
    /// specify the time range for which you want AWS WAF to return a sample of web requests.
    /// </para>
    ///  
    /// <para>
    /// You must specify the times in Coordinated Universal Time (UTC) format. UTC format
    /// includes the special designator, <c>Z</c>. For example, <c>"2016-09-27T14:50Z"</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// In a <a>GetSampledRequests</a> response, the <c>StartTime</c> and <c>EndTime</c> objects
    /// specify the time range for which AWS WAF actually returned a sample of web requests.
    /// AWS WAF gets the specified number of requests from among the first 5,000 requests
    /// that your AWS resource receives during the specified time period. If your resource
    /// receives more than 5,000 requests during that period, AWS WAF stops sampling after
    /// the 5,000th request. In that case, <c>EndTime</c> is the time that AWS WAF received
    /// the 5,000th request. 
    /// </para>
    /// </summary>
    public partial class TimeWindow
    {
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range from which you want <c>GetSampledRequests</c> to return
        /// a sample of the requests that your AWS resource received. You must specify the date
        /// and time in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, <c>Z</c>. For example, <c>"2016-09-27T14:50Z"</c>. You can specify any
        /// time range in the previous three hours.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The beginning of the time range from which you want <c>GetSampledRequests</c> to return
        /// a sample of the requests that your AWS resource received. You must specify the date
        /// and time in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, <c>Z</c>. For example, <c>"2016-09-27T14:50Z"</c>. You can specify any
        /// time range in the previous three hours.
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
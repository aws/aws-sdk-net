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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the GetChannelSchedule operation. Retrieves information
    /// about your channel's schedule.
    /// </summary>
    public partial class GetChannelScheduleRequest : AmazonMediaTailorRequest
    {
        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The single audience for GetChannelScheduleRequest.
        /// </para>
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// Checks to see if the Audience property is set.
        /// </summary>
        internal bool IsSetAudience() => this.Audience != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel associated with this Channel Schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property DurationMinutes. 
        /// <para>
        /// The duration in minutes of the channel schedule.
        /// </para>
        /// </summary>
        public string DurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DurationMinutes property is set.
        /// </summary>
        internal bool IsSetDurationMinutes() => this.DurationMinutes != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of channel schedules that you want MediaTailor to return in response
        /// to the current request. If there are more than <c>MaxResults</c> channel schedules,
        /// use the value of <c>NextToken</c> in the response to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// (Optional) If the playback configuration has more than <c>MaxResults</c> channel schedules,
        /// use <c>NextToken</c> to get the second and subsequent pages of results.
        /// </para>
        ///  
        /// <para>
        /// For the first <c>GetChannelScheduleRequest</c> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// For the second and subsequent requests, get the value of <c>NextToken</c> from the
        /// previous response and specify that value for <c>NextToken</c> in the request.
        /// </para>
        ///  
        /// <para>
        /// If the previous response didn't include a <c>NextToken</c> element, there are no more
        /// channel schedules to get.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

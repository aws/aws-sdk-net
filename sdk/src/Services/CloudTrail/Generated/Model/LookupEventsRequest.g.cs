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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the LookupEvents operation. Looks up <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-management-events">management
    /// events</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-insights-events">CloudTrail
    /// Insights events</a> that are captured by CloudTrail. You can look up events that occurred
    /// in a Region within the last 90 days. <note> <para> <c>LookupEvents</c> returns recent
    /// Insights events for trails that enable Insights. To view Insights events for an event
    /// data store, you can run queries on your Insights event data store, and you can also
    /// view the Lake dashboard for Insights. </para> </note> <para> Lookup supports the following
    /// attributes for management events: </para> <ul> <li> <para> Amazon Web Services access
    /// key </para> </li> <li> <para> Event ID </para> </li> <li> <para> Event name </para>
    /// </li> <li> <para> Event source </para> </li> <li> <para> Read only </para> </li> <li>
    /// <para> Resource name </para> </li> <li> <para> Resource type </para> </li> <li> <para>
    /// User name </para> </li> </ul> <para> Lookup supports the following attributes for
    /// Insights events: </para> <ul> <li> <para> Event ID </para> </li> <li> <para> Event
    /// name </para> </li> <li> <para> Event source </para> </li> </ul> <para> All attributes
    /// are optional. The default number of results returned is 50, with a maximum of 50 possible.
    /// The response includes a token that you can use to get the next page of results. </para>
    /// <important> <para> The rate of lookup requests is limited to two per second, per account,
    /// per Region. If this limit is exceeded, a throttling error occurs. </para> </important>
    /// </summary>
    public partial class LookupEventsRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Specifies that only events that occur before or at the specified time are returned.
        /// If the specified end time is before the specified start time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventCategory. 
        /// <para>
        /// Specifies the event category. If you do not specify an event category, events of the
        /// category are not returned in the response. For example, if you do not specify <c>insight</c>
        /// as the value of <c>EventCategory</c>, no Insights events are returned.
        /// </para>
        /// </summary>
        public EventCategory EventCategory { get; set; }

        /// <summary>
        /// Checks to see if the EventCategory property is set.
        /// </summary>
        internal bool IsSetEventCategory() => this.EventCategory != null;

        /// <summary>
        /// Gets and sets the property LookupAttributes. 
        /// <para>
        /// Contains a list of lookup attributes. Currently the list can contain only one item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LookupAttribute> LookupAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<LookupAttribute>() : null;

        /// <summary>
        /// Checks to see if the LookupAttributes property is set.
        /// </summary>
        internal bool IsSetLookupAttributes() => this.LookupAttributes != null && (this.LookupAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of events to return. Possible values are 1 through 50. The default is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next page of results after a previous API call. This token
        /// must be passed in with the same parameters that were specified in the original call.
        /// For example, if the original call specified an AttributeKey of 'Username' with a value
        /// of 'root', the call with NextToken should include those same parameters.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Specifies that only events that occur after or at the specified time are returned.
        /// If the specified start time is after the specified end time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}

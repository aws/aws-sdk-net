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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListEventsByWebACL operation. Retrieves a paginated
    /// list of event summaries for the specified web ACL. Use this operation to monitor and
    /// investigate potential threats to the resources that the web ACL protects. Results
    /// are paginated. Use the <c>NextMarker</c> value from the response to retrieve the next
    /// batch of results. Currently, this operation supports API Security Amazon Web Services
    /// Managed Rules. <para> You can filter the results by time window, event category, resource,
    /// and API pattern, and sort them by start time, end time, or confidence. </para> <para>
    /// To retrieve the events for all of the web ACLs in your account, use <a>ListEvents</a>.
    /// To retrieve the full details of a single event, use <a>GetEvent</a>. </para>
    /// </summary>
    public partial class ListEventsByWebACLRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property ApiPatternFilters. 
        /// <para>
        /// Filters that narrow the results to events that involve the specified API patterns.
        /// If you specify more than one API pattern filter, WAF returns the events that match
        /// any of the filters. You can specify up to 20 API pattern filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<ApiPatternFilter> ApiPatternFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ApiPatternFilter>() : null;

        /// <summary>
        /// Checks to see if the ApiPatternFilters property is set.
        /// </summary>
        internal bool IsSetApiPatternFilters() => this.ApiPatternFilters != null && (this.ApiPatternFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters that narrow the results by event category or by the Amazon Resource Name (ARN)
        /// of the protected resource. You can specify up to 8 filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public List<EventFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<EventFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Additional fields to return with each event summary. By default, the response includes
        /// only the default summary fields.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>TIMELINE</c> to return the timeline of each event in <c>ApiSecurityEventDetail$Timeline</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Include { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Include property is set.
        /// </summary>
        internal bool IsSetInclude() => this.Include != null && (this.Include.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of events that you want WAF to return for this request. Valid values
        /// are 1 to 20. If more events are available, WAF returns a <c>NextMarker</c> value in
        /// the response that you can use in a subsequent call to get the next batch of events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <c>Limit</c> setting, if the number of objects
        /// that are still available for retrieval exceeds the limit, WAF returns a <c>NextMarker</c>
        /// value in the response. To retrieve the next batch of objects, provide the marker from
        /// the prior call in your next request.
        /// </para>
        ///  
        /// <para>
        /// The marker is valid only for a request with the same <c>WebAclArn</c>, <c>TimeWindow</c>,
        /// <c>Filters</c>, <c>SortBy</c>, and <c>SortOrder</c> settings as the request that returned
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextMarker { get; set; }

        /// <summary>
        /// Checks to see if the NextMarker property is set.
        /// </summary>
        internal bool IsSetNextMarker() => this.NextMarker != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field that WAF sorts the events by. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONFIDENCE</c> - Sort by the confidence level of the event detection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>END_TIME</c> - Sort by the time that the event ended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>START_TIME</c> - Sort by the time that the event started.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EventSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which WAF sorts the events. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASC</c> - Sort in ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESC</c> - Sort in descending order. This is the default.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The time range for the events to return. If you don't specify a time window, WAF returns
        /// events from the past year. The time window can't be longer than one year.
        /// </para>
        /// </summary>
        public TimeWindow TimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the TimeWindow property is set.
        /// </summary>
        internal bool IsSetTimeWindow() => this.TimeWindow != null;

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL whose events you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;
    }
}

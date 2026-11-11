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
    /// Container for the parameters to the PutInsightSelectors operation. Lets you enable
    /// Insights event logging on specific event categories by specifying the Insights selectors
    /// that you want to enable on an existing trail or event data store. You also use <c>PutInsightSelectors</c>
    /// to turn off Insights event logging, by passing an empty list of Insights types. The
    /// valid Insights event types are <c>ApiErrorRateInsight</c> and <c>ApiCallRateInsight</c>,
    /// and valid EventCategories are <c>Management</c> and <c>Data</c>. <note> <para> Insights
    /// on data events are not supported on event data stores. For event data stores, you
    /// can only enable Insights on management events. </para> </note> <para> To enable Insights
    /// on an event data store, you must specify the ARNs (or ID suffix of the ARNs) for the
    /// source event data store (<c>EventDataStore</c>) and the destination event data store
    /// (<c>InsightsDestination</c>). The source event data store logs management events and
    /// enables Insights. The destination event data store logs Insights events based upon
    /// the management event activity of the source event data store. The source and destination
    /// event data stores must belong to the same Amazon Web Services account. </para> <para>
    /// To log Insights events for a trail, you must specify the name (<c>TrailName</c>) of
    /// the CloudTrail trail for which you want to change or add Insights selectors. </para>
    /// <ul> <li> <para> For Management events Insights: To log CloudTrail Insights on the
    /// API call rate, the trail or event data store must log <c>write</c> management events.
    /// To log CloudTrail Insights on the API error rate, the trail or event data store must
    /// log <c>read</c> or <c>write</c> management events. </para> </li> <li> <para> For Data
    /// events Insights: To log CloudTrail Insights on the API call rate or API error rate,
    /// the trail must log <c>read</c> or <c>write</c> data events. Data events Insights are
    /// not supported on event data store. </para> </li> </ul> <para> To log CloudTrail Insights
    /// events on API call volume, the trail or event data store must log <c>write</c> management
    /// events. To log CloudTrail Insights events on API error rate, the trail or event data
    /// store must log <c>read</c> or <c>write</c> management events. You can call <c>GetEventSelectors</c>
    /// on a trail to check whether the trail logs management events. You can call <c>GetEventDataStore</c>
    /// on an event data store to check whether the event data store logs management events.
    /// </para> <para> For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
    /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>. </para>
    /// </summary>
    public partial class PutInsightSelectorsRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or ID suffix of the ARN) of the source event data store for which you want
        /// to change or add Insights selectors. To enable Insights on an event data store, you
        /// must provide both the <c>EventDataStore</c> and <c>InsightsDestination</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// You cannot use this parameter with the <c>TrailName</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string EventDataStore { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStore property is set.
        /// </summary>
        internal bool IsSetEventDataStore() => this.EventDataStore != null;

        /// <summary>
        /// Gets and sets the property InsightSelectors. 
        /// <para>
        /// Contains the Insights types you want to log on a specific category of events on a
        /// trail or event data store. <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>
        /// are valid Insight types.The EventCategory field can specify <c>Management</c> or <c>Data</c>
        /// events or both. For event data store, you can log Insights for management events only.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApiCallRateInsight</c> Insights type analyzes write-only management API calls
        /// or read and write data API calls that are aggregated per minute against a baseline
        /// API call volume.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApiErrorRateInsight</c> Insights type analyzes management and data API calls
        /// that result in error codes. The error is shown if the API call is unsuccessful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InsightSelector> InsightSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightSelector>() : null;

        /// <summary>
        /// Checks to see if the InsightSelectors property is set.
        /// </summary>
        internal bool IsSetInsightSelectors() => this.InsightSelectors != null && (this.InsightSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InsightsDestination. 
        /// <para>
        ///  The ARN (or ID suffix of the ARN) of the destination event data store that logs Insights
        /// events. To enable Insights on an event data store, you must provide both the <c>EventDataStore</c>
        /// and <c>InsightsDestination</c> parameters. 
        /// </para>
        ///  
        /// <para>
        /// You cannot use this parameter with the <c>TrailName</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string InsightsDestination { get; set; }

        /// <summary>
        /// Checks to see if the InsightsDestination property is set.
        /// </summary>
        internal bool IsSetInsightsDestination() => this.InsightsDestination != null;

        /// <summary>
        /// Gets and sets the property TrailName. 
        /// <para>
        /// The name of the CloudTrail trail for which you want to change or add Insights selectors.
        /// </para>
        ///  
        /// <para>
        /// You cannot use this parameter with the <c>EventDataStore</c> and <c>InsightsDestination</c>
        /// parameters.
        /// </para>
        /// </summary>
        public string TrailName { get; set; }

        /// <summary>
        /// Checks to see if the TrailName property is set.
        /// </summary>
        internal bool IsSetTrailName() => this.TrailName != null;
    }
}

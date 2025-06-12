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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
    /// Container for the parameters to the PutInsightSelectors operation.
    /// Lets you enable Insights event logging by specifying the Insights selectors that you
    /// want to enable on an existing trail or event data store. You also use <c>PutInsightSelectors</c>
    /// to turn off Insights event logging, by passing an empty list of Insights types. The
    /// valid Insights event types are <c>ApiErrorRateInsight</c> and <c>ApiCallRateInsight</c>.
    /// 
    ///  
    /// <para>
    /// To enable Insights on an event data store, you must specify the ARNs (or ID suffix
    /// of the ARNs) for the source event data store (<c>EventDataStore</c>) and the destination
    /// event data store (<c>InsightsDestination</c>). The source event data store logs management
    /// events and enables Insights. The destination event data store logs Insights events
    /// based upon the management event activity of the source event data store. The source
    /// and destination event data stores must belong to the same Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// To log Insights events for a trail, you must specify the name (<c>TrailName</c>) of
    /// the CloudTrail trail for which you want to change or add Insights selectors.
    /// </para>
    ///  
    /// <para>
    /// To log CloudTrail Insights events on API call volume, the trail or event data store
    /// must log <c>write</c> management events. To log CloudTrail Insights events on API
    /// error rate, the trail or event data store must log <c>read</c> or <c>write</c> management
    /// events. You can call <c>GetEventSelectors</c> on a trail to check whether the trail
    /// logs management events. You can call <c>GetEventDataStore</c> on an event data store
    /// to check whether the event data store logs management events.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
    /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutInsightSelectorsRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;
        private string _insightsDestination;
        private List<InsightSelector> _insightSelectors = AWSConfigs.InitializeCollections ? new List<InsightSelector>() : null;
        private string _trailName;

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
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

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
        [AWSProperty(Min=3, Max=256)]
        public string InsightsDestination
        {
            get { return this._insightsDestination; }
            set { this._insightsDestination = value; }
        }

        // Check to see if InsightsDestination property is set
        internal bool IsSetInsightsDestination()
        {
            return this._insightsDestination != null;
        }

        /// <summary>
        /// Gets and sets the property InsightSelectors. 
        /// <para>
        /// A JSON string that contains the Insights types you want to log on a trail or event
        /// data store. <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c> are valid Insight
        /// types.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApiCallRateInsight</c> Insights type analyzes write-only management API calls
        /// that are aggregated per minute against a baseline API call volume.
        /// </para>
        ///  
        /// <para>
        /// The <c>ApiErrorRateInsight</c> Insights type analyzes management API calls that result
        /// in error codes. The error is shown if the API call is unsuccessful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InsightSelector> InsightSelectors
        {
            get { return this._insightSelectors; }
            set { this._insightSelectors = value; }
        }

        // Check to see if InsightSelectors property is set
        internal bool IsSetInsightSelectors()
        {
            return this._insightSelectors != null && (this._insightSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string TrailName
        {
            get { return this._trailName; }
            set { this._trailName = value; }
        }

        // Check to see if TrailName property is set
        internal bool IsSetTrailName()
        {
            return this._trailName != null;
        }

    }
}
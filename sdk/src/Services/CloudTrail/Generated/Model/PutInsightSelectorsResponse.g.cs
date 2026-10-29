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
    /// This is the response object from the PutInsightSelectors operation.
    /// </summary>
    public partial class PutInsightSelectorsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source event data store for which you want to
        /// change or add Insights selectors.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string EventDataStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStoreArn property is set.
        /// </summary>
        internal bool IsSetEventDataStoreArn() => this.EventDataStoreArn != null;

        /// <summary>
        /// Gets and sets the property InsightSelectors. 
        /// <para>
        /// Contains the Insights types you want to log on a specific category of events in a
        /// trail or event data store. <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>
        /// are valid Insight types.The EventCategory field can specify <c>Management</c> or <c>Data</c>
        /// events or both. For event data store, you can only log Insights for management events
        /// only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightSelector> InsightSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightSelector>() : null;

        /// <summary>
        /// Checks to see if the InsightSelectors property is set.
        /// </summary>
        internal bool IsSetInsightSelectors() => this.InsightSelectors != null && (this.InsightSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InsightsDestination. 
        /// <para>
        ///  The ARN of the destination event data store that logs Insights events. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string InsightsDestination { get; set; }

        /// <summary>
        /// Checks to see if the InsightsDestination property is set.
        /// </summary>
        internal bool IsSetInsightsDestination() => this.InsightsDestination != null;

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a trail for which you want to change or add Insights
        /// selectors.
        /// </para>
        /// </summary>
        public string TrailARN { get; set; }

        /// <summary>
        /// Checks to see if the TrailARN property is set.
        /// </summary>
        internal bool IsSetTrailARN() => this.TrailARN != null;
    }
}

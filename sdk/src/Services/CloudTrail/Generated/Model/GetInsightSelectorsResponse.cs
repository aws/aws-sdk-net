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
    /// This is the response object from the GetInsightSelectors operation.
    /// </summary>
    public partial class GetInsightSelectorsResponse : AmazonWebServiceResponse
    {
        private string _eventDataStoreArn;
        private string _insightsDestination;
        private List<InsightSelector> _insightSelectors = AWSConfigs.InitializeCollections ? new List<InsightSelector>() : null;
        private string _trailARN;

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        ///  The ARN of the source event data store that enabled Insights events. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStoreArn
        {
            get { return this._eventDataStoreArn; }
            set { this._eventDataStoreArn = value; }
        }

        // Check to see if EventDataStoreArn property is set
        internal bool IsSetEventDataStoreArn()
        {
            return this._eventDataStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property InsightsDestination. 
        /// <para>
        ///  The ARN of the destination event data store that logs Insights events. 
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
        /// A JSON string that contains the Insight types you want to log on a trail or event
        /// data store. <c>ApiErrorRateInsight</c> and <c>ApiCallRateInsight</c> are supported
        /// as Insights types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a trail for which you want to get Insights selectors.
        /// </para>
        /// </summary>
        public string TrailARN
        {
            get { return this._trailARN; }
            set { this._trailARN = value; }
        }

        // Check to see if TrailARN property is set
        internal bool IsSetTrailARN()
        {
            return this._trailARN != null;
        }

    }
}
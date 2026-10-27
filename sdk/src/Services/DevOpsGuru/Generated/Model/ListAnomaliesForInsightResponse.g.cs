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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the ListAnomaliesForInsight operation.
    /// </summary>
    public partial class ListAnomaliesForInsightResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProactiveAnomalies. 
        /// <para>
        ///  An array of <c>ProactiveAnomalySummary</c> objects that represent the requested anomalies
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProactiveAnomalySummary> ProactiveAnomalies { get; set; } = AWSConfigs.InitializeCollections ? new List<ProactiveAnomalySummary>() : null;

        /// <summary>
        /// Checks to see if the ProactiveAnomalies property is set.
        /// </summary>
        internal bool IsSetProactiveAnomalies() => this.ProactiveAnomalies != null && (this.ProactiveAnomalies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReactiveAnomalies. 
        /// <para>
        ///  An array of <c>ReactiveAnomalySummary</c> objects that represent the requested anomalies
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReactiveAnomalySummary> ReactiveAnomalies { get; set; } = AWSConfigs.InitializeCollections ? new List<ReactiveAnomalySummary>() : null;

        /// <summary>
        /// Checks to see if the ReactiveAnomalies property is set.
        /// </summary>
        internal bool IsSetReactiveAnomalies() => this.ReactiveAnomalies != null && (this.ReactiveAnomalies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

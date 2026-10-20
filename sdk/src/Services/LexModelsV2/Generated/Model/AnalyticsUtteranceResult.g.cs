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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// An object containing the results for the utterance metrics you requested and the bin
    /// and/or group(s) they refer to, if applicable.
    /// </summary>
    public partial class AnalyticsUtteranceResult
    {
        /// <summary>
        /// Gets and sets the property AttributeResults. 
        /// <para>
        /// A list of objects containing information about the last used intent at the time of
        /// an utterance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalyticsUtteranceAttributeResult> AttributeResults { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalyticsUtteranceAttributeResult>() : null;

        /// <summary>
        /// Checks to see if the AttributeResults property is set.
        /// </summary>
        internal bool IsSetAttributeResults() => this.AttributeResults != null && (this.AttributeResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BinKeys. 
        /// <para>
        /// A list of objects containing the criteria you requested for binning results and the
        /// values of the bins.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AnalyticsBinKey> BinKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalyticsBinKey>() : null;

        /// <summary>
        /// Checks to see if the BinKeys property is set.
        /// </summary>
        internal bool IsSetBinKeys() => this.BinKeys != null && (this.BinKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupByKeys. 
        /// <para>
        /// A list of objects containing the criteria you requested for grouping results and the
        /// values of the bins.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalyticsUtteranceGroupByKey> GroupByKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalyticsUtteranceGroupByKey>() : null;

        /// <summary>
        /// Checks to see if the GroupByKeys property is set.
        /// </summary>
        internal bool IsSetGroupByKeys() => this.GroupByKeys != null && (this.GroupByKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricsResults. 
        /// <para>
        /// A list of objects, each of which contains a metric you want to list, the statistic
        /// for the metric you want to return, and the method by which to organize the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalyticsUtteranceMetricResult> MetricsResults { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalyticsUtteranceMetricResult>() : null;

        /// <summary>
        /// Checks to see if the MetricsResults property is set.
        /// </summary>
        internal bool IsSetMetricsResults() => this.MetricsResults != null && (this.MetricsResults.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

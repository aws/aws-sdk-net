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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the custom analysis rule configuration for an intermediate table.
    /// </summary>
    public partial class IntermediateTableAnalysisRuleCustom
    {
        /// <summary>
        /// Gets and sets the property AdditionalAnalyses. 
        /// <para>
        /// The setting that controls whether additional analyses are allowed on the intermediate
        /// table.
        /// </para>
        /// </summary>
        public AdditionalAnalyses AdditionalAnalyses { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalAnalyses property is set.
        /// </summary>
        internal bool IsSetAdditionalAnalyses() => this.AdditionalAnalyses != null;

        /// <summary>
        /// Gets and sets the property AggregationThresholds. 
        /// <para>
        /// The aggregation thresholds that each query output group must satisfy. Clean Rooms
        /// filters out any group that represents fewer than the specified number of distinct
        /// identities. You can specify at most one threshold. You can't use aggregation thresholds
        /// with differential privacy, or when <c>allowedAnalyses</c> allows only jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AggregationThreshold> AggregationThresholds { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregationThreshold>() : null;

        /// <summary>
        /// Checks to see if the AggregationThresholds property is set.
        /// </summary>
        internal bool IsSetAggregationThresholds() => this.AggregationThresholds != null && (this.AggregationThresholds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedAdditionalAnalyses. 
        /// <para>
        /// The list of allowed additional analyses for the intermediate table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<string> AllowedAdditionalAnalyses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedAdditionalAnalyses property is set.
        /// </summary>
        internal bool IsSetAllowedAdditionalAnalyses() => this.AllowedAdditionalAnalyses != null && (this.AllowedAdditionalAnalyses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedAnalyses. 
        /// <para>
        /// The list of allowed analyses that can be performed on the intermediate table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedAnalyses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedAnalyses property is set.
        /// </summary>
        internal bool IsSetAllowedAnalyses() => this.AllowedAnalyses != null && (this.AllowedAnalyses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedAnalysisProviders. 
        /// <para>
        /// The list of Amazon Web Services account IDs for the allowed analysis providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedAnalysisProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedAnalysisProviders property is set.
        /// </summary>
        internal bool IsSetAllowedAnalysisProviders() => this.AllowedAnalysisProviders != null && (this.AllowedAnalysisProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedResultReceivers. 
        /// <para>
        /// The list of Amazon Web Services account IDs that are allowed to receive results from
        /// queries run on the intermediate table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedResultReceivers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedResultReceivers property is set.
        /// </summary>
        internal bool IsSetAllowedResultReceivers() => this.AllowedResultReceivers != null && (this.AllowedResultReceivers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComparisonControls. 
        /// <para>
        /// The controls that restrict how a query can compare the columns in the intermediate
        /// table. You can't use comparison controls with differential privacy, or when <c>allowedAnalyses</c>
        /// allows only jobs.
        /// </para>
        /// </summary>
        public ComparisonControls ComparisonControls { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonControls property is set.
        /// </summary>
        internal bool IsSetComparisonControls() => this.ComparisonControls != null;

        /// <summary>
        /// Gets and sets the property DifferentialPrivacy.
        /// </summary>
        public DifferentialPrivacyConfiguration DifferentialPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the DifferentialPrivacy property is set.
        /// </summary>
        internal bool IsSetDifferentialPrivacy() => this.DifferentialPrivacy != null;

        /// <summary>
        /// Gets and sets the property DisallowedOutputColumns. 
        /// <para>
        /// The list of columns that are not allowed in the query output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DisallowedOutputColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DisallowedOutputColumns property is set.
        /// </summary>
        internal bool IsSetDisallowedOutputColumns() => this.DisallowedOutputColumns != null && (this.DisallowedOutputColumns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

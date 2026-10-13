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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the result of the evaluation of a data quality analyzer.
    /// </summary>
    public partial class DataQualityAnalyzerResult
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvaluatedDistributions. 
        /// <para>
        /// A map of distribution metrics associated with the evaluation of the analyzer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, DistributionData> EvaluatedDistributions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DistributionData>() : null;

        /// <summary>
        /// Checks to see if the EvaluatedDistributions property is set.
        /// </summary>
        internal bool IsSetEvaluatedDistributions() => this.EvaluatedDistributions != null && (this.EvaluatedDistributions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluatedMetrics. 
        /// <para>
        /// A map of metrics associated with the evaluation of the analyzer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, double> EvaluatedMetrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Checks to see if the EvaluatedMetrics property is set.
        /// </summary>
        internal bool IsSetEvaluatedMetrics() => this.EvaluatedMetrics != null && (this.EvaluatedMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluationMessage. 
        /// <para>
        /// An evaluation message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string EvaluationMessage { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMessage property is set.
        /// </summary>
        internal bool IsSetEvaluationMessage() => this.EvaluationMessage != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data quality analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}

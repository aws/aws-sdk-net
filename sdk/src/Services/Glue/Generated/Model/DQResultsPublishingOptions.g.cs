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
    /// Options to configure how your data quality evaluation results are published.
    /// </summary>
    public partial class DQResultsPublishingOptions
    {
        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// Enable metrics for your data quality results.
        /// </para>
        /// </summary>
        public bool? CloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetCloudWatchMetricsEnabled() => this.CloudWatchMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The context of the evaluation.
        /// </para>
        /// </summary>
        public string EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property ResultsPublishingEnabled. 
        /// <para>
        /// Enable publishing for your data quality results.
        /// </para>
        /// </summary>
        public bool? ResultsPublishingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ResultsPublishingEnabled property is set.
        /// </summary>
        internal bool IsSetResultsPublishingEnabled() => this.ResultsPublishingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ResultsS3Prefix. 
        /// <para>
        /// The Amazon S3 prefix prepended to the results.
        /// </para>
        /// </summary>
        public string ResultsS3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the ResultsS3Prefix property is set.
        /// </summary>
        internal bool IsSetResultsS3Prefix() => this.ResultsS3Prefix != null;
    }
}

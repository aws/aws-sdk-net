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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Options to configure how your data quality evaluation results are published.
    /// </summary>
    public partial class DQResultsPublishingOptions
    {
        private bool? _cloudWatchMetricsEnabled;
        private string _evaluationContext;
        private bool? _resultsPublishingEnabled;
        private string _resultsS3Prefix;

        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// Enable metrics for your data quality results.
        /// </para>
        /// </summary>
        public bool CloudWatchMetricsEnabled
        {
            get { return this._cloudWatchMetricsEnabled.GetValueOrDefault(); }
            set { this._cloudWatchMetricsEnabled = value; }
        }

        // Check to see if CloudWatchMetricsEnabled property is set
        internal bool IsSetCloudWatchMetricsEnabled()
        {
            return this._cloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The context of the evaluation.
        /// </para>
        /// </summary>
        public string EvaluationContext
        {
            get { return this._evaluationContext; }
            set { this._evaluationContext = value; }
        }

        // Check to see if EvaluationContext property is set
        internal bool IsSetEvaluationContext()
        {
            return this._evaluationContext != null;
        }

        /// <summary>
        /// Gets and sets the property ResultsPublishingEnabled. 
        /// <para>
        /// Enable publishing for your data quality results.
        /// </para>
        /// </summary>
        public bool ResultsPublishingEnabled
        {
            get { return this._resultsPublishingEnabled.GetValueOrDefault(); }
            set { this._resultsPublishingEnabled = value; }
        }

        // Check to see if ResultsPublishingEnabled property is set
        internal bool IsSetResultsPublishingEnabled()
        {
            return this._resultsPublishingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultsS3Prefix. 
        /// <para>
        /// The Amazon S3 prefix prepended to the results.
        /// </para>
        /// </summary>
        public string ResultsS3Prefix
        {
            get { return this._resultsS3Prefix; }
            set { this._resultsS3Prefix = value; }
        }

        // Check to see if ResultsS3Prefix property is set
        internal bool IsSetResultsS3Prefix()
        {
            return this._resultsS3Prefix != null;
        }

    }
}
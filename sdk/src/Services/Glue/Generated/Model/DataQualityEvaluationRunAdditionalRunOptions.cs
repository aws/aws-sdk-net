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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Additional run options you can specify for an evaluation run.
    /// </summary>
    public partial class DataQualityEvaluationRunAdditionalRunOptions
    {
        private bool? _cloudWatchMetricsEnabled;
        private DQCompositeRuleEvaluationMethod _compositeRuleEvaluationMethod;
        private string _resultsS3Prefix;

        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// Whether or not to enable CloudWatch metrics.
        /// </para>
        /// </summary>
        public bool? CloudWatchMetricsEnabled
        {
            get { return this._cloudWatchMetricsEnabled; }
            set { this._cloudWatchMetricsEnabled = value; }
        }

        // Check to see if CloudWatchMetricsEnabled property is set
        internal bool IsSetCloudWatchMetricsEnabled()
        {
            return this._cloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompositeRuleEvaluationMethod. 
        /// <para>
        /// Set the evaluation method for composite rules in the ruleset to ROW/COLUMN
        /// </para>
        /// </summary>
        public DQCompositeRuleEvaluationMethod CompositeRuleEvaluationMethod
        {
            get { return this._compositeRuleEvaluationMethod; }
            set { this._compositeRuleEvaluationMethod = value; }
        }

        // Check to see if CompositeRuleEvaluationMethod property is set
        internal bool IsSetCompositeRuleEvaluationMethod()
        {
            return this._compositeRuleEvaluationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ResultsS3Prefix. 
        /// <para>
        /// Prefix for Amazon S3 to store results.
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
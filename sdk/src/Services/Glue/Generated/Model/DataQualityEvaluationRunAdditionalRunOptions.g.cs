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
    /// Additional run options you can specify for an evaluation run.
    /// </summary>
    public partial class DataQualityEvaluationRunAdditionalRunOptions
    {
        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// Whether or not to enable CloudWatch metrics.
        /// </para>
        /// </summary>
        public bool? CloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetCloudWatchMetricsEnabled() => this.CloudWatchMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CompositeRuleEvaluationMethod. 
        /// <para>
        /// Set the evaluation method for composite rules in the ruleset to ROW/COLUMN
        /// </para>
        /// </summary>
        public DQCompositeRuleEvaluationMethod CompositeRuleEvaluationMethod { get; set; }

        /// <summary>
        /// Checks to see if the CompositeRuleEvaluationMethod property is set.
        /// </summary>
        internal bool IsSetCompositeRuleEvaluationMethod() => this.CompositeRuleEvaluationMethod != null;

        /// <summary>
        /// Gets and sets the property CustomLogGroupPrefix. 
        /// <para>
        /// A custom prefix for the CloudWatch log group names. When specified, evaluation run
        /// logs are written to <c>&lt;CustomLogGroupPrefix&gt;/error</c> and <c>&lt;CustomLogGroupPrefix&gt;/output</c>
        /// instead of the default <c>/aws-glue/data-quality/error</c> and <c>/aws-glue/data-quality/output</c>
        /// log groups.
        /// </para>
        /// </summary>
        public string CustomLogGroupPrefix { get; set; }

        /// <summary>
        /// Checks to see if the CustomLogGroupPrefix property is set.
        /// </summary>
        internal bool IsSetCustomLogGroupPrefix() => this.CustomLogGroupPrefix != null;

        /// <summary>
        /// Gets and sets the property DataQualityRuleResults. 
        /// <para>
        /// The configuration for writing rule results to a Glue Data Catalog table.
        /// </para>
        /// </summary>
        public DataQualityRuleResultsOptions DataQualityRuleResults { get; set; }

        /// <summary>
        /// Checks to see if the DataQualityRuleResults property is set.
        /// </summary>
        internal bool IsSetDataQualityRuleResults() => this.DataQualityRuleResults != null;

        /// <summary>
        /// Gets and sets the property ObservationMode. 
        /// <para>
        /// The observation mode for the evaluation run. Specifies how anomaly detection bounds
        /// are calculated.
        /// </para>
        /// </summary>
        public ObservationMode ObservationMode { get; set; }

        /// <summary>
        /// Checks to see if the ObservationMode property is set.
        /// </summary>
        internal bool IsSetObservationMode() => this.ObservationMode != null;

        /// <summary>
        /// Gets and sets the property ObservationResults. 
        /// <para>
        /// The configuration for writing observation results to a Glue Data Catalog table.
        /// </para>
        /// </summary>
        public ObservationResultsOptions ObservationResults { get; set; }

        /// <summary>
        /// Checks to see if the ObservationResults property is set.
        /// </summary>
        internal bool IsSetObservationResults() => this.ObservationResults != null;

        /// <summary>
        /// Gets and sets the property ObservationScope. 
        /// <para>
        /// The scope of the observation for the evaluation run. Specifies whether anomaly detection
        /// is enabled or disabled.
        /// </para>
        /// </summary>
        public ObservationConfiguration ObservationScope { get; set; }

        /// <summary>
        /// Checks to see if the ObservationScope property is set.
        /// </summary>
        internal bool IsSetObservationScope() => this.ObservationScope != null;

        /// <summary>
        /// Gets and sets the property ProfilingResults. 
        /// <para>
        /// The configuration for writing profiling results to a Glue Data Catalog table.
        /// </para>
        /// </summary>
        public ProfilingResultsOptions ProfilingResults { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingResults property is set.
        /// </summary>
        internal bool IsSetProfilingResults() => this.ProfilingResults != null;

        /// <summary>
        /// Gets and sets the property ResultsS3Prefix. 
        /// <para>
        /// Prefix for Amazon S3 to store results.
        /// </para>
        /// </summary>
        public string ResultsS3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the ResultsS3Prefix property is set.
        /// </summary>
        internal bool IsSetResultsS3Prefix() => this.ResultsS3Prefix != null;

        /// <summary>
        /// Gets and sets the property RowLevelResults. 
        /// <para>
        /// The configuration for writing row-level evaluation results to a Glue Data Catalog
        /// table.
        /// </para>
        /// </summary>
        public RowLevelResultsOptions RowLevelResults { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelResults property is set.
        /// </summary>
        internal bool IsSetRowLevelResults() => this.RowLevelResults != null;
    }
}

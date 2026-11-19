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
    /// Container for the parameters to the UpdateDataQualityEvaluationConfig operation. Updates
    /// a data quality evaluation configuration. Fields that you don't specify keep their
    /// current values.
    /// </summary>
    public partial class UpdateDataQualityEvaluationConfigRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalDataSources. 
        /// <para>
        /// A map of reference strings to additional data sources you can specify for an evaluation
        /// run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DataSource> AdditionalDataSources { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DataSource>() : null;

        /// <summary>
        /// Checks to see if the AdditionalDataSources property is set.
        /// </summary>
        internal bool IsSetAdditionalDataSources() => this.AdditionalDataSources != null && (this.AdditionalDataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalRunOptions. 
        /// <para>
        /// Additional run options you can specify for an evaluation run.
        /// </para>
        /// </summary>
        public DataQualityEvaluationConfigAdditionalRunOptions AdditionalRunOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalRunOptions property is set.
        /// </summary>
        internal bool IsSetAdditionalRunOptions() => this.AdditionalRunOptions != null;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The database or table that the configuration applies to. Replaces the current data
        /// source.
        /// </para>
        /// </summary>
        public DataQualityEvaluationConfigDataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property EndAt. 
        /// <para>
        /// The time at which the schedule stops running, exclusive.
        /// </para>
        /// </summary>
        public DateTime? EndAt { get; set; }

        /// <summary>
        /// Checks to see if the EndAt property is set.
        /// </summary>
        internal bool IsSetEndAt() => this.EndAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedRulesetName. 
        /// <para>
        /// A built-in ruleset, <c>SIMPLE</c> or <c>ADVANCED</c>, that profiles each table.
        /// </para>
        /// </summary>
        public DataQualityEvaluationConfigManagedRuleset ManagedRulesetName { get; set; }

        /// <summary>
        /// Checks to see if the ManagedRulesetName property is set.
        /// </summary>
        internal bool IsSetManagedRulesetName() => this.ManagedRulesetName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data quality evaluation configuration to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of <c>G.1X</c> workers to be used in the run. The default is 5.
        /// </para>
        /// </summary>
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property PauseRuns. 
        /// <para>
        /// Specifies whether to pause the configuration. While paused, the configuration evaluates
        /// nothing, including tables added to the catalog or database.
        /// </para>
        /// </summary>
        public bool? PauseRuns { get; set; }

        /// <summary>
        /// Checks to see if the PauseRuns property is set.
        /// </summary>
        internal bool IsSetPauseRuns() => this.PauseRuns.HasValue;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that evaluations assume. You can specify the role name or the role Amazon
        /// Resource Name (ARN). The role needs the trust policy and permissions described for
        /// <c>CreateDataQualityEvaluationConfig</c>.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property RulesetName. 
        /// <para>
        /// The name of a Data Quality Definition Language (DQDL) ruleset, containing analyzers,
        /// rules, or both, to evaluate tables with. You create the ruleset using the <c>CreateDataQualityRuleset</c>
        /// API. Specify either <c>RulesetName</c> or <c>ManagedRulesetName</c>, not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RulesetName { get; set; }

        /// <summary>
        /// Checks to see if the RulesetName property is set.
        /// </summary>
        internal bool IsSetRulesetName() => this.RulesetName != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron or rate expression, in UTC, for the <c>SCHEDULE</c> trigger, for example <c>cron(0
        /// 6 * * ? *)</c>. The schedule can run at most once an hour.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The time from which the schedule runs, inclusive.
        /// </para>
        /// </summary>
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Checks to see if the StartAt property is set.
        /// </summary>
        internal bool IsSetStartAt() => this.StartAt.HasValue;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout for a run in minutes. This is the maximum time that a run can consume
        /// resources before it is terminated and enters <c>TIMEOUT</c> status. The default is
        /// 2,880 minutes (48 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// When the configuration evaluates tables. Replaces the current triggers. Choose from
        /// the following triggers:
        /// </para>
        ///  <dl> <dt>ONCE</dt> <dd> 
        /// <para>
        /// Evaluates each table one time, including when tables are added to a database or catalog.
        /// </para>
        ///  </dd> <dt>SCHEDULE</dt> <dd> 
        /// <para>
        /// Evaluates each table on the cron or rate expression in <c>ScheduleExpression</c>,
        /// between the optional <c>StartAt</c> and <c>EndAt</c> times.
        /// </para>
        ///  </dd> <dt>METADATA_CHANGE</dt> <dd> 
        /// <para>
        /// Evaluates a table whenever its Glue Data Catalog metadata changes, such as a schema
        /// change or an Apache Iceberg commit.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> Triggers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Triggers property is set.
        /// </summary>
        internal bool IsSetTriggers() => this.Triggers != null && (this.Triggers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

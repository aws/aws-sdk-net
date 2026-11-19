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
    /// Container for the parameters to the CreateDataQualityEvaluationConfig operation. Creates
    /// a data quality evaluation configuration, which evaluates the data quality of a collection
    /// of tables in the Glue Data Catalog once, on a schedule, or when table metadata changes.
    /// A configuration applies to a catalog, a database, or a single table, and evaluates
    /// every table in scope, including tables added later, without per-table setup. <para>
    /// When configurations at more than one level apply to the same table, the most specific
    /// configuration applies. Each table is evaluated at most once an hour, whichever triggers
    /// you choose. </para>
    /// </summary>
    public partial class CreateDataQualityEvaluationConfigRequest : AmazonGlueRequest
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the operation completes
        /// no more than one time. If this token matches a previous request, the service ignores
        /// the request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The catalog, database, or table that the configuration applies to, as specified by
        /// <c>Level</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property Level. 
        /// <para>
        /// The Glue Data Catalog hierarchical level that the configuration applies to. Valid
        /// values are <c>CATALOG</c>, <c>DATABASE</c>, and <c>TABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataQualityEvaluationConfigLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property ManagedRulesetName. 
        /// <para>
        /// A built-in ruleset that profiles each table, used when <c>RulesetName</c> is not set.
        /// The default is <c>SIMPLE</c>. Choose from the following built-in rulesets:
        /// </para>
        ///  <dl> <dt>SIMPLE</dt> <dd> 
        /// <para>
        /// Row count and column count, completeness, minimum, and maximum for every column, mean,
        /// sum, and standard deviation for numeric columns, and column length for string columns.
        /// </para>
        ///  </dd> <dt>ADVANCED</dt> <dd> 
        /// <para>
        /// Every statistic in <c>SIMPLE</c>, plus distribution, uniqueness, and distinct values
        /// count.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public DataQualityEvaluationConfigManagedRuleset ManagedRulesetName { get; set; }

        /// <summary>
        /// Checks to see if the ManagedRulesetName property is set.
        /// </summary>
        internal bool IsSetManagedRulesetName() => this.ManagedRulesetName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the data quality evaluation configuration. The name must be unique within
        /// your account.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that evaluations assume. You can specify the role name or the role Amazon
        /// Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// The role must allow the <c>glue.amazonaws.com</c> service principal to assume it,
        /// and needs permissions to read the catalog (<c>glue:GetCatalog</c>, <c>glue:GetDatabase</c>,
        /// <c>glue:GetTable</c>, <c>glue:SearchTables</c>, and <c>glue:GetPartitions</c>), read
        /// and create rulesets (<c>glue:GetDataQualityRuleset</c> and <c>glue:CreateDataQualityRuleset</c>),
        /// start evaluations (<c>glue:StartDataQualityRulesetEvaluationRun</c>, <c>glue:PublishDataQuality</c>,
        /// and <c>iam:PassRole</c> on the role itself), read the tables' data in Amazon S3, and
        /// write logs to Amazon CloudWatch Logs. If a catalog-level or database-level configuration
        /// applies to an Amazon S3 Tables catalog, the role also needs <c>s3tables:ListTableBuckets</c>
        /// and <c>s3tables:ListTables</c>. If you use Lake Formation, the role needs the <c>DESCRIBE</c>
        /// permission on the tables.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags applied to the data quality evaluation configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// When the configuration evaluates tables. You can choose one or more triggers, and
        /// each table is evaluated at most once an hour. The default is <c>ONCE</c>. Choose from
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

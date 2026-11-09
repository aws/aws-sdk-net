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
    /// Describes a data quality evaluation configuration.
    /// </summary>
    public partial class DataQualityEvaluationConfigListDetails
    {
        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The time when the configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedOn property is set.
        /// </summary>
        internal bool IsSetCreatedOn() => this.CreatedOn.HasValue;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The catalog, database, or table that the configuration applies to.
        /// </para>
        /// </summary>
        public DataQualityEvaluationConfigListDataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property EvaluationRunMode. 
        /// <para>
        /// The evaluation run mode of the configuration's results, which is <c>EVALUATION_CONFIG</c>.
        /// </para>
        /// </summary>
        public DataQualityEvaluationRunMode EvaluationRunMode { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationRunMode property is set.
        /// </summary>
        internal bool IsSetEvaluationRunMode() => this.EvaluationRunMode != null;

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The time when the configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedOn property is set.
        /// </summary>
        internal bool IsSetLastModifiedOn() => this.LastModifiedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The Glue Data Catalog hierarchical level that the configuration applies to.
        /// </para>
        /// </summary>
        public DataQualityEvaluationConfigLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property ManagedRulesetName. 
        /// <para>
        /// The built-in ruleset that tables are evaluated with.
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
        /// The name of the data quality evaluation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PauseRuns. 
        /// <para>
        /// Specifies whether evaluations are paused.
        /// </para>
        /// </summary>
        public bool? PauseRuns { get; set; }

        /// <summary>
        /// Checks to see if the PauseRuns property is set.
        /// </summary>
        internal bool IsSetPauseRuns() => this.PauseRuns.HasValue;

        /// <summary>
        /// Gets and sets the property RulesetName. 
        /// <para>
        /// The name of the data quality ruleset that tables are evaluated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RulesetName { get; set; }

        /// <summary>
        /// Checks to see if the RulesetName property is set.
        /// </summary>
        internal bool IsSetRulesetName() => this.RulesetName != null;
    }
}

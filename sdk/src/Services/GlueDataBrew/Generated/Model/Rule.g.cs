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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents a single data quality requirement that should be validated in the scope
    /// of this dataset.
    /// </summary>
    public partial class Rule
    {
        /// <summary>
        /// Gets and sets the property CheckExpression. 
        /// <para>
        /// The expression which includes column references, condition names followed by variable
        /// references, possibly grouped and combined with other conditions. For example, <c>(:col1
        /// starts_with :prefix1 or :col1 starts_with :prefix2) and (:col1 ends_with :suffix1
        /// or :col1 ends_with :suffix2)</c>. Column and value references are substitution variables
        /// that should start with the ':' symbol. Depending on the context, substitution variables'
        /// values can be either an actual value or a column name. These values are defined in
        /// the SubstitutionMap. If a CheckExpression starts with a column reference, then ColumnSelectors
        /// in the rule should be null. If ColumnSelectors has been defined, then there should
        /// be no column reference in the left side of a condition, for example, <c>is_between
        /// :val1 and :val2</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/databrew/latest/dg/profile.data-quality-available-checks.html">Available
        /// checks</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 1024)]
        public string CheckExpression { get; set; }

        /// <summary>
        /// Checks to see if the CheckExpression property is set.
        /// </summary>
        internal bool IsSetCheckExpression() => this.CheckExpression != null;

        /// <summary>
        /// Gets and sets the property ColumnSelectors. 
        /// <para>
        /// List of column selectors. Selectors can be used to select columns using a name or
        /// regular expression from the dataset. Rule will be applied to selected columns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ColumnSelector> ColumnSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnSelector>() : null;

        /// <summary>
        /// Checks to see if the ColumnSelectors property is set.
        /// </summary>
        internal bool IsSetColumnSelectors() => this.ColumnSelectors != null && (this.ColumnSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// A value that specifies whether the rule is disabled. Once a rule is disabled, a profile
        /// job will not validate it during a job run. Default value is false.
        /// </para>
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Checks to see if the Disabled property is set.
        /// </summary>
        internal bool IsSetDisabled() => this.Disabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SubstitutionMap. 
        /// <para>
        /// The map of substitution variable names to their values used in a check expression.
        /// Variable names should start with a ':' (colon). Variable values can either be actual
        /// values or column names. To differentiate between the two, column names should be enclosed
        /// in backticks, for example, <c>":col1": "`Column A`".</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SubstitutionMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SubstitutionMap property is set.
        /// </summary>
        internal bool IsSetSubstitutionMap() => this.SubstitutionMap != null && (this.SubstitutionMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshold used with a non-aggregate check expression. Non-aggregate check expressions
        /// will be applied to each row in a specific column, and the threshold will be used to
        /// determine whether the validation succeeds.
        /// </para>
        /// </summary>
        public Threshold Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold != null;
    }
}

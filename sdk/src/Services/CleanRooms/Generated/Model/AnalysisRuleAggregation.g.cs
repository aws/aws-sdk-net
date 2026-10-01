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
    /// A type of analysis rule that enables query structure and specified queries that produce
    /// aggregate statistics.
    /// </summary>
    public partial class AnalysisRuleAggregation
    {
        /// <summary>
        /// Gets and sets the property AdditionalAnalyses. 
        /// <para>
        ///  An indicator as to whether additional analyses (such as Clean Rooms ML) can be applied
        /// to the output of the direct query. 
        /// </para>
        ///  
        /// <para>
        /// The <c>additionalAnalyses</c> parameter is currently supported for the list analysis
        /// rule (<c>AnalysisRuleList</c>) and the custom analysis rule (<c>AnalysisRuleCustom</c>).
        /// </para>
        /// </summary>
        public AdditionalAnalyses AdditionalAnalyses { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalAnalyses property is set.
        /// </summary>
        internal bool IsSetAdditionalAnalyses() => this.AdditionalAnalyses != null;

        /// <summary>
        /// Gets and sets the property AggregateColumns. 
        /// <para>
        /// The columns that query runners are allowed to use in aggregation queries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<AggregateColumn> AggregateColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregateColumn>() : null;

        /// <summary>
        /// Checks to see if the AggregateColumns property is set.
        /// </summary>
        internal bool IsSetAggregateColumns() => this.AggregateColumns != null && (this.AggregateColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedJoinOperators. 
        /// <para>
        /// Which logical operators (if any) are to be used in an INNER JOIN match condition.
        /// Default is <c>AND</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2)]
        public List<string> AllowedJoinOperators { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedJoinOperators property is set.
        /// </summary>
        internal bool IsSetAllowedJoinOperators() => this.AllowedJoinOperators != null && (this.AllowedJoinOperators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DimensionColumns. 
        /// <para>
        /// The columns that query runners are allowed to select, group by, or filter by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> DimensionColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DimensionColumns property is set.
        /// </summary>
        internal bool IsSetDimensionColumns() => this.DimensionColumns != null && (this.DimensionColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        /// Columns in configured table that can be used in join statements and/or as aggregate
        /// columns. They can never be outputted directly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> JoinColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the JoinColumns property is set.
        /// </summary>
        internal bool IsSetJoinColumns() => this.JoinColumns != null && (this.JoinColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JoinRequired. 
        /// <para>
        /// Control that requires member who runs query to do a join with their configured table
        /// and/or other configured table in query.
        /// </para>
        /// </summary>
        public JoinRequiredOption JoinRequired { get; set; }

        /// <summary>
        /// Checks to see if the JoinRequired property is set.
        /// </summary>
        internal bool IsSetJoinRequired() => this.JoinRequired != null;

        /// <summary>
        /// Gets and sets the property OutputConstraints. 
        /// <para>
        /// Columns that must meet a specific threshold value (after an aggregation function is
        /// applied to it) for each output row to be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<AggregationConstraint> OutputConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregationConstraint>() : null;

        /// <summary>
        /// Checks to see if the OutputConstraints property is set.
        /// </summary>
        internal bool IsSetOutputConstraints() => this.OutputConstraints != null && (this.OutputConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScalarFunctions. 
        /// <para>
        /// Set of scalar functions that are allowed to be used on dimension columns and the output
        /// of aggregation of metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ScalarFunctions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ScalarFunctions property is set.
        /// </summary>
        internal bool IsSetScalarFunctions() => this.ScalarFunctions != null && (this.ScalarFunctions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

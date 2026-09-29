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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Represents a column in a dataset.
    /// </summary>
    public partial class TopicColumn
    {
        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The type of aggregation that is performed on the column data when it's queried.
        /// </para>
        /// </summary>
        public DefaultAggregation Aggregation { get; set; }

        /// <summary>
        /// Checks to see if the Aggregation property is set.
        /// </summary>
        internal bool IsSetAggregation() => this.Aggregation != null;

        /// <summary>
        /// Gets and sets the property AllowedAggregations. 
        /// <para>
        /// The list of aggregation types that are allowed for the column. Valid values for this
        /// structure are <c>COUNT</c>, <c>DISTINCT_COUNT</c>, <c>MIN</c>, <c>MAX</c>, <c>MEDIAN</c>,
        /// <c>SUM</c>, <c>AVERAGE</c>, <c>STDEV</c>, <c>STDEVP</c>, <c>VAR</c>, <c>VARP</c>,
        /// and <c>PERCENTILE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedAggregations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedAggregations property is set.
        /// </summary>
        internal bool IsSetAllowedAggregations() => this.AllowedAggregations != null && (this.AllowedAggregations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CellValueSynonyms. 
        /// <para>
        /// The other names or aliases for the column cell value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CellValueSynonym> CellValueSynonyms { get; set; } = AWSConfigs.InitializeCollections ? new List<CellValueSynonym>() : null;

        /// <summary>
        /// Checks to see if the CellValueSynonyms property is set.
        /// </summary>
        internal bool IsSetCellValueSynonyms() => this.CellValueSynonyms != null && (this.CellValueSynonyms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ColumnDataRole. 
        /// <para>
        /// The role of the column in the data. Valid values are <c>DIMENSION</c> and <c>MEASURE</c>.
        /// </para>
        /// </summary>
        public ColumnDataRole ColumnDataRole { get; set; }

        /// <summary>
        /// Checks to see if the ColumnDataRole property is set.
        /// </summary>
        internal bool IsSetColumnDataRole() => this.ColumnDataRole != null;

        /// <summary>
        /// Gets and sets the property ColumnDescription. 
        /// <para>
        /// A description of the column and its contents.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string ColumnDescription { get; set; }

        /// <summary>
        /// Checks to see if the ColumnDescription property is set.
        /// </summary>
        internal bool IsSetColumnDescription() => this.ColumnDescription != null;

        /// <summary>
        /// Gets and sets the property ColumnFriendlyName. 
        /// <para>
        /// A user-friendly name for the column.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string ColumnFriendlyName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnFriendlyName property is set.
        /// </summary>
        internal bool IsSetColumnFriendlyName() => this.ColumnFriendlyName != null;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property ColumnSynonyms. 
        /// <para>
        /// The other names or aliases for the column.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnSynonyms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ColumnSynonyms property is set.
        /// </summary>
        internal bool IsSetColumnSynonyms() => this.ColumnSynonyms != null && (this.ColumnSynonyms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComparativeOrder. 
        /// <para>
        /// The order in which data is displayed for the column when it's used in a comparative
        /// context.
        /// </para>
        /// </summary>
        public ComparativeOrder ComparativeOrder { get; set; }

        /// <summary>
        /// Checks to see if the ComparativeOrder property is set.
        /// </summary>
        internal bool IsSetComparativeOrder() => this.ComparativeOrder != null;

        /// <summary>
        /// Gets and sets the property DefaultFormatting. 
        /// <para>
        /// The default formatting used for values in the column.
        /// </para>
        /// </summary>
        public DefaultFormatting DefaultFormatting { get; set; }

        /// <summary>
        /// Checks to see if the DefaultFormatting property is set.
        /// </summary>
        internal bool IsSetDefaultFormatting() => this.DefaultFormatting != null;

        /// <summary>
        /// Gets and sets the property DisableIndexing. 
        /// <para>
        /// A Boolean value that indicates whether the column shows in the autocomplete functionality.
        /// </para>
        /// </summary>
        public bool? DisableIndexing { get; set; }

        /// <summary>
        /// Checks to see if the DisableIndexing property is set.
        /// </summary>
        internal bool IsSetDisableIndexing() => this.DisableIndexing.HasValue;

        /// <summary>
        /// Gets and sets the property IsIncludedInTopic. 
        /// <para>
        /// A Boolean value that indicates whether the column is included in the query results.
        /// </para>
        /// </summary>
        public bool? IsIncludedInTopic { get; set; }

        /// <summary>
        /// Checks to see if the IsIncludedInTopic property is set.
        /// </summary>
        internal bool IsSetIsIncludedInTopic() => this.IsIncludedInTopic.HasValue;

        /// <summary>
        /// Gets and sets the property NeverAggregateInFilter. 
        /// <para>
        /// A Boolean value that indicates whether to aggregate the column data when it's used
        /// in a filter context.
        /// </para>
        /// </summary>
        public bool? NeverAggregateInFilter { get; set; }

        /// <summary>
        /// Checks to see if the NeverAggregateInFilter property is set.
        /// </summary>
        internal bool IsSetNeverAggregateInFilter() => this.NeverAggregateInFilter.HasValue;

        /// <summary>
        /// Gets and sets the property NonAdditive. 
        /// <para>
        /// The non additive value for the column.
        /// </para>
        /// </summary>
        public bool? NonAdditive { get; set; }

        /// <summary>
        /// Checks to see if the NonAdditive property is set.
        /// </summary>
        internal bool IsSetNonAdditive() => this.NonAdditive.HasValue;

        /// <summary>
        /// Gets and sets the property NotAllowedAggregations. 
        /// <para>
        /// The list of aggregation types that are not allowed for the column. Valid values for
        /// this structure are <c>COUNT</c>, <c>DISTINCT_COUNT</c>, <c>MIN</c>, <c>MAX</c>, <c>MEDIAN</c>,
        /// <c>SUM</c>, <c>AVERAGE</c>, <c>STDEV</c>, <c>STDEVP</c>, <c>VAR</c>, <c>VARP</c>,
        /// and <c>PERCENTILE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotAllowedAggregations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotAllowedAggregations property is set.
        /// </summary>
        internal bool IsSetNotAllowedAggregations() => this.NotAllowedAggregations != null && (this.NotAllowedAggregations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SemanticType. 
        /// <para>
        /// The semantic type of data contained in the column.
        /// </para>
        /// </summary>
        public SemanticType SemanticType { get; set; }

        /// <summary>
        /// Checks to see if the SemanticType property is set.
        /// </summary>
        internal bool IsSetSemanticType() => this.SemanticType != null;

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        public TopicTimeGranularity TimeGranularity { get; set; }

        /// <summary>
        /// Checks to see if the TimeGranularity property is set.
        /// </summary>
        internal bool IsSetTimeGranularity() => this.TimeGranularity != null;
    }
}

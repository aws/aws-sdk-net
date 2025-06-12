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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private DefaultAggregation _aggregation;
        private List<string> _allowedAggregations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<CellValueSynonym> _cellValueSynonyms = AWSConfigs.InitializeCollections ? new List<CellValueSynonym>() : null;
        private ColumnDataRole _columnDataRole;
        private string _columnDescription;
        private string _columnFriendlyName;
        private string _columnName;
        private List<string> _columnSynonyms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ComparativeOrder _comparativeOrder;
        private DefaultFormatting _defaultFormatting;
        private bool? _disableIndexing;
        private bool? _isIncludedInTopic;
        private bool? _neverAggregateInFilter;
        private bool? _nonAdditive;
        private List<string> _notAllowedAggregations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SemanticType _semanticType;
        private TopicTimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The type of aggregation that is performed on the column data when it's queried.
        /// </para>
        /// </summary>
        public DefaultAggregation Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedAggregations. 
        /// <para>
        /// The list of aggregation types that are allowed for the column. Valid values for this
        /// structure are <c>COUNT</c>, <c>DISTINCT_COUNT</c>, <c>MIN</c>, <c>MAX</c>, <c>MEDIAN</c>,
        /// <c>SUM</c>, <c>AVERAGE</c>, <c>STDEV</c>, <c>STDEVP</c>, <c>VAR</c>, <c>VARP</c>,
        /// and <c>PERCENTILE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedAggregations
        {
            get { return this._allowedAggregations; }
            set { this._allowedAggregations = value; }
        }

        // Check to see if AllowedAggregations property is set
        internal bool IsSetAllowedAggregations()
        {
            return this._allowedAggregations != null && (this._allowedAggregations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CellValueSynonyms. 
        /// <para>
        /// The other names or aliases for the column cell value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CellValueSynonym> CellValueSynonyms
        {
            get { return this._cellValueSynonyms; }
            set { this._cellValueSynonyms = value; }
        }

        // Check to see if CellValueSynonyms property is set
        internal bool IsSetCellValueSynonyms()
        {
            return this._cellValueSynonyms != null && (this._cellValueSynonyms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ColumnDataRole. 
        /// <para>
        /// The role of the column in the data. Valid values are <c>DIMENSION</c> and <c>MEASURE</c>.
        /// </para>
        /// </summary>
        public ColumnDataRole ColumnDataRole
        {
            get { return this._columnDataRole; }
            set { this._columnDataRole = value; }
        }

        // Check to see if ColumnDataRole property is set
        internal bool IsSetColumnDataRole()
        {
            return this._columnDataRole != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnDescription. 
        /// <para>
        /// A description of the column and its contents.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ColumnDescription
        {
            get { return this._columnDescription; }
            set { this._columnDescription = value; }
        }

        // Check to see if ColumnDescription property is set
        internal bool IsSetColumnDescription()
        {
            return this._columnDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnFriendlyName. 
        /// <para>
        /// A user-friendly name for the column.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ColumnFriendlyName
        {
            get { return this._columnFriendlyName; }
            set { this._columnFriendlyName = value; }
        }

        // Check to see if ColumnFriendlyName property is set
        internal bool IsSetColumnFriendlyName()
        {
            return this._columnFriendlyName != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnSynonyms. 
        /// <para>
        /// The other names or aliases for the column.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnSynonyms
        {
            get { return this._columnSynonyms; }
            set { this._columnSynonyms = value; }
        }

        // Check to see if ColumnSynonyms property is set
        internal bool IsSetColumnSynonyms()
        {
            return this._columnSynonyms != null && (this._columnSynonyms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComparativeOrder. 
        /// <para>
        /// The order in which data is displayed for the column when it's used in a comparative
        /// context.
        /// </para>
        /// </summary>
        public ComparativeOrder ComparativeOrder
        {
            get { return this._comparativeOrder; }
            set { this._comparativeOrder = value; }
        }

        // Check to see if ComparativeOrder property is set
        internal bool IsSetComparativeOrder()
        {
            return this._comparativeOrder != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultFormatting. 
        /// <para>
        /// The default formatting used for values in the column.
        /// </para>
        /// </summary>
        public DefaultFormatting DefaultFormatting
        {
            get { return this._defaultFormatting; }
            set { this._defaultFormatting = value; }
        }

        // Check to see if DefaultFormatting property is set
        internal bool IsSetDefaultFormatting()
        {
            return this._defaultFormatting != null;
        }

        /// <summary>
        /// Gets and sets the property DisableIndexing. 
        /// <para>
        /// A Boolean value that indicates whether the column shows in the autocomplete functionality.
        /// </para>
        /// </summary>
        public bool? DisableIndexing
        {
            get { return this._disableIndexing; }
            set { this._disableIndexing = value; }
        }

        // Check to see if DisableIndexing property is set
        internal bool IsSetDisableIndexing()
        {
            return this._disableIndexing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsIncludedInTopic. 
        /// <para>
        /// A Boolean value that indicates whether the column is included in the query results.
        /// </para>
        /// </summary>
        public bool? IsIncludedInTopic
        {
            get { return this._isIncludedInTopic; }
            set { this._isIncludedInTopic = value; }
        }

        // Check to see if IsIncludedInTopic property is set
        internal bool IsSetIsIncludedInTopic()
        {
            return this._isIncludedInTopic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NeverAggregateInFilter. 
        /// <para>
        /// A Boolean value that indicates whether to aggregate the column data when it's used
        /// in a filter context.
        /// </para>
        /// </summary>
        public bool? NeverAggregateInFilter
        {
            get { return this._neverAggregateInFilter; }
            set { this._neverAggregateInFilter = value; }
        }

        // Check to see if NeverAggregateInFilter property is set
        internal bool IsSetNeverAggregateInFilter()
        {
            return this._neverAggregateInFilter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonAdditive. 
        /// <para>
        /// The non additive value for the column.
        /// </para>
        /// </summary>
        public bool? NonAdditive
        {
            get { return this._nonAdditive; }
            set { this._nonAdditive = value; }
        }

        // Check to see if NonAdditive property is set
        internal bool IsSetNonAdditive()
        {
            return this._nonAdditive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotAllowedAggregations. 
        /// <para>
        /// The list of aggregation types that are not allowed for the column. Valid values for
        /// this structure are <c>COUNT</c>, <c>DISTINCT_COUNT</c>, <c>MIN</c>, <c>MAX</c>, <c>MEDIAN</c>,
        /// <c>SUM</c>, <c>AVERAGE</c>, <c>STDEV</c>, <c>STDEVP</c>, <c>VAR</c>, <c>VARP</c>,
        /// and <c>PERCENTILE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotAllowedAggregations
        {
            get { return this._notAllowedAggregations; }
            set { this._notAllowedAggregations = value; }
        }

        // Check to see if NotAllowedAggregations property is set
        internal bool IsSetNotAllowedAggregations()
        {
            return this._notAllowedAggregations != null && (this._notAllowedAggregations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SemanticType. 
        /// <para>
        /// The semantic type of data contained in the column.
        /// </para>
        /// </summary>
        public SemanticType SemanticType
        {
            get { return this._semanticType; }
            set { this._semanticType = value; }
        }

        // Check to see if SemanticType property is set
        internal bool IsSetSemanticType()
        {
            return this._semanticType != null;
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        public TopicTimeGranularity TimeGranularity
        {
            get { return this._timeGranularity; }
            set { this._timeGranularity = value; }
        }

        // Check to see if TimeGranularity property is set
        internal bool IsSetTimeGranularity()
        {
            return this._timeGranularity != null;
        }

    }
}
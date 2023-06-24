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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a calculated field.
    /// </summary>
    public partial class TopicCalculatedField
    {
        private DefaultAggregation _aggregation;
        private List<string> _allowedAggregations = new List<string>();
        private string _calculatedFieldDescription;
        private string _calculatedFieldName;
        private List<string> _calculatedFieldSynonyms = new List<string>();
        private List<CellValueSynonym> _cellValueSynonyms = new List<CellValueSynonym>();
        private ColumnDataRole _columnDataRole;
        private ComparativeOrder _comparativeOrder;
        private DefaultFormatting _defaultFormatting;
        private bool? _disableIndexing;
        private string _expression;
        private bool? _isIncludedInTopic;
        private bool? _neverAggregateInFilter;
        private List<string> _notAllowedAggregations = new List<string>();
        private SemanticType _semanticType;
        private TopicTimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The default aggregation. Valid values for this structure are <code>SUM</code>, <code>MAX</code>,
        /// <code>MIN</code>, <code>COUNT</code>, <code>DISTINCT_COUNT</code>, and <code>AVERAGE</code>.
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
        /// The list of aggregation types that are allowed for the calculated field. Valid values
        /// for this structure are <code>COUNT</code>, <code>DISTINCT_COUNT</code>, <code>MIN</code>,
        /// <code>MAX</code>, <code>MEDIAN</code>, <code>SUM</code>, <code>AVERAGE</code>, <code>STDEV</code>,
        /// <code>STDEVP</code>, <code>VAR</code>, <code>VARP</code>, and <code>PERCENTILE</code>.
        /// </para>
        /// </summary>
        public List<string> AllowedAggregations
        {
            get { return this._allowedAggregations; }
            set { this._allowedAggregations = value; }
        }

        // Check to see if AllowedAggregations property is set
        internal bool IsSetAllowedAggregations()
        {
            return this._allowedAggregations != null && this._allowedAggregations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CalculatedFieldDescription. 
        /// <para>
        /// The calculated field description.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string CalculatedFieldDescription
        {
            get { return this._calculatedFieldDescription; }
            set { this._calculatedFieldDescription = value; }
        }

        // Check to see if CalculatedFieldDescription property is set
        internal bool IsSetCalculatedFieldDescription()
        {
            return this._calculatedFieldDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CalculatedFieldName. 
        /// <para>
        /// The calculated field name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string CalculatedFieldName
        {
            get { return this._calculatedFieldName; }
            set { this._calculatedFieldName = value; }
        }

        // Check to see if CalculatedFieldName property is set
        internal bool IsSetCalculatedFieldName()
        {
            return this._calculatedFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property CalculatedFieldSynonyms. 
        /// <para>
        /// The other names or aliases for the calculated field.
        /// </para>
        /// </summary>
        public List<string> CalculatedFieldSynonyms
        {
            get { return this._calculatedFieldSynonyms; }
            set { this._calculatedFieldSynonyms = value; }
        }

        // Check to see if CalculatedFieldSynonyms property is set
        internal bool IsSetCalculatedFieldSynonyms()
        {
            return this._calculatedFieldSynonyms != null && this._calculatedFieldSynonyms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CellValueSynonyms. 
        /// <para>
        /// The other names or aliases for the calculated field cell value.
        /// </para>
        /// </summary>
        public List<CellValueSynonym> CellValueSynonyms
        {
            get { return this._cellValueSynonyms; }
            set { this._cellValueSynonyms = value; }
        }

        // Check to see if CellValueSynonyms property is set
        internal bool IsSetCellValueSynonyms()
        {
            return this._cellValueSynonyms != null && this._cellValueSynonyms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ColumnDataRole. 
        /// <para>
        /// The column data role for a calculated field. Valid values for this structure are <code>DIMENSION</code>
        /// and <code>MEASURE</code>.
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
        /// Gets and sets the property ComparativeOrder. 
        /// <para>
        /// The order in which data is displayed for the calculated field when it's used in a
        /// comparative context.
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
        /// The default formatting definition.
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
        /// A Boolean value that indicates if a calculated field is visible in the autocomplete.
        /// </para>
        /// </summary>
        public bool DisableIndexing
        {
            get { return this._disableIndexing.GetValueOrDefault(); }
            set { this._disableIndexing = value; }
        }

        // Check to see if DisableIndexing property is set
        internal bool IsSetDisableIndexing()
        {
            return this._disableIndexing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The calculated field expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property IsIncludedInTopic. 
        /// <para>
        /// A boolean value that indicates if a calculated field is included in the topic.
        /// </para>
        /// </summary>
        public bool IsIncludedInTopic
        {
            get { return this._isIncludedInTopic.GetValueOrDefault(); }
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
        /// A Boolean value that indicates whether to never aggregate calculated field in filters.
        /// </para>
        /// </summary>
        public bool NeverAggregateInFilter
        {
            get { return this._neverAggregateInFilter.GetValueOrDefault(); }
            set { this._neverAggregateInFilter = value; }
        }

        // Check to see if NeverAggregateInFilter property is set
        internal bool IsSetNeverAggregateInFilter()
        {
            return this._neverAggregateInFilter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotAllowedAggregations. 
        /// <para>
        /// The list of aggregation types that are not allowed for the calculated field. Valid
        /// values for this structure are <code>COUNT</code>, <code>DISTINCT_COUNT</code>, <code>MIN</code>,
        /// <code>MAX</code>, <code>MEDIAN</code>, <code>SUM</code>, <code>AVERAGE</code>, <code>STDEV</code>,
        /// <code>STDEVP</code>, <code>VAR</code>, <code>VARP</code>, and <code>PERCENTILE</code>.
        /// </para>
        /// </summary>
        public List<string> NotAllowedAggregations
        {
            get { return this._notAllowedAggregations; }
            set { this._notAllowedAggregations = value; }
        }

        // Check to see if NotAllowedAggregations property is set
        internal bool IsSetNotAllowedAggregations()
        {
            return this._notAllowedAggregations != null && this._notAllowedAggregations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SemanticType. 
        /// <para>
        /// The semantic type.
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
        /// The level of time precision that is used to aggregate <code>DateTime</code> values.
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
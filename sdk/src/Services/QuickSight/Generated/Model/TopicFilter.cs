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
    /// A structure that represents a filter used to select items for a topic.
    /// </summary>
    public partial class TopicFilter
    {
        private TopicCategoryFilter _categoryFilter;
        private TopicDateRangeFilter _dateRangeFilter;
        private FilterClass _filterClass;
        private string _filterDescription;
        private string _filterName;
        private List<string> _filterSynonyms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NamedFilterType _filterType;
        private TopicNullFilter _nullFilter;
        private TopicNumericEqualityFilter _numericEqualityFilter;
        private TopicNumericRangeFilter _numericRangeFilter;
        private string _operandFieldName;
        private TopicRelativeDateFilter _relativeDateFilter;

        /// <summary>
        /// Gets and sets the property CategoryFilter. 
        /// <para>
        /// The category filter that is associated with this filter.
        /// </para>
        /// </summary>
        public TopicCategoryFilter CategoryFilter
        {
            get { return this._categoryFilter; }
            set { this._categoryFilter = value; }
        }

        // Check to see if CategoryFilter property is set
        internal bool IsSetCategoryFilter()
        {
            return this._categoryFilter != null;
        }

        /// <summary>
        /// Gets and sets the property DateRangeFilter. 
        /// <para>
        /// The date range filter.
        /// </para>
        /// </summary>
        public TopicDateRangeFilter DateRangeFilter
        {
            get { return this._dateRangeFilter; }
            set { this._dateRangeFilter = value; }
        }

        // Check to see if DateRangeFilter property is set
        internal bool IsSetDateRangeFilter()
        {
            return this._dateRangeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property FilterClass. 
        /// <para>
        /// The class of the filter. Valid values for this structure are <c>ENFORCED_VALUE_FILTER</c>,
        /// <c>CONDITIONAL_VALUE_FILTER</c>, and <c>NAMED_VALUE_FILTER</c>.
        /// </para>
        /// </summary>
        public FilterClass FilterClass
        {
            get { return this._filterClass; }
            set { this._filterClass = value; }
        }

        // Check to see if FilterClass property is set
        internal bool IsSetFilterClass()
        {
            return this._filterClass != null;
        }

        /// <summary>
        /// Gets and sets the property FilterDescription. 
        /// <para>
        /// A description of the filter used to select items for a topic.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FilterDescription
        {
            get { return this._filterDescription; }
            set { this._filterDescription = value; }
        }

        // Check to see if FilterDescription property is set
        internal bool IsSetFilterDescription()
        {
            return this._filterDescription != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The name of the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterSynonyms. 
        /// <para>
        /// The other names or aliases for the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FilterSynonyms
        {
            get { return this._filterSynonyms; }
            set { this._filterSynonyms = value; }
        }

        // Check to see if FilterSynonyms property is set
        internal bool IsSetFilterSynonyms()
        {
            return this._filterSynonyms != null && (this._filterSynonyms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The type of the filter. Valid values for this structure are <c>CATEGORY_FILTER</c>,
        /// <c>NUMERIC_EQUALITY_FILTER</c>, <c>NUMERIC_RANGE_FILTER</c>, <c>DATE_RANGE_FILTER</c>,
        /// and <c>RELATIVE_DATE_FILTER</c>.
        /// </para>
        /// </summary>
        public NamedFilterType FilterType
        {
            get { return this._filterType; }
            set { this._filterType = value; }
        }

        // Check to see if FilterType property is set
        internal bool IsSetFilterType()
        {
            return this._filterType != null;
        }

        /// <summary>
        /// Gets and sets the property NullFilter. 
        /// <para>
        /// The null filter.
        /// </para>
        /// </summary>
        public TopicNullFilter NullFilter
        {
            get { return this._nullFilter; }
            set { this._nullFilter = value; }
        }

        // Check to see if NullFilter property is set
        internal bool IsSetNullFilter()
        {
            return this._nullFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NumericEqualityFilter. 
        /// <para>
        /// The numeric equality filter.
        /// </para>
        /// </summary>
        public TopicNumericEqualityFilter NumericEqualityFilter
        {
            get { return this._numericEqualityFilter; }
            set { this._numericEqualityFilter = value; }
        }

        // Check to see if NumericEqualityFilter property is set
        internal bool IsSetNumericEqualityFilter()
        {
            return this._numericEqualityFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NumericRangeFilter. 
        /// <para>
        /// The numeric range filter.
        /// </para>
        /// </summary>
        public TopicNumericRangeFilter NumericRangeFilter
        {
            get { return this._numericRangeFilter; }
            set { this._numericRangeFilter = value; }
        }

        // Check to see if NumericRangeFilter property is set
        internal bool IsSetNumericRangeFilter()
        {
            return this._numericRangeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property OperandFieldName. 
        /// <para>
        /// The name of the field that the filter operates on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string OperandFieldName
        {
            get { return this._operandFieldName; }
            set { this._operandFieldName = value; }
        }

        // Check to see if OperandFieldName property is set
        internal bool IsSetOperandFieldName()
        {
            return this._operandFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property RelativeDateFilter. 
        /// <para>
        /// The relative date filter.
        /// </para>
        /// </summary>
        public TopicRelativeDateFilter RelativeDateFilter
        {
            get { return this._relativeDateFilter; }
            set { this._relativeDateFilter = value; }
        }

        // Check to see if RelativeDateFilter property is set
        internal bool IsSetRelativeDateFilter()
        {
            return this._relativeDateFilter != null;
        }

    }
}
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
    /// A structure that represents a filter used to select items for a topic.
    /// </summary>
    public partial class TopicFilter
    {
        /// <summary>
        /// Gets and sets the property CategoryFilter. 
        /// <para>
        /// The category filter that is associated with this filter.
        /// </para>
        /// </summary>
        public TopicCategoryFilter CategoryFilter { get; set; }

        /// <summary>
        /// Checks to see if the CategoryFilter property is set.
        /// </summary>
        internal bool IsSetCategoryFilter() => this.CategoryFilter != null;

        /// <summary>
        /// Gets and sets the property DateRangeFilter. 
        /// <para>
        /// The date range filter.
        /// </para>
        /// </summary>
        public TopicDateRangeFilter DateRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the DateRangeFilter property is set.
        /// </summary>
        internal bool IsSetDateRangeFilter() => this.DateRangeFilter != null;

        /// <summary>
        /// Gets and sets the property FilterClass. 
        /// <para>
        /// The class of the filter. Valid values for this structure are <c>ENFORCED_VALUE_FILTER</c>,
        /// <c>CONDITIONAL_VALUE_FILTER</c>, and <c>NAMED_VALUE_FILTER</c>.
        /// </para>
        /// </summary>
        public FilterClass FilterClass { get; set; }

        /// <summary>
        /// Checks to see if the FilterClass property is set.
        /// </summary>
        internal bool IsSetFilterClass() => this.FilterClass != null;

        /// <summary>
        /// Gets and sets the property FilterDescription. 
        /// <para>
        /// A description of the filter used to select items for a topic.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string FilterDescription { get; set; }

        /// <summary>
        /// Checks to see if the FilterDescription property is set.
        /// </summary>
        internal bool IsSetFilterDescription() => this.FilterDescription != null;

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The name of the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FilterName { get; set; }

        /// <summary>
        /// Checks to see if the FilterName property is set.
        /// </summary>
        internal bool IsSetFilterName() => this.FilterName != null;

        /// <summary>
        /// Gets and sets the property FilterSynonyms. 
        /// <para>
        /// The other names or aliases for the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FilterSynonyms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterSynonyms property is set.
        /// </summary>
        internal bool IsSetFilterSynonyms() => this.FilterSynonyms != null && (this.FilterSynonyms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The type of the filter. Valid values for this structure are <c>CATEGORY_FILTER</c>,
        /// <c>NUMERIC_EQUALITY_FILTER</c>, <c>NUMERIC_RANGE_FILTER</c>, <c>DATE_RANGE_FILTER</c>,
        /// and <c>RELATIVE_DATE_FILTER</c>.
        /// </para>
        /// </summary>
        public NamedFilterType FilterType { get; set; }

        /// <summary>
        /// Checks to see if the FilterType property is set.
        /// </summary>
        internal bool IsSetFilterType() => this.FilterType != null;

        /// <summary>
        /// Gets and sets the property NullFilter. 
        /// <para>
        /// The null filter.
        /// </para>
        /// </summary>
        public TopicNullFilter NullFilter { get; set; }

        /// <summary>
        /// Checks to see if the NullFilter property is set.
        /// </summary>
        internal bool IsSetNullFilter() => this.NullFilter != null;

        /// <summary>
        /// Gets and sets the property NumericEqualityFilter. 
        /// <para>
        /// The numeric equality filter.
        /// </para>
        /// </summary>
        public TopicNumericEqualityFilter NumericEqualityFilter { get; set; }

        /// <summary>
        /// Checks to see if the NumericEqualityFilter property is set.
        /// </summary>
        internal bool IsSetNumericEqualityFilter() => this.NumericEqualityFilter != null;

        /// <summary>
        /// Gets and sets the property NumericRangeFilter. 
        /// <para>
        /// The numeric range filter.
        /// </para>
        /// </summary>
        public TopicNumericRangeFilter NumericRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the NumericRangeFilter property is set.
        /// </summary>
        internal bool IsSetNumericRangeFilter() => this.NumericRangeFilter != null;

        /// <summary>
        /// Gets and sets the property OperandFieldName. 
        /// <para>
        /// The name of the field that the filter operates on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string OperandFieldName { get; set; }

        /// <summary>
        /// Checks to see if the OperandFieldName property is set.
        /// </summary>
        internal bool IsSetOperandFieldName() => this.OperandFieldName != null;

        /// <summary>
        /// Gets and sets the property RelativeDateFilter. 
        /// <para>
        /// The relative date filter.
        /// </para>
        /// </summary>
        public TopicRelativeDateFilter RelativeDateFilter { get; set; }

        /// <summary>
        /// Checks to see if the RelativeDateFilter property is set.
        /// </summary>
        internal bool IsSetRelativeDateFilter() => this.RelativeDateFilter != null;
    }
}

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
    /// A <c>HierarchyFilter</c> filters data by drilling down through an ordered list of
    /// columns. Each level in the list narrows the data by one column, and the selected values
    /// at each level determine which values are available at the next.
    /// </summary>
    public partial class HierarchyFilter
    {
        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that anchors the filter. This column determines the dataset that the whole
        /// filter applies to, so every column in <c>HierarchyLevels</c> and in <c>HierarchyTree</c>
        /// must belong to the same dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property DefaultFilterControlConfiguration. 
        /// <para>
        /// The default configurations for the associated controls. This applies only for filters
        /// that are scoped to multiple sheets.
        /// </para>
        /// </summary>
        public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DefaultFilterControlConfiguration property is set.
        /// </summary>
        internal bool IsSetDefaultFilterControlConfiguration() => this.DefaultFilterControlConfiguration != null;

        /// <summary>
        /// Gets and sets the property FilterId. 
        /// <para>
        /// An identifier that uniquely identifies a filter within a dashboard, analysis, or template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FilterId { get; set; }

        /// <summary>
        /// Checks to see if the FilterId property is set.
        /// </summary>
        internal bool IsSetFilterId() => this.FilterId != null;

        /// <summary>
        /// Gets and sets the property HierarchyLevels. 
        /// <para>
        /// The ordered list of columns that defines the drill-down path of the filter. The first
        /// level is the top of the hierarchy. You can specify a maximum of 5 levels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<HierarchyFilterLevel> HierarchyLevels { get; set; } = AWSConfigs.InitializeCollections ? new List<HierarchyFilterLevel>() : null;

        /// <summary>
        /// Checks to see if the HierarchyLevels property is set.
        /// </summary>
        internal bool IsSetHierarchyLevels() => this.HierarchyLevels != null && (this.HierarchyLevels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HierarchyTree. 
        /// <para>
        /// The tree of selected values for the filter. Each node records the values that are
        /// selected at one level of the hierarchy, and its children record the selections beneath
        /// those values. Omit this attribute to define the drill-down path without restricting
        /// any values.
        /// </para>
        /// </summary>
        public HierarchyFilterNode HierarchyTree { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyTree property is set.
        /// </summary>
        internal bool IsSetHierarchyTree() => this.HierarchyTree != null;

        /// <summary>
        /// Gets and sets the property MatchOperator. 
        /// <para>
        /// Determines whether the values selected in <c>HierarchyTree</c> are kept or removed.
        /// Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INCLUDE</c>: Keep only the selected values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXCLUDE</c>: Remove the selected values.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public HierarchyFilterMatchOperator MatchOperator { get; set; }

        /// <summary>
        /// Checks to see if the MatchOperator property is set.
        /// </summary>
        internal bool IsSetMatchOperator() => this.MatchOperator != null;

        /// <summary>
        /// Gets and sets the property NullOption. 
        /// <para>
        /// This option determines how null values should be treated when filtering data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_VALUES</c>: Include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NULLS_ONLY</c>: Only include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_NULLS_ONLY</c>: Exclude null values from filtered results.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FilterNullOption NullOption { get; set; }

        /// <summary>
        /// Checks to see if the NullOption property is set.
        /// </summary>
        internal bool IsSetNullOption() => this.NullOption != null;
    }
}

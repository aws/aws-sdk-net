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
    /// A grouping of individual filters. Filter groups are applied to the same group of visuals.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/add-a-compound-filter.html">Adding
    /// filter conditions (group filters) with AND and OR operators</a> in the <i>Amazon Quick
    /// Suite User Guide</i>.
    /// </para>
    /// </summary>
    public partial class FilterGroup
    {
        /// <summary>
        /// Gets and sets the property CrossDataset. 
        /// <para>
        /// The filter new feature which can apply filter group to all data sets. Choose one of
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_DATASETS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_DATASET</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public CrossDatasetTypes CrossDataset { get; set; }

        /// <summary>
        /// Checks to see if the CrossDataset property is set.
        /// </summary>
        internal bool IsSetCrossDataset() => this.CrossDataset != null;

        /// <summary>
        /// Gets and sets the property FilterGroupId. 
        /// <para>
        /// The value that uniquely identifies a <c>FilterGroup</c> within a dashboard, template,
        /// or analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FilterGroupId { get; set; }

        /// <summary>
        /// Checks to see if the FilterGroupId property is set.
        /// </summary>
        internal bool IsSetFilterGroupId() => this.FilterGroupId != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The list of filters that are present in a <c>FilterGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20)]
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The configuration that specifies what scope to apply to a <c>FilterGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// This is a union type structure. For this structure to be valid, only one of the attributes
        /// can be defined.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FilterScopeConfiguration ScopeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScopeConfiguration property is set.
        /// </summary>
        internal bool IsSetScopeConfiguration() => this.ScopeConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the <c>FilterGroup</c>.
        /// </para>
        /// </summary>
        public WidgetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

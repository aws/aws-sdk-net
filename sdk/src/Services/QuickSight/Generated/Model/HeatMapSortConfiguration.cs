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
    /// The sort configuration of a heat map.
    /// </summary>
    public partial class HeatMapSortConfiguration
    {
        private ItemsLimitConfiguration _heatMapColumnItemsLimitConfiguration;
        private List<FieldSortOptions> _heatMapColumnSort = AWSConfigs.InitializeCollections ? new List<FieldSortOptions>() : null;
        private ItemsLimitConfiguration _heatMapRowItemsLimitConfiguration;
        private List<FieldSortOptions> _heatMapRowSort = AWSConfigs.InitializeCollections ? new List<FieldSortOptions>() : null;

        /// <summary>
        /// Gets and sets the property HeatMapColumnItemsLimitConfiguration. 
        /// <para>
        /// The limit on the number of columns that are displayed in a heat map.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration HeatMapColumnItemsLimitConfiguration
        {
            get { return this._heatMapColumnItemsLimitConfiguration; }
            set { this._heatMapColumnItemsLimitConfiguration = value; }
        }

        // Check to see if HeatMapColumnItemsLimitConfiguration property is set
        internal bool IsSetHeatMapColumnItemsLimitConfiguration()
        {
            return this._heatMapColumnItemsLimitConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HeatMapColumnSort. 
        /// <para>
        /// The column sort configuration for heat map for columns that aren't a part of a field
        /// well.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> HeatMapColumnSort
        {
            get { return this._heatMapColumnSort; }
            set { this._heatMapColumnSort = value; }
        }

        // Check to see if HeatMapColumnSort property is set
        internal bool IsSetHeatMapColumnSort()
        {
            return this._heatMapColumnSort != null && (this._heatMapColumnSort.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HeatMapRowItemsLimitConfiguration. 
        /// <para>
        /// The limit on the number of rows that are displayed in a heat map.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration HeatMapRowItemsLimitConfiguration
        {
            get { return this._heatMapRowItemsLimitConfiguration; }
            set { this._heatMapRowItemsLimitConfiguration = value; }
        }

        // Check to see if HeatMapRowItemsLimitConfiguration property is set
        internal bool IsSetHeatMapRowItemsLimitConfiguration()
        {
            return this._heatMapRowItemsLimitConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HeatMapRowSort. 
        /// <para>
        /// The field sort configuration of the rows fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> HeatMapRowSort
        {
            get { return this._heatMapRowSort; }
            set { this._heatMapRowSort = value; }
        }

        // Check to see if HeatMapRowSort property is set
        internal bool IsSetHeatMapRowSort()
        {
            return this._heatMapRowSort != null && (this._heatMapRowSort.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
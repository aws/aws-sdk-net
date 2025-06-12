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
    /// Describes the <b>Category</b> dataset column and constraints for the dynamic values
    /// used to repeat the contents of a section.
    /// </summary>
    public partial class BodySectionDynamicCategoryDimensionConfiguration
    {
        private ColumnIdentifier _column;
        private int? _limit;
        private List<ColumnSort> _sortByMetrics = AWSConfigs.InitializeCollections ? new List<ColumnSort>() : null;

        /// <summary>
        /// Gets and sets the property Column.
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Number of values to use from the column for repetition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SortByMetrics. 
        /// <para>
        /// Sort criteria on the column values that you use for repetition. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ColumnSort> SortByMetrics
        {
            get { return this._sortByMetrics; }
            set { this._sortByMetrics = value; }
        }

        // Check to see if SortByMetrics property is set
        internal bool IsSetSortByMetrics()
        {
            return this._sortByMetrics != null && (this._sortByMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
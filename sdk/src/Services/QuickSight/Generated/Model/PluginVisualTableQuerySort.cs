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
    /// The table query sorting options for the plugin visual.
    /// </summary>
    public partial class PluginVisualTableQuerySort
    {
        private PluginVisualItemsLimitConfiguration _itemsLimitConfiguration;
        private List<FieldSortOptions> _rowSort = AWSConfigs.InitializeCollections ? new List<FieldSortOptions>() : null;

        /// <summary>
        /// Gets and sets the property ItemsLimitConfiguration. 
        /// <para>
        /// The maximum amount of data to be returned by a query.
        /// </para>
        /// </summary>
        public PluginVisualItemsLimitConfiguration ItemsLimitConfiguration
        {
            get { return this._itemsLimitConfiguration; }
            set { this._itemsLimitConfiguration = value; }
        }

        // Check to see if ItemsLimitConfiguration property is set
        internal bool IsSetItemsLimitConfiguration()
        {
            return this._itemsLimitConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RowSort. 
        /// <para>
        /// Determines how data is sorted in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> RowSort
        {
            get { return this._rowSort; }
            set { this._rowSort = value; }
        }

        // Check to see if RowSort property is set
        internal bool IsSetRowSort()
        {
            return this._rowSort != null && (this._rowSort.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
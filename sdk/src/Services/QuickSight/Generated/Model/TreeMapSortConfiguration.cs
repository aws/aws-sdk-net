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
    /// The sort configuration of a tree map.
    /// </summary>
    public partial class TreeMapSortConfiguration
    {
        private ItemsLimitConfiguration _treeMapGroupItemsLimitConfiguration;
        private List<FieldSortOptions> _treeMapSort = new List<FieldSortOptions>();

        /// <summary>
        /// Gets and sets the property TreeMapGroupItemsLimitConfiguration. 
        /// <para>
        /// The limit on the number of groups that are displayed.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration TreeMapGroupItemsLimitConfiguration
        {
            get { return this._treeMapGroupItemsLimitConfiguration; }
            set { this._treeMapGroupItemsLimitConfiguration = value; }
        }

        // Check to see if TreeMapGroupItemsLimitConfiguration property is set
        internal bool IsSetTreeMapGroupItemsLimitConfiguration()
        {
            return this._treeMapGroupItemsLimitConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TreeMapSort. 
        /// <para>
        /// The sort configuration of group by fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> TreeMapSort
        {
            get { return this._treeMapSort; }
            set { this._treeMapSort = value; }
        }

        // Check to see if TreeMapSort property is set
        internal bool IsSetTreeMapSort()
        {
            return this._treeMapSort != null && this._treeMapSort.Count > 0; 
        }

    }
}
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
    /// The sort configuration of a <code>FunnelChartVisual</code>.
    /// </summary>
    public partial class FunnelChartSortConfiguration
    {
        private ItemsLimitConfiguration _categoryItemsLimit;
        private List<FieldSortOptions> _categorySort = new List<FieldSortOptions>();

        /// <summary>
        /// Gets and sets the property CategoryItemsLimit. 
        /// <para>
        /// The limit on the number of categories displayed.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration CategoryItemsLimit
        {
            get { return this._categoryItemsLimit; }
            set { this._categoryItemsLimit = value; }
        }

        // Check to see if CategoryItemsLimit property is set
        internal bool IsSetCategoryItemsLimit()
        {
            return this._categoryItemsLimit != null;
        }

        /// <summary>
        /// Gets and sets the property CategorySort. 
        /// <para>
        /// The sort configuration of the category fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> CategorySort
        {
            get { return this._categorySort; }
            set { this._categorySort = value; }
        }

        // Check to see if CategorySort property is set
        internal bool IsSetCategorySort()
        {
            return this._categorySort != null && this._categorySort.Count > 0; 
        }

    }
}
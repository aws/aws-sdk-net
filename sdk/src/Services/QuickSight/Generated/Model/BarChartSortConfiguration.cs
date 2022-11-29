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
    /// sort-configuration-description
    /// </summary>
    public partial class BarChartSortConfiguration
    {
        private ItemsLimitConfiguration _categoryItemsLimit;
        private List<FieldSortOptions> _categorySort = new List<FieldSortOptions>();
        private ItemsLimitConfiguration _colorItemsLimit;
        private List<FieldSortOptions> _colorSort = new List<FieldSortOptions>();
        private ItemsLimitConfiguration _smallMultiplesLimitConfiguration;
        private List<FieldSortOptions> _smallMultiplesSort = new List<FieldSortOptions>();

        /// <summary>
        /// Gets and sets the property CategoryItemsLimit. 
        /// <para>
        /// The limit on the number of categories displayed in a bar chart.
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
        /// The sort configuration of category fields.
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

        /// <summary>
        /// Gets and sets the property ColorItemsLimit. 
        /// <para>
        /// The limit on the number of values displayed in a bar chart.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration ColorItemsLimit
        {
            get { return this._colorItemsLimit; }
            set { this._colorItemsLimit = value; }
        }

        // Check to see if ColorItemsLimit property is set
        internal bool IsSetColorItemsLimit()
        {
            return this._colorItemsLimit != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSort. 
        /// <para>
        /// The sort configuration of color fields in a bar chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> ColorSort
        {
            get { return this._colorSort; }
            set { this._colorSort = value; }
        }

        // Check to see if ColorSort property is set
        internal bool IsSetColorSort()
        {
            return this._colorSort != null && this._colorSort.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SmallMultiplesLimitConfiguration. 
        /// <para>
        /// The limit on the number of small multiples panels that are displayed.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration SmallMultiplesLimitConfiguration
        {
            get { return this._smallMultiplesLimitConfiguration; }
            set { this._smallMultiplesLimitConfiguration = value; }
        }

        // Check to see if SmallMultiplesLimitConfiguration property is set
        internal bool IsSetSmallMultiplesLimitConfiguration()
        {
            return this._smallMultiplesLimitConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SmallMultiplesSort. 
        /// <para>
        /// The sort configuration of the small multiples field.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> SmallMultiplesSort
        {
            get { return this._smallMultiplesSort; }
            set { this._smallMultiplesSort = value; }
        }

        // Check to see if SmallMultiplesSort property is set
        internal bool IsSetSmallMultiplesSort()
        {
            return this._smallMultiplesSort != null && this._smallMultiplesSort.Count > 0; 
        }

    }
}
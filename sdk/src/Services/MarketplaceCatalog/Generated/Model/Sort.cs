/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// An object that contains two attributes, <code>sortBy</code> and <code>sortOrder</code>.
    /// </summary>
    public partial class Sort
    {
        private string _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// For <code>ListEntities</code>, supported attributes include <code>LastModifiedDate</code>
        /// (default), <code>Visibility</code>, <code>EntityId</code>, and <code>Name</code>.
        /// </para>
        ///  
        /// <para>
        /// For <code>ListChangeSets</code>, supported attributes include <code>StartTime</code>
        /// and <code>EndTime</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sorting order. Can be <code>ASCENDING</code> or <code>DESCENDING</code>. The default
        /// value is <code>DESCENDING</code>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}
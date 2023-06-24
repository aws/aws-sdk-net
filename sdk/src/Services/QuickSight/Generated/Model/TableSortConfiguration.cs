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
    /// The sort configuration for a <code>TableVisual</code>.
    /// </summary>
    public partial class TableSortConfiguration
    {
        private PaginationConfiguration _paginationConfiguration;
        private List<FieldSortOptions> _rowSort = new List<FieldSortOptions>();

        /// <summary>
        /// Gets and sets the property PaginationConfiguration. 
        /// <para>
        /// The pagination configuration (page size, page number) for the table.
        /// </para>
        /// </summary>
        public PaginationConfiguration PaginationConfiguration
        {
            get { return this._paginationConfiguration; }
            set { this._paginationConfiguration = value; }
        }

        // Check to see if PaginationConfiguration property is set
        internal bool IsSetPaginationConfiguration()
        {
            return this._paginationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RowSort. 
        /// <para>
        /// The field sort options for rows in the table.
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
            return this._rowSort != null && this._rowSort.Count > 0; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the sort order of a sorted column.
    /// </summary>
    public partial class Order
    {
        private string _column;
        private int? _sortOrder;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The name of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Column
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
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Indicates that the column is sorted in ascending order (<c>== 1</c>), or in descending
        /// order (<c>==0</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public int? SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder.HasValue; 
        }

    }
}
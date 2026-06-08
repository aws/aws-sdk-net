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
    /// The sort configuration for searching knowledge bases.
    /// </summary>
    public partial class KnowledgeBaseSortBy
    {
        private KnowledgeBaseSortByField _sortByField;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property SortByField. 
        /// <para>
        /// The field to sort by.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseSortByField SortByField
        {
            get { return this._sortByField; }
            set { this._sortByField = value; }
        }

        // Check to see if SortByField property is set
        internal bool IsSetSortByField()
        {
            return this._sortByField != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order (ascending or descending).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
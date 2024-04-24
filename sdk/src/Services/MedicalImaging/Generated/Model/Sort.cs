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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Sort search results.
    /// </summary>
    public partial class Sort
    {
        private SortField _sortField;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property SortField. 
        /// <para>
        /// The sort field for search criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SortField SortField
        {
            get { return this._sortField; }
            set { this._sortField = value; }
        }

        // Check to see if SortField property is set
        internal bool IsSetSortField()
        {
            return this._sortField != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for search criteria.
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
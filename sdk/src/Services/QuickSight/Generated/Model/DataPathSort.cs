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
    /// Allows data paths to be sorted by a specific data value.
    /// </summary>
    public partial class DataPathSort
    {
        private SortDirection _direction;
        private List<DataPathValue> _sortPaths = new List<DataPathValue>();

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Determines the sort direction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SortDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property SortPaths. 
        /// <para>
        /// The list of data paths that need to be sorted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=20)]
        public List<DataPathValue> SortPaths
        {
            get { return this._sortPaths; }
            set { this._sortPaths = value; }
        }

        // Check to see if SortPaths property is set
        internal bool IsSetSortPaths()
        {
            return this._sortPaths != null && this._sortPaths.Count > 0; 
        }

    }
}
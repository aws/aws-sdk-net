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
    /// The sort configuration of a sankey diagram.
    /// </summary>
    public partial class SankeyDiagramSortConfiguration
    {
        private ItemsLimitConfiguration _destinationItemsLimit;
        private ItemsLimitConfiguration _sourceItemsLimit;
        private List<FieldSortOptions> _weightSort = new List<FieldSortOptions>();

        /// <summary>
        /// Gets and sets the property DestinationItemsLimit. 
        /// <para>
        /// The limit on the number of destination nodes that are displayed in a sankey diagram.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration DestinationItemsLimit
        {
            get { return this._destinationItemsLimit; }
            set { this._destinationItemsLimit = value; }
        }

        // Check to see if DestinationItemsLimit property is set
        internal bool IsSetDestinationItemsLimit()
        {
            return this._destinationItemsLimit != null;
        }

        /// <summary>
        /// Gets and sets the property SourceItemsLimit. 
        /// <para>
        /// The limit on the number of source nodes that are displayed in a sankey diagram.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration SourceItemsLimit
        {
            get { return this._sourceItemsLimit; }
            set { this._sourceItemsLimit = value; }
        }

        // Check to see if SourceItemsLimit property is set
        internal bool IsSetSourceItemsLimit()
        {
            return this._sourceItemsLimit != null;
        }

        /// <summary>
        /// Gets and sets the property WeightSort. 
        /// <para>
        /// The sort configuration of the weight fields.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> WeightSort
        {
            get { return this._weightSort; }
            set { this._weightSort = value; }
        }

        // Check to see if WeightSort property is set
        internal bool IsSetWeightSort()
        {
            return this._weightSort != null && this._weightSort.Count > 0; 
        }

    }
}
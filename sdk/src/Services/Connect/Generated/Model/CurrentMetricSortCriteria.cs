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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The way to sort the resulting response based on metrics. By default resources are
    /// sorted based on <code>AGENTS_ONLINE</code>, <code>DESCENDING</code>. The metric collection
    /// is sorted based on the input metrics.
    /// </summary>
    public partial class CurrentMetricSortCriteria
    {
        private CurrentMetricName _sortByMetric;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property SortByMetric.
        /// </summary>
        public CurrentMetricName SortByMetric
        {
            get { return this._sortByMetric; }
            set { this._sortByMetric = value; }
        }

        // Check to see if SortByMetric property is set
        internal bool IsSetSortByMetric()
        {
            return this._sortByMetric != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The way to sort.
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
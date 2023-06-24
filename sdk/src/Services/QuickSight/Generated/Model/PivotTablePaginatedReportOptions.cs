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
    /// The paginated report options for a pivot table visual.
    /// </summary>
    public partial class PivotTablePaginatedReportOptions
    {
        private Visibility _overflowColumnHeaderVisibility;
        private Visibility _verticalOverflowVisibility;

        /// <summary>
        /// Gets and sets the property OverflowColumnHeaderVisibility. 
        /// <para>
        /// The visibility of the repeating header rows on each page.
        /// </para>
        /// </summary>
        public Visibility OverflowColumnHeaderVisibility
        {
            get { return this._overflowColumnHeaderVisibility; }
            set { this._overflowColumnHeaderVisibility = value; }
        }

        // Check to see if OverflowColumnHeaderVisibility property is set
        internal bool IsSetOverflowColumnHeaderVisibility()
        {
            return this._overflowColumnHeaderVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property VerticalOverflowVisibility. 
        /// <para>
        /// The visibility of the printing table overflow across pages.
        /// </para>
        /// </summary>
        public Visibility VerticalOverflowVisibility
        {
            get { return this._verticalOverflowVisibility; }
            set { this._verticalOverflowVisibility = value; }
        }

        // Check to see if VerticalOverflowVisibility property is set
        internal bool IsSetVerticalOverflowVisibility()
        {
            return this._verticalOverflowVisibility != null;
        }

    }
}
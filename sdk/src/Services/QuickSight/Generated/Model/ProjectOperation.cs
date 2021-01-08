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
    /// A transform operation that projects columns. Operations that come after a projection
    /// can only refer to projected columns.
    /// </summary>
    public partial class ProjectOperation
    {
        private List<string> _projectedColumns = new List<string>();

        /// <summary>
        /// Gets and sets the property ProjectedColumns. 
        /// <para>
        /// Projected columns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public List<string> ProjectedColumns
        {
            get { return this._projectedColumns; }
            set { this._projectedColumns = value; }
        }

        // Check to see if ProjectedColumns property is set
        internal bool IsSetProjectedColumns()
        {
            return this._projectedColumns != null && this._projectedColumns.Count > 0; 
        }

    }
}
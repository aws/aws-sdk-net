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
    /// The sort configuration for a <code>PivotTableVisual</code>.
    /// </summary>
    public partial class PivotTableSortConfiguration
    {
        private List<PivotFieldSortOptions> _fieldSortOptions = new List<PivotFieldSortOptions>();

        /// <summary>
        /// Gets and sets the property FieldSortOptions. 
        /// <para>
        /// The field sort options for a pivot table sort configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<PivotFieldSortOptions> FieldSortOptions
        {
            get { return this._fieldSortOptions; }
            set { this._fieldSortOptions = value; }
        }

        // Check to see if FieldSortOptions property is set
        internal bool IsSetFieldSortOptions()
        {
            return this._fieldSortOptions != null && this._fieldSortOptions.Count > 0; 
        }

    }
}
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
    /// The field sort options in a chart configuration.
    /// </summary>
    public partial class FieldSortOptions
    {
        private ColumnSort _columnSort;
        private FieldSort _fieldSort;

        /// <summary>
        /// Gets and sets the property ColumnSort. 
        /// <para>
        /// The sort configuration for a column that is not used in a field well.
        /// </para>
        /// </summary>
        public ColumnSort ColumnSort
        {
            get { return this._columnSort; }
            set { this._columnSort = value; }
        }

        // Check to see if ColumnSort property is set
        internal bool IsSetColumnSort()
        {
            return this._columnSort != null;
        }

        /// <summary>
        /// Gets and sets the property FieldSort. 
        /// <para>
        /// The sort configuration for a field in a field well.
        /// </para>
        /// </summary>
        public FieldSort FieldSort
        {
            get { return this._fieldSort; }
            set { this._fieldSort = value; }
        }

        // Check to see if FieldSort property is set
        internal bool IsSetFieldSort()
        {
            return this._fieldSort != null;
        }

    }
}
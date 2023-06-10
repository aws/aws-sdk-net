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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A filter that uses both column-level and row-level filtering.
    /// </summary>
    public partial class ColumnRowFilter
    {
        private string _columnName;
        private string _rowFilterExpression;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// A string containing the name of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property RowFilterExpression. 
        /// <para>
        /// A string containing the row-level filter expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RowFilterExpression
        {
            get { return this._rowFilterExpression; }
            set { this._rowFilterExpression = value; }
        }

        // Check to see if RowFilterExpression property is set
        internal bool IsSetRowFilterExpression()
        {
            return this._rowFilterExpression != null;
        }

    }
}
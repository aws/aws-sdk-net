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
    /// A calculated column for a dataset.
    /// </summary>
    public partial class CalculatedColumn
    {
        private string _columnId;
        private string _columnName;
        private string _expression;

        /// <summary>
        /// Gets and sets the property ColumnId. 
        /// <para>
        /// A unique ID to identify a calculated column. During a dataset update, if the column
        /// ID of a calculated column matches that of an existing calculated column, Amazon QuickSight
        /// preserves the existing calculated column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ColumnId
        {
            get { return this._columnId; }
            set { this._columnId = value; }
        }

        // Check to see if ColumnId property is set
        internal bool IsSetColumnId()
        {
            return this._columnId != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// Column name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Expression. 
        /// <para>
        /// An expression that defines the calculated column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

    }
}
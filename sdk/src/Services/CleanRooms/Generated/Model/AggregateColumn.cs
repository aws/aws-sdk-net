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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Column in configured table that can be used in aggregate function in query.
    /// </summary>
    public partial class AggregateColumn
    {
        private List<string> _columnNames = new List<string>();
        private AggregateFunctionName _function;

        /// <summary>
        /// Gets and sets the property ColumnNames. 
        /// <para>
        /// Column names in configured table of aggregate columns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> ColumnNames
        {
            get { return this._columnNames; }
            set { this._columnNames = value; }
        }

        // Check to see if ColumnNames property is set
        internal bool IsSetColumnNames()
        {
            return this._columnNames != null && this._columnNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// Aggregation function that can be applied to aggregate column in query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AggregateFunctionName Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

    }
}
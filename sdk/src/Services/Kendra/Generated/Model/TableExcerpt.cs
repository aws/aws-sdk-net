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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// An excerpt from a table within a document. The table excerpt displays up to five columns
    /// and three rows, depending on how many table cells are relevant to the query and how
    /// many columns are available in the original table. The top most relevant cell is displayed
    /// in the table excerpt, along with the next most relevant cells.
    /// </summary>
    public partial class TableExcerpt
    {
        private List<TableRow> _rows = new List<TableRow>();
        private int? _totalNumberOfRows;

        /// <summary>
        /// Gets and sets the property Rows. 
        /// <para>
        /// A list of rows in the table excerpt.
        /// </para>
        /// </summary>
        public List<TableRow> Rows
        {
            get { return this._rows; }
            set { this._rows = value; }
        }

        // Check to see if Rows property is set
        internal bool IsSetRows()
        {
            return this._rows != null && this._rows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfRows. 
        /// <para>
        /// A count of the number of rows in the original table within the document.
        /// </para>
        /// </summary>
        public int TotalNumberOfRows
        {
            get { return this._totalNumberOfRows.GetValueOrDefault(); }
            set { this._totalNumberOfRows = value; }
        }

        // Check to see if TotalNumberOfRows property is set
        internal bool IsSetTotalNumberOfRows()
        {
            return this._totalNumberOfRows.HasValue; 
        }

    }
}
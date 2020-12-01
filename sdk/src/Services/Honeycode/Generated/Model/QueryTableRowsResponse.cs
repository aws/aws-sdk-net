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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// This is the response object from the QueryTableRows operation.
    /// </summary>
    public partial class QueryTableRowsResponse : AmazonWebServiceResponse
    {
        private List<string> _columnIds = new List<string>();
        private string _nextToken;
        private List<TableRow> _rows = new List<TableRow>();
        private long? _workbookCursor;

        /// <summary>
        /// Gets and sets the property ColumnIds. 
        /// <para>
        ///  The list of columns in the table whose row data is returned in the result. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ColumnIds
        {
            get { return this._columnIds; }
            set { this._columnIds = value; }
        }

        // Check to see if ColumnIds property is set
        internal bool IsSetColumnIds()
        {
            return this._columnIds != null && this._columnIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Provides the pagination token to load the next page if there are more results matching
        /// the request. If a pagination token is not present in the response, it means that all
        /// data matching the request has been loaded. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Rows. 
        /// <para>
        ///  The list of rows in the table that match the query filter. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property WorkbookCursor. 
        /// <para>
        ///  Indicates the cursor of the workbook at which the data returned by this request is
        /// read. Workbook cursor keeps increasing with every update and the increments are not
        /// sequential. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long WorkbookCursor
        {
            get { return this._workbookCursor.GetValueOrDefault(); }
            set { this._workbookCursor = value; }
        }

        // Check to see if WorkbookCursor property is set
        internal bool IsSetWorkbookCursor()
        {
            return this._workbookCursor.HasValue; 
        }

    }
}
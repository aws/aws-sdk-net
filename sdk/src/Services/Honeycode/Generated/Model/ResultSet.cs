/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// ResultSet contains the results of the request for a single block or list defined
    /// on the screen.
    /// </summary>
    public partial class ResultSet
    {
        private List<ColumnMetadata> _headers = new List<ColumnMetadata>();
        private List<ResultRow> _rows = new List<ResultRow>();

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        ///  List of headers for all the data cells in the block. The header identifies the name
        /// and default format of the data cell. Data cells appear in the same order in all rows
        /// as defined in the header. The names and formats are not repeated in the rows. If a
        /// particular row does not have a value for a data cell, a blank value is used. 
        /// </para>
        ///  
        /// <para>
        ///  For example, a task list that displays the task name, due date and assigned person
        /// might have headers [ { "name": "Task Name"}, {"name": "Due Date", "format": "DATE"},
        /// {"name": "Assigned", "format": "CONTACT"} ]. Every row in the result will have the
        /// task name as the first item, due date as the second item and assigned person as the
        /// third item. If a particular task does not have a due date, that row will still have
        /// a blank value in the second element and the assigned person will still be in the third
        /// element. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ColumnMetadata> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && this._headers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Rows. 
        /// <para>
        ///  List of rows returned by the request. Each row has a row Id and a list of data cells
        /// in that row. The data cells will be present in the same order as they are defined
        /// in the header. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResultRow> Rows
        {
            get { return this._rows; }
            set { this._rows = value; }
        }

        // Check to see if Rows property is set
        internal bool IsSetRows()
        {
            return this._rows != null && this._rows.Count > 0; 
        }

    }
}
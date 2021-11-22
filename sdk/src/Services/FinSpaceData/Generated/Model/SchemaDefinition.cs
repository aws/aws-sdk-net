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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Definition for a schema on a tabular Dataset.
    /// </summary>
    public partial class SchemaDefinition
    {
        private List<ColumnDefinition> _columns = new List<ColumnDefinition>();
        private List<string> _primaryKeyColumns = new List<string>();

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// List of column definitions.
        /// </para>
        /// </summary>
        public List<ColumnDefinition> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null && this._columns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryKeyColumns. 
        /// <para>
        /// List of column names used for primary key.
        /// </para>
        /// </summary>
        public List<string> PrimaryKeyColumns
        {
            get { return this._primaryKeyColumns; }
            set { this._primaryKeyColumns = value; }
        }

        // Check to see if PrimaryKeyColumns property is set
        internal bool IsSetPrimaryKeyColumns()
        {
            return this._primaryKeyColumns != null && this._primaryKeyColumns.Count > 0; 
        }

    }
}
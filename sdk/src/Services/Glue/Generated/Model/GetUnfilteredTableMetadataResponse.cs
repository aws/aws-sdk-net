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
    /// This is the response object from the GetUnfilteredTableMetadata operation.
    /// </summary>
    public partial class GetUnfilteredTableMetadataResponse : AmazonWebServiceResponse
    {
        private List<string> _authorizedColumns = new List<string>();
        private List<ColumnRowFilter> _cellFilters = new List<ColumnRowFilter>();
        private bool? _isRegisteredWithLakeFormation;
        private Table _table;

        /// <summary>
        /// Gets and sets the property AuthorizedColumns. 
        /// <para>
        /// A list of column names that the user has been granted access to.
        /// </para>
        /// </summary>
        public List<string> AuthorizedColumns
        {
            get { return this._authorizedColumns; }
            set { this._authorizedColumns = value; }
        }

        // Check to see if AuthorizedColumns property is set
        internal bool IsSetAuthorizedColumns()
        {
            return this._authorizedColumns != null && this._authorizedColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CellFilters. 
        /// <para>
        /// A list of column row filters.
        /// </para>
        /// </summary>
        public List<ColumnRowFilter> CellFilters
        {
            get { return this._cellFilters; }
            set { this._cellFilters = value; }
        }

        // Check to see if CellFilters property is set
        internal bool IsSetCellFilters()
        {
            return this._cellFilters != null && this._cellFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsRegisteredWithLakeFormation. 
        /// <para>
        /// A Boolean value that indicates whether the partition location is registered with Lake
        /// Formation.
        /// </para>
        /// </summary>
        public bool IsRegisteredWithLakeFormation
        {
            get { return this._isRegisteredWithLakeFormation.GetValueOrDefault(); }
            set { this._isRegisteredWithLakeFormation = value; }
        }

        // Check to see if IsRegisteredWithLakeFormation property is set
        internal bool IsSetIsRegisteredWithLakeFormation()
        {
            return this._isRegisteredWithLakeFormation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// A Table object containing the table metadata.
        /// </para>
        /// </summary>
        public Table Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}
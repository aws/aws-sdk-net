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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// List of columns and their types.
    /// </summary>
    public partial class ResultSetMetadata
    {
        private long? _columnCount;
        private List<ColumnMetadata> _columnMetadata = new List<ColumnMetadata>();

        /// <summary>
        /// Gets and sets the property ColumnCount. Number of columns
        /// </summary>
        public long ColumnCount
        {
            get { return this._columnCount.GetValueOrDefault(); }
            set { this._columnCount = value; }
        }

        // Check to see if ColumnCount property is set
        internal bool IsSetColumnCount()
        {
            return this._columnCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnMetadata. List of columns and their types
        /// </summary>
        public List<ColumnMetadata> ColumnMetadata
        {
            get { return this._columnMetadata; }
            set { this._columnMetadata = value; }
        }

        // Check to see if ColumnMetadata property is set
        internal bool IsSetColumnMetadata()
        {
            return this._columnMetadata != null && this._columnMetadata.Count > 0; 
        }

    }
}
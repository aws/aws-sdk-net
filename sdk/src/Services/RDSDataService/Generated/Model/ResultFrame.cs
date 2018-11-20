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
    /// Result Frame
    /// </summary>
    public partial class ResultFrame
    {
        private List<Record> _records = new List<Record>();
        private ResultSetMetadata _resultSetMetadata;

        /// <summary>
        /// Gets and sets the property Records. ResultSet Metadata.
        /// </summary>
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResultSetMetadata. ResultSet Metadata.
        /// </summary>
        public ResultSetMetadata ResultSetMetadata
        {
            get { return this._resultSetMetadata; }
            set { this._resultSetMetadata = value; }
        }

        // Check to see if ResultSetMetadata property is set
        internal bool IsSetResultSetMetadata()
        {
            return this._resultSetMetadata != null;
        }

    }
}
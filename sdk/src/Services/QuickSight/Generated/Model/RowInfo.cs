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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Information about rows for a data set SPICE ingestion.
    /// </summary>
    public partial class RowInfo
    {
        private long? _rowsDropped;
        private long? _rowsIngested;

        /// <summary>
        /// Gets and sets the property RowsDropped. 
        /// <para>
        /// The number of rows that were not ingested.
        /// </para>
        /// </summary>
        public long RowsDropped
        {
            get { return this._rowsDropped.GetValueOrDefault(); }
            set { this._rowsDropped = value; }
        }

        // Check to see if RowsDropped property is set
        internal bool IsSetRowsDropped()
        {
            return this._rowsDropped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowsIngested. 
        /// <para>
        /// The number of rows that were ingested.
        /// </para>
        /// </summary>
        public long RowsIngested
        {
            get { return this._rowsIngested.GetValueOrDefault(); }
            set { this._rowsIngested = value; }
        }

        // Check to see if RowsIngested property is set
        internal bool IsSetRowsIngested()
        {
            return this._rowsIngested.HasValue; 
        }

    }
}
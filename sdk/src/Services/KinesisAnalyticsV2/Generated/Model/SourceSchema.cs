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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For an SQL-based Amazon Kinesis Data Analytics application, describes the format of
    /// the data in the streaming source, and how each data element maps to corresponding
    /// columns created in the in-application stream.
    /// </summary>
    public partial class SourceSchema
    {
        private List<RecordColumn> _recordColumns = new List<RecordColumn>();
        private string _recordEncoding;
        private RecordFormat _recordFormat;

        /// <summary>
        /// Gets and sets the property RecordColumns. 
        /// <para>
        /// A list of <code>RecordColumn</code> objects. 
        /// </para>
        /// </summary>
        public List<RecordColumn> RecordColumns
        {
            get { return this._recordColumns; }
            set { this._recordColumns = value; }
        }

        // Check to see if RecordColumns property is set
        internal bool IsSetRecordColumns()
        {
            return this._recordColumns != null && this._recordColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecordEncoding. 
        /// <para>
        /// Specifies the encoding of the records in the streaming source. For example, UTF-8.
        /// </para>
        /// </summary>
        public string RecordEncoding
        {
            get { return this._recordEncoding; }
            set { this._recordEncoding = value; }
        }

        // Check to see if RecordEncoding property is set
        internal bool IsSetRecordEncoding()
        {
            return this._recordEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property RecordFormat. 
        /// <para>
        /// Specifies the format of the records on the streaming source.
        /// </para>
        /// </summary>
        public RecordFormat RecordFormat
        {
            get { return this._recordFormat; }
            set { this._recordFormat = value; }
        }

        // Check to see if RecordFormat property is set
        internal bool IsSetRecordFormat()
        {
            return this._recordFormat != null;
        }

    }
}
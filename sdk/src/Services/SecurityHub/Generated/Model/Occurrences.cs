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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The detected occurrences of sensitive data.
    /// </summary>
    public partial class Occurrences
    {
        private List<Cell> _cells = new List<Cell>();
        private List<Range> _lineRanges = new List<Range>();
        private List<Range> _offsetRanges = new List<Range>();
        private List<Page> _pages = new List<Page>();
        private List<Record> _records = new List<Record>();

        /// <summary>
        /// Gets and sets the property Cells. 
        /// <para>
        /// Occurrences of sensitive data detected in Microsoft Excel workbooks, comma-separated
        /// value (CSV) files, or tab-separated value (TSV) files.
        /// </para>
        /// </summary>
        public List<Cell> Cells
        {
            get { return this._cells; }
            set { this._cells = value; }
        }

        // Check to see if Cells property is set
        internal bool IsSetCells()
        {
            return this._cells != null && this._cells.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LineRanges. 
        /// <para>
        /// Occurrences of sensitive data detected in a non-binary text file or a Microsoft Word
        /// file. Non-binary text files include files such as HTML, XML, JSON, and TXT files.
        /// </para>
        /// </summary>
        public List<Range> LineRanges
        {
            get { return this._lineRanges; }
            set { this._lineRanges = value; }
        }

        // Check to see if LineRanges property is set
        internal bool IsSetLineRanges()
        {
            return this._lineRanges != null && this._lineRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OffsetRanges. 
        /// <para>
        /// Occurrences of sensitive data detected in a binary text file.
        /// </para>
        /// </summary>
        public List<Range> OffsetRanges
        {
            get { return this._offsetRanges; }
            set { this._offsetRanges = value; }
        }

        // Check to see if OffsetRanges property is set
        internal bool IsSetOffsetRanges()
        {
            return this._offsetRanges != null && this._offsetRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Pages. 
        /// <para>
        /// Occurrences of sensitive data in an Adobe Portable Document Format (PDF) file.
        /// </para>
        /// </summary>
        public List<Page> Pages
        {
            get { return this._pages; }
            set { this._pages = value; }
        }

        // Check to see if Pages property is set
        internal bool IsSetPages()
        {
            return this._pages != null && this._pages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// Occurrences of sensitive data in an Apache Avro object container or an Apache Parquet
        /// file.
        /// </para>
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

    }
}
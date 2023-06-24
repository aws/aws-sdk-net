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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the location of 1-15 occurrences of sensitive data that was detected by
    /// a managed data identifier or a custom data identifier and produced a sensitive data
    /// finding.
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
        /// An array of objects, one for each occurrence of sensitive data in a Microsoft Excel
        /// workbook, CSV file, or TSV file. This value is null for all other types of files.
        /// </para>
        ///  
        /// <para>
        /// Each Cell object specifies a cell or field that contains the sensitive data.
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
        /// An array of objects, one for each occurrence of sensitive data in an email message
        /// or a non-binary text file such as an HTML, TXT, or XML file. Each Range object specifies
        /// a line or inclusive range of lines that contains the sensitive data, and the position
        /// of the data on the specified line or lines.
        /// </para>
        ///  
        /// <para>
        /// This value is often null for file types that are supported by Cell, Page, or Record
        /// objects. Exceptions are the location of sensitive data in: unstructured sections of
        /// an otherwise structured file, such as a comment in a file; a malformed file that Amazon
        /// Macie analyzes as plain text; and, a CSV or TSV file that has any column names that
        /// contain sensitive data.
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
        /// Reserved for future use.
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
        /// An array of objects, one for each occurrence of sensitive data in an Adobe Portable
        /// Document Format file. This value is null for all other types of files.
        /// </para>
        ///  
        /// <para>
        /// Each Page object specifies a page that contains the sensitive data.
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
        /// An array of objects, one for each occurrence of sensitive data in an Apache Avro object
        /// container, Apache Parquet file, JSON file, or JSON Lines file. This value is null
        /// for all other types of files.
        /// </para>
        ///  
        /// <para>
        /// For an Avro object container or Parquet file, each Record object specifies a record
        /// index and the path to a field in a record that contains the sensitive data. For a
        /// JSON or JSON Lines file, each Record object specifies the path to a field or array
        /// that contains the sensitive data. For a JSON Lines file, it also specifies the index
        /// of the line that contains the data.
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
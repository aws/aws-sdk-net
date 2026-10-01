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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the location of 1-15 occurrences of sensitive data that was detected by
    /// a managed data identifier or a custom data identifier and produced a sensitive data
    /// finding.
    /// </summary>
    public partial class Occurrences
    {
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Cell> Cells { get; set; } = AWSConfigs.InitializeCollections ? new List<Cell>() : null;

        /// <summary>
        /// Checks to see if the Cells property is set.
        /// </summary>
        internal bool IsSetCells() => this.Cells != null && (this.Cells.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> LineRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<Range>() : null;

        /// <summary>
        /// Checks to see if the LineRanges property is set.
        /// </summary>
        internal bool IsSetLineRanges() => this.LineRanges != null && (this.LineRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OffsetRanges. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> OffsetRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<Range>() : null;

        /// <summary>
        /// Checks to see if the OffsetRanges property is set.
        /// </summary>
        internal bool IsSetOffsetRanges() => this.OffsetRanges != null && (this.OffsetRanges.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Page> Pages { get; set; } = AWSConfigs.InitializeCollections ? new List<Page>() : null;

        /// <summary>
        /// Checks to see if the Pages property is set.
        /// </summary>
        internal bool IsSetPages() => this.Pages != null && (this.Pages.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Record> Records { get; set; } = AWSConfigs.InitializeCollections ? new List<Record>() : null;

        /// <summary>
        /// Checks to see if the Records property is set.
        /// </summary>
        internal bool IsSetRecords() => this.Records != null && (this.Records.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

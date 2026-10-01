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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The detected occurrences of sensitive data.
    /// </summary>
    public partial class Occurrences
    {
        /// <summary>
        /// Gets and sets the property Cells. 
        /// <para>
        /// Occurrences of sensitive data detected in Microsoft Excel workbooks, comma-separated
        /// value (CSV) files, or tab-separated value (TSV) files.
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
        /// Occurrences of sensitive data detected in a non-binary text file or a Microsoft Word
        /// file. Non-binary text files include files such as HTML, XML, JSON, and TXT files.
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
        /// Occurrences of sensitive data detected in a binary text file.
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
        /// Occurrences of sensitive data in an Adobe Portable Document Format (PDF) file.
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
        /// Occurrences of sensitive data in an Apache Avro object container or an Apache Parquet
        /// file.
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

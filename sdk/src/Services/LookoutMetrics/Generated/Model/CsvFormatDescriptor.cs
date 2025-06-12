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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Contains information about how a source CSV data file should be analyzed.
    /// </summary>
    public partial class CsvFormatDescriptor
    {
        private string _charset;
        private bool? _containsHeader;
        private string _delimiter;
        private CSVFileCompression _fileCompression;
        private List<string> _headerList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _quoteSymbol;

        /// <summary>
        /// Gets and sets the property Charset. 
        /// <para>
        /// The character set in which the source CSV file is written.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string Charset
        {
            get { return this._charset; }
            set { this._charset = value; }
        }

        // Check to see if Charset property is set
        internal bool IsSetCharset()
        {
            return this._charset != null;
        }

        /// <summary>
        /// Gets and sets the property ContainsHeader. 
        /// <para>
        /// Whether or not the source CSV file contains a header.
        /// </para>
        /// </summary>
        public bool? ContainsHeader
        {
            get { return this._containsHeader; }
            set { this._containsHeader = value; }
        }

        // Check to see if ContainsHeader property is set
        internal bool IsSetContainsHeader()
        {
            return this._containsHeader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// The character used to delimit the source CSV file.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public string Delimiter
        {
            get { return this._delimiter; }
            set { this._delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this._delimiter != null;
        }

        /// <summary>
        /// Gets and sets the property FileCompression. 
        /// <para>
        /// The level of compression of the source CSV file.
        /// </para>
        /// </summary>
        public CSVFileCompression FileCompression
        {
            get { return this._fileCompression; }
            set { this._fileCompression = value; }
        }

        // Check to see if FileCompression property is set
        internal bool IsSetFileCompression()
        {
            return this._fileCompression != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderList. 
        /// <para>
        /// A list of the source CSV file's headers, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HeaderList
        {
            get { return this._headerList; }
            set { this._headerList = value; }
        }

        // Check to see if HeaderList property is set
        internal bool IsSetHeaderList()
        {
            return this._headerList != null && (this._headerList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QuoteSymbol. 
        /// <para>
        /// The character used as a quote character.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public string QuoteSymbol
        {
            get { return this._quoteSymbol; }
            set { this._quoteSymbol = value; }
        }

        // Check to see if QuoteSymbol property is set
        internal bool IsSetQuoteSymbol()
        {
            return this._quoteSymbol != null;
        }

    }
}
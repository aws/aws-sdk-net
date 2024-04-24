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
    /// Properties of an inferred CSV format.
    /// </summary>
    public partial class DetectedCsvFormatDescriptor
    {
        private DetectedField _charset;
        private DetectedField _containsHeader;
        private DetectedField _delimiter;
        private DetectedField _fileCompression;
        private DetectedField _headerList;
        private DetectedField _quoteSymbol;

        /// <summary>
        /// Gets and sets the property Charset. 
        /// <para>
        /// The format's charset.
        /// </para>
        /// </summary>
        public DetectedField Charset
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
        /// Whether the format includes a header.
        /// </para>
        /// </summary>
        public DetectedField ContainsHeader
        {
            get { return this._containsHeader; }
            set { this._containsHeader = value; }
        }

        // Check to see if ContainsHeader property is set
        internal bool IsSetContainsHeader()
        {
            return this._containsHeader != null;
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// The format's delimiter.
        /// </para>
        /// </summary>
        public DetectedField Delimiter
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
        /// The format's file compression.
        /// </para>
        /// </summary>
        public DetectedField FileCompression
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
        /// The format's header list.
        /// </para>
        /// </summary>
        public DetectedField HeaderList
        {
            get { return this._headerList; }
            set { this._headerList = value; }
        }

        // Check to see if HeaderList property is set
        internal bool IsSetHeaderList()
        {
            return this._headerList != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteSymbol. 
        /// <para>
        /// The format's quote symbol.
        /// </para>
        /// </summary>
        public DetectedField QuoteSymbol
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
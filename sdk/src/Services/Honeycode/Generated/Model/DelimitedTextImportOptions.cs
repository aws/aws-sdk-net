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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that contains the options relating to parsing delimited text as part of
    /// an import request.
    /// </summary>
    public partial class DelimitedTextImportOptions
    {
        private ImportDataCharacterEncoding _dataCharacterEncoding;
        private string _delimiter;
        private bool? _hasHeaderRow;
        private bool? _ignoreEmptyRows;

        /// <summary>
        /// Gets and sets the property DataCharacterEncoding. 
        /// <para>
        /// The encoding of the data in the input file.
        /// </para>
        /// </summary>
        public ImportDataCharacterEncoding DataCharacterEncoding
        {
            get { return this._dataCharacterEncoding; }
            set { this._dataCharacterEncoding = value; }
        }

        // Check to see if DataCharacterEncoding property is set
        internal bool IsSetDataCharacterEncoding()
        {
            return this._dataCharacterEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// The delimiter to use for separating columns in a single row of the input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
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
        /// Gets and sets the property HasHeaderRow. 
        /// <para>
        /// Indicates whether the input file has a header row at the top containing the column
        /// names.
        /// </para>
        /// </summary>
        public bool HasHeaderRow
        {
            get { return this._hasHeaderRow.GetValueOrDefault(); }
            set { this._hasHeaderRow = value; }
        }

        // Check to see if HasHeaderRow property is set
        internal bool IsSetHasHeaderRow()
        {
            return this._hasHeaderRow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnoreEmptyRows. 
        /// <para>
        /// A parameter to indicate whether empty rows should be ignored or be included in the
        /// import.
        /// </para>
        /// </summary>
        public bool IgnoreEmptyRows
        {
            get { return this._ignoreEmptyRows.GetValueOrDefault(); }
            set { this._ignoreEmptyRows = value; }
        }

        // Check to see if IgnoreEmptyRows property is set
        internal bool IsSetIgnoreEmptyRows()
        {
            return this._ignoreEmptyRows.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// A delimited data format where the column separator can be a comma and the record separator
    /// is a newline character.
    /// </summary>
    public partial class CsvConfiguration
    {
        private string _columnSeparator;
        private string _escapeChar;
        private string _nullValue;
        private string _quoteChar;
        private bool? _trimWhiteSpace;

        /// <summary>
        /// Gets and sets the property ColumnSeparator. 
        /// <para>
        /// Column separator can be one of comma (','), pipe ('|), semicolon (';'), tab('/t'),
        /// or blank space (' '). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string ColumnSeparator
        {
            get { return this._columnSeparator; }
            set { this._columnSeparator = value; }
        }

        // Check to see if ColumnSeparator property is set
        internal bool IsSetColumnSeparator()
        {
            return this._columnSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property EscapeChar. 
        /// <para>
        /// Escape character can be one of 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string EscapeChar
        {
            get { return this._escapeChar; }
            set { this._escapeChar = value; }
        }

        // Check to see if EscapeChar property is set
        internal bool IsSetEscapeChar()
        {
            return this._escapeChar != null;
        }

        /// <summary>
        /// Gets and sets the property NullValue. 
        /// <para>
        /// Can be blank space (' ').
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NullValue
        {
            get { return this._nullValue; }
            set { this._nullValue = value; }
        }

        // Check to see if NullValue property is set
        internal bool IsSetNullValue()
        {
            return this._nullValue != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteChar. 
        /// <para>
        /// Can be single quote (') or double quote (").
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string QuoteChar
        {
            get { return this._quoteChar; }
            set { this._quoteChar = value; }
        }

        // Check to see if QuoteChar property is set
        internal bool IsSetQuoteChar()
        {
            return this._quoteChar != null;
        }

        /// <summary>
        /// Gets and sets the property TrimWhiteSpace. 
        /// <para>
        /// Specifies to trim leading and trailing white space.
        /// </para>
        /// </summary>
        public bool TrimWhiteSpace
        {
            get { return this._trimWhiteSpace.GetValueOrDefault(); }
            set { this._trimWhiteSpace = value; }
        }

        // Check to see if TrimWhiteSpace property is set
        internal bool IsSetTrimWhiteSpace()
        {
            return this._trimWhiteSpace.HasValue; 
        }

    }
}
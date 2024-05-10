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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Information about the format for a source file or files.
    /// </summary>
    public partial class UploadSettings
    {
        private bool? _containsHeader;
        private string _delimiter;
        private FileFormat _format;
        private int? _startFromRow;
        private TextQualifier _textQualifier;

        /// <summary>
        /// Gets and sets the property ContainsHeader. 
        /// <para>
        /// Whether the file has a header row, or the files each have a header row.
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
        /// The delimiter between values in the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property Format. 
        /// <para>
        /// File format.
        /// </para>
        /// </summary>
        public FileFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property StartFromRow. 
        /// <para>
        /// A row number to start reading data from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? StartFromRow
        {
            get { return this._startFromRow; }
            set { this._startFromRow = value; }
        }

        // Check to see if StartFromRow property is set
        internal bool IsSetStartFromRow()
        {
            return this._startFromRow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TextQualifier. 
        /// <para>
        /// Text qualifier.
        /// </para>
        /// </summary>
        public TextQualifier TextQualifier
        {
            get { return this._textQualifier; }
            set { this._textQualifier = value; }
        }

        // Check to see if TextQualifier property is set
        internal bool IsSetTextQualifier()
        {
            return this._textQualifier != null;
        }

    }
}
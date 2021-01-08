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
    /// Provides details about the location of an occurrence of sensitive data in an Adobe
    /// Portable Document Format file, Microsoft Word document, or non-binary text file.
    /// </summary>
    public partial class Range
    {
        private long? _end;
        private long? _start;
        private long? _startColumn;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// In an Occurrences.lineRanges array, the number of lines from the beginning of the
        /// file to the end of the sensitive data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// In an Occurrences.offsetRanges array, the number of characters from the beginning
        /// of the file to the end of the sensitive data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// In a Page object, the number of lines (lineRange) or characters (offsetRange) from
        /// the beginning of the page to the end of the sensitive data.
        /// </para>
        /// </li></ul>
        /// </summary>
        public long End
        {
            get { return this._end.GetValueOrDefault(); }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// In an Occurrences.lineRanges array, the number of lines from the beginning of the
        /// file to the beginning of the sensitive data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// In an Occurrences.offsetRanges array, the number of characters from the beginning
        /// of the file to the beginning of the sensitive data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// In a Page object, the number of lines (lineRange) or characters (offsetRange) from
        /// the beginning of the page to the beginning of the sensitive data.
        /// </para>
        /// </li></ul>
        /// </summary>
        public long Start
        {
            get { return this._start.GetValueOrDefault(); }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartColumn. 
        /// <para>
        /// The column number for the column that contains the data, if the file contains structured
        /// data.
        /// </para>
        /// </summary>
        public long StartColumn
        {
            get { return this._startColumn.GetValueOrDefault(); }
            set { this._startColumn = value; }
        }

        // Check to see if StartColumn property is set
        internal bool IsSetStartColumn()
        {
            return this._startColumn.HasValue; 
        }

    }
}
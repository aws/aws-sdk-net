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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains options for wrapping (line folding) in X12 EDI files. Wrapping controls how
    /// long lines are handled in the EDI output.
    /// </summary>
    public partial class WrapOptions
    {
        private int? _lineLength;
        private LineTerminator _lineTerminator;
        private WrapFormat _wrapBy;

        /// <summary>
        /// Gets and sets the property LineLength. 
        /// <para>
        /// Specifies the maximum length of a line before wrapping occurs. This value is used
        /// when <c>wrapBy</c> is set to <c>LINE_LENGTH</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? LineLength
        {
            get { return this._lineLength; }
            set { this._lineLength = value; }
        }

        // Check to see if LineLength property is set
        internal bool IsSetLineLength()
        {
            return this._lineLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineTerminator. 
        /// <para>
        /// Specifies the character sequence used to terminate lines when wrapping. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CRLF</c>: carriage return and line feed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LF</c>: line feed)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CR</c>: carriage return
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineTerminator LineTerminator
        {
            get { return this._lineTerminator; }
            set { this._lineTerminator = value; }
        }

        // Check to see if LineTerminator property is set
        internal bool IsSetLineTerminator()
        {
            return this._lineTerminator != null;
        }

        /// <summary>
        /// Gets and sets the property WrapBy. 
        /// <para>
        /// Specifies the method used for wrapping lines in the EDI output. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SEGMENT</c>: Wraps by segment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONE_LINE</c>: Indicates that the entire content is on a single line.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you specify <c>ONE_LINE</c>, do not provide either the line length nor the line
        /// terminator value.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>LINE_LENGTH</c>: Wraps by character count, as specified by <c>lineLength</c> value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WrapFormat WrapBy
        {
            get { return this._wrapBy; }
            set { this._wrapBy = value; }
        }

        // Check to see if WrapBy property is set
        internal bool IsSetWrapBy()
        {
            return this._wrapBy != null;
        }

    }
}
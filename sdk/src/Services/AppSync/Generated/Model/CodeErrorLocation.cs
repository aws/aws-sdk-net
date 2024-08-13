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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes the location of the error in a code sample.
    /// </summary>
    public partial class CodeErrorLocation
    {
        private int? _column;
        private int? _line;
        private int? _span;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column number in the code. Defaults to <c>0</c> if unknown.
        /// </para>
        /// </summary>
        public int? Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Line. 
        /// <para>
        /// The line number in the code. Defaults to <c>0</c> if unknown.
        /// </para>
        /// </summary>
        public int? Line
        {
            get { return this._line; }
            set { this._line = value; }
        }

        // Check to see if Line property is set
        internal bool IsSetLine()
        {
            return this._line.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Span. 
        /// <para>
        /// The span/length of the error. Defaults to <c>-1</c> if unknown.
        /// </para>
        /// </summary>
        public int? Span
        {
            get { return this._span; }
            set { this._span = value; }
        }

        // Check to see if Span property is set
        internal bool IsSetSpan()
        {
            return this._span.HasValue; 
        }

    }
}
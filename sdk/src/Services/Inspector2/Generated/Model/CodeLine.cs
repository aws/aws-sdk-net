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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains information on the lines of code associated with a code snippet.
    /// </summary>
    public partial class CodeLine
    {
        private string _content;
        private int? _lineNumber;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of a line of code
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=240)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property LineNumber. 
        /// <para>
        /// The line number that a section of code is located at.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? LineNumber
        {
            get { return this._lineNumber; }
            set { this._lineNumber = value; }
        }

        // Check to see if LineNumber property is set
        internal bool IsSetLineNumber()
        {
            return this._lineNumber.HasValue; 
        }

    }
}
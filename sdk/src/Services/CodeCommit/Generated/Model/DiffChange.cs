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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// A single line-level entry in a diff hunk. Each <c>DiffChange</c> describes one line
    /// and its change type: unchanged context, an addition in the after blob, or a deletion
    /// from the before blob.
    /// </summary>
    public partial class DiffChange
    {
        private int? _afterLineNumber;
        private int? _beforeLineNumber;
        private string _content;
        private DiffChangeType _type;

        /// <summary>
        /// Gets and sets the property AfterLineNumber. 
        /// <para>
        /// The 1-based line number in the after blob. This field is omitted for <c>DELETE</c>
        /// lines.
        /// </para>
        /// </summary>
        public int? AfterLineNumber
        {
            get { return this._afterLineNumber; }
            set { this._afterLineNumber = value; }
        }

        // Check to see if AfterLineNumber property is set
        internal bool IsSetAfterLineNumber()
        {
            return this._afterLineNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeLineNumber. 
        /// <para>
        /// The 1-based line number in the before blob. This field is omitted for <c>ADD</c> lines.
        /// </para>
        /// </summary>
        public int? BeforeLineNumber
        {
            get { return this._beforeLineNumber; }
            set { this._beforeLineNumber = value; }
        }

        // Check to see if BeforeLineNumber property is set
        internal bool IsSetBeforeLineNumber()
        {
            return this._beforeLineNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The text content of the line, without the trailing newline.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of change for this line. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTEXT</c> – Unchanged line included for surrounding context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADD</c> – Line added in the after blob.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE</c> – Line removed from the before blob.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DiffChangeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AfterLineNumber. 
        /// <para>
        /// The 1-based line number in the after blob. This field is omitted for <c>DELETE</c>
        /// lines.
        /// </para>
        /// </summary>
        public int? AfterLineNumber { get; set; }

        /// <summary>
        /// Checks to see if the AfterLineNumber property is set.
        /// </summary>
        internal bool IsSetAfterLineNumber() => this.AfterLineNumber.HasValue;

        /// <summary>
        /// Gets and sets the property BeforeLineNumber. 
        /// <para>
        /// The 1-based line number in the before blob. This field is omitted for <c>ADD</c> lines.
        /// </para>
        /// </summary>
        public int? BeforeLineNumber { get; set; }

        /// <summary>
        /// Checks to see if the BeforeLineNumber property is set.
        /// </summary>
        internal bool IsSetBeforeLineNumber() => this.BeforeLineNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The text content of the line, without the trailing newline.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

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
        public DiffChangeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

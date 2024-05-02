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
    /// Information about the details of a merge hunk that contains a conflict in a merge
    /// or pull request operation.
    /// </summary>
    public partial class MergeHunkDetail
    {
        private int? _endLine;
        private string _hunkContent;
        private int? _startLine;

        /// <summary>
        /// Gets and sets the property EndLine. 
        /// <para>
        /// The end position of the hunk in the merge result.
        /// </para>
        /// </summary>
        public int? EndLine
        {
            get { return this._endLine; }
            set { this._endLine = value; }
        }

        // Check to see if EndLine property is set
        internal bool IsSetEndLine()
        {
            return this._endLine.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HunkContent. 
        /// <para>
        /// The base-64 encoded content of the hunk merged region that might contain a conflict.
        /// </para>
        /// </summary>
        public string HunkContent
        {
            get { return this._hunkContent; }
            set { this._hunkContent = value; }
        }

        // Check to see if HunkContent property is set
        internal bool IsSetHunkContent()
        {
            return this._hunkContent != null;
        }

        /// <summary>
        /// Gets and sets the property StartLine. 
        /// <para>
        /// The start position of the hunk in the merge result.
        /// </para>
        /// </summary>
        public int? StartLine
        {
            get { return this._startLine; }
            set { this._startLine = value; }
        }

        // Check to see if StartLine property is set
        internal bool IsSetStartLine()
        {
            return this._startLine.HasValue; 
        }

    }
}
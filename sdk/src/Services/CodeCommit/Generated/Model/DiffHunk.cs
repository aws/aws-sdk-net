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
    /// A contiguous run of changed lines from a blob diff, together with any surrounding
    /// unchanged context lines. Hunks are returned in order from the start of the file to
    /// the end. Adjacent or overlapping hunks are merged into a single hunk in the response.
    /// </summary>
    public partial class DiffHunk
    {
        private int? _afterLineCount;
        private int? _afterStartLine;
        private int? _beforeLineCount;
        private int? _beforeStartLine;
        private List<DiffChange> _changes = AWSConfigs.InitializeCollections ? new List<DiffChange>() : null;

        /// <summary>
        /// Gets and sets the property AfterLineCount. 
        /// <para>
        /// The number of lines from the after blob covered by this hunk, including any context
        /// lines.
        /// </para>
        /// </summary>
        public int? AfterLineCount
        {
            get { return this._afterLineCount; }
            set { this._afterLineCount = value; }
        }

        // Check to see if AfterLineCount property is set
        internal bool IsSetAfterLineCount()
        {
            return this._afterLineCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AfterStartLine. 
        /// <para>
        /// The 1-based line number in the after blob where this hunk begins. When the hunk consists
        /// entirely of deletions, <c>afterLineCount</c> is <c>0</c>.
        /// </para>
        /// </summary>
        public int? AfterStartLine
        {
            get { return this._afterStartLine; }
            set { this._afterStartLine = value; }
        }

        // Check to see if AfterStartLine property is set
        internal bool IsSetAfterStartLine()
        {
            return this._afterStartLine.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeLineCount. 
        /// <para>
        /// The number of lines from the before blob covered by this hunk, including any context
        /// lines.
        /// </para>
        /// </summary>
        public int? BeforeLineCount
        {
            get { return this._beforeLineCount; }
            set { this._beforeLineCount = value; }
        }

        // Check to see if BeforeLineCount property is set
        internal bool IsSetBeforeLineCount()
        {
            return this._beforeLineCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeStartLine. 
        /// <para>
        /// The 1-based line number in the before blob where this hunk begins. When the hunk consists
        /// entirely of additions, <c>beforeLineCount</c> is <c>0</c>.
        /// </para>
        /// </summary>
        public int? BeforeStartLine
        {
            get { return this._beforeStartLine; }
            set { this._beforeStartLine = value; }
        }

        // Check to see if BeforeStartLine property is set
        internal bool IsSetBeforeStartLine()
        {
            return this._beforeStartLine.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// An ordered list of line-level changes that make up this hunk. Each entry indicates
        /// whether the line is unchanged context, an addition, or a deletion.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=25000)]
        public List<DiffChange> Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null && (this._changes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
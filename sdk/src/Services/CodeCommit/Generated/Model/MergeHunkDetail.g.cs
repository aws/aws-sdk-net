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
    /// Information about the details of a merge hunk that contains a conflict in a merge
    /// or pull request operation.
    /// </summary>
    public partial class MergeHunkDetail
    {
        /// <summary>
        /// Gets and sets the property EndLine. 
        /// <para>
        /// The end position of the hunk in the merge result.
        /// </para>
        /// </summary>
        public int? EndLine { get; set; }

        /// <summary>
        /// Checks to see if the EndLine property is set.
        /// </summary>
        internal bool IsSetEndLine() => this.EndLine.HasValue;

        /// <summary>
        /// Gets and sets the property HunkContent. 
        /// <para>
        /// The base-64 encoded content of the hunk merged region that might contain a conflict.
        /// </para>
        /// </summary>
        public string HunkContent { get; set; }

        /// <summary>
        /// Checks to see if the HunkContent property is set.
        /// </summary>
        internal bool IsSetHunkContent() => this.HunkContent != null;

        /// <summary>
        /// Gets and sets the property StartLine. 
        /// <para>
        /// The start position of the hunk in the merge result.
        /// </para>
        /// </summary>
        public int? StartLine { get; set; }

        /// <summary>
        /// Checks to see if the StartLine property is set.
        /// </summary>
        internal bool IsSetStartLine() => this.StartLine.HasValue;
    }
}

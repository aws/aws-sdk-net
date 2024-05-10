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
    /// Information about merge hunks in a merge or pull request operation.
    /// </summary>
    public partial class MergeHunk
    {
        private MergeHunkDetail _base;
        private MergeHunkDetail _destination;
        private bool? _isConflict;
        private MergeHunkDetail _source;

        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// Information about the merge hunk in the base of a merge or pull request.
        /// </para>
        /// </summary>
        public MergeHunkDetail Base
        {
            get { return this._base; }
            set { this._base = value; }
        }

        // Check to see if Base property is set
        internal bool IsSetBase()
        {
            return this._base != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Information about the merge hunk in the destination of a merge or pull request.
        /// </para>
        /// </summary>
        public MergeHunkDetail Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property IsConflict. 
        /// <para>
        /// A Boolean value indicating whether a combination of hunks contains a conflict. Conflicts
        /// occur when the same file or the same lines in a file were modified in both the source
        /// and destination of a merge or pull request. Valid values include true, false, and
        /// null. True when the hunk represents a conflict and one or more files contains a line
        /// conflict. File mode conflicts in a merge do not set this to true.
        /// </para>
        /// </summary>
        public bool? IsConflict
        {
            get { return this._isConflict; }
            set { this._isConflict = value; }
        }

        // Check to see if IsConflict property is set
        internal bool IsSetIsConflict()
        {
            return this._isConflict.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the merge hunk in the source of a merge or pull request.
        /// </para>
        /// </summary>
        public MergeHunkDetail Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}
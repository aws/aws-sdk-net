/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetMergeConflicts operation.
    /// </summary>
    public partial class GetMergeConflictsResponse : AmazonWebServiceResponse
    {
        private string _destinationCommitId;
        private bool? _mergeable;
        private string _sourceCommitId;

        /// <summary>
        /// Gets and sets the property DestinationCommitId. 
        /// <para>
        /// The commit ID of the destination commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        public string DestinationCommitId
        {
            get { return this._destinationCommitId; }
            set { this._destinationCommitId = value; }
        }

        // Check to see if DestinationCommitId property is set
        internal bool IsSetDestinationCommitId()
        {
            return this._destinationCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property Mergeable. 
        /// <para>
        /// A Boolean value that indicates whether the code is mergable by the specified merge
        /// option.
        /// </para>
        /// </summary>
        public bool Mergeable
        {
            get { return this._mergeable.GetValueOrDefault(); }
            set { this._mergeable = value; }
        }

        // Check to see if Mergeable property is set
        internal bool IsSetMergeable()
        {
            return this._mergeable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceCommitId. 
        /// <para>
        /// The commit ID of the source commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        public string SourceCommitId
        {
            get { return this._sourceCommitId; }
            set { this._sourceCommitId = value; }
        }

        // Check to see if SourceCommitId property is set
        internal bool IsSetSourceCommitId()
        {
            return this._sourceCommitId != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// The commit diff for the pull request.
    /// </summary>
    public partial class CommitDiffSourceCodeType
    {
        private string _destinationCommit;
        private string _sourceCommit;

        /// <summary>
        /// Gets and sets the property DestinationCommit. 
        /// <para>
        ///  The SHA of the destination commit. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string DestinationCommit
        {
            get { return this._destinationCommit; }
            set { this._destinationCommit = value; }
        }

        // Check to see if DestinationCommit property is set
        internal bool IsSetDestinationCommit()
        {
            return this._destinationCommit != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCommit. 
        /// <para>
        ///  The SHA of the source commit. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string SourceCommit
        {
            get { return this._sourceCommit; }
            set { this._sourceCommit = value; }
        }

        // Check to see if SourceCommit property is set
        internal bool IsSetSourceCommit()
        {
            return this._sourceCommit != null;
        }

    }
}
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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetCommentsForComparedCommit operation.
    /// </summary>
    public partial class GetCommentsForComparedCommitResponse : AmazonWebServiceResponse
    {
        private List<CommentsForComparedCommit> _commentsForComparedCommitData = new List<CommentsForComparedCommit>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CommentsForComparedCommitData. 
        /// <para>
        /// A list of comment objects on the compared commit.
        /// </para>
        /// </summary>
        public List<CommentsForComparedCommit> CommentsForComparedCommitData
        {
            get { return this._commentsForComparedCommitData; }
            set { this._commentsForComparedCommitData = value; }
        }

        // Check to see if CommentsForComparedCommitData property is set
        internal bool IsSetCommentsForComparedCommitData()
        {
            return this._commentsForComparedCommitData != null && this._commentsForComparedCommitData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that can be used in a request to return the next batch of the
        /// results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}
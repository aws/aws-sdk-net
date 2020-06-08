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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the BatchGetCommits operation.
    /// </summary>
    public partial class BatchGetCommitsResponse : AmazonWebServiceResponse
    {
        private List<Commit> _commits = new List<Commit>();
        private List<BatchGetCommitsError> _errors = new List<BatchGetCommitsError>();

        /// <summary>
        /// Gets and sets the property Commits. 
        /// <para>
        /// An array of commit data type objects, each of which contains information about a specified
        /// commit.
        /// </para>
        /// </summary>
        public List<Commit> Commits
        {
            get { return this._commits; }
            set { this._commits = value; }
        }

        // Check to see if Commits property is set
        internal bool IsSetCommits()
        {
            return this._commits != null && this._commits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Returns any commit IDs for which information could not be found. For example, if one
        /// of the commit IDs was a shortened SHA ID or that commit was not found in the specified
        /// repository, the ID returns an error object with more information.
        /// </para>
        /// </summary>
        public List<BatchGetCommitsError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

    }
}
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
    /// Container for the parameters to the GetDifferences operation.
    /// Returns information about the differences in a valid commit specifier (such as a branch,
    /// tag, HEAD, commit ID, or other fully qualified reference). Results can be limited
    /// to a specified path.
    /// </summary>
    public partial class GetDifferencesRequest : AmazonCodeCommitRequest
    {
        private string _afterCommitSpecifier;
        private string _afterPath;
        private string _beforeCommitSpecifier;
        private string _beforePath;
        private int? _maxResults;
        private string _nextToken;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AfterCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AfterCommitSpecifier
        {
            get { return this._afterCommitSpecifier; }
            set { this._afterCommitSpecifier = value; }
        }

        // Check to see if AfterCommitSpecifier property is set
        internal bool IsSetAfterCommitSpecifier()
        {
            return this._afterCommitSpecifier != null;
        }

        /// <summary>
        /// Gets and sets the property AfterPath. 
        /// <para>
        /// The file path in which to check differences. Limits the results to this path. Can
        /// also be used to specify the changed name of a directory or folder, if it has changed.
        /// If not specified, differences are shown for all paths.
        /// </para>
        /// </summary>
        public string AfterPath
        {
            get { return this._afterPath; }
            set { this._afterPath = value; }
        }

        // Check to see if AfterPath property is set
        internal bool IsSetAfterPath()
        {
            return this._afterPath != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, the full commit ID). Optional. If not specified, all changes before
        /// the <c>afterCommitSpecifier</c> value are shown. If you do not use <c>beforeCommitSpecifier</c>
        /// in your request, consider limiting the results with <c>maxResults</c>.
        /// </para>
        /// </summary>
        public string BeforeCommitSpecifier
        {
            get { return this._beforeCommitSpecifier; }
            set { this._beforeCommitSpecifier = value; }
        }

        // Check to see if BeforeCommitSpecifier property is set
        internal bool IsSetBeforeCommitSpecifier()
        {
            return this._beforeCommitSpecifier != null;
        }

        /// <summary>
        /// Gets and sets the property BeforePath. 
        /// <para>
        /// The file path in which to check for differences. Limits the results to this path.
        /// Can also be used to specify the previous name of a directory or folder. If <c>beforePath</c>
        /// and <c>afterPath</c> are not specified, differences are shown for all paths.
        /// </para>
        /// </summary>
        public string BeforePath
        {
            get { return this._beforePath; }
            set { this._beforePath = value; }
        }

        // Check to see if BeforePath property is set
        internal bool IsSetBeforePath()
        {
            return this._beforePath != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that, when provided in a request, returns the next batch of the
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

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you want to get differences.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}
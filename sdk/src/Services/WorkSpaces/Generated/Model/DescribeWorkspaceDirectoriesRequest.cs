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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeWorkspaceDirectories operation.
    /// Describes the available directories that are registered with Amazon WorkSpaces.
    /// </summary>
    public partial class DescribeWorkspaceDirectoriesRequest : AmazonWorkSpacesRequest
    {
        private List<string> _directoryIds = new List<string>();
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DirectoryIds. 
        /// <para>
        /// The identifiers of the directories. If the value is null, all directories are retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> DirectoryIds
        {
            get { return this._directoryIds; }
            set { this._directoryIds = value; }
        }

        // Check to see if DirectoryIds property is set
        internal bool IsSetDirectoryIds()
        {
            return this._directoryIds != null && this._directoryIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of directories to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you received a <code>NextToken</code> from a previous call that was paginated,
        /// provide this token to receive the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
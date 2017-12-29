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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeWorkspaces operation.
    /// Describes the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// You can filter the results using bundle ID, directory ID, or owner, but you can specify
    /// only one filter at a time.
    /// </para>
    /// </summary>
    public partial class DescribeWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private string _bundleId;
        private string _directoryId;
        private int? _limit;
        private string _nextToken;
        private string _userName;
        private List<string> _workspaceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle. All WorkSpaces that are created from this bundle are retrieved.
        /// This parameter cannot be combined with any other filter.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The ID of the directory. In addition, you can optionally specify a specific directory
        /// user (see <code>UserName</code>). This parameter cannot be combined with any other
        /// filter.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return.
        /// </para>
        /// </summary>
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
        /// The token for the next set of results. (You received this token from a previous call.)
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the directory user. You must specify this parameter with <code>DirectoryId</code>.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceIds. 
        /// <para>
        /// The IDs of the WorkSpaces. This parameter cannot be combined with any other filter.
        /// </para>
        ///  
        /// <para>
        /// Because the <a>CreateWorkspaces</a> operation is asynchronous, the identifier it returns
        /// is not immediately available. If you immediately call <a>DescribeWorkspaces</a> with
        /// this identifier, no information is returned.
        /// </para>
        /// </summary>
        public List<string> WorkspaceIds
        {
            get { return this._workspaceIds; }
            set { this._workspaceIds = value; }
        }

        // Check to see if WorkspaceIds property is set
        internal bool IsSetWorkspaceIds()
        {
            return this._workspaceIds != null && this._workspaceIds.Count > 0; 
        }

    }
}
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
    /// Obtains information about the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// Only one of the filter parameters, such as <code>BundleId</code>, <code>DirectoryId</code>,
    /// or <code>WorkspaceIds</code>, can be specified at a time.
    /// </para>
    ///  
    /// <para>
    /// This operation supports pagination with the use of the <code>NextToken</code> request
    /// and response parameters. If more results are available, the <code>NextToken</code>
    /// response member contains a token that you pass in the next call to this operation
    /// to retrieve the next set of items.
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
        /// The identifier of a bundle to obtain the WorkSpaces for. All WorkSpaces that are created
        /// from this bundle will be retrieved. This parameter cannot be combined with any other
        /// filter parameter.
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
        /// Specifies the directory identifier to which to limit the WorkSpaces. Optionally, you
        /// can specify a specific directory user with the <code>UserName</code> parameter. This
        /// parameter cannot be combined with any other filter parameter.
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
        /// The <code>NextToken</code> value from a previous call to this operation. Pass null
        /// if this is the first call.
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
        /// Used with the <code>DirectoryId</code> parameter to specify the directory user for
        /// whom to obtain the WorkSpace.
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
        /// An array of strings that contain the identifiers of the WorkSpaces for which to retrieve
        /// information. This parameter cannot be combined with any other filter parameter.
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
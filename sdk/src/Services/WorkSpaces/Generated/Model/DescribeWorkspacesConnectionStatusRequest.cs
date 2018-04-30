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
    /// Container for the parameters to the DescribeWorkspacesConnectionStatus operation.
    /// Describes the connection status of the specified WorkSpaces.
    /// </summary>
    public partial class DescribeWorkspacesConnectionStatusRequest : AmazonWorkSpacesRequest
    {
        private string _nextToken;
        private List<string> _workspaceIds = new List<string>();

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
        /// Gets and sets the property WorkspaceIds. 
        /// <para>
        /// The identifiers of the WorkSpaces. You can specify up to 25 WorkSpaces.
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
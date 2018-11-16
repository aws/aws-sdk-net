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
    /// This is the response object from the DescribeWorkspacesConnectionStatus operation.
    /// </summary>
    public partial class DescribeWorkspacesConnectionStatusResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WorkspaceConnectionStatus> _workspacesConnectionStatus = new List<WorkspaceConnectionStatus>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next set of results, or null if no more results are
        /// available.
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
        /// Gets and sets the property WorkspacesConnectionStatus. 
        /// <para>
        /// Information about the connection status of the WorkSpace.
        /// </para>
        /// </summary>
        public List<WorkspaceConnectionStatus> WorkspacesConnectionStatus
        {
            get { return this._workspacesConnectionStatus; }
            set { this._workspacesConnectionStatus = value; }
        }

        // Check to see if WorkspacesConnectionStatus property is set
        internal bool IsSetWorkspacesConnectionStatus()
        {
            return this._workspacesConnectionStatus != null && this._workspacesConnectionStatus.Count > 0; 
        }

    }
}
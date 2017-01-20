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
    /// Contains the results for the <a>DescribeWorkspaces</a> operation.
    /// </summary>
    public partial class DescribeWorkspacesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Workspace> _workspaces = new List<Workspace>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If not null, more results are available. Pass this value for the <code>NextToken</code>
        /// parameter in a subsequent call to this operation to retrieve the next set of items.
        /// This token is valid for one day and must be used within that time frame.
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
        /// Gets and sets the property Workspaces. 
        /// <para>
        /// An array of structures that contain the information about the WorkSpaces.
        /// </para>
        ///  
        /// <para>
        /// Because the <a>CreateWorkspaces</a> operation is asynchronous, some of this information
        /// may be incomplete for a newly-created WorkSpace.
        /// </para>
        /// </summary>
        public List<Workspace> Workspaces
        {
            get { return this._workspaces; }
            set { this._workspaces = value; }
        }

        // Check to see if Workspaces property is set
        internal bool IsSetWorkspaces()
        {
            return this._workspaces != null && this._workspaces.Count > 0; 
        }

    }
}
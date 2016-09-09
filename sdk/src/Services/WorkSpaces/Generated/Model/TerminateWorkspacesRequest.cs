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
    /// Container for the parameters to the TerminateWorkspaces operation.
    /// Terminates the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// Terminating a WorkSpace is a permanent action and cannot be undone. The user's data
    /// is not maintained and will be destroyed. If you need to archive any user data, contact
    /// Amazon Web Services before terminating the WorkSpace.
    /// </para>
    ///  
    /// <para>
    /// You can terminate a WorkSpace that is in any state except <code>SUSPENDED</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is asynchronous and returns before the WorkSpaces have been completely
    /// terminated.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TerminateWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<TerminateRequest> _terminateWorkspaceRequests = new List<TerminateRequest>();

        /// <summary>
        /// Gets and sets the property TerminateWorkspaceRequests. 
        /// <para>
        /// An array of structures that specify the WorkSpaces to terminate.
        /// </para>
        /// </summary>
        public List<TerminateRequest> TerminateWorkspaceRequests
        {
            get { return this._terminateWorkspaceRequests; }
            set { this._terminateWorkspaceRequests = value; }
        }

        // Check to see if TerminateWorkspaceRequests property is set
        internal bool IsSetTerminateWorkspaceRequests()
        {
            return this._terminateWorkspaceRequests != null && this._terminateWorkspaceRequests.Count > 0; 
        }

    }
}
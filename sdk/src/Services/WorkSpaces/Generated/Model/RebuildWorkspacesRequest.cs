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
    /// Container for the parameters to the RebuildWorkspaces operation.
    /// Rebuilds the specified WorkSpace.
    /// 
    ///  
    /// <para>
    /// You cannot rebuild a WorkSpace unless its state is <code>AVAILABLE</code>, <code>ERROR</code>,
    /// or <code>UNHEALTHY</code>.
    /// </para>
    ///  
    /// <para>
    /// Rebuilding a WorkSpace is a potentially destructive action that can result in the
    /// loss of data. For more information, see <a href="http://docs.aws.amazon.com/workspaces/latest/adminguide/reset-workspace.html">Rebuild
    /// a WorkSpace</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation is asynchronous and returns before the WorkSpaces have been completely
    /// rebuilt.
    /// </para>
    /// </summary>
    public partial class RebuildWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<RebuildRequest> _rebuildWorkspaceRequests = new List<RebuildRequest>();

        /// <summary>
        /// Gets and sets the property RebuildWorkspaceRequests. 
        /// <para>
        /// The WorkSpace to rebuild. You can specify a single WorkSpace.
        /// </para>
        /// </summary>
        public List<RebuildRequest> RebuildWorkspaceRequests
        {
            get { return this._rebuildWorkspaceRequests; }
            set { this._rebuildWorkspaceRequests = value; }
        }

        // Check to see if RebuildWorkspaceRequests property is set
        internal bool IsSetRebuildWorkspaceRequests()
        {
            return this._rebuildWorkspaceRequests != null && this._rebuildWorkspaceRequests.Count > 0; 
        }

    }
}
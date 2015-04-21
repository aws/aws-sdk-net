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
    /// Rebuilds the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// Rebuilding a WorkSpace is a potentially destructive action that can result in the
    /// loss of data. Rebuilding a WorkSpace causes the following to occur:
    /// </para>
    ///  <ul> <li>The system is restored to the image of the bundle that the WorkSpace is
    /// created from. Any applications that have been installed, or system settings that have
    /// been made since the WorkSpace was created will be lost.</li> <li>The data drive (D
    /// drive) is re-created from the last automatic snapshot taken of the data drive. The
    /// current contents of the data drive are overwritten. Automatic snapshots of the data
    /// drive are taken every 12 hours, so the snapshot can be as much as 12 hours old.</li>
    /// </ul> 
    /// <para>
    /// To be able to rebuild a WorkSpace, the WorkSpace must have a <b>State</b> of <code>AVAILABLE</code>
    /// or <code>ERROR</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is asynchronous and will return before the WorkSpaces have been completely
    /// rebuilt.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RebuildWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<RebuildRequest> _rebuildWorkspaceRequests = new List<RebuildRequest>();

        /// <summary>
        /// Gets and sets the property RebuildWorkspaceRequests. 
        /// <para>
        /// An array of structures that specify the WorkSpaces to rebuild.
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
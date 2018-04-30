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
    /// Container for the parameters to the ModifyWorkspaceState operation.
    /// Sets the state of the specified WorkSpace.
    /// 
    ///  
    /// <para>
    /// To maintain a WorkSpace without being interrupted, set the WorkSpace state to <code>ADMIN_MAINTENANCE</code>.
    /// WorkSpaces in this state do not respond to requests to reboot, stop, start, or rebuild.
    /// An AutoStop WorkSpace in this state is not stopped. Users can log into a WorkSpace
    /// in the <code>ADMIN_MAINTENANCE</code> state.
    /// </para>
    /// </summary>
    public partial class ModifyWorkspaceStateRequest : AmazonWorkSpacesRequest
    {
        private string _workspaceId;
        private TargetWorkspaceState _workspaceState;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the WorkSpace.
        /// </para>
        /// </summary>
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceState. 
        /// <para>
        /// The WorkSpace state.
        /// </para>
        /// </summary>
        public TargetWorkspaceState WorkspaceState
        {
            get { return this._workspaceState; }
            set { this._workspaceState = value; }
        }

        // Check to see if WorkspaceState property is set
        internal bool IsSetWorkspaceState()
        {
            return this._workspaceState != null;
        }

    }
}
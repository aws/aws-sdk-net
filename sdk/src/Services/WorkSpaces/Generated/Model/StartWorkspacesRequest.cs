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
    /// Container for the parameters to the StartWorkspaces operation.
    /// Starts the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// You cannot start a WorkSpace unless it has a running mode of <code>AutoStop</code>
    /// and a state of <code>STOPPED</code>.
    /// </para>
    /// </summary>
    public partial class StartWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<StartRequest> _startWorkspaceRequests = new List<StartRequest>();

        /// <summary>
        /// Gets and sets the property StartWorkspaceRequests. 
        /// <para>
        /// The WorkSpaces to start. You can specify up to 25 WorkSpaces.
        /// </para>
        /// </summary>
        public List<StartRequest> StartWorkspaceRequests
        {
            get { return this._startWorkspaceRequests; }
            set { this._startWorkspaceRequests = value; }
        }

        // Check to see if StartWorkspaceRequests property is set
        internal bool IsSetStartWorkspaceRequests()
        {
            return this._startWorkspaceRequests != null && this._startWorkspaceRequests.Count > 0; 
        }

    }
}
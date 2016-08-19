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
    /// Container for the parameters to the StopWorkspaces operation.
    /// Stops the specified WorkSpaces. The API only works with WorkSpaces that have RunningMode
    /// configured as AutoStop and the State set to AVAILABLE, IMPAIRED, UNHEALTHY, or ERROR.
    /// </summary>
    public partial class StopWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<StopRequest> _stopWorkspaceRequests = new List<StopRequest>();

        /// <summary>
        /// Gets and sets the property StopWorkspaceRequests. 
        /// <para>
        /// The requests.
        /// </para>
        /// </summary>
        public List<StopRequest> StopWorkspaceRequests
        {
            get { return this._stopWorkspaceRequests; }
            set { this._stopWorkspaceRequests = value; }
        }

        // Check to see if StopWorkspaceRequests property is set
        internal bool IsSetStopWorkspaceRequests()
        {
            return this._stopWorkspaceRequests != null && this._stopWorkspaceRequests.Count > 0; 
        }

    }
}
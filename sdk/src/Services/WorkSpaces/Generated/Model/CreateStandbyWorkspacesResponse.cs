/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the CreateStandbyWorkspaces operation.
    /// </summary>
    public partial class CreateStandbyWorkspacesResponse : AmazonWebServiceResponse
    {
        private List<FailedCreateStandbyWorkspacesRequest> _failedStandbyRequests = new List<FailedCreateStandbyWorkspacesRequest>();
        private List<PendingCreateStandbyWorkspacesRequest> _pendingStandbyRequests = new List<PendingCreateStandbyWorkspacesRequest>();

        /// <summary>
        /// Gets and sets the property FailedStandbyRequests. 
        /// <para>
        /// Information about the standby WorkSpace that could not be created. 
        /// </para>
        /// </summary>
        public List<FailedCreateStandbyWorkspacesRequest> FailedStandbyRequests
        {
            get { return this._failedStandbyRequests; }
            set { this._failedStandbyRequests = value; }
        }

        // Check to see if FailedStandbyRequests property is set
        internal bool IsSetFailedStandbyRequests()
        {
            return this._failedStandbyRequests != null && this._failedStandbyRequests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingStandbyRequests. 
        /// <para>
        /// Information about the standby WorkSpace that was created.
        /// </para>
        /// </summary>
        public List<PendingCreateStandbyWorkspacesRequest> PendingStandbyRequests
        {
            get { return this._pendingStandbyRequests; }
            set { this._pendingStandbyRequests = value; }
        }

        // Check to see if PendingStandbyRequests property is set
        internal bool IsSetPendingStandbyRequests()
        {
            return this._pendingStandbyRequests != null && this._pendingStandbyRequests.Count > 0; 
        }

    }
}
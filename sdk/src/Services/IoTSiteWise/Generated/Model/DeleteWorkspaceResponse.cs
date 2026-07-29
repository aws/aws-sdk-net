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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DeleteWorkspace operation.
    /// </summary>
    public partial class DeleteWorkspaceResponse : AmazonWebServiceResponse
    {
        private WorkspaceStatus _workspaceStatus;

        /// <summary>
        /// Gets and sets the property WorkspaceStatus. 
        /// <para>
        /// The status of the workspace after the deletion request, which is <c>DELETING</c> when
        /// the operation returns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceStatus WorkspaceStatus
        {
            get { return this._workspaceStatus; }
            set { this._workspaceStatus = value; }
        }

        // Check to see if WorkspaceStatus property is set
        internal bool IsSetWorkspaceStatus()
        {
            return this._workspaceStatus != null;
        }

    }
}
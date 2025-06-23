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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWorkspaceInstance operation.
    /// Deletes the specified WorkSpace
    /// </summary>
    public partial class DeleteWorkspaceInstanceRequest : AmazonWorkspacesInstancesRequest
    {
        private string _workspaceInstanceId;

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// Unique identifier of the WorkSpaces Instance targeted for deletion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=70)]
        public string WorkspaceInstanceId
        {
            get { return this._workspaceInstanceId; }
            set { this._workspaceInstanceId = value; }
        }

        // Check to see if WorkspaceInstanceId property is set
        internal bool IsSetWorkspaceInstanceId()
        {
            return this._workspaceInstanceId != null;
        }

    }
}
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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreWorkspace operation.
    /// Restores the specified WorkSpace to its last known healthy state.
    /// 
    ///  
    /// <para>
    /// You cannot restore a WorkSpace unless its state is <c> AVAILABLE</c>, <c>ERROR</c>,
    /// <c>UNHEALTHY</c>, or <c>STOPPED</c>.
    /// </para>
    ///  
    /// <para>
    /// Restoring a WorkSpace is a potentially destructive action that can result in the loss
    /// of data. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/restore-workspace.html">Restore
    /// a WorkSpace</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation is asynchronous and returns before the WorkSpace is completely restored.
    /// </para>
    /// </summary>
    public partial class RestoreWorkspaceRequest : AmazonWorkSpacesRequest
    {
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}
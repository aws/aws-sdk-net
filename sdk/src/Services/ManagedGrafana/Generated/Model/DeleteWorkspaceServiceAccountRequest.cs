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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWorkspaceServiceAccount operation.
    /// Deletes a workspace service account from the workspace.
    /// 
    ///  
    /// <para>
    /// This will delete any tokens created for the service account, as well. If the tokens
    /// are currently in use, the will fail to authenticate / authorize after they are deleted.
    /// </para>
    ///  
    /// <para>
    /// Service accounts are only available for workspaces that are compatible with Grafana
    /// version 9 and above.
    /// </para>
    /// </summary>
    public partial class DeleteWorkspaceServiceAccountRequest : AmazonManagedGrafanaRequest
    {
        private string _serviceAccountId;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ServiceAccountId. 
        /// <para>
        /// The ID of the service account to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceAccountId
        {
            get { return this._serviceAccountId; }
            set { this._serviceAccountId = value; }
        }

        // Check to see if ServiceAccountId property is set
        internal bool IsSetServiceAccountId()
        {
            return this._serviceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace where the service account resides.
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
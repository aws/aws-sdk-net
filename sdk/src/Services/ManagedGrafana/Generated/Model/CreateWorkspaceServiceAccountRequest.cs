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
    /// Container for the parameters to the CreateWorkspaceServiceAccount operation.
    /// Creates a service account for the workspace. A service account can be used to call
    /// Grafana HTTP APIs, and run automated workloads. After creating the service account
    /// with the correct <c>GrafanaRole</c> for your use case, use <c>CreateWorkspaceServiceAccountToken</c>
    /// to create a token that can be used to authenticate and authorize Grafana HTTP API
    /// calls.
    /// 
    ///  
    /// <para>
    /// You can only create service accounts for workspaces that are compatible with Grafana
    /// version 9 and above.
    /// </para>
    ///  <note> 
    /// <para>
    /// For more information about service accounts, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/service-accounts.html">Service
    /// accounts</a> in the <i>Amazon Managed Grafana User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about the Grafana HTTP APIs, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">Using
    /// Grafana HTTP APIs</a> in the <i>Amazon Managed Grafana User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateWorkspaceServiceAccountRequest : AmazonManagedGrafanaRequest
    {
        private Role _grafanaRole;
        private string _name;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property GrafanaRole. 
        /// <para>
        /// The permission level to use for this service account.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more information about the roles and the permissions each has, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Grafana-user-roles.html">User
        /// roles</a> in the <i>Amazon Managed Grafana User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public Role GrafanaRole
        {
            get { return this._grafanaRole; }
            set { this._grafanaRole = value; }
        }

        // Check to see if GrafanaRole property is set
        internal bool IsSetGrafanaRole()
        {
            return this._grafanaRole != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the service account. The name must be unique within the workspace, as it
        /// determines the ID associated with the service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace within which to create the service account.
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
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
    /// Container for the parameters to the UpdateWorkspace operation.
    /// Updates a workspace. You can update only workspaces in the <c>ACTIVE</c> or <c>FAILED</c>
    /// state. Fields that you omit from the request are left unchanged. To recover a workspace
    /// in the <c>FAILED</c> state, call this operation and supply its encryption configuration
    /// again.
    /// </summary>
    public partial class UpdateWorkspaceRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private WorkspaceEncryptionConfiguration _encryptionConfiguration;
        private string _workspaceDescription;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the request is
        /// idempotent. If you retry a request that completed successfully using the same client
        /// token, the retry succeeds without performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the workspace. Omit this field to leave encryption
        /// unchanged. After a customer managed key configuration becomes active, the key can't
        /// be changed; supplying the same key is accepted.
        /// </para>
        /// </summary>
        public WorkspaceEncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDescription. 
        /// <para>
        /// A new description for the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string WorkspaceDescription
        {
            get { return this._workspaceDescription; }
            set { this._workspaceDescription = value; }
        }

        // Check to see if WorkspaceDescription property is set
        internal bool IsSetWorkspaceDescription()
        {
            return this._workspaceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}
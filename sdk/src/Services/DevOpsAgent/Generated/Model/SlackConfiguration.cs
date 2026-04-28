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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for Slack workspace integration.
    /// </summary>
    public partial class SlackConfiguration
    {
        private SlackTransmissionTarget _transmissionTarget;
        private string _workspaceId;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property TransmissionTarget. 
        /// <para>
        /// Transmission targets for agent notifications
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlackTransmissionTarget TransmissionTarget
        {
            get { return this._transmissionTarget; }
            set { this._transmissionTarget = value; }
        }

        // Check to see if TransmissionTarget property is set
        internal bool IsSetTransmissionTarget()
        {
            return this._transmissionTarget != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// Associated Slack workspace ID
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

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// Associated Slack workspace name
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
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
    /// Represents a single WorkSpace Instance.
    /// </summary>
    public partial class WorkspaceInstance
    {
        private EC2ManagedInstance _ec2ManagedInstance;
        private ProvisionStateEnum _provisionState;
        private string _workspaceInstanceId;

        /// <summary>
        /// Gets and sets the property EC2ManagedInstance. 
        /// <para>
        /// Details of the associated EC2 managed instance.
        /// </para>
        /// </summary>
        public EC2ManagedInstance EC2ManagedInstance
        {
            get { return this._ec2ManagedInstance; }
            set { this._ec2ManagedInstance = value; }
        }

        // Check to see if EC2ManagedInstance property is set
        internal bool IsSetEC2ManagedInstance()
        {
            return this._ec2ManagedInstance != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionState. 
        /// <para>
        /// Current provisioning state of the WorkSpace Instance.
        /// </para>
        /// </summary>
        public ProvisionStateEnum ProvisionState
        {
            get { return this._provisionState; }
            set { this._provisionState = value; }
        }

        // Check to see if ProvisionState property is set
        internal bool IsSetProvisionState()
        {
            return this._provisionState != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// Unique identifier for the WorkSpace Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=70)]
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
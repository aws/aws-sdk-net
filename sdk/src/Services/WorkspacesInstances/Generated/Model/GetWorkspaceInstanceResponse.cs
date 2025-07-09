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
    /// Provides comprehensive details about the requested WorkSpaces Instance.
    /// </summary>
    public partial class GetWorkspaceInstanceResponse : AmazonWebServiceResponse
    {
        private List<EC2InstanceError> _ec2InstanceErrors = AWSConfigs.InitializeCollections ? new List<EC2InstanceError>() : null;
        private EC2ManagedInstance _ec2ManagedInstance;
        private ProvisionStateEnum _provisionState;
        private List<WorkspaceInstanceError> _workspaceInstanceErrors = AWSConfigs.InitializeCollections ? new List<WorkspaceInstanceError>() : null;
        private string _workspaceInstanceId;

        /// <summary>
        /// Gets and sets the property EC2InstanceErrors. 
        /// <para>
        /// Includes any underlying EC2 instance errors encountered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2InstanceError> EC2InstanceErrors
        {
            get { return this._ec2InstanceErrors; }
            set { this._ec2InstanceErrors = value; }
        }

        // Check to see if EC2InstanceErrors property is set
        internal bool IsSetEC2InstanceErrors()
        {
            return this._ec2InstanceErrors != null && (this._ec2InstanceErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Current provisioning state of the WorkSpaces Instance.
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
        /// Gets and sets the property WorkspaceInstanceErrors. 
        /// <para>
        /// Captures any errors specific to the WorkSpace Instance lifecycle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkspaceInstanceError> WorkspaceInstanceErrors
        {
            get { return this._workspaceInstanceErrors; }
            set { this._workspaceInstanceErrors = value; }
        }

        // Check to see if WorkspaceInstanceErrors property is set
        internal bool IsSetWorkspaceInstanceErrors()
        {
            return this._workspaceInstanceErrors != null && (this._workspaceInstanceErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// Unique identifier of the retrieved WorkSpaces Instance.
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
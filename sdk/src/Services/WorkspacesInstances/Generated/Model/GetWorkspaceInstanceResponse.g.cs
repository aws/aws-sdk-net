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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetWorkspaceInstance operation.
    /// </summary>
    public partial class GetWorkspaceInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BillingConfiguration. 
        /// <para>
        /// Returns the current billing configuration for the WorkSpace Instance, indicating the
        /// active billing mode.
        /// </para>
        /// </summary>
        public BillingConfiguration BillingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BillingConfiguration property is set.
        /// </summary>
        internal bool IsSetBillingConfiguration() => this.BillingConfiguration != null;

        /// <summary>
        /// Gets and sets the property EC2InstanceErrors. 
        /// <para>
        /// Includes any underlying EC2 instance errors encountered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2InstanceError> EC2InstanceErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<EC2InstanceError>() : null;

        /// <summary>
        /// Checks to see if the EC2InstanceErrors property is set.
        /// </summary>
        internal bool IsSetEC2InstanceErrors() => this.EC2InstanceErrors != null && (this.EC2InstanceErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EC2ManagedInstance. 
        /// <para>
        /// Details of the associated EC2 managed instance.
        /// </para>
        /// </summary>
        public EC2ManagedInstance EC2ManagedInstance { get; set; }

        /// <summary>
        /// Checks to see if the EC2ManagedInstance property is set.
        /// </summary>
        internal bool IsSetEC2ManagedInstance() => this.EC2ManagedInstance != null;

        /// <summary>
        /// Gets and sets the property ProvisionState. 
        /// <para>
        /// Current provisioning state of the WorkSpaces Instance.
        /// </para>
        /// </summary>
        public ProvisionStateEnum ProvisionState { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionState property is set.
        /// </summary>
        internal bool IsSetProvisionState() => this.ProvisionState != null;

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceErrors. 
        /// <para>
        /// Captures any errors specific to the WorkSpace Instance lifecycle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkspaceInstanceError> WorkspaceInstanceErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkspaceInstanceError>() : null;

        /// <summary>
        /// Checks to see if the WorkspaceInstanceErrors property is set.
        /// </summary>
        internal bool IsSetWorkspaceInstanceErrors() => this.WorkspaceInstanceErrors != null && (this.WorkspaceInstanceErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// Unique identifier of the retrieved WorkSpaces Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 70)]
        public string WorkspaceInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceInstanceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceInstanceId() => this.WorkspaceInstanceId != null;
    }
}

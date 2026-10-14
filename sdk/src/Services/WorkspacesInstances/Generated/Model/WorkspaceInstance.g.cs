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
    /// Represents a single WorkSpace Instance.
    /// </summary>
    public partial class WorkspaceInstance
    {
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
        /// Current provisioning state of the WorkSpace Instance.
        /// </para>
        /// </summary>
        public ProvisionStateEnum ProvisionState { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionState property is set.
        /// </summary>
        internal bool IsSetProvisionState() => this.ProvisionState != null;

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// Unique identifier for the WorkSpace Instance.
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

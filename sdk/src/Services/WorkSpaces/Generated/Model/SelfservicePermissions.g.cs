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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the self-service permissions for a directory. For more information, see
    /// <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/enable-user-self-service-workspace-management.html">Enable
    /// Self-Service WorkSpace Management Capabilities for Your Users</a>.
    /// </summary>
    public partial class SelfservicePermissions
    {
        /// <summary>
        /// Gets and sets the property ChangeComputeType. 
        /// <para>
        /// Specifies whether users can change the compute type (bundle) for their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum ChangeComputeType { get; set; }

        /// <summary>
        /// Checks to see if the ChangeComputeType property is set.
        /// </summary>
        internal bool IsSetChangeComputeType() => this.ChangeComputeType != null;

        /// <summary>
        /// Gets and sets the property IncreaseVolumeSize. 
        /// <para>
        /// Specifies whether users can increase the volume size of the drives on their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum IncreaseVolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the IncreaseVolumeSize property is set.
        /// </summary>
        internal bool IsSetIncreaseVolumeSize() => this.IncreaseVolumeSize != null;

        /// <summary>
        /// Gets and sets the property RebuildWorkspace. 
        /// <para>
        /// Specifies whether users can rebuild the operating system of a WorkSpace to its original
        /// state.
        /// </para>
        /// </summary>
        public ReconnectEnum RebuildWorkspace { get; set; }

        /// <summary>
        /// Checks to see if the RebuildWorkspace property is set.
        /// </summary>
        internal bool IsSetRebuildWorkspace() => this.RebuildWorkspace != null;

        /// <summary>
        /// Gets and sets the property RestartWorkspace. 
        /// <para>
        /// Specifies whether users can restart their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum RestartWorkspace { get; set; }

        /// <summary>
        /// Checks to see if the RestartWorkspace property is set.
        /// </summary>
        internal bool IsSetRestartWorkspace() => this.RestartWorkspace != null;

        /// <summary>
        /// Gets and sets the property SwitchRunningMode. 
        /// <para>
        /// Specifies whether users can switch the running mode of their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum SwitchRunningMode { get; set; }

        /// <summary>
        /// Checks to see if the SwitchRunningMode property is set.
        /// </summary>
        internal bool IsSetSwitchRunningMode() => this.SwitchRunningMode != null;
    }
}

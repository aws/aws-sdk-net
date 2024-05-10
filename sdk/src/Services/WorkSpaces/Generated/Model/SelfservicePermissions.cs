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
    /// Describes the self-service permissions for a directory. For more information, see
    /// <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/enable-user-self-service-workspace-management.html">Enable
    /// Self-Service WorkSpace Management Capabilities for Your Users</a>.
    /// </summary>
    public partial class SelfservicePermissions
    {
        private ReconnectEnum _changeComputeType;
        private ReconnectEnum _increaseVolumeSize;
        private ReconnectEnum _rebuildWorkspace;
        private ReconnectEnum _restartWorkspace;
        private ReconnectEnum _switchRunningMode;

        /// <summary>
        /// Gets and sets the property ChangeComputeType. 
        /// <para>
        /// Specifies whether users can change the compute type (bundle) for their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum ChangeComputeType
        {
            get { return this._changeComputeType; }
            set { this._changeComputeType = value; }
        }

        // Check to see if ChangeComputeType property is set
        internal bool IsSetChangeComputeType()
        {
            return this._changeComputeType != null;
        }

        /// <summary>
        /// Gets and sets the property IncreaseVolumeSize. 
        /// <para>
        /// Specifies whether users can increase the volume size of the drives on their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum IncreaseVolumeSize
        {
            get { return this._increaseVolumeSize; }
            set { this._increaseVolumeSize = value; }
        }

        // Check to see if IncreaseVolumeSize property is set
        internal bool IsSetIncreaseVolumeSize()
        {
            return this._increaseVolumeSize != null;
        }

        /// <summary>
        /// Gets and sets the property RebuildWorkspace. 
        /// <para>
        /// Specifies whether users can rebuild the operating system of a WorkSpace to its original
        /// state.
        /// </para>
        /// </summary>
        public ReconnectEnum RebuildWorkspace
        {
            get { return this._rebuildWorkspace; }
            set { this._rebuildWorkspace = value; }
        }

        // Check to see if RebuildWorkspace property is set
        internal bool IsSetRebuildWorkspace()
        {
            return this._rebuildWorkspace != null;
        }

        /// <summary>
        /// Gets and sets the property RestartWorkspace. 
        /// <para>
        /// Specifies whether users can restart their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum RestartWorkspace
        {
            get { return this._restartWorkspace; }
            set { this._restartWorkspace = value; }
        }

        // Check to see if RestartWorkspace property is set
        internal bool IsSetRestartWorkspace()
        {
            return this._restartWorkspace != null;
        }

        /// <summary>
        /// Gets and sets the property SwitchRunningMode. 
        /// <para>
        /// Specifies whether users can switch the running mode of their WorkSpace.
        /// </para>
        /// </summary>
        public ReconnectEnum SwitchRunningMode
        {
            get { return this._switchRunningMode; }
            set { this._switchRunningMode = value; }
        }

        // Check to see if SwitchRunningMode property is set
        internal bool IsSetSwitchRunningMode()
        {
            return this._switchRunningMode != null;
        }

    }
}
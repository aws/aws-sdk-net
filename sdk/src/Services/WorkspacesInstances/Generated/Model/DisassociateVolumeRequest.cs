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
    /// Container for the parameters to the DisassociateVolume operation.
    /// Detaches a volume from a WorkSpace Instance.
    /// </summary>
    public partial class DisassociateVolumeRequest : AmazonWorkspacesInstancesRequest
    {
        private string _device;
        private DisassociateModeEnum _disassociateMode;
        private string _volumeId;
        private string _workspaceInstanceId;

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// Device path of volume to detach.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property DisassociateMode. 
        /// <para>
        /// Mode for volume detachment.
        /// </para>
        /// </summary>
        public DisassociateModeEnum DisassociateMode
        {
            get { return this._disassociateMode; }
            set { this._disassociateMode = value; }
        }

        // Check to see if DisassociateMode property is set
        internal bool IsSetDisassociateMode()
        {
            return this._disassociateMode != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// Volume to be detached.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// WorkSpace Instance to detach volume from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=70)]
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
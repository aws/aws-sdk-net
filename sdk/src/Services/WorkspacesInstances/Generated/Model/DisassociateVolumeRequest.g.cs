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
    /// Container for the parameters to the DisassociateVolume operation. Detaches a volume
    /// from a WorkSpace Instance.
    /// </summary>
    public partial class DisassociateVolumeRequest : AmazonWorkspacesInstancesRequest
    {
        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// Device path of volume to detach.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string Device { get; set; }

        /// <summary>
        /// Checks to see if the Device property is set.
        /// </summary>
        internal bool IsSetDevice() => this.Device != null;

        /// <summary>
        /// Gets and sets the property DisassociateMode. 
        /// <para>
        /// Mode for volume detachment.
        /// </para>
        /// </summary>
        public DisassociateModeEnum DisassociateMode { get; set; }

        /// <summary>
        /// Checks to see if the DisassociateMode property is set.
        /// </summary>
        internal bool IsSetDisassociateMode() => this.DisassociateMode != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// Volume to be detached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// WorkSpace Instance to detach volume from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 15, Max = 70)]
        public string WorkspaceInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceInstanceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceInstanceId() => this.WorkspaceInstanceId != null;
    }
}

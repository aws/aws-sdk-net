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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for a capacity provider volume mounted into the AgentCore Runtime. This
    /// references a persistent volume by its logical name, as defined in the capacity provider's
    /// list of volumes.
    /// </summary>
    public partial class CapacityProviderVolumeConfiguration
    {
        private string _mountPath;
        private string _volumeName;

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The mount path for the capacity provider volume inside the AgentCore Runtime. The
        /// path must be under <c>/mnt</c> with exactly one subdirectory level (for example, <c>/mnt/data</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=200)]
        public string MountPath
        {
            get { return this._mountPath; }
            set { this._mountPath = value; }
        }

        // Check to see if MountPath property is set
        internal bool IsSetMountPath()
        {
            return this._mountPath != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeName. 
        /// <para>
        /// The logical name of the capacity provider volume to mount. This name must match a
        /// volume that is defined in the capacity provider's list of volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string VolumeName
        {
            get { return this._volumeName; }
            set { this._volumeName = value; }
        }

        // Check to see if VolumeName property is set
        internal bool IsSetVolumeName()
        {
            return this._volumeName != null;
        }

    }
}
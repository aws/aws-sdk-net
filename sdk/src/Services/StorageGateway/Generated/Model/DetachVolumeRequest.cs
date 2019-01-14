/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DetachVolume operation.
    /// Disconnects a volume from an iSCSI connection and then detaches the volume from the
    /// specified gateway. Detaching and attaching a volume enables you to recover your data
    /// from one gateway to a different gateway without creating a snapshot. It also makes
    /// it easier to move your volumes from an on-premises gateway to a gateway hosted on
    /// an Amazon EC2 instance.
    /// </summary>
    public partial class DetachVolumeRequest : AmazonStorageGatewayRequest
    {
        private bool? _forceDetach;
        private string _volumeARN;

        /// <summary>
        /// Gets and sets the property ForceDetach. 
        /// <para>
        /// Set to <code>true</code> to forcibly remove the iSCSI connection of the target volume
        /// and detach the volume. The default is <code>false</code>. If this value is set to
        /// <code>false</code>, you must manually disconnect the iSCSI connection from the target
        /// volume.
        /// </para>
        /// </summary>
        public bool ForceDetach
        {
            get { return this._forceDetach.GetValueOrDefault(); }
            set { this._forceDetach = value; }
        }

        // Check to see if ForceDetach property is set
        internal bool IsSetForceDetach()
        {
            return this._forceDetach.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the volume to detach from the gateway.
        /// </para>
        /// </summary>
        public string VolumeARN
        {
            get { return this._volumeARN; }
            set { this._volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this._volumeARN != null;
        }

    }
}
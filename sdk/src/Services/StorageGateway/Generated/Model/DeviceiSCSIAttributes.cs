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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Lists iSCSI information about a VTL device.
    /// </summary>
    public partial class DeviceiSCSIAttributes
    {
        private bool? _chapEnabled;
        private string _networkInterfaceId;
        private int? _networkInterfacePort;
        private string _targetARN;

        /// <summary>
        /// Gets and sets the property ChapEnabled. 
        /// <para>
        /// Indicates whether mutual CHAP is enabled for the iSCSI target.
        /// </para>
        /// </summary>
        public bool? ChapEnabled
        {
            get { return this._chapEnabled; }
            set { this._chapEnabled = value; }
        }

        // Check to see if ChapEnabled property is set
        internal bool IsSetChapEnabled()
        {
            return this._chapEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface identifier of the VTL device.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfacePort. 
        /// <para>
        /// The port used to communicate with iSCSI VTL device targets.
        /// </para>
        /// </summary>
        public int? NetworkInterfacePort
        {
            get { return this._networkInterfacePort; }
            set { this._networkInterfacePort = value; }
        }

        // Check to see if NetworkInterfacePort property is set
        internal bool IsSetNetworkInterfacePort()
        {
            return this._networkInterfacePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetARN. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) that encodes the iSCSI qualified name(iqn)
        /// of a tape drive or media changer target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=800)]
        public string TargetARN
        {
            get { return this._targetARN; }
            set { this._targetARN = value; }
        }

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this._targetARN != null;
        }

    }
}
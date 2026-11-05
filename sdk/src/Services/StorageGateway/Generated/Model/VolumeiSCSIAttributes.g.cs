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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Lists iSCSI information about a volume.
    /// </summary>
    public partial class VolumeiSCSIAttributes
    {
        /// <summary>
        /// Gets and sets the property ChapEnabled. 
        /// <para>
        /// Indicates whether mutual CHAP is enabled for the iSCSI target.
        /// </para>
        /// </summary>
        public bool? ChapEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ChapEnabled property is set.
        /// </summary>
        internal bool IsSetChapEnabled() => this.ChapEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LunNumber. 
        /// <para>
        /// The logical disk number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? LunNumber { get; set; }

        /// <summary>
        /// Checks to see if the LunNumber property is set.
        /// </summary>
        internal bool IsSetLunNumber() => this.LunNumber.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface identifier.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfacePort. 
        /// <para>
        /// The port used to communicate with iSCSI targets.
        /// </para>
        /// </summary>
        public int? NetworkInterfacePort { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfacePort property is set.
        /// </summary>
        internal bool IsSetNetworkInterfacePort() => this.NetworkInterfacePort.HasValue;

        /// <summary>
        /// Gets and sets the property TargetARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the volume target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 800)]
        public string TargetARN { get; set; }

        /// <summary>
        /// Checks to see if the TargetARN property is set.
        /// </summary>
        internal bool IsSetTargetARN() => this.TargetARN != null;
    }
}

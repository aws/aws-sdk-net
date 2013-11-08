/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>Lists iSCSI information about a VTL device.</para>
    /// </summary>
    public class DeviceiSCSIAttributes
    {
        
        private string targetARN;
        private string networkInterfaceId;
        private int? networkInterfacePort;
        private bool? chapEnabled;


        /// <summary>
        /// Specifies the unique Amazon Resource Name(ARN) that encodes the iSCSI qualified name(iqn) of a tape drive or media changer target.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 800</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TargetARN
        {
            get { return this.targetARN; }
            set { this.targetARN = value; }
        }

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this.targetARN != null;
        }

        /// <summary>
        /// The network interface identifier of the VTL device.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\A(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\z</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

        /// <summary>
        /// The port used to communicate with iSCSI VTL device targets.
        ///  
        /// </summary>
        public int NetworkInterfacePort
        {
            get { return this.networkInterfacePort ?? default(int); }
            set { this.networkInterfacePort = value; }
        }

        // Check to see if NetworkInterfacePort property is set
        internal bool IsSetNetworkInterfacePort()
        {
            return this.networkInterfacePort.HasValue;
        }

        /// <summary>
        /// Indicates whether mutual CHAP is enabled for the iSCSI target.
        ///  
        /// </summary>
        public bool ChapEnabled
        {
            get { return this.chapEnabled ?? default(bool); }
            set { this.chapEnabled = value; }
        }

        // Check to see if ChapEnabled property is set
        internal bool IsSetChapEnabled()
        {
            return this.chapEnabled.HasValue;
        }
    }
}

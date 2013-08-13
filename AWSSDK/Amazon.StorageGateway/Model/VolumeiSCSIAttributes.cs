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
    /// <para>Lists iSCSI information about a volume.</para>
    /// </summary>
    public class VolumeiSCSIAttributes  
    {
        
        private string targetARN;
        private string networkInterfaceId;
        private int? networkInterfacePort;
        private int? lunNumber;
        private bool? chapEnabled;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the volume target.
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

        /// <summary>
        /// Sets the TargetARN property
        /// </summary>
        /// <param name="targetARN">The value to set for the TargetARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeiSCSIAttributes WithTargetARN(string targetARN)
        {
            this.targetARN = targetARN;
            return this;
        }
            

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this.targetARN != null;       
        }

        /// <summary>
        /// The network interface identifier.
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

        /// <summary>
        /// Sets the NetworkInterfaceId property
        /// </summary>
        /// <param name="networkInterfaceId">The value to set for the NetworkInterfaceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeiSCSIAttributes WithNetworkInterfaceId(string networkInterfaceId)
        {
            this.networkInterfaceId = networkInterfaceId;
            return this;
        }
            

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;       
        }

        /// <summary>
        /// The port used to communicate with iSCSI targets.
        ///  
        /// </summary>
        public int NetworkInterfacePort
        {
            get { return this.networkInterfacePort ?? default(int); }
            set { this.networkInterfacePort = value; }
        }

        /// <summary>
        /// Sets the NetworkInterfacePort property
        /// </summary>
        /// <param name="networkInterfacePort">The value to set for the NetworkInterfacePort property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeiSCSIAttributes WithNetworkInterfacePort(int networkInterfacePort)
        {
            this.networkInterfacePort = networkInterfacePort;
            return this;
        }
            

        // Check to see if NetworkInterfacePort property is set
        internal bool IsSetNetworkInterfacePort()
        {
            return this.networkInterfacePort.HasValue;       
        }

        /// <summary>
        /// The logical disk number.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int LunNumber
        {
            get { return this.lunNumber ?? default(int); }
            set { this.lunNumber = value; }
        }

        /// <summary>
        /// Sets the LunNumber property
        /// </summary>
        /// <param name="lunNumber">The value to set for the LunNumber property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeiSCSIAttributes WithLunNumber(int lunNumber)
        {
            this.lunNumber = lunNumber;
            return this;
        }
            

        // Check to see if LunNumber property is set
        internal bool IsSetLunNumber()
        {
            return this.lunNumber.HasValue;       
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

        /// <summary>
        /// Sets the ChapEnabled property
        /// </summary>
        /// <param name="chapEnabled">The value to set for the ChapEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VolumeiSCSIAttributes WithChapEnabled(bool chapEnabled)
        {
            this.chapEnabled = chapEnabled;
            return this;
        }
            

        // Check to see if ChapEnabled property is set
        internal bool IsSetChapEnabled()
        {
            return this.chapEnabled.HasValue;       
        }
    }
}

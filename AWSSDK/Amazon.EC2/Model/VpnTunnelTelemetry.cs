/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// VPN Tunnel Telemetry
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class VpnTunnelTelemetry
    {
        private string outsideIpAddressField;
        private string statusField;
        private string lastStatusChangeField;
        private string statusMessageField;
        private int? acceptedRouteCountField;

        /// <summary>  
        /// The Internet-routable IP address of the virtual private gateway's outside interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "OutsideIpAddress")]
        public string OutsideIpAddress
        {
            get { return this.outsideIpAddressField; }
            set { this.outsideIpAddressField = value; }
        }

        /// <summary>
        /// Sets the Internet-routable IP address of the virtual private gateway's outside interface.
        /// </summary>
        /// <param name="outsideIpAddress">The Internet-routable address of the virtual private gateway.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnTunnelTelemetry WithOutsideIpAddress(string outsideIpAddress)
        {
            this.outsideIpAddressField = outsideIpAddress;
            return this;
        }

        /// <summary>
        /// Checks whether the OutsideIpAddress property is set.
        /// </summary>
        /// <returns>True if the OutsideIpAddress property is set.</returns>
        public bool IsSetOutsideIpAddress()
        {
            return this.outsideIpAddressField != null;
        }

        /// <summary>
        /// The status of the VPN tunnel.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status of the VPN tunnel.
        /// </summary>
        /// <param name="status">The status of the VPN tunnel.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnTunnelTelemetry WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks whether the Status property of the VPN tunnel is set.
        /// </summary>
        /// <returns>True if the Status property is set.</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }

        /// <summary>
        /// The date and time of the last change in status.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastStatusChange")]
        public string LastStatusChange
        {
            get { return this.lastStatusChangeField; }
            set { this.lastStatusChangeField = value; }
        }

        /// <summary>
        /// Sets the date and time of the last change in status.
        /// </summary>
        /// <param name="lastStatusChange">The date and time of the last change in status.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnTunnelTelemetry WithLastStatusChange(string lastStatusChange)
        {
            this.lastStatusChangeField = lastStatusChange;
            return this;
        }

        /// <summary>
        /// Checks whether the LastStatusChange property is set.
        /// </summary>
        /// <returns>True if the LastStatusChange property is set.</returns>
        public bool IsSetLastStatusChange()
        {
            return this.lastStatusChangeField != null;
        }

        /// <summary>
        /// Description of an error, if an error occurs.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusMessage")]
        public string StatusMessage
        {
            get { return this.statusMessageField; }
            set { this.statusMessageField = value; }
        }

        /// <summary>
        /// Sets the description of an error, if an error occurs.
        /// </summary>
        /// <param name="statusMessage">The description of the error.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnTunnelTelemetry WithStatusMessage(string statusMessage)
        {
            this.statusMessageField = statusMessage;
            return this;
        }

        /// <summary>
        /// Checks whether the StatusMessage property is set.
        /// </summary>
        /// <returns>True if the StatusMessage property is set.</returns>
        public bool IsSetStatusMessage()
        {
            return this.statusMessageField != null;
        }

        /// <summary>
        /// The number of accepted routes.
        /// </summary>
        [XmlElementAttribute(ElementName = "AcceptedRouteCount")]
        public int AcceptedRouteCount
        {
            get { return this.acceptedRouteCountField.GetValueOrDefault(); }
            set { this.acceptedRouteCountField = value; }
        }

        /// <summary>
        /// Sets the number of accepted routes.
        /// </summary>
        /// <param name="acceptedRouteCount">The number of accepted routes.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnTunnelTelemetry WithAcceptedRouteCount(int acceptedRouteCount)
        {
            this.acceptedRouteCountField = acceptedRouteCount;
            return this;
        }

        /// <summary>
        /// Checks whether the AcceptedRouteCount property is set.
        /// </summary>
        /// <returns>True if the AcceptedRouteCount property is set.</returns>
        public bool IsSetAcceptedRouteCount()
        {
            return this.acceptedRouteCountField.HasValue;
        }
    }
}

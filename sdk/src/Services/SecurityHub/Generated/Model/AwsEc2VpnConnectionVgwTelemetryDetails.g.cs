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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the VPN tunnel.
    /// </summary>
    public partial class AwsEc2VpnConnectionVgwTelemetryDetails
    {
        /// <summary>
        /// Gets and sets the property AcceptedRouteCount. 
        /// <para>
        /// The number of accepted routes.
        /// </para>
        /// </summary>
        public int? AcceptedRouteCount { get; set; }

        /// <summary>
        /// Checks to see if the AcceptedRouteCount property is set.
        /// </summary>
        internal bool IsSetAcceptedRouteCount() => this.AcceptedRouteCount.HasValue;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the VPN tunnel endpoint certificate.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property LastStatusChange. 
        /// <para>
        /// The date and time of the last change in status.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastStatusChange { get; set; }

        /// <summary>
        /// Checks to see if the LastStatusChange property is set.
        /// </summary>
        internal bool IsSetLastStatusChange() => this.LastStatusChange != null;

        /// <summary>
        /// Gets and sets the property OutsideIpAddress. 
        /// <para>
        /// The Internet-routable IP address of the virtual private gateway's outside interface.
        /// </para>
        /// </summary>
        public string OutsideIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the OutsideIpAddress property is set.
        /// </summary>
        internal bool IsSetOutsideIpAddress() => this.OutsideIpAddress != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VPN tunnel. Valid values are <c>DOWN</c> or <c>UP</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If an error occurs, a description of the error.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}

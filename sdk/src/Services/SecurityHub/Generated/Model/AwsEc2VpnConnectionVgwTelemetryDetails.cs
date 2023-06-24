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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the VPN tunnel.
    /// </summary>
    public partial class AwsEc2VpnConnectionVgwTelemetryDetails
    {
        private int? _acceptedRouteCount;
        private string _certificateArn;
        private string _lastStatusChange;
        private string _outsideIpAddress;
        private string _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AcceptedRouteCount. 
        /// <para>
        /// The number of accepted routes.
        /// </para>
        /// </summary>
        public int AcceptedRouteCount
        {
            get { return this._acceptedRouteCount.GetValueOrDefault(); }
            set { this._acceptedRouteCount = value; }
        }

        // Check to see if AcceptedRouteCount property is set
        internal bool IsSetAcceptedRouteCount()
        {
            return this._acceptedRouteCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the VPN tunnel endpoint certificate.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusChange. 
        /// <para>
        /// The date and time of the last change in status.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string LastStatusChange
        {
            get { return this._lastStatusChange; }
            set { this._lastStatusChange = value; }
        }

        // Check to see if LastStatusChange property is set
        internal bool IsSetLastStatusChange()
        {
            return this._lastStatusChange != null;
        }

        /// <summary>
        /// Gets and sets the property OutsideIpAddress. 
        /// <para>
        /// The Internet-routable IP address of the virtual private gateway's outside interface.
        /// </para>
        /// </summary>
        public string OutsideIpAddress
        {
            get { return this._outsideIpAddress; }
            set { this._outsideIpAddress = value; }
        }

        // Check to see if OutsideIpAddress property is set
        internal bool IsSetOutsideIpAddress()
        {
            return this._outsideIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VPN tunnel. Valid values are <code>DOWN</code> or <code>UP</code>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If an error occurs, a description of the error.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}
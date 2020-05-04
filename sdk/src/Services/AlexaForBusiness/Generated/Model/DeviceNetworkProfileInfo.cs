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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Detailed information about a device's network profile.
    /// </summary>
    public partial class DeviceNetworkProfileInfo
    {
        private string _certificateArn;
        private DateTime? _certificateExpirationTime;
        private string _networkProfileArn;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the certificate associated with a device.
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
        /// Gets and sets the property CertificateExpirationTime. 
        /// <para>
        /// The time (in epoch) when the certificate expires.
        /// </para>
        /// </summary>
        public DateTime CertificateExpirationTime
        {
            get { return this._certificateExpirationTime.GetValueOrDefault(); }
            set { this._certificateExpirationTime = value; }
        }

        // Check to see if CertificateExpirationTime property is set
        internal bool IsSetCertificateExpirationTime()
        {
            return this._certificateExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkProfileArn. 
        /// <para>
        /// The ARN of the network profile associated with a device.
        /// </para>
        /// </summary>
        public string NetworkProfileArn
        {
            get { return this._networkProfileArn; }
            set { this._networkProfileArn = value; }
        }

        // Check to see if NetworkProfileArn property is set
        internal bool IsSetNetworkProfileArn()
        {
            return this._networkProfileArn != null;
        }

    }
}